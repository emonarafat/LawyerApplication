#pragma checksum "C:\Users\Shamil\Desktop\LawyerAppLast\LawyerApp\Views\Home\Practice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81d5add98f6dfd73428ac571ad55933590e39bf2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Practice), @"mvc.1.0.view", @"/Views/Home/Practice.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Practice.cshtml", typeof(AspNetCore.Views_Home_Practice))]
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
#line 1 "C:\Users\Shamil\Desktop\LawyerAppLast\LawyerApp\Views\_ViewImports.cshtml"
using LawyerApp.Models;

#line default
#line hidden
#line 2 "C:\Users\Shamil\Desktop\LawyerAppLast\LawyerApp\Views\_ViewImports.cshtml"
using LawyerApp;

#line default
#line hidden
#line 3 "C:\Users\Shamil\Desktop\LawyerAppLast\LawyerApp\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81d5add98f6dfd73428ac571ad55933590e39bf2", @"/Views/Home/Practice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e2e05354d6fe86a2f3c0288f0a5237cf7ad05ed", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Practice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LawyerApp.Areas.LawyerAdminPanel.Models.AreaDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "services", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(121, 40, true);
            WriteLiteral("\r\n<main class=\"practise-main\">\r\n    <h1>");
            EndContext();
            BeginContext(162, 26, false);
#line 5 "C:\Users\Shamil\Desktop\LawyerAppLast\LawyerApp\Views\Home\Practice.cshtml"
   Write(resource["Practice_Areas"]);

#line default
#line hidden
            EndContext();
            BeginContext(188, 22, true);
            WriteLiteral("</h1>\r\n    <p>\r\n      ");
            EndContext();
            BeginContext(211, 21, false);
#line 7 "C:\Users\Shamil\Desktop\LawyerAppLast\LawyerApp\Views\Home\Practice.cshtml"
 Write(resource["Areatitle"]);

#line default
#line hidden
            EndContext();
            BeginContext(232, 53, true);
            WriteLiteral("\r\n    </p>\r\n    <div class=\"practise-main-content\">\r\n");
            EndContext();
#line 10 "C:\Users\Shamil\Desktop\LawyerAppLast\LawyerApp\Views\Home\Practice.cshtml"
        foreach (var item in Model)
       {

#line default
#line hidden
            BeginContext(332, 72, true);
            WriteLiteral("        <section class=\" main-team\">\r\n            <hr>\r\n            <h2>");
            EndContext();
            BeginContext(405, 9, false);
#line 14 "C:\Users\Shamil\Desktop\LawyerAppLast\LawyerApp\Views\Home\Practice.cshtml"
           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(414, 40, true);
            WriteLiteral("</h2>\r\n            <p>\r\n                ");
            EndContext();
            BeginContext(455, 16, false);
#line 16 "C:\Users\Shamil\Desktop\LawyerAppLast\LawyerApp\Views\Home\Practice.cshtml"
           Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(471, 40, true);
            WriteLiteral("\r\n            </p>\r\n        </section>\r\n");
            EndContext();
#line 19 "C:\Users\Shamil\Desktop\LawyerAppLast\LawyerApp\Views\Home\Practice.cshtml"
       }

#line default
#line hidden
            BeginContext(521, 75, true);
            WriteLiteral("    </div>\r\n    <section style=\"text-align:right;padding:1% 0%;\">\r\n        ");
            EndContext();
            BeginContext(596, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a889dc6118fe4e89a766118ea2f98276", async() => {
                BeginContext(646, 33, false);
#line 22 "C:\Users\Shamil\Desktop\LawyerAppLast\LawyerApp\Views\Home\Practice.cshtml"
                                                    Write(resource["Schedule_Consultation"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(683, 25, true);
            WriteLiteral("\r\n    </section>\r\n</main>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IStringLocalizer<SharedResource> resource { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LawyerApp.Areas.LawyerAdminPanel.Models.AreaDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591