#pragma checksum "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f4793c4d949580da72007b071f6915e93d0be357"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidates_Index), @"mvc.1.0.view", @"/Views/Candidates/Index.cshtml")]
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
#line 1 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\_ViewImports.cshtml"
using OSPI.Voting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\_ViewImports.cshtml"
using OSPI.Voting.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f4793c4d949580da72007b071f6915e93d0be357", @"/Views/Candidates/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247b62a2bdc651d01e4f58f63b873ced4f59b401", @"/Views/_ViewImports.cshtml")]
    public class Views_Candidates_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OSPI.Infrastructure.Models.CandidateModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CloseNomination", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout_User_loggedIn.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n");
#nullable restore
#line 9 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Index.cshtml"
 if (!String.IsNullOrEmpty(ViewBag.Message))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 style=\"color:rebeccapurple\">");
#nullable restore
#line 11 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Index.cshtml"
                               Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 12 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <div class=""row"">
                    <div class=""col-sm-4""> <h4>Nomination Dashboard</h4></div>
                    <div class=""col-sm-4""></div>
                    <div class=""col-sm-2"">
");
#nullable restore
#line 23 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Index.cshtml"
                         if (User.Claims.FirstOrDefault(x => x.Type == "Role").Value.ToUpper() == "82D0B260-E01D-4FB8-A4A6-4A6E0AB9E008" && (String.IsNullOrEmpty(ViewBag.Message) || (!String.IsNullOrEmpty(ViewBag.Message) && ViewBag.Message != "Nomination has ended.")))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4793c4d949580da72007b071f6915e93d0be3576626", async() => {
                WriteLiteral(" Close Nomination");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <div class=\"col-sm-2\">\r\n");
#nullable restore
#line 29 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Index.cshtml"
                         if (String.IsNullOrEmpty(ViewBag.Message) || (!String.IsNullOrEmpty(ViewBag.Message) && ViewBag.Message != "Nomination has ended."))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f4793c4d949580da72007b071f6915e93d0be3578635", async() => {
                WriteLiteral("<i class=\"fa fa-plus\"> </i> Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 32 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </div>
                </div>

            </div>
            <div class=""panel-body"">
                <div class=""dataTable_wrapper table-responsive"">
                    <table id=""tbl_Candidate"" class=""table table-striped table-bordered table-hover  display nowrap"">
                        <thead>
                            <tr>
                                <th class=""text-center"">
                                    <input type=""checkbox"" value=""1"" id=""chkCandidate_all"">
                                </th>
                                <th>
                                    ");
#nullable restore
#line 46 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.PositionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 49 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.CandidateFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 52 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.NomineeFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 55 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Index.cshtml"
                               Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n\r\n");
#nullable restore
#line 61 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Index.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <tr class=""odd gradeX"">
                                    <td class=""text-center"">
                                        <input type=""checkbox"" value=""1"">
                                    </td>

                                    <th>
                                        ");
#nullable restore
#line 69 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Index.cshtml"
                                   Write(Html.ActionLink("" + item.PositionName + "", "Details", "Candidates", new { id = item.CandidateId }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 73 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CandidateFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 76 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.NomineeFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 79 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Index.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                </tr>\r\n");
#nullable restore
#line 82 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n            <!-- /.panel-body -->\r\n        </div>\r\n        <!-- /.panel -->\r\n    </div>\r\n    <!-- /.col-lg-12 -->\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OSPI.Infrastructure.Models.CandidateModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
