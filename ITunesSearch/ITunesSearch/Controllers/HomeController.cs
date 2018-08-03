using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Mvc;
using ITunesSearch.Models;
using System.Threading.Tasks;
using ITunesSearch.Services;

namespace ITunesSearch.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Search()
        {
            var clientAPI = new AppleAPI();
            var searchResults = clientAPI.Search("jack johnson");



            return View("Index");
        }
    }
}
