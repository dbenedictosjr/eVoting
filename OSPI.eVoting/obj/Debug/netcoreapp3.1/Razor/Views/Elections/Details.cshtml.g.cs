#pragma checksum "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5d69f732a9d13e7600b310fc99b3d3720605b717"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Elections_Details), @"mvc.1.0.view", @"/Views/Elections/Details.cshtml")]
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
#line 1 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\_ViewImports.cshtml"
using OSPI.eVoting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\_ViewImports.cshtml"
using OSPI.eVoting.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d69f732a9d13e7600b310fc99b3d3720605b717", @"/Views/Elections/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98263acb9f6d1cf9169e6a9e03e12ce6125381df", @"/Views/_ViewImports.cshtml")]
    public class Views_Elections_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OSPI.Infrastructure.Models.ElectionModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout_User_loggedIn.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<br />
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <div class=""row"">
                    <div class=""col-sm-4""> <h4>  eBallot Details</h4></div>
                    <div class=""col-sm-4""></div>
                    <div class=""col-sm-2"">

                    </div>
                    <div class=""col-sm-2"">
                        <div class=""row"">

                            <i class=""fa fa-arrow-circle-left""></i>  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d69f732a9d13e7600b310fc99b3d3720605b7174912", async() => {
                WriteLiteral("Back to  eBallots List");
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
            WriteLiteral(@"
                        </div>
                    </div>
                </div>

            </div>
            <div class=""panel-body"">


                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div class=""form-group"">
                            <b>
                                ");
#nullable restore
#line 34 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.RefCode));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 36 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                       Write(Html.DisplayFor(model => model.RefCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-6\">\r\n                        <div class=\"form-group\">\r\n                            <b>\r\n                                ");
#nullable restore
#line 43 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 45 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div class=""form-group"">
                            <b>
                                ");
#nullable restore
#line 53 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.RegStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 55 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                       Write(Html.DisplayFor(model => model.RegStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-6\">\r\n                        <div class=\"form-group\">\r\n                            <b>\r\n                                ");
#nullable restore
#line 62 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.RegEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 64 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                       Write(Html.DisplayFor(model => model.RegEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div class=""form-group"">
                            <b>
                                ");
#nullable restore
#line 73 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.VotingStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 75 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                       Write(Html.DisplayFor(model => model.VotingStartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-6\">\r\n                        <div class=\"form-group\">\r\n                            <b>\r\n                                ");
#nullable restore
#line 82 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.VotingEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 84 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                       Write(Html.DisplayFor(model => model.VotingEndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div class=""form-group"">
                            
                        </div>
                    </div>
                    <div class=""col-lg-6"">
                        <div class=""form-group"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5d69f732a9d13e7600b310fc99b3d3720605b71711793", async() => {
                WriteLiteral("<i class=\"fa fa-edit\" aria-hidden=\"true\"></i> Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 97 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                                                                                      WriteLiteral(Model.ElectionID);

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
            WriteLiteral(@"

                        </div>
                    </div>
                </div>

               
            </div>
        </div>
    </div>
</div>
<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <div class=""row"">
                    <div class=""col-sm-4""> <h4> Positions Detail List</h4></div>
                   
                </div>

            </div>
            <div class=""panel-body"">
                <div class=""dataTable_wrapper table-responsive"">
                    <table id=""tbl_Positions"" class=""table table-striped table-bordered table-hover  display nowrap"">
                        <thead>
                            <tr>
                                <th>
                                    ");
#nullable restore
#line 124 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                               Write(Html.DisplayNameFor(Modelitem => Model.Positions.First().PositionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 127 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                               Write(Html.DisplayNameFor(Modelitem => Model.Positions.First().RequiredCandidates));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 130 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                               Write(Html.DisplayNameFor(Modelitem => Model.Positions.First().Qualifications));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 135 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                             foreach (var item in Model.Positions)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"odd gradeX\">\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 139 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.PositionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 142 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.RequiredCandidates));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 145 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Qualifications));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 148 "G:\2020\25-02-2020 New Project\OSPI.eVoting\Views\Elections\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n            <!-- /.panel-body -->\r\n        </div>\r\n        <!-- /.panel -->\r\n    </div>\r\n    <!-- /.col-lg-12 -->\r\n</div>\r\n ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OSPI.Infrastructure.Models.ElectionModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
