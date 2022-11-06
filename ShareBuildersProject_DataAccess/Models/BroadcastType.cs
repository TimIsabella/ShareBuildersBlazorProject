using System.ComponentModel.DataAnnotations;

namespace ShareBuildersProject_DataAccess.Models
{
    public class BroadcastType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1, 50)]
        public string Name { get; set; }
    }
}
