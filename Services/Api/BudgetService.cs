using DuitTracker.Frontend.Constants;
using DuitTracker.Frontend.Models.Budgets;
using DuitTracker.Frontend.Services.Storage;

namespace DuitTracker.Frontend.Services.Api;

public class BudgetService(HttpClient httpClient, LocalStorageService localStorage)
    : BaseApiService(httpClient, localStorage)
{
    public Task<List<BudgetResponse>?> GetAllAsync(CancellationToken ct = default)
        => GetAsync<List<BudgetResponse>>(ApiRoutes.Budgets.GetAll, ct);

    public Task<BudgetResponse?> GetByIdAsync(Guid id, CancellationToken ct = default)
        => GetAsync<BudgetResponse>(ApiRoutes.Budgets.GetById(id), ct);

    public Task<BudgetResponse?> CreateAsync(CreateBudgetRequest request, CancellationToken ct = default)
        => PostAsync<BudgetResponse>(ApiRoutes.Budgets.Create, request, ct);

    public Task<BudgetResponse?> EditAsync(Guid id, EditBudgetRequest request, CancellationToken ct = default)
        => PutAsync<BudgetResponse>(ApiRoutes.Budgets.Edit(id), request, ct);

    public Task DeleteAsync(Guid id, CancellationToken ct = default)
        => DeleteAsync(ApiRoutes.Budgets.Delete(id), ct);
}