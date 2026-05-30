using DuitTracker.Frontend.Constants;
using DuitTracker.Frontend.Models.Dashboard;
using DuitTracker.Frontend.Services.Storage;

namespace DuitTracker.Frontend.Services.Api;

public class DashboardService(HttpClient httpClient, LocalStorageService localStorage)
    : BaseApiService(httpClient, localStorage)
{
    public Task<DashboardResponse?> GetSummaryAsync(CancellationToken ct = default)
        => GetAsync<DashboardResponse>(ApiRoutes.Dashboard.GetSummary, ct);

    public Task<DashboardResponse?> GetSummaryByYearAsync(int year, CancellationToken ct = default)
        => GetAsync<DashboardResponse>(ApiRoutes.Dashboard.GetSummaryByYear(year), ct);
}