using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using ITunesSearch.Models;
using Newtonsoft.Json;

namespace ITunesSearch.Services
{
    public class AppleAPI
    {
        //https://itunes.apple.com/search?term=jack+johnson
        //https://itunes.apple.com/search?term=jack+johnson&entity=musicVideo

        const string itunesUrl = "https://itunes.apple.com/search?";

        internal async static Task<IEnumerable<SearchResult>> Search(string searchCriteria, string entity = "song")
        {
            var searchResults = new  JSONSearchRoot();
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(itunesUrl);

            var searchUrl = itunesUrl + "term=" + searchCriteria.Replace(" ", "+") 
                                                                + "&entity=" + entity;

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response =
                client.GetAsync(searchUrl).Result; 
            
            if (response.IsSuccessStatusCode)
            {
                searchResults = JsonConvert.DeserializeObject<JSONSearchRoot>
                                           (response.Content.ReadAsStringAsync().Result);
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }


            return searchResults.Results;
        }
    }
}
