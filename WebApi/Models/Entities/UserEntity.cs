using System.ComponentModel.DataAnnotations;

namespace WebApi.Models.Entities
{
    public class UserEntity
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string ComformPassword { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;

        public DateTime DateCreated { get; set; }
        public bool IsActive { get; set; }
    }
}
