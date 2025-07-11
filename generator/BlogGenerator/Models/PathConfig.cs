namespace BlogGenerator.Models;

public class PathConfig
{
    public required string ContentPath { get; set; }
    public required string OutputPath { get; set; }
    public required string TemplatesPath { get; set; }
    public required string AssetsPath { get; set; }
}
