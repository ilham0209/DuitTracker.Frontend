using DuitTracker.Frontend.Constants;
using DuitTracker.Frontend.Models.Categories;
using DuitTracker.Frontend.Services.Storage;

namespace DuitTracker.Frontend.Services.Api;

public class CategoryService(HttpClient httpClient, LocalStorageService localStorage)
    : BaseApiService(httpClient, localStorage)
{
    public Task<List<CategoryResponse>?> GetAllAsync(CancellationToken ct = default)
        => GetAsync<List<CategoryResponse>>(ApiRoutes.Categories.GetAll, ct);

    public Task<CategoryResponse?> GetByIdAsync(Guid id, CancellationToken ct = default)
        => GetAsync<CategoryResponse>(ApiRoutes.Categories.GetById(id), ct);

    public Task<CategoryResponse?> CreateAsync(CreateCategoryRequest request, CancellationToken ct = default)
        => PostAsync<CategoryResponse>(ApiRoutes.Categories.Create, request, ct);

    public Task<CategoryResponse?> EditAsync(Guid id, EditCategoryRequest request, CancellationToken ct = default)
        => PutAsync<CategoryResponse>(ApiRoutes.Categories.Edit(id), request, ct);

    public Task DeleteAsync(Guid id, CancellationToken ct = default)
        => DeleteAsync(ApiRoutes.Categories.Delete(id), ct);
}