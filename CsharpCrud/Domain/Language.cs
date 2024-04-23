using System.ComponentModel.DataAnnotations;

public class Language
{
    [Key]
    public int Id { get; set; }
    
    public required string Name { get; set; }
    public required string ReleaseYear { get; set; }
}