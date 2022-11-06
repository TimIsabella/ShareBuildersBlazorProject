using System.ComponentModel.DataAnnotations;

namespace ShareBuildersProject_DataAccess.Models
{
    public class Market
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1, 50)]
        public string Name { get; set; }

        [Required]
        [Range(1, 50)]
        public string State { get; set; }
    }
}
