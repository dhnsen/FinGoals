#pragma checksum "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "232af60ea7dd5ade6b6a00023071eae2d003ddbd"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"232af60ea7dd5ade6b6a00023071eae2d003ddbd", @"/Views/Goals/Index.cshtml")]
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
            BeginContext(70, 471, true);
            WriteLiteral(@"

<div class=""form-group"" style=""display: block; text-align: center;"">
    <h4>Savings Amount</h4>
    <p>Enter the amount you've saved and press ""Update""</p>
    <div class=""input-group mb-3"" style=""width: 250px; margin: 0 auto;"">
        <input type=""text"" class=""form-control"" id=""amount-saved"" >
        &nbsp;
        <button class=""btn btn-primary"" id=""update-amount"">Update Amount</button>
    </div>
</div>
<hr>
<div id=""goals-section"">
    <p>
    ");
            EndContext();
            BeginContext(541, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "232af60ea7dd5ade6b6a00023071eae2d003ddbd4739", async() => {
                BeginContext(564, 11, true);
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
            BeginContext(579, 8, true);
            WriteLiteral("\r\n</p>\r\n");
            EndContext();
#line 22 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
      

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
            BeginContext(1618, 136, true);
            WriteLiteral("            <div class=\"goal-container\">\r\n                <div class=\"goal-container-info\">\r\n                    <h5 class=\"goal-title\">");
            EndContext();
            BeginContext(1755, 39, false);
#line 61 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
                                      Write(Html.DisplayFor(modelItem => goal.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1794, 64, true);
            WriteLiteral("</h5>\r\n                    <p class=\"goal-amount-paid\"><strong>$");
            EndContext();
            BeginContext(1859, 11, false);
#line 62 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
                                                    Write(amountSaved);

#line default
#line hidden
            EndContext();
            BeginContext(1870, 5, true);
            WriteLiteral(" of $");
            EndContext();
            BeginContext(1876, 41, false);
#line 62 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
                                                                     Write(Html.DisplayFor(modelItem => goal.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1917, 210, true);
            WriteLiteral("</strong></p>\r\n                </div>\r\n                <br>\r\n                <br>\r\n                <div class=\"goal-container-progress\">\r\n                    <div class=\"progress\">\r\n                        <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2127, "\"", 2157, 2);
            WriteAttributeValue("", 2135, "progress-bar", 2135, 12, true);
#line 68 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
WriteAttributeValue(" ", 2147, barStyle, 2148, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2158, 19, true);
            WriteLiteral(" role=\"progressbar\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 2177, "\"", 2202, 3);
            WriteAttributeValue("", 2185, "width:", 2185, 6, true);
#line 68 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
WriteAttributeValue(" ", 2191, barWidth, 2192, 9, false);

#line default
#line hidden
            WriteAttributeValue("", 2201, "%", 2201, 1, true);
            EndWriteAttribute();
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 2203, "\"", 2228, 1);
#line 68 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
WriteAttributeValue("", 2219, barWidth, 2219, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2229, 174, true);
            WriteLiteral("\r\n                             aria-valuemin=\"0\" aria-valuemax=\"100\"></div>\r\n                    </div>\r\n                </div>\r\n                <div>\r\n\r\n                    ");
            EndContext();
            BeginContext(2403, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "232af60ea7dd5ade6b6a00023071eae2d003ddbd10331", async() => {
                BeginContext(2448, 4, true);
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
#line 74 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
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
            BeginContext(2456, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2480, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "232af60ea7dd5ade6b6a00023071eae2d003ddbd12660", async() => {
                BeginContext(2527, 6, true);
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
#line 75 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
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
            BeginContext(2537, 66, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <br />\r\n");
            EndContext();
#line 79 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2614, 57, true);
            WriteLiteral("        <div id=\"savings-amount\"><h3>\r\n    Total Saved: $");
            EndContext();
            BeginContext(2672, 22, false);
#line 81 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
             Write(Model.UserTotalSavings);

#line default
#line hidden
            EndContext();
            BeginContext(2694, 5, true);
            WriteLiteral(" of $");
            EndContext();
            BeginContext(2700, 20, false);
#line 81 "C:\Users\Dan\Desktop\FinGoals\Views\Goals\Index.cshtml"
                                         Write(totalSavingsRequired);

#line default
#line hidden
            EndContext();
            BeginContext(2720, 15, true);
            WriteLiteral("\r\n</h3></div>\r\n");
            EndContext();
            BeginContext(2742, 280, true);
            WriteLiteral(@"</div>
<hr>
<p>here are the goals generated by api and javascript:</p>
<!-- ------------------------------------------------------------------- -->
<div id=""goal-list""></div>




<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>

");
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
