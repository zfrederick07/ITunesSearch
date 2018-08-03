#pragma checksum "/Users/zacharyfrederick/Documents/GitHub/ITunesSearch/ITunesSearch/ITunesSearch/Views/Home/_SearchResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4644686b0639b8b4bd2c6c34dcb44445ddd03f42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__SearchResults), @"mvc.1.0.view", @"/Views/Home/_SearchResults.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/_SearchResults.cshtml", typeof(AspNetCore.Views_Home__SearchResults))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/zacharyfrederick/Documents/GitHub/ITunesSearch/ITunesSearch/ITunesSearch/Views/_ViewImports.cshtml"
using ITunesSearch;

#line default
#line hidden
#line 2 "/Users/zacharyfrederick/Documents/GitHub/ITunesSearch/ITunesSearch/ITunesSearch/Views/_ViewImports.cshtml"
using ITunesSearch.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4644686b0639b8b4bd2c6c34dcb44445ddd03f42", @"/Views/Home/_SearchResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b84d489f197db726957d831cffa80b4d58ba0d5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home__SearchResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SearchResult>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 4, true);
            WriteLiteral("    ");
            EndContext();
#line 2 "/Users/zacharyfrederick/Documents/GitHub/ITunesSearch/ITunesSearch/ITunesSearch/Views/Home/_SearchResults.cshtml"
      
    var searchResults = (List<SearchResult>
        )ViewData["SearchResults"];
        var sessionId = (string)ViewData["SessionId"];
        

