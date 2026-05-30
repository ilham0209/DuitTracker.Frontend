using DuitTracker.Frontend.Constants;
using DuitTracker.Frontend.Services.Storage;
using Microsoft.AspNetCore.Components.Authorization;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace DuitTracker.Frontend.Services.Authentication;

public class CustomAuthStateProvider(LocalStorageService localStorage) : AuthenticationStateProvider
{
    private readonly AuthenticationState _anonymous =
        new AuthenticationState(new ClaimsPrincipal(new ClaimsIdentity()));

    public override async Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var token = await localStorage.GetAsync(LocalStorageKeys.AuthToken);

        if (string.IsNullOrWhiteSpace(token))
            return _anonymous;

        var handler = new JwtSecurityTokenHandler();

        if (!handler.CanReadToken(token))
            return _anonymous;

        var jwt = handler.ReadJwtToken(token);

        if (jwt.ValidTo < DateTime.UtcNow)
        {
            await localStorage.ClearAsync();
            return _anonymous;
        }

        var identity = new ClaimsIdentity(jwt.Claims, "jwt");
        var user = new ClaimsPrincipal(identity);

        return new AuthenticationState(user);
    }

    public async Task NotifyUserLoginAsync(string token)
    {
        await localStorage.SetAsync(LocalStorageKeys.AuthToken, token);

        var handler = new JwtSecurityTokenHandler();
        var jwt = handler.ReadJwtToken(token);
        var identity = new ClaimsIdentity(jwt.Claims, "jwt");
        var user = new ClaimsPrincipal(identity);

        NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
    }

    public async Task NotifyUserLogoutAsync()
    {
        await localStorage.ClearAsync();
        NotifyAuthenticationStateChanged(Task.FromResult(_anonymous));
    }
}