using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.Json;
using DuitTracker.Frontend.Constants;
using DuitTracker.Frontend.Models.Common;
using DuitTracker.Frontend.Services.Storage;

namespace DuitTracker.Frontend.Services.Api;

public abstract class BaseApiService(HttpClient httpClient, LocalStorageService localStorage)
{
    private static readonly JsonSerializerOptions JsonOptions = new()
    {
        PropertyNameCaseInsensitive = true
    };

    private async Task AttachTokenAsync()
    {
        var token = await localStorage.GetAsync(LocalStorageKeys.AuthToken);
        if (!string.IsNullOrWhiteSpace(token))
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
    }

    protected async Task<T?> GetAsync<T>(string url, CancellationToken ct = default)
    {
        await AttachTokenAsync();
        var response = await httpClient.GetAsync(url, ct);
        await EnsureSuccessAsync(response);
        return await response.Content.ReadFromJsonAsync<T>(JsonOptions, ct);
    }

    protected async Task<T?> PostAsync<T>(string url, object body, CancellationToken ct = default)
    {
        await AttachTokenAsync();
        var response = await httpClient.PostAsJsonAsync(url, body, ct);
        await EnsureSuccessAsync(response);
        return await response.Content.ReadFromJsonAsync<T>(JsonOptions, ct);
    }

    protected async Task PostAsync(string url, object body, CancellationToken ct = default)
    {
        await AttachTokenAsync();
        var response = await httpClient.PostAsJsonAsync(url, body, ct);
        await EnsureSuccessAsync(response);
    }

    protected async Task<T?> PutAsync<T>(string url, object body, CancellationToken ct = default)
    {
        await AttachTokenAsync();
        var response = await httpClient.PutAsJsonAsync(url, body, ct);
        await EnsureSuccessAsync(response);
        return await response.Content.ReadFromJsonAsync<T>(JsonOptions, ct);
    }

    protected async Task DeleteAsync(string url, CancellationToken ct = default)
    {
        await AttachTokenAsync();
        var response = await httpClient.DeleteAsync(url, ct);
        await EnsureSuccessAsync(response);
    }

    private static async Task EnsureSuccessAsync(HttpResponseMessage response)
    {
        if (response.IsSuccessStatusCode)
            return;

        var content = await response.Content.ReadAsStringAsync();

        try
        {
            var error = JsonSerializer.Deserialize<ApiErrorResponse>(content, JsonOptions);

            if (error?.Errors?.Count > 0)
            {
                var messages = string.Join(", ", error.Errors.Select(e => e.ErrorMessage));
                throw new Exception(messages);
            }

            if (!string.IsNullOrWhiteSpace(error?.Error))
                throw new Exception(error.Error);
        }
        catch (JsonException)
        {
            throw new Exception($"Request failed with status {(int)response.StatusCode}.");
        }

        throw new Exception($"Request failed with status {(int)response.StatusCode}.");
    }
}