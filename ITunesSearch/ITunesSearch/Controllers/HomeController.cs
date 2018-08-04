using System;
using Microsoft.AspNetCore.Mvc;
using ITunesSearch.Models;
using ITunesSearch.Services;


namespace ITunesSearch.Controllers
{
    public class HomeController : Controller
    {
        //Initial view for the controller
        public IActionResult Index()
        {
            return View();
        }


        //Updates the view with the search information inputted by the users
        [HttpPost]
        public IActionResult Index(SearchResult searchResult)
        {
            if (!string.IsNullOrEmpty(searchResult.SearchText))
            {
                var clientAPI = new AppleAPI();
                var searchResults = AppleAPI.Search(searchResult.SearchText ?? string.Empty);

                ViewData.Add("SessionID", HttpContext.Session.Id);
                ViewData.Add("SearchResults", searchResults.Result);
            }

            return View();
        }
    }
}
