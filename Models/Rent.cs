using System.ComponentModel.DataAnnotations;

namespace MovieRental.Models
{
    public class Rent
    {
        [Key]
        public int RentId { get; set; }
        public string RentStartDate { get; set; }
        public string RentEndDate { get; set; }
        public string RenterName { get; set; }
    }
}
