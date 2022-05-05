using System.ComponentModel.DataAnnotations;

namespace AppointmentBookingService.Models
{
    public class Booking
    {
        public int Id { get; set; }

        [StringLength(8)]
        public string? Reference { get; set; }

        [StringLength(30)]
        [Required]
        public string? Name { get; set; }

        [StringLength(30)]
        [Required]
        public string? Service { get; set; }

        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        [StringLength(30)]
        [Required]
        public string? Location { get; set; }

    }
}