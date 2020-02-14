#pragma checksum "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CityProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d474d15e33bc9fbf911ba017d0ff5d01d2ab958"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CityProfile), @"mvc.1.0.view", @"/Views/Home/CityProfile.cshtml")]
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
#line 1 "C:\Users\rossh\source\repos\FYP\FYP\Views\_ViewImports.cshtml"
using FYP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rossh\source\repos\FYP\FYP\Views\_ViewImports.cshtml"
using FYP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d474d15e33bc9fbf911ba017d0ff5d01d2ab958", @"/Views/Home/CityProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b52c45aebf89b7495f206b1cf6886a36ce29318", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CityProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FYP.Models.City>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CityProfile.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span style=\"display:inline-block;\">\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 166, "\"", 206, 1);
#nullable restore
#line 8 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CityProfile.cshtml"
WriteAttributeValue("", 172, Url.Content(Model.GeneralPicture), 172, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"1100\" height=\"500\" />\r\n        </span>\r\n    <h1>");
#nullable restore
#line 10 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CityProfile.cshtml"
   Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 10 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CityProfile.cshtml"
                                          Write(Html.DisplayFor(model => model.Country.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <br />\r\n    <p> ");
#nullable restore
#line 12 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CityProfile.cshtml"
   Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <br />\r\n    <div class=\"cityStuff\">\r\n        <div class=\"cityGeneral\">\r\n            <h3>General</h3>\r\n            <ul>\r\n                <li>Population: ");
#nullable restore
#line 18 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CityProfile.cshtml"
                           Write(Html.DisplayFor(model => model.Population));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>Quality of Life Index: ");
#nullable restore
#line 19 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CityProfile.cshtml"
                                      Write(Html.DisplayFor(model => model.QualityOfLifeIndex));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li>Number of Universities: ");
#nullable restore
#line 20 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CityProfile.cshtml"
                                       Write(Html.DisplayFor(model => model.NoOfUniversities));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n\r\n            <br />\r\n        </div>\r\n        <div class=\"cityCost\">\r\n    <h3>Costs</h3>\r\n    <ul>\r\n        <li>Cost of Living Index: ");
#nullable restore
#line 28 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CityProfile.cshtml"
                             Write(Html.DisplayFor(model => model.CostOfLivingIndex));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n        <li>Rent Index: ");
#nullable restore
#line 29 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CityProfile.cshtml"
                   Write(Html.DisplayFor(model => model.RentIndex));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Purchasing Power: ");
#nullable restore
#line 30 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CityProfile.cshtml"
                         Write(Html.DisplayFor(model => model.PurchasingPowerIndex));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n    </ul>\r\n            </div>\r\n    </div>\r\n<br /><br /><br /><br /><br />\r\n    <div class=\"climate\">\r\n    <h3>Climate</h3>\r\n    <p>\r\n        Climate Type: ");
#nullable restore
#line 38 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CityProfile.cshtml"
                 Write(Html.DisplayFor(model => model.ClimateType));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 1424, "\"", 1462, 1);
#nullable restore
#line 39 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CityProfile.cshtml"
WriteAttributeValue("", 1430, Url.Content(Model.ClimateImage), 1430, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"600\" height=\"300\" /> <br />\r\n        ");
#nullable restore
#line 40 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CityProfile.cshtml"
   Write(Html.DisplayFor(model => model.ClimateDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    </div>\r\n\r\n    <br />\r\n    <h3>Transportation</h3>\r\n    <div style=\"align-items:center;\">\r\n        <div style=\"float:left; width:400px;\"  >\r\n        <ul>\r\n        <li>Traffic Rate: ");
#nullable restore
#line 49 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CityProfile.cshtml"
                     Write(Html.DisplayFor(model => model.TrafficRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</li>\r\n        <li>Number of Airports: ");
#nullable restore
#line 50 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CityProfile.cshtml"
                           Write(Html.DisplayFor(model => model.NoOfAirports));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li>Number of Light Rail Lines: ");
#nullable restore
#line 51 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CityProfile.cshtml"
                                   Write(Html.DisplayFor(model => model.LightRailLines));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n            </div>\r\n        <div class=\"cityTransport\" >\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 2074, "\"", 2114, 1);
#nullable restore
#line 55 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CityProfile.cshtml"
WriteAttributeValue("", 2080, Url.Content(Model.TransportImage), 2080, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"500\" height=\"200\"/> \r\n            </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FYP.Models.City> Html { get; private set; }
    }
}
#pragma warning restore 1591
