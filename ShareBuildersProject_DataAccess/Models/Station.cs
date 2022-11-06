using System.ComponentModel.DataAnnotations;

namespace ShareBuildersProject_DataAccess.Models
{
    public class Station
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1, 50)]
        public string CallLetters { get; set; }

        [Required]
        [Range(1, 50)]
        public string Owner { get; set; }

        [Required]
        [Range(1, 50)]
        public string Format { get; set; }
    }
}
