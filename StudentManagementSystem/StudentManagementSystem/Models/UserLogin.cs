using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class UserLogin
    {
        public string Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [StringLength(20)]
        [Required]
        public string Password { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
