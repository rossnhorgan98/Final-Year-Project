#pragma checksum "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbf7043e482ecc0093d6dc7c1d9b4a8b1397fcaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CompareCities), @"mvc.1.0.view", @"/Views/Home/CompareCities.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbf7043e482ecc0093d6dc7c1d9b4a8b1397fcaa", @"/Views/Home/CompareCities.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b52c45aebf89b7495f206b1cf6886a36ce29318", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CompareCities : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FYP.Models.CompareViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cityA"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cityB"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CompareCities", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CityProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
  
    ViewData["Title"] = "Locationer - Compare";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    <div class=\"container text-center\">\r\n       \r\n        <div class=\"container text-center\">\r\n            <h2>Select cities to compare</h2>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbf7043e482ecc0093d6dc7c1d9b4a8b1397fcaa5806", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbf7043e482ecc0093d6dc7c1d9b4a8b1397fcaa6080", async() => {
                    WriteLiteral("\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 13 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.cityA.CityId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 13 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.cityList,"CityId","Name").OrderBy(l => l.Text));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbf7043e482ecc0093d6dc7c1d9b4a8b1397fcaa8248", async() => {
                    WriteLiteral("\r\n                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 16 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.cityB.CityId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.cityList,"CityId","Name").OrderBy(l => l.Text));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <br /> <br />\r\n                <button class=\"genric-btn primary radius\">Compare</button>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n\r\n\r\n");
#nullable restore
#line 24 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
         if (Model != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"container text-center\" style=\"display:flex;\">\r\n                <div style=\"flex:1;\">\r\n                    <h2>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbf7043e482ecc0093d6dc7c1d9b4a8b1397fcaa12488", async() => {
#nullable restore
#line 28 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                                                                                        Write(Model.cityA.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                                                            WriteLiteral(Model.cityA.CityId);

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
            WriteLiteral("</h2><br />\r\n                    <h3>General</h3>\r\n                    <ul style=\"list-style: none;\">\r\n                        <li>\r\n                            <b>Population:</b> ");
#nullable restore
#line 32 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                          Write(Model.cityA.Population);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </li>\r\n                        <li><b>Quality of Life Index:</b> ");
#nullable restore
#line 34 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                                     Write(Model.cityA.QualityOfLifeIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                        \r\n                        <li><b>Safety Index:</b> ");
#nullable restore
#line 36 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                            Write(Model.cityA.SafetyIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><b>Pollution Index:</b> ");
#nullable restore
#line 37 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                               Write(Model.cityA.PollutionIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ul>\r\n                    <br />\r\n                    <h3>Cost</h3>\r\n                    <ul style=\"list-style: none;\">\r\n                        <li><b>Cost of Living Index:</b> ");
#nullable restore
#line 42 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                                    Write(Model.cityA.CostOfLivingIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><b>Rent Index: </b>");
#nullable restore
#line 43 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                          Write(Model.cityA.RentIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><b>Purchasing Power Index: </b>");
#nullable restore
#line 44 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                                      Write(Model.cityA.PurchasingPowerIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ul>\r\n                    <br />\r\n                    <h3>Transport</h3>\r\n                    <ul style=\"list-style: none;\">\r\n                        <li><b>Traffic Rate:</b>");
#nullable restore
#line 49 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                           Write(Model.cityA.TrafficRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</li>\r\n                        <li><b>Number of light rail lines:</b> ");
#nullable restore
#line 50 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                                          Write(Model.cityA.LightRailLines);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><b>Number of Airports:</b> ");
#nullable restore
#line 51 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                                  Write(Model.cityA.NoOfAirports);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ul>\r\n                    <br />\r\n                    <h3>Climate</h3>\r\n                    <ul>\r\n                        <li><b>Climate Type:</b> ");
#nullable restore
#line 56 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                            Write(Model.cityA.ClimateType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><img");
            BeginWriteAttribute("src", " src=\"", 2714, "\"", 2758, 1);
#nullable restore
#line 57 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
WriteAttributeValue("", 2720, Url.Content(Model.cityA.ClimateImage), 2720, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"175\" /></li>\r\n                    </ul>\r\n                </div>\r\n                \r\n                <div style=\"flex:1;\">\r\n                    <h2> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbf7043e482ecc0093d6dc7c1d9b4a8b1397fcaa19923", async() => {
#nullable restore
#line 62 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                                                                                         Write(Model.cityB.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 62 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                                                             WriteLiteral(Model.cityB.CityId);

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
            WriteLiteral("</h2> <br>\r\n                    <h3>General</h3>\r\n                    <ul style=\"list-style: none;\">\r\n                        <li><b>Population:</b> ");
#nullable restore
#line 65 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                          Write(Model.cityB.Population);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><b>Quality of Life Index:</b> ");
#nullable restore
#line 66 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                                     Write(Model.cityB.QualityOfLifeIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><b>Safety Index:</b>");
#nullable restore
#line 67 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                           Write(Model.cityB.SafetyIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                        <li><b>Pollution Index:</b> ");
#nullable restore
#line 68 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                               Write(Model.cityB.PollutionIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ul>\r\n                    <br />\r\n                    <h3>Cost</h3>\r\n                    <ul style=\"list-style: none;\">\r\n                        <li><b>Cost of Living Index:</b> ");
#nullable restore
#line 73 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                                    Write(Model.cityB.CostOfLivingIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n                        <li><b>Rent Index:</b> ");
#nullable restore
#line 74 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                          Write(Model.cityB.RentIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><b>Purchasing Power Index:</b> ");
#nullable restore
#line 75 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                                      Write(Model.cityB.PurchasingPowerIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ul>\r\n                    <br />\r\n                    <h3>Transport</h3>\r\n                    <ul style=\"list-style: none;\">\r\n                        <li><b>Traffic Rate:</b> ");
#nullable restore
#line 80 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                            Write(Model.cityB.TrafficRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</li>\r\n                        <li><b>Number of light rail lines:</b> ");
#nullable restore
#line 81 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                                          Write(Model.cityB.LightRailLines);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><b>Number of Airports:</b> ");
#nullable restore
#line 82 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                                  Write(Model.cityB.NoOfAirports);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                    </ul>\r\n                    <br />\r\n                    <h3>Climate</h3>\r\n                    <ul>\r\n                        <li><b>Climate Type:</b> ");
#nullable restore
#line 87 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
                                            Write(Model.cityB.ClimateType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li><img");
            BeginWriteAttribute("src", " src=\"", 4529, "\"", 4573, 1);
#nullable restore
#line 88 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"
WriteAttributeValue("", 4535, Url.Content(Model.cityB.ClimateImage), 4535, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"300\" height=\"175\" /></li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 92 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCities.cshtml"

            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FYP.Models.CompareViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
