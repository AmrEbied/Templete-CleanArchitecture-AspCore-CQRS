using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class AddRoleModel
    {
        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        public string Role { get; set; } = null!;
    }
}
