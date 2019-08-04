#pragma checksum "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef45690ef6a174c6229a68a98407e015eb3e8329"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Goals_Index), @"mvc.1.0.view", @"/Views/Goals/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Goals/Index.cshtml", typeof(AspNetCore.Views_Goals_Index))]
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
#line 1 "C:\Users\Dan\Desktop\FinGoals\Views\_ViewImports.cshtml"
using FinGoals;

#line default
#line hidden
#line 2 "C:\Users\Dan\Desktop\FinGoals\Views\_ViewImports.cshtml"
using FinGoals.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef45690ef6a174c6229a68a98407e015eb3e8329", @"/Views/Goals/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e66666effa2132601026bb7f7f634e527140f8bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Goals_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GoalIndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(70, 11, true);
            WriteLiteral("\r\n<p>\r\n    ");
            EndContext();
            BeginContext(81, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef45690ef6a174c6229a68a98407e015eb3e83294258", async() => {
                BeginContext(104, 11, true);
                WriteLiteral("Add a Goal!");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(119, 197, true);
            WriteLiteral("\r\n</p>\r\n<h4>Amount Saved:</h4>\r\n<button id=\"update-amount\">Update Amount</button>\r\n<button id=\"get-amount\">Get Amount</button>\r\n<br><br>\r\n<div id=\"amount-saved\"></div>\r\n\r\n<div id=\"goals-section\">\r\n");
            EndContext();
#line 17 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
      

        var savingsToDistribute = Model.UserTotalSavings;

        var totalSavingsRequired = 0.0;

        foreach (var goal in Model.Goals)
        {
            totalSavingsRequired += goal.Amount;
            var amountSaved = 0.0;
            if (goal.Amount < savingsToDistribute)
            {
                amountSaved = goal.Amount;
                savingsToDistribute -= amountSaved;
            }
            else
            {
                amountSaved = savingsToDistribute;
                savingsToDistribute = 0;
            }
            var percentSaved = amountSaved / goal.Amount;
            var barWidth = percentSaved * 100;
            if (barWidth == 0)
            {
                barWidth = 1;
            }
            string barStyle = "bg-danger";

            if (barWidth > 24)
            {
                barStyle = "bg-warning";
            }
            if (barWidth > 74)
            {
                barStyle = "bg-success";
            }


#line default
#line hidden
            BeginContext(1347, 136, true);
            WriteLiteral("            <div class=\"goal-container\">\r\n                <div class=\"goal-container-info\">\r\n                    <h3 class=\"goal-title\">");
            EndContext();
            BeginContext(1484, 39, false);
#line 56 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
                                      Write(Html.DisplayFor(modelItem => goal.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1523, 64, true);
            WriteLiteral("</h3>\r\n                    <p class=\"goal-amount-paid\"><strong>$");
            EndContext();
            BeginContext(1588, 11, false);
#line 57 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
                                                    Write(amountSaved);

#line default
#line hidden
            EndContext();
            BeginContext(1599, 5, true);
            WriteLiteral(" of $");
            EndContext();
            BeginContext(1605, 41, false);
#line 57 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
                                                                     Write(Html.DisplayFor(modelItem => goal.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1646, 210, true);
            WriteLiteral("</strong></p>\r\n                </div>\r\n                <br>\r\n                <br>\r\n                <div class=\"goal-container-progress\">\r\n                    <div class=\"progress\">\r\n                        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1856, "\"", 1886, 2);
            WriteAttributeValue("", 1864, "progress-bar", 1864, 12, true);
#line 63 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
WriteAttributeValue(" ", 1876, barStyle, 1877, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1887, 19, true);
            WriteLiteral(" role=\"progressbar\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 1906, "\"", 1931, 3);
            WriteAttributeValue("", 1914, "width:", 1914, 6, true);
#line 63 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
WriteAttributeValue(" ", 1920, barWidth, 1921, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 1930, "%", 1930, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1932, "\"", 1957, 1);
#line 63 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
WriteAttributeValue("", 1948, barWidth, 1948, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1958, 174, true);
            WriteLiteral("\r\n                             aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                    </div>\r\n                </div>\r\n                <div>\r\n\r\n                    ");
            EndContext();
            BeginContext(2132, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef45690ef6a174c6229a68a98407e015eb3e832910063", async() => {
                BeginContext(2177, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
                                           WriteLiteral(goal.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2185, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2209, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef45690ef6a174c6229a68a98407e015eb3e832912392", async() => {
                BeginContext(2256, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
                                             WriteLiteral(goal.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2266, 66, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <br />\r\n");
            EndContext();
#line 74 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2343, 57, true);
            WriteLiteral("        <div id=\"savings-amount\"><h3>\r\n    Total Saved: $");
            EndContext();
            BeginContext(2401, 22, false);
#line 76 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
             Write(Model.UserTotalSavings);

#line default
#line hidden
            EndContext();
            BeginContext(2423, 5, true);
            WriteLiteral(" of $");
            EndContext();
            BeginContext(2429, 20, false);
#line 76 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
                                         Write(totalSavingsRequired);

#line default
#line hidden
            EndContext();
            BeginContext(2449, 15, true);
            WriteLiteral("\r\n</h3></div>\r\n");
            EndContext();
            BeginContext(2471, 100, true);
            WriteLiteral("</div>\r\n<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js\"></script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GoalIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
