using System.ComponentModel.DataAnnotations;

namespace API.DTOs;

public class RegisterDto
{
    [Required]
    public string Username { get; set; } = string.Empty;
    // here we are removing required from this line because it will not work good when comes to validation of our fields.
    //will remove required and will initialize these values to string.empty.

    [Required]
    [StringLength(8, MinimumLength =4)]
    public string Password { get; set; } = string.Empty;
}
