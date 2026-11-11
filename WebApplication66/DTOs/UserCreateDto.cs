using System.ComponentModel.DataAnnotations;

namespace UserManager.DTOs
{
    public class UserCreateDto
    {
        [Required(ErrorMessage = "Поле Username є обов'язковим.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Username має бути від 3 до 50 символів.")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Поле Email є обов'язковим.")]
        [EmailAddress(ErrorMessage = "Некоректний формат Email.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Поле Role є обов'язковим.")]
        public string Role { get; set; } = string.Empty;
    }
}
