#pragma checksum "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00c61cf900c7d49e92af173c30ca0eba70f530f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Home), @"mvc.1.0.view", @"/Views/Home/Home.cshtml")]
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
#nullable restore
#line 1 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/_ViewImports.cshtml"
using csharpExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/_ViewImports.cshtml"
using csharpExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00c61cf900c7d49e92af173c30ca0eba70f530f2", @"/Views/Home/Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0685f33139b1d7c25572dc27b65fd076ab7005a2", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<csharpExam.Models.HomeModels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
  
    ViewData["Title"] = "Login/Registration";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"
    <header>
        <nav class=""navbar navbar-expand-lg navbar-light bg-light fixed-top"">
            <a class=""navbar-brand"">Dojo Activity Center</a>
            <button class=""navbar-toggler"" data-target=""#my-nav"" data-toggle=""collapse"" aria-controls=""my-nav"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div id=""my-nav"" class=""collapse navbar-collapse"">
                <ul class=""navbar-nav ml-sm-2"">
                    <li class=""nav-item active"">
                        <p>Welcome, ");
#nullable restore
#line 16 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                               Write(ViewBag.thisUser.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""/logout"">logout</a>
                    </li>
                </ul>
            </div>
        </nav>
    </header>

<div class=""container m-5"">
    <table class=""table table-dark"">
        <thead class=""thead-light"">
            <tr>
                <th>Activity</th>
                <th>Date and Time</th>
                <th>Duration</th>
                <th>Event Coordinator</th>
                <th>No. of Participants</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 39 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
             foreach (var a in ViewBag.AllActivities)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1473, "\"", 1503, 2);
            WriteAttributeValue("", 1480, "/activity/", 1480, 10, true);
#nullable restore
#line 42 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
WriteAttributeValue("", 1490, a.ActivityId, 1490, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 42 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                                                         Write(a.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\n                        <td>");
#nullable restore
#line 43 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                       Write(a.Date.ToString("M/d"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            WriteLiteral("@ ");
#nullable restore
#line 43 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                                                  Write(a.Date.ToString("h:mmtt"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                        <td>");
#nullable restore
#line 44 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                       Write(a.Length);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 44 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                                 Write(a.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 45 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                         if (ViewBag.userCoordinator != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                             foreach (var c in ViewBag.userCoordinator)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                                 if (a.CoordinatorId == c.UserId)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 51 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                                   Write(c.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 52 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                                 
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 55 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                       Write(a.Participants.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n");
#nullable restore
#line 56 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                         if (a.CoordinatorId == ViewBag.ThisUser.UserId)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td><a");
            BeginWriteAttribute("href", " href=\"", 2287, "\"", 2315, 2);
            WriteAttributeValue("", 2294, "/delete/", 2294, 8, true);
#nullable restore
#line 58 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
WriteAttributeValue("", 2302, a.ActivityId, 2302, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a></td>\n");
#nullable restore
#line 59 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                        }
                        else
                        {
                            int user = 0;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                             foreach (var u in a.Participants)
                            {
                                if (u.User.UserId == ViewBag.ThisUser.UserId)
                                {
                                    user = u.ParticipantId;
                                }
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                             if (user == 0)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><a");
            BeginWriteAttribute("href", " href=\"", 2897, "\"", 2923, 2);
            WriteAttributeValue("", 2904, "/join/", 2904, 6, true);
#nullable restore
#line 72 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
WriteAttributeValue("", 2910, a.ActivityId, 2910, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Join</a></td>\n");
#nullable restore
#line 73 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><a");
            BeginWriteAttribute("href", " href=\"", 3070, "\"", 3089, 2);
            WriteAttributeValue("", 3077, "/leave/", 3077, 7, true);
#nullable restore
#line 76 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
WriteAttributeValue("", 3084, user, 3084, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Leave</a></td>\n");
#nullable restore
#line 77 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                             
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tr>\n");
#nullable restore
#line 80 "/Users/shawn/Documents/codingDojo/exam/csharpExam/Views/Home/Home.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n    <a href=\"/new\">Create New Activity</a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<csharpExam.Models.HomeModels> Html { get; private set; }
    }
}
#pragma warning restore 1591