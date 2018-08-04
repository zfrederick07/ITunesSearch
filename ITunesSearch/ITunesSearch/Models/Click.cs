using System;

namespace ITunesSearch.Models
{
    //Click Model for the information of the clicks on the site
    public class Click
    {
        public string SessionId { get; set; }
        public string TrackName { get; set; }
        public string TrackViewUrl { get; set; }
        public DateTime TimeOfClick { get; set; }
    }
}
