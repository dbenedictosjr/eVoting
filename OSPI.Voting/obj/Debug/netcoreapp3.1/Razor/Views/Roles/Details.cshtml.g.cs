#pragma checksum "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36696e10e461e1e0ce562ce72007edf56f506efe"
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
#line 1 "G:\2020\Diego Project\V15\OSPI.Voting\Views\_ViewImports.cshtml"
using OSPI.Voting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\2020\Diego Project\V15\OSPI.Voting\Views\_ViewImports.cshtml"
using OSPI.Voting.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36696e10e461e1e0ce562ce72007edf56f506efe", @"/Views/Roles/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247b62a2bdc651d01e4f58f63b873ced4f59b401", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OSPI.Infrastructure.Models.RoleModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger pull-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout_User_loggedIn.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 8 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
 if (!String.IsNullOrEmpty(ViewBag.Message))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 style=\"color:rebeccapurple\">");
#nullable restore
#line 10 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
                               Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 11 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <div class=""row"">
                    <div class=""col-sm-4""> <h4> Role Details</h4></div>
                    <div class=""col-sm-4""></div>
                    <div class=""col-sm-2"">

                    </div>
                    <div class=""col-sm-2"">
                        <div class=""row"">

                            <i class=""fa fa-arrow-circle-left""></i>  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36696e10e461e1e0ce562ce72007edf56f506efe6207", async() => {
                WriteLiteral("Back to  Roles List");
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
#line 39 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 41 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
                       Write(Html.DisplayFor(model => model.RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                    </div>
                    <div class=""col-lg-6"">
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div class=""form-group"">
                            <b>
                                ");
#nullable restore
#line 52 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 54 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                    </div>
                    <div class=""col-lg-6"">
                    </div>
                </div>



                <div class=""row"">
                    <div class=""col-lg-6"">
                        <div class=""form-group"">

                        </div>
                    </div>
                    <div class=""col-lg-6"">
                        <div class=""form-group"">
                            <div class=""col-lg-8""></div>
                            <div class=""col-lg-2"">
");
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36696e10e461e1e0ce562ce72007edf56f506efe9890", async() => {
                WriteLiteral("<i class=\"fa fa-trash\" aria-hidden=\"true\"></i> Delete");
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
#line 75 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
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
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"col-lg-2\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36696e10e461e1e0ce562ce72007edf56f506efe12341", async() => {
                WriteLiteral("<i class=\"fa fa-edit\" aria-hidden=\"true\"></i> Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
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
            WriteLiteral(@"

                            </div>
                        </div>
                    </div>
                </div>

                <br />

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
                             ");
            WriteLiteral("                   <th>\r\n                                                    ");
#nullable restore
#line 103 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
                                               Write(Html.DisplayNameFor(Modelitem => Model.RoleAccesses.First().ModuleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 106 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
                                               Write(Html.DisplayNameFor(Modelitem => Model.RoleAccesses.First().CanAdd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 109 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
                                               Write(Html.DisplayNameFor(Modelitem => Model.RoleAccesses.First().CanEdit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 112 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
                                               Write(Html.DisplayNameFor(Modelitem => Model.RoleAccesses.First().CanView));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 115 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
                                               Write(Html.DisplayNameFor(Modelitem => Model.RoleAccesses.First().CanPrint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                                <th>\r\n                                                    ");
#nullable restore
#line 118 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
                                               Write(Html.DisplayNameFor(Modelitem => Model.RoleAccesses.First().CanDelete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </th>\r\n                                            </tr>\r\n                                        </thead>\r\n                                        <tbody>\r\n");
#nullable restore
#line 123 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
                                             foreach (var item in Model.RoleAccesses)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr class=\"odd gradeX\">\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 127 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.ModuleName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 130 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.CanAdd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 133 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.CanEdit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 136 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.CanView));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 139 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.CanPrint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                    <td>\r\n                                                        ");
#nullable restore
#line 142 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
                                                   Write(Html.DisplayFor(modelItem => item.CanDelete));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                    </td>\r\n                                                </tr>\r\n");
#nullable restore
#line 145 "G:\2020\Diego Project\V15\OSPI.Voting\Views\Roles\Details.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        </tbody>
                                    </table>
                                </div>
                            </div>
                            <!-- /.panel-body -->
                        </div>
                        <!-- /.panel -->
                    </div>
                    <!-- /.col-lg-12 -->
                </div>


            </div>
        </div>
    </div>
</div>

<script>
    function confirmDelete(url) {
        var res = confirm(""Do you really want to delete this Role?"");
        if (res == true) {
            window.location.href = url;
        }
    }
</script>
");
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
