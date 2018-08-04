using ITunesSearch.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITunesSearch.Controllers
{
    public class ClicksController : Controller
    {
        //Updates the clicks view to display the click information from each user
        public IActionResult Index()
        {
            return View(FileServices.ReadFromFile());
        }
    }
}
