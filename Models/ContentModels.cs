namespace AppBuilder.Models;

public sealed record ProjectItem(
    string Slug,
    string Title,
    string Summary,
    string CoverImage,    
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
    string? DownloadUrl,  
    string? ExternalUrl,
    DateOnly Date,
    string? CoverImage
);

public sealed record AboutMe(
    string Name,
    string Title,
    string Summary,
    string? AvatarImage,   
    string? LinkedInUrl,
    string? GitHubUrl,
    string? TwitterUrl
);


public sealed record Home(
    string Title,
    string Summary,
    string? CoverImage,  
    string? LinkedInUrl,
    string? GitHubUrl,
    string? TwitterUrl
);
