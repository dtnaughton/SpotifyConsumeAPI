#pragma checksum "C:\Users\Daniel.Naughton\source\repos\SpotifyConsumeAPI\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d4587bd8f99c02cc81ce91ae4358d5442fcc59d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Daniel.Naughton\source\repos\SpotifyConsumeAPI\Views\_ViewImports.cshtml"
using SpotifyConsumeAPI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Daniel.Naughton\source\repos\SpotifyConsumeAPI\Views\_ViewImports.cshtml"
using SpotifyConsumeAPI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d4587bd8f99c02cc81ce91ae4358d5442fcc59d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07391e68ca6d7bb9518b0facbbb3e498a5ba90d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SpotifyConsumeAPI.Models.Release>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Daniel.Naughton\source\repos\SpotifyConsumeAPI\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\Users\Daniel.Naughton\source\repos\SpotifyConsumeAPI\Views\Home\Index.cshtml"
     foreach(var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card m-1\" style=\"width:350px\";>\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\Daniel.Naughton\source\repos\SpotifyConsumeAPI\Views\Home\Index.cshtml"
                                  Write(Html.DisplayFor(modelItem => item.Artist));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h6 class=\"card-subtitle mb-2 text-muted\">");
#nullable restore
#line 13 "C:\Users\Daniel.Naughton\source\repos\SpotifyConsumeAPI\Views\Home\Index.cshtml"
                                                     Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <p class=\"card-text\">");
#nullable restore
#line 14 "C:\Users\Daniel.Naughton\source\repos\SpotifyConsumeAPI\Views\Home\Index.cshtml"
                                Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 548, "\"", 598, 1);
#nullable restore
#line 15 "C:\Users\Daniel.Naughton\source\repos\SpotifyConsumeAPI\Views\Home\Index.cshtml"
WriteAttributeValue("", 554, Html.DisplayFor(modelItem => item.ImageUrl), 554, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"300\" alt=\"Release picture\" />\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 669, "\"", 716, 1);
#nullable restore
#line 16 "C:\Users\Daniel.Naughton\source\repos\SpotifyConsumeAPI\Views\Home\Index.cshtml"
WriteAttributeValue("", 676, Html.DisplayFor(modelItem => item.Link), 676, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">Listen</a>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 19 "C:\Users\Daniel.Naughton\source\repos\SpotifyConsumeAPI\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SpotifyConsumeAPI.Models.Release>> Html { get; private set; }
    }
}
#pragma warning restore 1591
