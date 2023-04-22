using System.ComponentModel.DataAnnotations;

namespace MovieRental.Models
{
    public class Movie
    {
        [Key]
        public int MovieId { get; set; }
        public string MovieTitle { get; set; }
        public string Synopsis { get; set; }
        public string Category { get; set; } 
        public string ReleaseDate { get; set; }
    }
}
