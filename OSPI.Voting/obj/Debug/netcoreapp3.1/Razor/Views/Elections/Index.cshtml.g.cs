#pragma checksum "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Elections\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "787f1de4fe0f04533fcda0cb148cabe8c6cb13dd"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"787f1de4fe0f04533fcda0cb148cabe8c6cb13dd", @"/Views/Elections/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247b62a2bdc651d01e4f58f63b873ced4f59b401", @"/Views/_ViewImports.cshtml")]
    public class Views_Elections_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OSPI.Infrastructure.Models.CPositionModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Elections\Index.cshtml"
  
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

                    <div class=""col-sm-2"">
                        <a role=""button"" id=""btnconfirm"" class=""btn btn-primary pull-right""> Save</a>
                    </div>
                </div>
            </div>
            <div class=""panel-body"">

");
#nullable restore
#line 24 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Elections\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"section\"");
            BeginWriteAttribute("id", " id=\"", 832, "\"", 853, 1);
#nullable restore
#line 26 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Elections\Index.cshtml"
WriteAttributeValue("", 837, item.PositionId, 837, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <h5><b>INSTRUCTIONS:</b> Select between <label id=\"chkCount\" class=\"countermin\" data-countermin=\"");
#nullable restore
#line 27 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Elections\Index.cshtml"
                                                                                                                    Write(item.MinimumVotes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 27 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Elections\Index.cshtml"
                                                                                                                                        Write(item.MinimumVotes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>  and <label class=\"countermax\" data-countermax=\"");
#nullable restore
#line 27 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Elections\Index.cshtml"
                                                                                                                                                                                                                   Write(item.MaximumVotes);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 27 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Elections\Index.cshtml"
                                                                                                                                                                                                                                       Write(item.MaximumVotes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label> options from the list below. <label style=\"color:red\">* Required</label></h5>\r\n                        <p><span class=\"spncounter\">0</span> of  <span>");
#nullable restore
#line 28 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Elections\Index.cshtml"
                                                                  Write(item.MaximumVotes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> Selected</p>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-lg-6\">\r\n                                <div class=\"form-group\">\r\n                                    <h5><b>");
#nullable restore
#line 32 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Elections\Index.cshtml"
                                      Write(Html.DisplayFor(modelItem => item.PositionName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></h5>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n\r\n");
#nullable restore
#line 37 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Elections\Index.cshtml"
                         foreach (var emp in item.Candidates)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"row\">\r\n                                <div class=\"col-lg-8\">\r\n                                    <div class=\"row\">\r\n                                        <div class=\"col-sm-1\"><input type=\"checkbox\"");
            BeginWriteAttribute("class", " class=\"", 2009, "\"", 2037, 2);
            WriteAttributeValue("", 2017, "chk_", 2017, 4, true);
#nullable restore
#line 43 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Elections\Index.cshtml"
WriteAttributeValue("", 2021, item.PositionId, 2021, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-cid=\"");
#nullable restore
#line 43 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Elections\Index.cshtml"
                                                                                                                       Write(emp.CandidateId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-mid=\"");
#nullable restore
#line 43 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Elections\Index.cshtml"
                                                                                                                                                   Write(emp.MemberId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-cname=\"");
#nullable restore
#line 43 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Elections\Index.cshtml"
                                                                                                                                                                              Write(emp.CandidateName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-pname=\"");
#nullable restore
#line 43 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Elections\Index.cshtml"
                                                                                                                                                                                                              Write(item.PositionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"></div>\r\n\r\n                                        <div class=\"col-sm-2\"> <img");
            BeginWriteAttribute("src", " src=\"", 2233, "\"", 2256, 1);
#nullable restore
#line 45 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Elections\Index.cshtml"
WriteAttributeValue("", 2239, emp.MemberNumber, 2239, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:70px\"></div>\r\n                                        <div class=\"col-sm-6\">");
#nullable restore
#line 46 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Elections\Index.cshtml"
                                                         Write(emp.CandidateName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                            <br />\r\n");
#nullable restore
#line 51 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Elections\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n");
#nullable restore
#line 54 "C:\Projects\OSPI-Systems\OSPI.Voting\Views\Elections\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>
    <!-- /.col-lg-12 -->
</div>
<div id=""myModal"" class=""modal fade"">
    <div class=""modal-dialog modal-confirm"">
        <div class=""modal-content"">
            
            <div class=""modal-body"">
                <div class=""row"">
                    <div class=""col-lg-3"">

                    </div>
                    <div class=""col-lg-7"">
                        <p><b>Do you want to submit your  votes now ?</b></p>
                    </div>
                   
                </div>
                

            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-3"">

                    </div>
                    <div class=""col-lg-4"">
                        <button type=""button"" id=""btnSave"" class=""btn btn-info"">Yes</button>
                        <button type=""button"" id=""btnNo"" class=""btn  btn-da");
            WriteLiteral(@"nger"" data-dismiss=""modal"">No</button>

                    </div>
                    
                </div>
               

            </div>
        </div>
    </div>
</div>

<script>
    $(function () {
        var test = [];

        var pdata = [];
        var flag = true;
        $('input[type=""checkbox""]').click(function () {
            var mainSection = $(this).closest("".section"");
            var className = this.className;
            var counterMin = mainSection.find('.countermin').attr('data-countermin');
            var counterMax = mainSection.find('.countermax').attr('data-countermax');
            var tolatCheckbox = $('.' + className + ':checked').length;
            mainSection.find('.spncounter').html(tolatCheckbox);

        });
        $('#btnconfirm').click(function () {           
            var data = [];
            $("".section"").each(function (e, v) {              
                var counterMin = $(this).find('.countermin').attr('data-countermin')");
            WriteLiteral(@";
                var counterMax = $(this).find('.countermax').attr('data-countermax');

                var selectedCB = [];
                var pselectedCB = [];
                var secctionId = $('#' + v.id + "" input[type='checkbox']:checked"");

                if (secctionId.length >= parseInt(counterMin) && secctionId.length <= parseInt(counterMax)) {
                    $.each(secctionId, function () {
                        selectedCB.push('{""CandidateId"":""' + $(this).attr('data-cid') + '"",""MemberId"":""' + $(this).attr('data-mid') + '""}');
                        //pselectedCB.push('{""CandidateName"":""' + $(this).attr('data-cname') + '""}');
                    });
                    data.push('{""PositionId"":""' + v.id + '"",""Candidates"":[' + selectedCB.join("", "") + ']}')
                    flag = true;
                    //pdata.push('{""PositionId"":""' + v.id + '"",""CandidatesList"":[' + pselectedCB.join("", "") + ']}')
                }
                else {
                    alert('Ple");
            WriteLiteral(@"ase check limit of ' + v.id + '.')
                    flag = false;
                }

            });
            if (flag) {
                data = '[' + data.join("", "") + ']';
                test = data;
                $(""#myModal"").modal(""show"");
                //pdata = '[' + pdata.join("", "") + ']';
                //var pdatas = pdata;
                //var i;
                //for (i in pdatas.CandidatesList) {
                //    var data= pdatas.CandidatesList[i] + ""<br>"";
                //}

                //$(""#myModal"").modal(""show"");
                //$.ajax({
                //    type: 'POST',
                //    url: '/Elections/SaveVotes',
                //    data: data,
                //    contentType: ""application/json"",
                //    success: function (data) {
                //        alert(""Record has been successfully inserted."");
                //        location.href = ""/Elections/Results"";
                //    }
                //});");
            WriteLiteral(@"
            }

        });
        $('#btnSave').click(function () {
            var model =test;
               $.ajax({
                    type: 'POST',
                    url: '/Elections/SaveVotes',
                    data: model,
                    contentType: ""application/json"",
                    success: function (model) {
                        alert(""Record has been successfully inserted."");
                        location.href = ""/Elections/Results"";
                    }
                });
        });
        $('#btnNo').click(function () {
            $(""#myModal"").modal(""hide"");
        });
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
