#pragma checksum "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fc321010a1cc5fb8a44e9cbd74cdfc164fa8a24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_LawyerAdminPanel_Views_Team_Details), @"mvc.1.0.view", @"/Areas/LawyerAdminPanel/Views/Team/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/LawyerAdminPanel/Views/Team/Details.cshtml", typeof(AspNetCore.Areas_LawyerAdminPanel_Views_Team_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fc321010a1cc5fb8a44e9cbd74cdfc164fa8a24", @"/Areas/LawyerAdminPanel/Views/Team/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c84317fcae242e14145f84bcbfce4e5dcd9250d9", @"/Areas/LawyerAdminPanel/Views/_ViewImports.cshtml")]
    public class Areas_LawyerAdminPanel_Views_Team_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeamMemberDetailModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "team", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Back To List"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Edit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("215"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail lightbox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-plugin-options", new global::Microsoft.AspNetCore.Html.HtmlString("{ \"type\":\"image\" }"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(30, 173, true);
            WriteLiteral("\r\n<header class=\"page-header\">\r\n    <h2>Team Members</h2>\r\n\r\n    <div class=\"right-wrapper text-right\">\r\n        <ol class=\"breadcrumbs\">\r\n            <li>\r\n                ");
            EndContext();
            BeginContext(203, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f5115931b63e4d7b82970e7ad6cb355a", async() => {
                BeginContext(248, 66, true);
                WriteLiteral("\r\n                    <i class=\"fa fa-home\"></i>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(318, 354, true);
            WriteLiteral(@"
            </li>
            <li><span>Team Member</span></li>
            <li><span>Details</span></li>
        </ol>

        <a class=""sidebar-right-toggle"" data-open=""sidebar-right""><i class=""fa fa-chevron-left""></i></a>
    </div>
</header>

<!-- start: page -->

<div class=""row"">
    <div class=""col-lg-4 col-xl-3 mb-4 mb-xl-0"">

");
            EndContext();
#line 26 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
           
            TeamMemberDto teamMember = Model.TeamMemberViews.SingleOrDefault(m => m.LanguageId == (Model.Languages.SingleOrDefault(n => n.LangShort == "en-US").Id));
        

#line default
#line hidden
            BeginContext(863, 136, true);
            WriteLiteral("        <section class=\"card\">\r\n            <div class=\"card-body\">\r\n                <div class=\"thumb-info mb-3\">\r\n                    ");
            EndContext();
            BeginContext(999, 106, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8c397a5720a942aca3eac18322a68a9d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1009, "~/Uploads/", 1009, 10, true);
#line 32 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
AddHtmlAttributeValue("", 1019, teamMember.Img, 1019, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 32 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
AddHtmlAttributeValue("", 1067, teamMember.Name, 1067, 16, false);

#line default
#line hidden
#line 32 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
AddHtmlAttributeValue(" ", 1083, teamMember.Surname, 1084, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1105, 178, true);
            WriteLiteral("\r\n                    <div class=\"thumb-info-title\" style=\"padding:9px 8px 9px\">\r\n                        <span class=\"thumb-info-inner\" style=\"font-size:11px;letter-spacing:0;\">");
            EndContext();
            BeginContext(1284, 15, false);
#line 34 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                                                           Write(teamMember.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1299, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1301, 18, false);
#line 34 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                                                                            Write(teamMember.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(1319, 63, true);
            WriteLiteral("</span>\r\n                        <span class=\"thumb-info-type\">");
            EndContext();
            BeginContext(1383, 10, false);
#line 35 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                 Write(Model.Area);

#line default
#line hidden
            EndContext();
            BeginContext(1393, 1334, true);
            WriteLiteral(@"</span>
                    </div>
                </div>

                <div class=""widget-toggle-expand mb-3"">
                    <div class=""widget-header"">
                        <h5 class=""mb-2"">Member Details</h5>
                        <div class=""widget-toggle"">+</div>
                    </div>
                    <div class=""widget-content-collapsed"">
                        <div class=""progress progress-xs light"">
                            <div class=""progress-bar"" role=""progressbar"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 100%;"">
                            </div>
                        </div>
                    </div>
                    <div class=""widget-content-expanded"">
                        <ul class=""simple-todo-list mt-3"">
                            <li class=""completed"">Member name for current languages</li>
                            <li class=""completed"">Member surname for current languages</li>
                           ");
            WriteLiteral(@" <li class=""completed"">About Member for current languages</li>
                            <li class=""completed"">Member's photo</li>
                        </ul>
                    </div>
                </div>

                <hr class=""dotted short"">


                <div>
                    ");
            EndContext();
            BeginContext(2727, 127, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3c967df481d438ca84652f6484b1324", async() => {
                BeginContext(2818, 32, true);
                WriteLiteral("<i class=\"fa fa-arrow-left\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2854, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2876, 152, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dd9513b007e4039a8db8ccee7c33251", async() => {
                BeginContext(2987, 37, true);
                WriteLiteral("<i class=\"fa fa-pencil-square-o\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                                  WriteLiteral(teamMember.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3028, 1119, true);
            WriteLiteral(@"
                </div>

            </div>
        </section>
    </div>
    <div class=""col-lg-8 col-xl-8"">

        <div class=""tabs"">
            <ul class=""nav nav-tabs tabs-primary"">
                <li class=""nav-item active"">
                    <a class=""nav-link"" href=""#overview"" data-toggle=""tab"">Overview</a>
                </li>
            </ul>
            <div class=""tab-content"">
                <div id=""overview"" class=""tab-pane active"">

                    <div class=""p-3"">

                        <h4 class=""mb-3 pt-4"">Member Details</h4>

                        <div class=""timeline timeline-simple mt-3 mb-3"">
                            <div class=""tm-body"">
                                <div class=""tm-title"">
                                    <h5 class=""m-0 pt-2 pb-2 text-uppercase"">Name</h5>
                                </div>
                                <ol class=""tm-items"">
                                    <li>
                              ");
            WriteLiteral("          <div class=\"tm-box\">\r\n                                            <div class=\"row\">\r\n");
            EndContext();
#line 95 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                 foreach (var item in Model.TeamMemberViews)
                                                {

#line default
#line hidden
            BeginContext(4292, 73, true);
            WriteLiteral("                                                    <div class=\"col-4\">\r\n");
            EndContext();
#line 98 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                          
                                                            Language language = Model.Languages.SingleOrDefault(m => m.Id == item.LanguageId);
                                                        

#line default
#line hidden
            BeginContext(4628, 83, true);
            WriteLiteral("                                                        <p class=\"text-muted mb-0\">");
            EndContext();
            BeginContext(4712, 17, false);
#line 101 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                                              Write(language.LangLong);

#line default
#line hidden
            EndContext();
            BeginContext(4729, 127, true);
            WriteLiteral("</p>\r\n                                                        <p>\r\n                                                            ");
            EndContext();
            BeginContext(4857, 9, false);
#line 103 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4866, 36, true);
            WriteLiteral(" <br /> <span class=\"text-primary\">#");
            EndContext();
            BeginContext(4903, 18, false);
#line 103 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                                                                     Write(language.LangShort);

#line default
#line hidden
            EndContext();
            BeginContext(4921, 131, true);
            WriteLiteral("</span>\r\n                                                        </p>\r\n                                                    </div>\r\n");
            EndContext();
#line 106 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                 }

#line default
#line hidden
            BeginContext(5104, 784, true);
            WriteLiteral(@"                                            </div>
                                        </div>
                                    </li>
                                </ol>
                            </div>
                        </div>
                        <div class=""timeline timeline-simple mt-3 mb-3"">
                            <div class=""tm-body"">
                                <div class=""tm-title"">
                                    <h5 class=""m-0 pt-2 pb-2 text-uppercase"">Surname</h5>
                                </div>
                                <ol class=""tm-items"">
                                    <li>
                                        <div class=""tm-box"">
                                            <div class=""row"">
");
            EndContext();
#line 122 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                 foreach (var item in Model.TeamMemberViews)
                                                {

#line default
#line hidden
            BeginContext(6033, 73, true);
            WriteLiteral("                                                    <div class=\"col-4\">\r\n");
            EndContext();
#line 125 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                          
                                                            Language language = Model.Languages.SingleOrDefault(m => m.Id == item.LanguageId);
                                                        

#line default
#line hidden
            BeginContext(6369, 83, true);
            WriteLiteral("                                                        <p class=\"text-muted mb-0\">");
            EndContext();
            BeginContext(6453, 17, false);
#line 128 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                                              Write(language.LangLong);

#line default
#line hidden
            EndContext();
            BeginContext(6470, 127, true);
            WriteLiteral("</p>\r\n                                                        <p>\r\n                                                            ");
            EndContext();
            BeginContext(6598, 12, false);
#line 130 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                       Write(item.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(6610, 36, true);
            WriteLiteral(" <br /> <span class=\"text-primary\">#");
            EndContext();
            BeginContext(6647, 18, false);
#line 130 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                                                                        Write(language.LangShort);

#line default
#line hidden
            EndContext();
            BeginContext(6665, 131, true);
            WriteLiteral("</span>\r\n                                                        </p>\r\n                                                    </div>\r\n");
            EndContext();
#line 133 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                 }

#line default
#line hidden
            BeginContext(6848, 623, true);
            WriteLiteral(@"                                            </div>
                                        </div>
                                    </li>

                                </ol>
                            </div>
                        </div>
                        <div class=""timeline timeline-simple mt-3 mb-3"">
                            <div class=""tm-body"">
                                <div class=""tm-title"">
                                    <h5 class=""m-0 pt-2 pb-2 text-uppercase"">Description</h5>
                                </div>
                                <ol class=""tm-items"">
");
            EndContext();
#line 147 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                     foreach (var item in Model.TeamMemberViews)
                                    {

#line default
#line hidden
            BeginContext(7592, 112, true);
            WriteLiteral("                                        <li>\r\n                                            <div class=\"tm-box\">\r\n");
            EndContext();
#line 151 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                  
                                                    Language language = Model.Languages.SingleOrDefault(m => m.Id == item.LanguageId);
                                                

#line default
#line hidden
            BeginContext(7943, 75, true);
            WriteLiteral("                                                <p class=\"text-muted mb-0\">");
            EndContext();
            BeginContext(8019, 17, false);
#line 154 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                                      Write(language.LangLong);

#line default
#line hidden
            EndContext();
            BeginContext(8036, 111, true);
            WriteLiteral("</p>\r\n                                                <p>\r\n                                                    ");
            EndContext();
            BeginContext(8148, 16, false);
#line 156 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                               Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(8164, 36, true);
            WriteLiteral(" <br /> <span class=\"text-primary\">#");
            EndContext();
            BeginContext(8201, 18, false);
#line 156 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                                                                    Write(language.LangShort);

#line default
#line hidden
            EndContext();
            BeginContext(8219, 162, true);
            WriteLiteral("</span>\r\n                                                </p>\r\n                                            </div>\r\n                                        </li>\r\n");
            EndContext();
#line 160 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                       }

#line default
#line hidden
            BeginContext(8423, 388, true);
            WriteLiteral(@"                                </ol>
                            </div>
                        </div>
                       <div class=""ml-5"">
                           <ol class=""list-unstyled"">
                               <li>
                                   <div class=""tm-box"">
                                       <p class=""text-muted mb-0"" style=""font-size:17px"">");
            EndContext();
            BeginContext(8812, 15, false);
#line 168 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                                                    Write(teamMember.Name);

#line default
#line hidden
            EndContext();
            BeginContext(8827, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(8829, 18, false);
#line 168 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
                                                                                                     Write(teamMember.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(8847, 283, true);
            WriteLiteral(@"</p>
                                       <p style=""font-size:14px"">
                                           Photo
                                       </p>
                                       <div class=""thumbnail-gallery"">
                                           ");
            EndContext();
            BeginContext(9130, 478, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c00a1193f374caf84a826521c7e0028", async() => {
                BeginContext(9238, 49, true);
                WriteLiteral("\r\n                                               ");
                EndContext();
                BeginContext(9287, 67, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2e9246f88e634fe19d44f944e769d637", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 9327, "~/Uploads/", 9327, 10, true);
#line 174 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
AddHtmlAttributeValue("", 9337, teamMember.Img, 9337, 15, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9354, 250, true);
                WriteLiteral("\r\n                                               <span class=\"zoom\">\r\n                                                   <i class=\"fa fa-search\"></i>\r\n                                               </span>\r\n                                           ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9170, "~/Uploads/", 9170, 10, true);
#line 173 "C:\Users\hp\Desktop\LawyerApp\LawyerApp\Areas\LawyerAdminPanel\Views\Team\Details.cshtml"
AddHtmlAttributeValue("", 9180, teamMember.Img, 9180, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(9608, 327, true);
            WriteLiteral(@"
                                       </div>
                                   </div>
                               </li>
                           </ol>
                       </div>
                    </div>

                </div>
            </div>
        </div>
    </div>
</div>
<!-- end: page -->

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeamMemberDetailModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
