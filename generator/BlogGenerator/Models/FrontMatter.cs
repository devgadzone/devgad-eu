namespace BlogGenerator.Models;

public class FrontMatter
{
    [YamlMember(Alias = "title")]
    public string? Title { get; set; }

    [YamlMember(Alias = "date")]
    public DateTime? Date { get; set; }

    [YamlMember(Alias = "slug")]
    public string? Slug { get; set; }

    [YamlMember(Alias = "draft")]
    public bool? Draft { get; set; }

    [YamlMember(Alias = "author")]
    public string? Author { get; set; }

    [YamlMember(Alias = "excerpt")]
    public string? Excerpt { get; set; }

    [YamlMember(Alias = "tags")]
    public List<string>? Tags { get; set; }

    [YamlMember(Alias = "categories")]
    public List<string>? Categories { get; set; }

    [YamlMember(Alias = "description")]
    public string? Description { get; set; }

    [YamlMember(Alias = "image")]
    public string? Image { get; set; }

    [YamlMember(Alias = "canonical")]
    public string? Canonical { get; set; }

    [YamlMember(Alias = "layout")]
    public string? Layout { get; set; }

    [YamlMember(Alias = "updated")]
    public DateTime? Updated { get; set; }
}
