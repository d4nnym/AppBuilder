namespace AppBuilder.Models;

public sealed record ProjectItem(
    string Slug,
    string Title,
    string Summary,
    string CoverImage,      // /images/...
    string[] Tags,
    string? RepoUrl,
    string? LiveUrl,
    bool Featured,
    DateOnly? Date
);

public sealed record PostItem(
    string Slug,
    string Title,
    string Summary,
    string[] Tags,
    DateOnly Date,
    int ReadMinutes,
    string? CoverImage
);

public sealed record ResourceItem(
    string Slug,
    string Title,
    string Summary,
    string[] Tags,
    string? DownloadUrl,   // /content/resources/files/...
    string? ExternalUrl,
    DateOnly Date,
    string? CoverImage
);