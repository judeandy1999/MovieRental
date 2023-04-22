using System.ComponentModel.DataAnnotations;

namespace MovieRental.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
    }
}
