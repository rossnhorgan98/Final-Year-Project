#pragma checksum "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41667b52939756a3f7f67daa70155b81dad7655d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CompareCountries), @"mvc.1.0.view", @"/Views/Home/CompareCountries.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41667b52939756a3f7f67daa70155b81dad7655d", @"/Views/Home/CompareCountries.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b52c45aebf89b7495f206b1cf6886a36ce29318", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CompareCountries : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FYP.Models.CompareViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CompareCountries", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CountryProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
  
    ViewData["Title"] = "Locationer - Compare";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container text-center\">\r\n\r\n    <div class=\"container text-center\">\r\n        <h2>Select countries to compare</h2>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41667b52939756a3f7f67daa70155b81dad7655d5132", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41667b52939756a3f7f67daa70155b81dad7655d5402", async() => {
                    WriteLiteral("\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 13 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.countryA.CountryId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 13 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.countryList,"CountryId","Name"));

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
                WriteLiteral("\r\n\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41667b52939756a3f7f67daa70155b81dad7655d7472", async() => {
                    WriteLiteral("\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#nullable restore
#line 16 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.countryB.CountryId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 16 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.countryList,"CountryId","Name"));

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
                WriteLiteral("\r\n            <br /> <br />\r\n            <button class=\"genric-btn primary radius\">Compare</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n");
#nullable restore
#line 24 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
     if (Model != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container text-center\" style=\"display:flex;\">\r\n    <div style=\"flex:1;\">\r\n        <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41667b52939756a3f7f67daa70155b81dad7655d11561", async() => {
#nullable restore
#line 28 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                                                                                     Write(Model.countryA.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                                                   WriteLiteral(Model.countryA.CountryId);

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
            WriteLiteral("</h3><br />\r\n        <h5>General</h5>\r\n        <ul style=\"list-style: none;\">\r\n            <li>\r\n                <b>Population:</b> ");
#nullable restore
#line 32 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                              Write(Model.countryA.Population);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n            <li><b>Language(s):</b> ");
#nullable restore
#line 34 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                               Write(Model.countryA.LanguageS);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n            <li><b>Currency:</b> ");
#nullable restore
#line 35 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                            Write(Model.countryA.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li><b>Human Development Index:</b> ");
#nullable restore
#line 36 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                           Write(Model.countryA.Hdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li><b>Gross Domestic Product:</b> $");
#nullable restore
#line 37 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                           Write(Model.countryA.Gdp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li><b>International Healthcare System Ranking:</b> ");
#nullable restore
#line 38 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                                           Write(Model.countryA.HealthcareRanking);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li><b>Homicide Rate:</b> ");
#nullable restore
#line 39 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                 Write(Model.countryA.HomicideRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li><b>Average Annual Univesity Cost:</b> ");
#nullable restore
#line 40 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                                 Write(Model.countryA.AvgUniCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ul>\r\n        <br />\r\n        <h5>Work</h5>\r\n        <ul style=\"list-style: none;\">\r\n            <li><b>Average Annual Salary:</b> $");
#nullable restore
#line 45 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                          Write(Model.countryA.AverageWage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li><b>Minnimum Annual Leave: </b>");
#nullable restore
#line 46 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                         Write(Model.countryA.MinAnnualLeave);

#line default
#line hidden
#nullable disable
            WriteLiteral(" days</li>\r\n            <li><b>Average working hours per week: </b>");
#nullable restore
#line 47 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                                  Write(Model.countryA.AvgWorkHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li><b>Minnimum Wage:</b> $");
#nullable restore
#line 48 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                  Write(Model.countryA.MinnimumWage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" per hour</li>\r\n            <li><b>Unemployment Rate:</b> ");
#nullable restore
#line 49 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                     Write(Model.countryA.UnemploymentRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</li>\r\n            <li><b>Pension Index:</b> ");
#nullable restore
#line 50 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                 Write(Model.countryA.PensionIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n        </ul>\r\n        <br />\r\n        <h5>Taxation</h5>\r\n        <ul style=\"list-style: none;\">\r\n            <li><b>Minnimum Income Tax:</b>");
#nullable restore
#line 56 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                      Write(Model.countryA.MinIncomeTax);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</li>\r\n            <li><b>Maximum Income Tax:</b>");
#nullable restore
#line 57 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                     Write(Model.countryA.MinIncomeTax);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</li>\r\n            <li><b>Standard VAT Rate:</b>");
#nullable restore
#line 58 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                    Write(Model.countryA.Vat);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</li>\r\n            <li><b>Standard Corporation Tax:</b> ");
#nullable restore
#line 59 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                            Write(Model.countryA.CorporationTax);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</li>\r\n        </ul>\r\n\r\n    </div>\r\n\r\n    <div style=\"flex:1;\">\r\n        <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41667b52939756a3f7f67daa70155b81dad7655d20233", async() => {
#nullable restore
#line 65 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                                                                                     Write(Model.countryB.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 65 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                                                   WriteLiteral(Model.countryB.CountryId);

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
            WriteLiteral("</h3><br />\r\n        <h5>General</h5>\r\n        <ul style=\"list-style: none;\">\r\n            <li>\r\n                <b>Population:</b> ");
#nullable restore
#line 69 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                              Write(Model.countryB.Population);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </li>\r\n            <li><b>Language(s):</b> ");
#nullable restore
#line 71 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                               Write(Model.countryB.LanguageS);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </li>\r\n            <li><b>Currency:</b> ");
#nullable restore
#line 72 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                            Write(Model.countryB.Currency);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li><b>Human Development Index:</b> ");
#nullable restore
#line 73 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                           Write(Model.countryB.Hdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li><b>Gross Domestic Product:</b> $");
#nullable restore
#line 74 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                           Write(Model.countryB.Gdp);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li><b>International Healthcare System Ranking:</b> ");
#nullable restore
#line 75 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                                           Write(Model.countryB.HealthcareRanking);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li><b>Homicide Rate:</b> ");
#nullable restore
#line 76 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                 Write(Model.countryB.HomicideRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li><b>Average Annual Univesity Cost:</b> ");
#nullable restore
#line 77 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                                 Write(Model.countryB.AvgUniCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ul>\r\n        <br />\r\n        <h5>Work</h5>\r\n        <ul style=\"list-style: none;\">\r\n            <li><b>Average Annual Salary:</b> $");
#nullable restore
#line 82 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                          Write(Model.countryB.AverageWage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li><b>Minnimum Annual Leave: </b>");
#nullable restore
#line 83 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                         Write(Model.countryB.MinAnnualLeave);

#line default
#line hidden
#nullable disable
            WriteLiteral(" days</li>\r\n            <li><b>Average working hours per week: </b>");
#nullable restore
#line 84 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                                  Write(Model.countryB.AvgWorkHours);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li><b>Minnimum Wage:</b> $");
#nullable restore
#line 85 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                  Write(Model.countryB.MinnimumWage);

#line default
#line hidden
#nullable disable
            WriteLiteral(" per hour</li>\r\n            <li><b>Unemployment Rate:</b> ");
#nullable restore
#line 86 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                     Write(Model.countryB.UnemploymentRate);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</li>\r\n            <li><b>Pension Index:</b> ");
#nullable restore
#line 87 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                 Write(Model.countryB.PensionIndex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n        </ul>\r\n        <br />\r\n        <h5>Taxation</h5>\r\n        <ul style=\"list-style: none;\">\r\n            <li><b>Minnimum Income Tax:</b>");
#nullable restore
#line 93 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                      Write(Model.countryB.MinIncomeTax);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</li>\r\n            <li><b>Maximum Income Tax:</b>");
#nullable restore
#line 94 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                     Write(Model.countryB.MinIncomeTax);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</li>\r\n            <li><b>Standard VAT Rate:</b>");
#nullable restore
#line 95 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                    Write(Model.countryB.Vat);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</li>\r\n            <li><b>Standard Corporation Tax:</b> ");
#nullable restore
#line 96 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"
                                            Write(Model.countryB.CorporationTax);

#line default
#line hidden
#nullable disable
            WriteLiteral("%</li>\r\n        </ul>\r\n\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 101 "C:\Users\rossh\source\repos\FYP\FYP\Views\Home\CompareCountries.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
