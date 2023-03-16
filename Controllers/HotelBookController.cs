using hotelbook.Models;
using Microsoft.AspNetCore.Mvc;

namespace hotelbook.Controllers
{
    public class HotelBookController : Controller
    {
        private static List<HotelBooking> hotelBooked = new List<HotelBooking>();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult HotelBookingDetails() {
                     
            return View(hotelBooked);
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult SubmitForm(HotelBooking hotelBooking)
        {
            hotelBooked.Add(hotelBooking);
            return RedirectToAction(nameof(HotelBookingDetails));
        }
    }
}