#line default
#line hidden
            BeginContext(184, 923, true);
            WriteLiteral(@"        <div class=""col-8"">
            <div class=""row"">
                <div class=""table-responsive"">
                    <table class=""table table-bordered table-condensed table-striped table-hover sortable"" data-toggle=""table"" data-pagination=""true"" data-search=""true"">
                        <thead>
                            <tr class=""secondary"">
                                <th class=""col-sm-2"" data-defaultsign=""AZ"">Artwork</th>
                                <th class=""col-sm-3"" data-sortable=""true"" data-field=""ArtistName"" data-defaultsign=""AZ"">Artist</th>
                                <th class=""col-sm-4"" data-sortable=""true"" data-field=""CollectionName"" data-defaultsign=""AZ"">Collection</th>
                                <th class=""col-sm-3"" data-sortable=""true"" data-field=""Track"" data-defaultsign=""AZ"">Track</th>
                            </tr>
                        </thead>
");
            EndContext();
#line 19 "/Users/zacharyfrederick/Documents/GitHub/ITunesSearch/ITunesSearch/ITunesSearch/Views/Home/_SearchResults.cshtml"
                         if (searchResults == null || searchResults.Count() == 0)
                        {

#line default
#line hidden
            BeginContext(1217, 129, true);
            WriteLiteral("                        <tr>\r\n                            <td colspan=\"4\">No Records found.</td>\r\n                        </tr>\r\n");
            EndContext();
#line 24 "/Users/zacharyfrederick/Documents/GitHub/ITunesSearch/ITunesSearch/ITunesSearch/Views/Home/_SearchResults.cshtml"
                        }
                        else
                        {
                        foreach (var item in searchResults.OrderBy(x => x.CollectionName).ThenBy(x => x.TrackNumber))
                        {

#line default
#line hidden
            BeginContext(1576, 100, true);
            WriteLiteral("                        <tr>\r\n                            <td>\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1676, "\"", 1701, 1);
#line 31 "/Users/zacharyfrederick/Documents/GitHub/ITunesSearch/ITunesSearch/ITunesSearch/Views/Home/_SearchResults.cshtml"
WriteAttributeValue("", 1682, item.ArtworkUrl100, 1682, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1702, 106, true);
            WriteLiteral(" />\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1809, 15, false);
#line 34 "/Users/zacharyfrederick/Documents/GitHub/ITunesSearch/ITunesSearch/ITunesSearch/Views/Home/_SearchResults.cshtml"
                           Write(item.ArtistName);

#line default
#line hidden
            EndContext();
            BeginContext(1824, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1928, 19, false);
#line 37 "/Users/zacharyfrederick/Documents/GitHub/ITunesSearch/ITunesSearch/ITunesSearch/Views/Home/_SearchResults.cshtml"
                           Write(item.CollectionName);

#line default
#line hidden
            EndContext();
            BeginContext(1947, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2051, 16, false);
#line 40 "/Users/zacharyfrederick/Documents/GitHub/ITunesSearch/ITunesSearch/ITunesSearch/Views/Home/_SearchResults.cshtml"
                           Write(item.TrackNumber);

#line default
#line hidden
            EndContext();
            BeginContext(2067, 10, true);
            WriteLiteral(". &nbsp;<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2077, "\"", 2102, 1);
#line 40 "/Users/zacharyfrederick/Documents/GitHub/ITunesSearch/ITunesSearch/ITunesSearch/Views/Home/_SearchResults.cshtml"
WriteAttributeValue("", 2084, item.TrackViewUrl, 2084, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 2103, "\"", 2215, 10);
            WriteAttributeValue("", 2113, "return", 2113, 6, true);
            WriteAttributeValue(" ", 2119, "track(\'", 2120, 8, true);
#line 40 "/Users/zacharyfrederick/Documents/GitHub/ITunesSearch/ITunesSearch/ITunesSearch/Views/Home/_SearchResults.cshtml"
WriteAttributeValue("", 2127, sessionId, 2127, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 2137, "\',", 2137, 2, true);
            WriteAttributeValue(" ", 2139, "\'", 2140, 2, true);
#line 40 "/Users/zacharyfrederick/Documents/GitHub/ITunesSearch/ITunesSearch/ITunesSearch/Views/Home/_SearchResults.cshtml"
WriteAttributeValue("", 2141, item.TrackName, 2141, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 2156, "\',", 2156, 2, true);
            WriteAttributeValue(" ", 2158, "\'", 2159, 2, true);
#line 40 "/Users/zacharyfrederick/Documents/GitHub/ITunesSearch/ITunesSearch/ITunesSearch/Views/Home/_SearchResults.cshtml"
WriteAttributeValue("", 2160, System.Net.WebUtility.UrlEncode(@item.TrackViewUrl), 2160, 52, false);

#line default
#line hidden
            WriteAttributeValue("", 2212, "\');", 2212, 3, true);
            EndWriteAttribute();
            BeginContext(2216, 55, true);
            WriteLiteral(" target=\"_blank\">\r\n                                    ");
            EndContext();
            BeginContext(2272, 14, false);
#line 41 "/Users/zacharyfrederick/Documents/GitHub/ITunesSearch/ITunesSearch/ITunesSearch/Views/Home/_SearchResults.cshtml"
                               Write(item.TrackName);

#line default
#line hidden
            EndContext();
            BeginContext(2286, 106, true);
            WriteLiteral("\r\n                                </a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 45 "/Users/zacharyfrederick/Documents/GitHub/ITunesSearch/ITunesSearch/ITunesSearch/Views/Home/_SearchResults.cshtml"
                        }
                        }

#line default
#line hidden
            BeginContext(2446, 539, true);
            WriteLiteral(@"                    </table>
                </div>
            </div>
        </div>
        <script typeof=""text/javascript"">function track(sessionId, trackName, trackViewUrl) {
                var dataType = ""application/json; charset=utf-8"";
                var data = {
                    SessionId: sessionId,
                    TrackName: trackName,
                    TrackViewUrl: trackViewUrl
                }

                //alert(JSON.stringify(data));

                $.ajax({
                    url: '");
            EndContext();
            BeginContext(2986, 35, false);
#line 62 "/Users/zacharyfrederick/Documents/GitHub/ITunesSearch/ITunesSearch/ITunesSearch/Views/Home/_SearchResults.cshtml"
                     Write(Url.Action("PlusOne", "ClickCount"));

#line default
#line hidden
            EndContext();
            BeginContext(3021, 318, true);
            WriteLiteral(@"',
                    type: ""POST"",
                    dataType: 'json',
                    data: JSON.stringify(data),
                    contentType: dataType,

                    success: function(result) {
                        //alert(result);
                    }
                });
}</script>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SearchResult>> Html { get; private set; }
    }
}
#pragma warning restore 1591