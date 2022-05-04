using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace AppointmentBookingService.Controllers
{
    public class BookingController : Controller
    {

        // GET: /Booking

        public string Index()
        {
            return "Default action.";
        }

        // GET: /Booking/Welcome

        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}! ID: {ID}");
        }
    }
}
