using Blazored.LocalStorage;
using DuitTracker.Frontend.Constants;
using DuitTracker.Frontend.Services.Api;
using DuitTracker.Frontend.Services.Authentication;
using DuitTracker.Frontend.Services.Navigation;
using DuitTracker.Frontend.Services.Storage;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using DuitTracker.Frontend;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddAuthorizationCore();

builder.Services.AddScoped<LocalStorageService>();
builder.Services.AddScoped<CustomAuthStateProvider>();
builder.Services.AddScoped<AuthenticationStateProvider>(sp =>
    sp.GetRequiredService<CustomAuthStateProvider>());

builder.Services.AddScoped<MenuService>();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(AppConstants.ApiBaseUrl) });

builder.Services.AddScoped<AuthService>();
builder.Services.AddScoped<CategoryService>();
builder.Services.AddScoped<TransactionService>();
builder.Services.AddScoped<PaymentMethodService>();
builder.Services.AddScoped<BudgetService>();
builder.Services.AddScoped<DashboardService>();

await builder.Build().RunAsync();