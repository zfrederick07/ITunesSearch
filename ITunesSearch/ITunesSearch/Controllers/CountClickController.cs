using System;
using System.Collections.Generic;
using ITunesSearch.Models;
using ITunesSearch.Services;
using Microsoft.AspNetCore.Mvc;

namespace ITunesSearch.Controllers
{
    //Click count controller
    public class CountClickController : Controller
    {
        private static List<Click> clicks;
        private const int _writeBuffer = 1;

        //Records the each click and writes it to a file
        [HttpPost]
        public void PlusOne([FromBody]Click click)
        {
            if (click == null)
            {
                return;
            }

            click.TimeOfClick = DateTime.UtcNow;

            if (clicks == null)
            {
                clicks = new List<Click>();
            }

            clicks.Add(click);

            if (clicks.Count % _writeBuffer == 0)
            {
                FileServices.SaveToFile(clicks);
            }
        }
    }
}
