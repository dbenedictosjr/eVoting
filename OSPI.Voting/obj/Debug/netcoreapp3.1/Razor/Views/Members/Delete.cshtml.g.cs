#pragma checksum "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49f4b1a5aa263e23053f062097ff6ac76c5465b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Members_Delete), @"mvc.1.0.view", @"/Views/Members/Delete.cshtml")]
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
#line 1 "G:\2020\Diego Project\V22\OSPI.Voting\Views\_ViewImports.cshtml"
using OSPI.Voting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\2020\Diego Project\V22\OSPI.Voting\Views\_ViewImports.cshtml"
using OSPI.Voting.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49f4b1a5aa263e23053f062097ff6ac76c5465b1", @"/Views/Members/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247b62a2bdc651d01e4f58f63b873ced4f59b401", @"/Views/_ViewImports.cshtml")]
    public class Views_Members_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OSPI.Infrastructure.Models.MemberModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
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
                    <div class=""col-sm-4""> <h4> Are you sure you want to delete this?</h4></div>
                    <div class=""col-sm-4""></div>
                    <div class=""col-sm-2"">

                    </div>
                    <div class=""col-sm-2"">
                        <div class=""row"">

                            <i class=""fa fa-arrow-circle-left""></i>  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49f4b1a5aa263e23053f062097ff6ac76c5465b15229", async() => {
                WriteLiteral("Back to  Members List");
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
#line 34 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.MemberNo));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 36 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.MemberNo));

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
#line 48 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 50 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-6\">\r\n                        <div class=\"form-group\">\r\n                            <b>\r\n                                ");
#nullable restore
#line 57 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.MiddleName));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 59 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.MiddleName));

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
#line 69 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 71 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-6\">\r\n                        <div class=\"form-group\">\r\n                            <b>\r\n                                ");
#nullable restore
#line 78 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 80 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.BirthDate));

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
#line 90 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.HomeAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 92 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.HomeAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"col-lg-6\">\r\n                        <div class=\"form-group\">\r\n                            <b>\r\n                                ");
#nullable restore
#line 100 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.EmailAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 102 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.EmailAddress));

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
#line 112 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.PhoneNo));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 114 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.PhoneNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n\r\n                    <div class=\"col-lg-6\">\r\n                        <div class=\"form-group\">\r\n                            <b>\r\n                                ");
#nullable restore
#line 122 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.AccountNo));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 124 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.AccountNo));

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
#line 134 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.CreditStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 136 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.CreditStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-6\">\r\n                        <div class=\"form-group\">\r\n                            <b>\r\n                                ");
#nullable restore
#line 143 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.MemberStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 145 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.MemberStatus));

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
#line 155 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.RegistrationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 157 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.RegistrationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-6\">\r\n                        <div class=\"form-group\">\r\n                            <b>\r\n                                ");
#nullable restore
#line 163 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.DateHired));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 165 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.DateHired));

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
#line 175 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 177 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-6\">\r\n                        <div class=\"form-group\">\r\n                            <b>\r\n                                ");
#nullable restore
#line 184 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.Capital));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 186 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Capital));

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
#line 196 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                           Write(Html.DisplayNameFor(model => model.RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral(":\r\n                            </b>\r\n                            ");
#nullable restore
#line 198 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.RoleName));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </div>
                    </div>
                    <div class=""col-lg-6"">
                        <div class=""form-group"">

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49f4b1a5aa263e23053f062097ff6ac76c5465b120749", async() => {
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "49f4b1a5aa263e23053f062097ff6ac76c5465b121040", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 218 "G:\2020\Diego Project\V22\OSPI.Voting\Views\Members\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.MemberId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger pull-right\" />\r\n\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OSPI.Infrastructure.Models.MemberModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
