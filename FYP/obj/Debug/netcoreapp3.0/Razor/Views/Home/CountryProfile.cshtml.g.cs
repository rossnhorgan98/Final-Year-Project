#pragma checksum "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2be3ac77e0064c403a2d54f60799cd86a73f4934"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CountryProfile), @"mvc.1.0.view", @"/Views/Home/CountryProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2be3ac77e0064c403a2d54f60799cd86a73f4934", @"/Views/Home/CountryProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b52c45aebf89b7495f206b1cf6886a36ce29318", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CountryProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FYP.Models.Country>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CityProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
  
    ViewData["Title"] = Model.Name;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n\r\n\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 159, "\"", 189, 1);
#nullable restore
#line 11 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
WriteAttributeValue("", 165, Url.Content(Model.Flag), 165, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"250\" height=\"150\" style=\"border:1px solid black\" /><br />\r\n\r\n\r\n    <div class=\"container text-center\">\r\n        <h1>");
#nullable restore
#line 15 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1><br />\r\n        <p><i><b>Language(s):</b> ");
#nullable restore
#line 16 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                             Write(Html.DisplayFor(model => model.LanguageS));

#line default
#line hidden
#nullable disable
            WriteLiteral("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <b>Currency: </b>");
#nullable restore
#line 16 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                                                                                                                                                     Write(Html.DisplayFor(model => model.Currency));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n    </div>\r\n    <br />\r\n    <div style=\"display:flex;\">\r\n\r\n        <!-- <p> Html.DisplayFor(model => model.Description)</p>-->\r\n        <div style=\"flex:1; width:75%\">\r\n\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 756, "\"", 772, 1);
#nullable restore
#line 24 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
WriteAttributeValue("", 762, Model.Map, 762, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
        </div>

        <div style=""flex:1;"">
            <h2>Cities:</h2><br />
            <ul class=""unordered-list"">
                <!--Code below is based on:
                MVC4 EF DB First - How to access a models foreign key (ICollection)
                nycfdtd
                https://stackoverflow.com/a/15171755 -->
");
#nullable restore
#line 34 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                 foreach (var city in Model.City.OrderBy(m => m.Name))
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2be3ac77e0064c403a2d54f60799cd86a73f49346683", async() => {
#nullable restore
#line 37 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                                                                                                 Write(Html.DisplayFor(model => city.Name));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                                                                            WriteLiteral(city.CityId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 38 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <!--End-->\r\n            </ul>\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <div style=\"display:flex\">\r\n        <div style=\"flex:1;\">\r\n            <h2>General</h2>\r\n            <ul>\r\n                <li><b>Population:</b> ");
#nullable restore
#line 49 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                                  Write(Html.DisplayFor(model => model.Population));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li><b>Human Development Index:</b> ");
#nullable restore
#line 50 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                                               Write(Html.DisplayFor(model => model.Hdi));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li><b>Gross Domestic Product:</b> $");
#nullable restore
#line 51 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                                               Write(Html.DisplayFor(model => model.Gdp));

#line default
#line hidden
#nullable disable
            WriteLiteral(" million</li>\r\n                <li><b>International Helathcare System Ranking:</b> ");
#nullable restore
#line 52 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                                                               Write(Html.DisplayFor(model => model.HealthcareRanking));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li><b>Average Annual Tuition Fees:</b> $");
#nullable restore
#line 53 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                                                    Write(Html.DisplayFor(model => model.AvgUniCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li><b>Homicide Rate:</b> ");
#nullable restore
#line 54 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                                     Write(Html.DisplayFor(model => model.HomicideRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n            <br />\r\n        </div>\r\n\r\n        <div style=\"flex:1;\">\r\n            <h2>Work</h2>\r\n            <ul>\r\n                <li><b>Average Annual Salary:</b> $");
#nullable restore
#line 62 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                                              Write(Html.DisplayFor(model => model.AverageWage));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li><b>Average Weekly Work Hours:</b> ");
#nullable restore
#line 63 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                                                 Write(Html.DisplayFor(model => model.AvgWorkHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                <li><b>Minnimum Annual Leave: </b> ");
#nullable restore
#line 64 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                                              Write(Html.DisplayFor(model => model.MinAnnualLeave));

#line default
#line hidden
#nullable disable
            WriteLiteral(" days</li>\r\n                <li><b>Minimum Wage:</b> $");
#nullable restore
#line 65 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                                     Write(Html.DisplayFor(model => model.MinnimumWage));

#line default
#line hidden
#nullable disable
            WriteLiteral(" per hour</li>\r\n                <li><b>Unemployment Rate:</b> ");
#nullable restore
#line 66 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                                         Write(Html.DisplayFor(model => model.UnemploymentRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</li>\r\n                <li><b>Pension Index: </b>");
#nullable restore
#line 67 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                                     Write(Html.DisplayFor(model => model.PensionIndex));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </ul>\r\n            <br />\r\n        </div>\r\n\r\n        <div style=\"flex:1;\">\r\n            <h2>Taxation</h2>\r\n            <ul>\r\n                <li><b>Maximum Income Tax: </b>");
#nullable restore
#line 75 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                                          Write(Html.DisplayFor(model => model.MaxIncomeTax));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</li>\r\n                <li><b>Minnimum Income Tax:</b> ");
#nullable restore
#line 76 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                                           Write(Html.DisplayFor(model => model.MinIncomeTax));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</li>\r\n                <li><b>Standard VAT Rate:</b> ");
#nullable restore
#line 77 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                                         Write(Html.DisplayFor(model => model.Vat));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</li>\r\n                <li><b>Standard Corporation Tax Rate:</b> ");
#nullable restore
#line 78 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CountryProfile.cshtml"
                                                     Write(Html.DisplayFor(model => model.CorporationTax));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</li>\r\n            </ul>\r\n\r\n        </div>\r\n\r\n    </div>\r\n\r\n\r\n    <br />\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FYP.Models.Country> Html { get; private set; }
    }
}
#pragma warning restore 1591
