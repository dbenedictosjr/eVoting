#pragma checksum "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0680819f1e1271c88134d5b3f9fecec4d86036b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Details), @"mvc.1.0.view", @"/Views/Roles/Details.cshtml")]
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
#line 1 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\_ViewImports.cshtml"
using OSPI.eVoting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\_ViewImports.cshtml"
using OSPI.eVoting.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0680819f1e1271c88134d5b3f9fecec4d86036b", @"/Views/Roles/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98263acb9f6d1cf9169e6a9e03e12ce6125381df", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OSPI.Infrastructure.Models.RoleModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout_User_loggedIn.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n");
#nullable restore
#line 10 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
 if (!String.IsNullOrEmpty(ViewBag.Message))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 style=\"color:rebeccapurple\">");
#nullable restore
#line 12 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
                               Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 13 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h4>RoleEntity</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
       Write(Html.DisplayFor(model => model.RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0680819f1e1271c88134d5b3f9fecec4d86036b5991", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
                           WriteLiteral(Model.RoleId);

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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0680819f1e1271c88134d5b3f9fecec4d86036b8122", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <div class=""row"">
                    <div class=""col-sm-4""> <h4>Claims</h4></div>
                    <div class=""col-sm-8""></div>
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
#line 54 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
                               Write(Html.DisplayNameFor(Modelitem => Model.RoleAccesses.First().ModuleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 57 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
                               Write(Html.DisplayNameFor(Modelitem => Model.RoleAccesses.First().CanAdd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 60 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
                               Write(Html.DisplayNameFor(Modelitem => Model.RoleAccesses.First().CanEdit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 63 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
                               Write(Html.DisplayNameFor(Modelitem => Model.RoleAccesses.First().CanView));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 66 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
                               Write(Html.DisplayNameFor(Modelitem => Model.RoleAccesses.First().CanPrint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 69 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
                               Write(Html.DisplayNameFor(Modelitem => Model.RoleAccesses.First().CanDelete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 74 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
                             foreach (var item in Model.RoleAccesses)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"odd gradeX\">\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 78 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.ModuleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 81 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CanAdd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 84 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CanEdit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 87 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CanView));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 90 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CanPrint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 93 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CanDelete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 96 "G:\2020\Diego Project\V7\OSPI.eVoting\Views\Roles\Details.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n            <!-- /.panel-body -->\r\n        </div>\r\n        <!-- /.panel -->\r\n    </div>\r\n    <!-- /.col-lg-12 -->\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OSPI.Infrastructure.Models.RoleModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
