#pragma checksum "G:\2020\Diego Project\V25\OSPI.Voting\Views\Members\Voters.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e437d8a4dbe4a12eb2f29ac6c9d6b7a52ad8a6aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Members_Voters), @"mvc.1.0.view", @"/Views/Members/Voters.cshtml")]
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
#line 1 "G:\2020\Diego Project\V25\OSPI.Voting\Views\_ViewImports.cshtml"
using OSPI.Voting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\2020\Diego Project\V25\OSPI.Voting\Views\_ViewImports.cshtml"
using OSPI.Voting.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e437d8a4dbe4a12eb2f29ac6c9d6b7a52ad8a6aa", @"/Views/Members/Voters.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247b62a2bdc651d01e4f58f63b873ced4f59b401", @"/Views/_ViewImports.cshtml")]
    public class Views_Members_Voters : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OSPI.Infrastructure.Models.MemberModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Members\Voters.cshtml"
  
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
                    <div class=""col-sm-4""> <h4>List of Voters</h4></div>
                    <div class=""col-sm-8""></div>
                </div>

            </div>
            <div class=""panel-body"">
                <div class=""dataTable_wrapper table-responsive"">
                    <table id=""tbl_Members"" class=""table table-striped table-bordered table-hover  display nowrap"">
                        <thead>
                            <tr>
                                <th>
                                    ");
#nullable restore
#line 25 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Members\Voters.cshtml"
                               Write(Html.DisplayNameFor(model => model.MemberNo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 28 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Members\Voters.cshtml"
                               Write(Html.DisplayNameFor(model => model.RegistrationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 31 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Members\Voters.cshtml"
                               Write(Html.DisplayNameFor(model => model.MemberFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                                <th>\r\n                                    ");
#nullable restore
#line 34 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Members\Voters.cshtml"
                               Write(Html.DisplayNameFor(model => model.IsVoted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </th>\r\n                            </tr>\r\n                        </thead>\r\n                        <tbody>\r\n\r\n");
#nullable restore
#line 40 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Members\Voters.cshtml"
                             foreach (var item in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr class=\"odd gradeX\">\r\n                                    <th>\r\n                                        <label style=\"cursor:pointer;color:#337ab7\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1827, "\"", 1862, 3);
            WriteAttributeValue("", 1837, "Details(\'", 1837, 9, true);
#nullable restore
#line 44 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Members\Voters.cshtml"
WriteAttributeValue("", 1846, item.MemberId, 1846, 14, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1860, "\')", 1860, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 44 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Members\Voters.cshtml"
                                                                                                                   Write(item.MemberNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
            WriteLiteral("                                       \r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 49 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Members\Voters.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.RegistrationDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 52 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Members\Voters.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.MemberFullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 55 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Members\Voters.cshtml"
                                   Write(Html.DisplayFor(modelItem => item.IsVoted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </th>\r\n                                </tr>\r\n");
#nullable restore
#line 58 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Members\Voters.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table>
                </div>
            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>
    <!-- /.col-lg-12 -->
</div>
<div id=""myModal"" class=""modal fade"">
    <div class=""modal-dialog modal-confirm"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <b>Voters Details</b>
            </div>
            <div class=""modal-body"">
                <div class=""row"">

                    <div id=""divtxt"">

                    </div>
                </div>


            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-4"">

                    </div>
                    <div class=""col-lg-4"">

                    </div>
                    <div class=""col-lg-4"">
                       
                        <button type=""button"" class=""btn  btn-danger"" data-dismiss=""moda");
            WriteLiteral(@"l"">Close</button>

                    </div>

                </div>


            </div>
        </div>
    </div>
</div>
<script>
      function Details(id)
      {
          var _Id = id;
          $.ajax({
              type: 'Get',
              contentType: 'application/json; charset=utf-8',
              dataType: 'json',
              url: '/Members/GetMemberDetails',
              data: { Id: _Id }, 
              success: function (data) {
               var jsonObj = data;
                $('#divtxt').html("""");
                var  table_body = "" "";

              
                  $.each(jsonObj, function (i, p) { 
                    table_body += ""<div class='col-md-12'>"";
                     table_body += '<b>';
                    table_body += '<p>' + p.positionName + '</p>';
                    table_body += ""</b>"";
                     table_body += ""</div>"";
                 
                    $.each(p.candidates, function (i, c) { 
                 ");
            WriteLiteral(@"      table_body+=""<div class='col-md-12'>"";
                    table_body += '<p>' + c.candidateName + '</p>';
                     table_body += ""</div>"";
                })
                    //table_body += ""</div>"";
                   
                   
                });
                  
                   
               
                 $('#divtxt').html(table_body);
               $(""#myModal"").modal(""show"");                
            } 
            
        });
             
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OSPI.Infrastructure.Models.MemberModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
