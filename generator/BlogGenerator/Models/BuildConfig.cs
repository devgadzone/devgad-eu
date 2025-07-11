namespace BlogGenerator.Models;

public class BuildConfig
{
    public required int PostsPerPage { get; set; }
    public required string DateFormat { get; set; }
    public required string TimeZone { get; set; }
    public required bool GenerateRss { get; set; }
    public required bool GenerateSitemap { get; set; }
}
