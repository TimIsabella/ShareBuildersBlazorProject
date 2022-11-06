using System.ComponentModel.DataAnnotations;

namespace ShareBuildersProject_DataAccess.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1, 50)]
        public string FirstName { get; set; }

        [Required]
        [Range(1, 50)]
        public string LastName { get; set; }

        public DateTime CreationDate { get; set; } = DateTime.UtcNow;
    }
}
