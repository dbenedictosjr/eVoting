#pragma checksum "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Candidates.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8089016ddd65da7177fa6a395f0166a492f7c218"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Candidates_Candidates), @"mvc.1.0.view", @"/Views/Candidates/Candidates.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8089016ddd65da7177fa6a395f0166a492f7c218", @"/Views/Candidates/Candidates.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247b62a2bdc651d01e4f58f63b873ced4f59b401", @"/Views/_ViewImports.cshtml")]
    public class Views_Candidates_Candidates : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OSPI.Infrastructure.Models.CandidateModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Candidates.cshtml"
  
    ViewData["Title"] = "Index";
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
                    <div class=""col-sm-4""> <h4>Candidate Dashboard</h4></div>
                    <div class=""col-sm-6""></div>

                    <div class=""col-sm-2"">
                    </div>
                </div>

            </div>
            <div class=""panel-body"">
                <div class=""dataTable_wrapper table-responsive"">
                    <table id=""tbl_Candidate"" class=""table table-striped table-bordered table-hover  display nowrap"">
                        <thead>
                            <tr>
                                <th>
                                    ");
#nullable restore
#line 29 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Candidates.cshtml"
                               Write(Html.DisplayNameFor(model => model.PositionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 32 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Candidates.cshtml"
                               Write(Html.DisplayNameFor(model => model.CandidateFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 35 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Candidates.cshtml"
                               Write(Html.DisplayNameFor(model => model.NomineeFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 38 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Candidates.cshtml"
                               Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n");
#nullable restore
#line 43 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Candidates.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 47 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Candidates.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.PositionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 50 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Candidates.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.CandidateFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 53 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Candidates.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.NomineeFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
#nullable restore
#line 56 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Candidates.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
#nullable restore
#line 59 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Candidates\Candidates.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n            <!-- /.panel-body -->\r\n        </div>\r\n        <!-- /.panel -->\r\n    </div>\r\n    <!-- /.col-lg-12 -->\r\n</div>");
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
