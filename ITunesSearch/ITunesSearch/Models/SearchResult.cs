using System;
using System.Collections.Generic;

namespace ITunesSearch.Models
{

    //Search Results model for the JSON from the Itunes API
    public class JSONSearchRoot
    {
        public int ResultCount { get; set; }
        public List<SearchResult> Results { get; set; }
    }

    public class SearchResult
    {
        public SearchResult() 
        {
            SearchText = string.Empty;
        }

        public string SearchText { get; set; }
        public string Kind { get; set; }
        public string ArtistName { get; set; }
        public string CollectionName { get; set; }
        public int TrackNumber { get; set; }
        public string TrackName { get; set; }
        public string TrackViewUrl { get; set; }
        public string ArtworkUrl100 { get; set; }
    }
}