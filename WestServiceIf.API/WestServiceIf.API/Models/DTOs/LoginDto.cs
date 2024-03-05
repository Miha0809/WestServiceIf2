namespace WestServiceIf.API.Models.DTOs;

public class LoginDto
{
    /// <example>admin@admin.com</example>
    public required string Email { get; set; }
    /// <example>Test1234,</example>
    public required string Password { get; set; }
}