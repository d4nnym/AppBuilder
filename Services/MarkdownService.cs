using Markdig;
using Markdig.Extensions.AutoIdentifiers;
using Microsoft.AspNetCore.Components;
using System.Collections.Concurrent;

namespace AppBuilder.Services;

public sealed class MarkdownService(HttpClient http, NavigationManager nav)
{
    private readonly HttpClient _http = http;
    private readonly NavigationManager _nav = nav;

    private readonly ConcurrentDictionary<string, string> _htmlCache = new();

    private static readonly MarkdownPipeline Pipeline = new MarkdownPipelineBuilder()
        .UseAdvancedExtensions()
        .UseAutoIdentifiers(AutoIdentifierOptions.GitHub)
        .Build();

    public async Task<string> RenderFromContentAsync(string relativePath, CancellationToken ct = default)
    {
        var url = new Uri(new Uri(_nav.BaseUri), relativePath).ToString();

        if (_htmlCache.TryGetValue(url, out var cached))
            return cached;

        try
        {
            var md = await _http.GetStringAsync(url, ct);
            var html = Markdown.ToHtml(md, Pipeline);

            _htmlCache[url] = html;
            return html;
        }
        catch (HttpRequestException)
        {
            return "<p><b>No se encontró el recurso.</b></p>";
        }
    }
}
