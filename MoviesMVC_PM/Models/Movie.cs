using System.ComponentModel.DataAnnotations;

namespace MoviesMVC_PM.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Title { get; set; } = string.Empty;

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string? Genre { get; set; }

        [Range(0, 30)]
        public decimal Price { get; set; }
    }
}
