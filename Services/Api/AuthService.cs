using DuitTracker.Frontend.Constants;
using DuitTracker.Frontend.Models.Auth;
using DuitTracker.Frontend.Services.Storage;

namespace DuitTracker.Frontend.Services.Api;

public class AuthService(HttpClient httpClient, LocalStorageService localStorage)
    : BaseApiService(httpClient, localStorage)
{
    public Task<AuthResponse?> RegisterAsync(RegisterRequest request, CancellationToken ct = default)
        => PostAsync<AuthResponse>(ApiRoutes.Auth.Register, request, ct);

    public Task<AuthResponse?> LoginAsync(LoginRequest request, CancellationToken ct = default)
        => PostAsync<AuthResponse>(ApiRoutes.Auth.Login, request, ct);

    public Task ForgotPasswordAsync(ForgotPasswordRequest request, CancellationToken ct = default)
        => PostAsync(ApiRoutes.Auth.ForgotPassword, request, ct);

    public Task ResetPasswordAsync(ResetPasswordRequest request, CancellationToken ct = default)
        => PostAsync(ApiRoutes.Auth.ResetPassword, request, ct);

    public Task ChangePasswordAsync(ChangePasswordRequest request, CancellationToken ct = default)
        => PostAsync(ApiRoutes.Auth.ChangePassword, request, ct);
}