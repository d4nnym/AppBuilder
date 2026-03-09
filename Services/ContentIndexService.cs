using System.Net.Http.Json;
using AppBuilder.Models;

namespace AppBuilder.Services;

public class ContentIndexService(HttpClient http)
{
    
    private IReadOnlyList<ProjectItem>? _projects;
    private IReadOnlyList<PostItem>? _posts;
    private IReadOnlyList<ResourceItem>? _resources;

    public async Task<IReadOnlyList<ProjectItem>> GetProjectsAsync(CancellationToken ct = default)
        => _projects ??= await LoadAsync<ProjectItem>("content/projects/projects.index.json", ct);

    public async Task<IReadOnlyList<PostItem>> GetPostsAsync(CancellationToken ct = default)
        => _posts ??= await LoadAsync<PostItem>("content/posts/posts.index.json", ct);

    public async Task<IReadOnlyList<ResourceItem>> GetResourcesAsync(CancellationToken ct = default)
        => _resources ??= await LoadAsync<ResourceItem>("content/resources/resources.index.json", ct);

    public async Task<IReadOnlyList<T>> LoadAsync<T>(string url, CancellationToken ct = default)
    {
        var list = await http.GetFromJsonAsync<List<T>>(url, ct);
        return list ?? [];
    }
}
