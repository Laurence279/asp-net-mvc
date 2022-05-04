using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace AppointmentBookingService.Controllers
{
    public class BookingController : Controller
    {

        // GET: /Booking

        public IActionResult Index()
        {
            return View();
        }

        // GET: /Booking/Welcome

        public IActionResult Welcome(string name = "No name given!", int ID = 1)
        {
            ViewData["Name"] = name;
            ViewData["ID"] = ID;
            Console.WriteLine(ViewData);
            return View();
        }
    }
}
