#pragma checksum "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Message\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb7ade235e6c3421ee152197f099a2a6799091cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_LawyerAdminPanel_Views_Message_Index), @"mvc.1.0.view", @"/Areas/LawyerAdminPanel/Views/Message/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/LawyerAdminPanel/Views/Message/Index.cshtml", typeof(AspNetCore.Areas_LawyerAdminPanel_Views_Message_Index))]
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
#line 1 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\_ViewImports.cshtml"
using LawyerApp.Areas.LawyerAdminPanel.Models;

#line default
#line hidden
#line 2 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\_ViewImports.cshtml"
using LawyerApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb7ade235e6c3421ee152197f099a2a6799091cc", @"/Areas/LawyerAdminPanel/Views/Message/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c84317fcae242e14145f84bcbfce4e5dcd9250d9", @"/Areas/LawyerAdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_LawyerAdminPanel_Views_Message_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MessageDto>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DataTableStylesPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "team", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "message", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Read Message"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DataTableScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("styles", async() => {
                BeginContext(50, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(56, 42, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2e3eac042b34454ba49652496f369d87", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(98, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            BeginContext(103, 167, true);
            WriteLiteral("<header class=\"page-header\">\r\n    <h2>Messages</h2>\r\n\r\n    <div class=\"right-wrapper text-right\">\r\n        <ol class=\"breadcrumbs\">\r\n            <li>\r\n                ");
            EndContext();
            BeginContext(270, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd73106fcee341a8a99db1d05853ee74", async() => {
                BeginContext(314, 66, true);
                WriteLiteral("\r\n                    <i class=\"fa fa-home\"></i>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(384, 835, true);
            WriteLiteral(@"
            </li>
            <li><span>Message</span></li>
            <li><span>Index</span></li>
        </ol>

        <a class=""sidebar-right-toggle"" data-open=""sidebar-right""><i class=""fa fa-chevron-left""></i></a>
    </div>
</header>
<div class=""row"">
    <div class=""col"">
        <section class=""card"">
            <header class=""card-header"">
                <div class=""card-actions"">
                    <a href=""#"" class=""card-action card-action-toggle"" data-card-toggle></a>
                </div>

                <h2 class=""card-title"">Messages</h2>
            </header>
            <div class=""card-body"">
                <table class=""table table-bordered table-striped mb-0"" id=""datatable-tabletools"">
                    <thead>
                        <tr>
                            <th>");
            EndContext();
            BeginContext(1220, 40, false);
#line 37 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Message\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1260, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1300, 41, false);
#line 38 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Message\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1341, 39, true);
            WriteLiteral("</th>\r\n                            <th>");
            EndContext();
            BeginContext(1381, 42, false);
#line 39 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Message\Index.cshtml"
                           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1423, 138, true);
            WriteLiteral("</th>\r\n\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 45 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Message\Index.cshtml"
                         foreach (MessageDto item in Model)
                        {

#line default
#line hidden
            BeginContext(1649, 91, true);
            WriteLiteral("                            <tr>\r\n                                <td class=\"teamMembertd\">");
            EndContext();
            BeginContext(1741, 9, false);
#line 48 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Message\Index.cshtml"
                                                    Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1750, 64, true);
            WriteLiteral("</td>\r\n                                <td class=\"teamMembertd\">");
            EndContext();
            BeginContext(1815, 10, false);
#line 49 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Message\Index.cshtml"
                                                    Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1825, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 50 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Message\Index.cshtml"
                                 if (item.Status)
                                {

#line default
#line hidden
            BeginContext(1918, 120, true);
            WriteLiteral("                                    <td class=\"teamMembertd text-success h4\"><i class=\"fa fa-check-square-o\"></i></td>\r\n");
            EndContext();
#line 53 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Message\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
            BeginContext(2146, 116, true);
            WriteLiteral("                                    <td class=\"teamMembertd text-danger h4\"><i class=\"fa fa-hourglass-2\"></i></td>\r\n");
            EndContext();
#line 57 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Message\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(2297, 95, true);
            WriteLiteral("                                <td class=\"teamMembertd\">\r\n                                    ");
            EndContext();
            BeginContext(2392, 164, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac243f93e8a641df9bc515c90b22c491", async() => {
                BeginContext(2518, 34, true);
                WriteLiteral("<i class=\"fa fa-mail-forward\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Message\Index.cshtml"
                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(2556, 106, true);
            WriteLiteral("\r\n                                    <a href=\"#modalPrimary\" class=\"modal-basic btn btn-danger\" data-id=\"");
            EndContext();
            BeginContext(2663, 7, false);
#line 60 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Message\Index.cshtml"
                                                                                                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(2670, 126, true);
            WriteLiteral("\" title=\"Delete\"><i class=\"fa fa-trash-o\"></i></a>\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 63 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Message\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2823, 1551, true);
            WriteLiteral(@"                    </tbody>
                </table>
                <div id=""modalPrimary"" class=""modal-block  modal-block-primary mfp-hide"">
                    <section class=""card"">
                        <header class=""card-header"">
                            <h2 class=""card-title"">Are you sure?</h2>
                        </header>
                        <div class=""card-body"">
                            <div class=""modal-wrapper"">
                                <div class=""modal-icon"">
                                    <i class=""fa fa-question-circle""></i>
                                </div>
                                <div class=""modal-text"">
                                    <h4>Delete</h4>
                                    <p>Are you sure that you want to delete this message from list?</p>
                                </div>
                            </div>
                        </div>
                        <footer class=""card-footer"">
                ");
            WriteLiteral(@"            <div class=""row"">
                                <div class=""col-md-12 text-right"">
                                    <button class=""btn btn-primary modal-confirm"">Confirm</button>
                                    <button class=""btn btn-default modal-dismiss"">Cancel</button>
                                </div>
                            </div>
                        </footer>
                    </section>
                </div>
            </div>
        </section>
    </div>
</div>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(4391, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(4397, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b4bb1267a8b24c69b3bb0ac1f2209208", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4440, 320, true);
                WriteLiteral(@"
    <script>
        var Id;
        var HttpStatusCodes={
            Ok: 200,
            NotFound:404
        }

        $("".modal-basic"").click(function () {
            Id= $(this).attr(""data-id"")

        })
        $("".modal-confirm"").click(function () {
            $.ajax({
                url: """);
                EndContext();
                BeginContext(4761, 30, false);
#line 112 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Message\Index.cshtml"
                 Write(Url.Action("delete","message"));

#line default
#line hidden
                EndContext();
                BeginContext(4791, 641, true);
                WriteLiteral(@""",
                type: ""POST"",
                dataType: ""JSON"",
                data: {
                    id: Id
                },
                success: function (response) {
                    if (response.status == HttpStatusCodes.Ok) {
                        location.reload();
                    }
                    else {
                        alert(""Some ploblem occured. Please try again. "")
                    }
                },
                error: function () {
                    alert(""Some ploblem occured. Please try again. "")
                }
            })
        })
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MessageDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
