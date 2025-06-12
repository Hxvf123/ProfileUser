using System.ComponentModel.DataAnnotations;

public class UserDto
{
    public int UserId { get; set; }

    [Required]
    public string PhoneNumber { get; set; }

    [Required]
    public string Password { get; set; }

    [Required]
    public string FullName { get; set; }

    public DateTime? Dob { get; set; }

    [Required]
    public string Gender { get; set; }

    [Required]
    public string Address { get; set; }

    public string? Role { get; set; }

    public int BloodTypeId { get; set; }
}
