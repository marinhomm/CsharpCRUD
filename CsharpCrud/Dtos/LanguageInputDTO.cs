using System.ComponentModel.DataAnnotations;

public record LanguageInputDTO
{
    [Required(ErrorMessage = "Field 'name' can not be empty or null")]
    public required string Name { get; set; }
    
    [Required(ErrorMessage = "Field 'releaseYear' can not be empty or null")]
    public required string ReleaseYear { get; set; }
}