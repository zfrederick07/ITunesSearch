using ITunesSearch.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITunesSearch.Controllers
{
    public class ClicksController : Controller
    {
        public IActionResult Index()
        {
            return View(FileServices.ReadFromFile());
        }
    }
}
