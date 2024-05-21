using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.Models
{
    public class UserDetail
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(300)]
        public string FirstName { get; set; } = null!;
        [Required]
        [MaxLength(300)]
        public string LastName { get; set; } = null!;
        [MaxLength(200)]
        public string Email { get; set; } = null!;
        [MaxLength(50)]
        public string Password { get; set; } = null!;
    }
}
