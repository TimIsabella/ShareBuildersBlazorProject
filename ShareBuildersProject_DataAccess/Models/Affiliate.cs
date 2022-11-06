using System.ComponentModel.DataAnnotations;

namespace ShareBuildersProject_DataAccess.Models
{
    public class Affiliate
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1, 50)]
        public string Name { get; set; }

        [Required]
        [Range(1, 50)]
        public string ShortName { get; set; }

        [Required]
        [Range(1, 50)]
        public string City { get; set; }

        [Required]
        [Range(1, 50)]
        public string State { get; set; }
    }
}
