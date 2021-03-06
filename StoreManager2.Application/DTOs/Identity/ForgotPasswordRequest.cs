using System.ComponentModel.DataAnnotations;

namespace StoreManager2.Application.DTOs.Identity
{
    public class ForgotPasswordRequest
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}