namespace GelezaApp.Models;

public class StudyResource
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Subject { get; set; } = string.Empty;
    public string Grade { get; set; } = string.Empty;
    public string ContentType { get; set; } = "Question Paper";
    public string? FileUrl { get; set; } 
    public string? VideoUrl { get; set; } 
    public string AuthorName { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}