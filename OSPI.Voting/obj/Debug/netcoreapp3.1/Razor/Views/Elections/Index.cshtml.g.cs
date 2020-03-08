#pragma checksum "G:\2020\Diego Project\V16\OSPI.Voting\Views\Elections\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c525401ad11a4a56c03234152cf69ebfcd81294"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Elections_Index), @"mvc.1.0.view", @"/Views/Elections/Index.cshtml")]
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
#line 1 "G:\2020\Diego Project\V16\OSPI.Voting\Views\_ViewImports.cshtml"
using OSPI.Voting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\2020\Diego Project\V16\OSPI.Voting\Views\_ViewImports.cshtml"
using OSPI.Voting.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c525401ad11a4a56c03234152cf69ebfcd81294", @"/Views/Elections/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247b62a2bdc651d01e4f58f63b873ced4f59b401", @"/Views/_ViewImports.cshtml")]
    public class Views_Elections_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OSPI.Infrastructure.Models.CPositionModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\2020\Diego Project\V16\OSPI.Voting\Views\Elections\Index.cshtml"
      
        ViewData["Title"] = "Index";
        Layout = "~/Views/Shared/_Layout_User_loggedIn.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <br />
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    <div class=""row"">
                        <div class=""col-sm-4""> <h4>Elections Dashboard</h4></div>
                        <div class=""col-sm-6""></div>
                    </div>

                </div>
                <div class=""panel-body"">

");
#nullable restore
#line 21 "G:\2020\Diego Project\V16\OSPI.Voting\Views\Elections\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""section"">
                            <h5><b>INSTRUCTIONS:</b> Select between <label id=""chkCount"" class=""countermin"">0</label>  and <label class=""countermax"">5</label> options from the list below. <label style=""color:red"">* Required</label></h5>

                            <div class=""row"">
                                <div class=""col-lg-6"">
                                    <div class=""form-group"">
                                        <h5><b>");
#nullable restore
#line 29 "G:\2020\Diego Project\V16\OSPI.Voting\Views\Elections\Index.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.PositionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h5>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n\r\n");
#nullable restore
#line 34 "G:\2020\Diego Project\V16\OSPI.Voting\Views\Elections\Index.cshtml"
                             foreach (var emp in item.Candidates)
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                <div class=""row"">
                                    <div class=""col-lg-8"">
                                        <div class=""row"">
                                            <div class=""col-sm-1""><input type=""checkbox""");
            BeginWriteAttribute("class", " class=\"", 1723, "\"", 1760, 2);
            WriteAttributeValue("", 1731, "chk_", 1731, 4, true);
#nullable restore
#line 40 "G:\2020\Diego Project\V16\OSPI.Voting\Views\Elections\Index.cshtml"
WriteAttributeValue("", 1735, item.PositionName.Trim(), 1735, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></div>\r\n\r\n                                            <div class=\"col-sm-2\"> <img");
            BeginWriteAttribute("src", " src=\"", 1843, "\"", 1866, 1);
#nullable restore
#line 42 "G:\2020\Diego Project\V16\OSPI.Voting\Views\Elections\Index.cshtml"
WriteAttributeValue("", 1849, emp.MemberNumber, 1849, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:70px\"></div>\r\n                                            <div class=\"col-sm-6\">");
#nullable restore
#line 43 "G:\2020\Diego Project\V16\OSPI.Voting\Views\Elections\Index.cshtml"
                                                             Write(emp.CandidateName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                                <br />\r\n");
#nullable restore
#line 48 "G:\2020\Diego Project\V16\OSPI.Voting\Views\Elections\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 51 "G:\2020\Diego Project\V16\OSPI.Voting\Views\Elections\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <!-- /.panel-body -->
            </div>
            <!-- /.panel -->
        </div>
        <!-- /.col-lg-12 -->
    </div>

    <script>
        $(function () {
            $('input[type=""checkbox""]').click(function () {

                var className = this.className;
                var tolatCheckbox = $('.' + className + ':checked').length;
                if (tolatCheckbox > 5) {
                    alert('Select only five candidate.');
                    return false;
                } else {

                    $(this).closest("".section"").find('#chkCount').html(tolatCheckbox);
                }
            })
        })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OSPI.Infrastructure.Models.CPositionModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
