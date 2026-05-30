using DuitTracker.Frontend.Constants;
using DuitTracker.Frontend.Models.Transactions;
using DuitTracker.Frontend.Services.Storage;

namespace DuitTracker.Frontend.Services.Api;

public class TransactionService(HttpClient httpClient, LocalStorageService localStorage)
    : BaseApiService(httpClient, localStorage)
{
    public Task<List<TransactionResponse>?> GetAllAsync(CancellationToken ct = default)
        => GetAsync<List<TransactionResponse>>(ApiRoutes.Transactions.GetAll, ct);

    public Task<TransactionResponse?> GetByIdAsync(Guid id, CancellationToken ct = default)
        => GetAsync<TransactionResponse>(ApiRoutes.Transactions.GetById(id), ct);

    public Task<TransactionResponse?> CreateAsync(CreateTransactionRequest request, CancellationToken ct = default)
        => PostAsync<TransactionResponse>(ApiRoutes.Transactions.Create, request, ct);

    public Task<TransactionResponse?> EditAsync(Guid id, EditTransactionRequest request, CancellationToken ct = default)
        => PutAsync<TransactionResponse>(ApiRoutes.Transactions.Edit(id), request, ct);

    public Task DeleteAsync(Guid id, CancellationToken ct = default)
        => DeleteAsync(ApiRoutes.Transactions.Delete(id), ct);
}