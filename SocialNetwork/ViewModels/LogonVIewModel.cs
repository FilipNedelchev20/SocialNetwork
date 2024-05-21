using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.ViewModels
{
    public class LogonVIewModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
