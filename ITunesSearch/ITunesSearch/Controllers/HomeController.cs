
using Microsoft.AspNetCore.Mvc;
using ITunesSearch.Models;
using ITunesSearch.Services;


namespace ITunesSearch.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SearchResult searchResult)
        {
            if (!string.IsNullOrEmpty(searchResult.SearchText))
            {
                var clientAPI = new AppleAPI();
                var searchResults = AppleAPI.SearchesAsync(searchResult.SearchText ?? string.Empty);

                ViewData.Add("SessionID", HttpContext.Session.Id);
                ViewData.Add("SearchResults", searchResults.Result);
            }

            return View();
        }
    }
}
