#pragma checksum "D:\GitHub\IL\IL.SolutionBuilder.Web.MvcCore\Views\Solution\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fadd9e1b72322db46a7dd3063573cd356af11ee0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Solution_Index), @"mvc.1.0.view", @"/Views/Solution/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Solution/Index.cshtml", typeof(AspNetCore.Views_Solution_Index))]
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
#line 1 "D:\GitHub\IL\IL.SolutionBuilder.Web.MvcCore\Views\_ViewImports.cshtml"
using IL.SolutionBuilder.Web.MvcCore;

#line default
#line hidden
#line 2 "D:\GitHub\IL\IL.SolutionBuilder.Web.MvcCore\Views\_ViewImports.cshtml"
using IL.SolutionBuilder.Web.MvcCore.Models;

#line default
#line hidden
#line 1 "D:\GitHub\IL\IL.SolutionBuilder.Web.MvcCore\Views\Solution\Index.cshtml"
using Microsoft.CodeAnalysis;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fadd9e1b72322db46a7dd3063573cd356af11ee0", @"/Views/Solution/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1dac1df3626717285c07a4050f05ed5cdfef448", @"/Views/_ViewImports.cshtml")]
    public class Views_Solution_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IL.SolutionBuilder.Web.MvcCore.Models.Solution.ListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Solution", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("aria-pressed", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\GitHub\IL\IL.SolutionBuilder.Web.MvcCore\Views\Solution\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/Welcome/_Layout.cshtml";

#line default
#line hidden
            BeginContext(196, 262, true);
            WriteLiteral(@"<div class=""container-fluid bg-dark mb-3 p-2"">
    <div class=""row flex-row text-right"">
        <div class=""col-xl-4 col-sm-4"">
            <ol class=""breadcrumb bg-dark text-white m-0 p-2"">
                <li class=""breadcrumb-item"">
                    ");
            EndContext();
            BeginContext(458, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fadd9e1b72322db46a7dd3063573cd356af11ee06187", async() => {
                BeginContext(524, 9, true);
                WriteLiteral("Solutions");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(537, 178, true);
            WriteLiteral("\r\n                </li>\r\n                <li class=\"breadcrumb-item active\">Details</li>\r\n            </ol>\r\n        </div>\r\n        <div class=\"col-xl-8 col-sm-8\">\r\n            ");
            EndContext();
            BeginContext(715, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fadd9e1b72322db46a7dd3063573cd356af11ee08041", async() => {
                BeginContext(819, 6, true);
                WriteLiteral("Create");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(829, 101, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"container-fluid\">\r\n    <div class=\"row flex-row\">\r\n");
            EndContext();
#line 24 "D:\GitHub\IL\IL.SolutionBuilder.Web.MvcCore\Views\Solution\Index.cshtml"
         foreach (var solution in Model.Solutions)
        {

#line default
#line hidden
            BeginContext(993, 356, true);
            WriteLiteral(@"            <div class=""col-xl-3 col-sm-6 mb-3"">
                <div class=""card text-white bg-info o-hidden h-100"">
                    <div class=""card-body"">
                        <div class=""card-body-icon"">
                            <i class=""fas fa-fw fa-code""></i>
                        </div>
                        <div class=""mr-5"">");
            EndContext();
            BeginContext(1351, 49, false);
#line 32 "D:\GitHub\IL\IL.SolutionBuilder.Web.MvcCore\Views\Solution\Index.cshtml"
                                      Write(solution.CompanyName + "." + solution.ProjectName);

#line default
#line hidden
            EndContext();
            BeginContext(1401, 58, true);
            WriteLiteral("</div>\r\n                    </div>\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1459, "\"", 1532, 1);
#line 34 "D:\GitHub\IL\IL.SolutionBuilder.Web.MvcCore\Views\Solution\Index.cshtml"
WriteAttributeValue("", 1466, Url.Action("Details","Solution", new { solutionId = solution.Id}), 1466, 66, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1533, 342, true);
            WriteLiteral(@" class=""card-footer text-white clearfix small z-1"">
                        <span class=""float-left"">View Details</span>
                        <span class=""float-right"">
                            <i class=""fas fa-angle-right""></i>
                        </span>
                    </a>
                </div>
            </div>
");
            EndContext();
#line 42 "D:\GitHub\IL\IL.SolutionBuilder.Web.MvcCore\Views\Solution\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1886, 20, true);
            WriteLiteral("    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IL.SolutionBuilder.Web.MvcCore.Models.Solution.ListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
