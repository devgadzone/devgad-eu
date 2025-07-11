namespace BlogGenerator.Models;

public class SiteConfig
{
    public required string Title { get; set; }
    public required string Description { get; set; }
    public required string BaseUrl { get; set; }
    public required string Author { get; set; }
    public required string Language { get; set; }

    public required PathConfig Paths { get; set; }
    public required BuildConfig Build { get; set; }
    public SocialConfig? Social { get; set; }
}
