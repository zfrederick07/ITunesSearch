using System;

namespace ITunesSearch.Models
{
    public class Click
    {
        public string SessionId { get; set; }
        public string TrackName { get; set; }
        public string TrackViewUrl { get; set; }
        public DateTime TimeOfClick { get; set; }
    }
}
