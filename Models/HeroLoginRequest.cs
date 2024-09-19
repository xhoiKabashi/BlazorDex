using System.ComponentModel.DataAnnotations;

public class HeroLoginRequest
{
    [Required(ErrorMessage = "Player Name is required")]
    [StringLength(20, ErrorMessage = "Player Name cannot exceed 20 characters")]
    [MinLength(3, ErrorMessage = "Player Name must be at least 3 characters long")]

    public string? PlayerName { get; set; }

    [Required(ErrorMessage = "Password is required")]
    [MinLength(6, ErrorMessage = "Password must be at least 6 characters long")]
    public string? Password { get; set; }
}
