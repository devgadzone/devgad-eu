namespace BlogGenerator.Models;

public class BlogPost
{
    // Metadata z front matter
    public required string Title { get; set; }
    public required DateTime Date { get; set; }
    public required string Slug { get; set; }
    public bool Draft { get; set; } = false;
    public string? Author { get; set; }
    public string? Excerpt { get; set; }
    public List<string> Tags { get; set; } = new();
    public List<string> Categories { get; set; } = new();
    public string? Description { get; set; }
    public string? Image { get; set; }
    public string? Canonical { get; set; }
    public string? Layout { get; set; }
    public DateTime? Updated { get; set; }

    // Content
    public string? MarkdownContent { get; set; }
    public string? HtmlContent { get; set; }

    // Generated
    public string? SourcePath { get; set; }
    public string? OutputPath { get; set; }
}
