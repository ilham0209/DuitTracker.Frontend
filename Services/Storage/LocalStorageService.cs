using Blazored.LocalStorage;

namespace DuitTracker.Frontend.Services.Storage;

public class LocalStorageService(ILocalStorageService localStorage)
{
    public async Task SetAsync(string key, string value) =>
        await localStorage.SetItemAsStringAsync(key, value);

    public async Task<string?> GetAsync(string key) =>
        await localStorage.GetItemAsStringAsync(key);

    public async Task RemoveAsync(string key) =>
        await localStorage.RemoveItemAsync(key);

    public async Task ClearAsync() =>
        await localStorage.ClearAsync();
}