using System.ComponentModel.DataAnnotations;

namespace AppointmentBookingService.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Service { get; set; }
        public DateTime Date { get; set; }
        public string? Location { get; set; }

    }
}