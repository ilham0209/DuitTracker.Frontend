using DuitTracker.Frontend.Constants;
using DuitTracker.Frontend.Models.PaymentMethods;
using DuitTracker.Frontend.Services.Storage;

namespace DuitTracker.Frontend.Services.Api;

public class PaymentMethodService(HttpClient httpClient, LocalStorageService localStorage)
    : BaseApiService(httpClient, localStorage)
{
    public Task<List<PaymentMethodResponse>?> GetAllAsync(CancellationToken ct = default)
        => GetAsync<List<PaymentMethodResponse>>(ApiRoutes.PaymentMethods.GetAll, ct);

    public Task<PaymentMethodResponse?> GetByIdAsync(Guid id, CancellationToken ct = default)
        => GetAsync<PaymentMethodResponse>(ApiRoutes.PaymentMethods.GetById(id), ct);

    public Task<PaymentMethodResponse?> CreateAsync(CreatePaymentMethodRequest request, CancellationToken ct = default)
        => PostAsync<PaymentMethodResponse>(ApiRoutes.PaymentMethods.Create, request, ct);

    public Task<PaymentMethodResponse?> EditAsync(Guid id, EditPaymentMethodRequest request, CancellationToken ct = default)
        => PutAsync<PaymentMethodResponse>(ApiRoutes.PaymentMethods.Edit(id), request, ct);

    public Task DeleteAsync(Guid id, CancellationToken ct = default)
        => DeleteAsync(ApiRoutes.PaymentMethods.Delete(id), ct);
}