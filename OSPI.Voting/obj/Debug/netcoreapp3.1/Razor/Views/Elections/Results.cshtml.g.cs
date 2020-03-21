#pragma checksum "G:\2020\Diego Project\V25\OSPI.Voting\Views\Elections\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de856149a9681a955f53eddab37bdbb28fb81786"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Elections_Results), @"mvc.1.0.view", @"/Views/Elections/Results.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de856149a9681a955f53eddab37bdbb28fb81786", @"/Views/Elections/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247b62a2bdc651d01e4f58f63b873ced4f59b401", @"/Views/_ViewImports.cshtml")]
    public class Views_Elections_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OSPI.Infrastructure.Models.CPositionModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Results"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Elections\Results.cshtml"
  
    ViewData["Title"] = "Results";
    Layout = "~/Views/Shared/_Layout_User_loggedIn.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<script src=""https://cdn.jsdelivr.net/npm/chart.js@2.9.3/dist/Chart.min.js""></script>
<br />

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""col-sm-6""><h4>Elections Result</h4></div>
                        <div class=""col-sm-6"">
                            <div class=""col-sm-12"">
                                <div class=""col-sm-5""></div>
                                <div class=""col-sm-3"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de856149a9681a955f53eddab37bdbb28fb817867004", async() => {
                WriteLiteral("\r\n                                        <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 902, "\"", 927, 1);
#nullable restore
#line 24 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Elections\Results.cshtml"
WriteAttributeValue("", 910, Model.PositionId, 910, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""id"" />
                                        <input type=""submit"" class=""btn btn-primary"" value=""<"" id=""btnPrev"" name=""ButtonType"" />
                                        <input type=""submit"" value="">"" class=""btn btn-primary"" id=""btnNext"" name=""ButtonType"" />
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
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
                                <div class=""col-sm-4"">
                                    <input type=""button"" value=""Publish Result"" class=""btn btn-primary"" />
                                </div>
                            </div>
                        </div>


                    </div>
                </div>
");
            WriteLiteral("            </div>\r\n            <div class=\"panel-body\">\r\n\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-7\">\r\n                        <div class=\"dataTable_wrapper table-responsive\">\r\n                            <p><b>");
#nullable restore
#line 62 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Elections\Results.cshtml"
                             Write(Model.PositionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                            <table");
            BeginWriteAttribute("id", " id=\"", 2852, "\"", 2857, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""table table-striped table-bordered table-hover  display nowrap"" style=""overflow-x:auto;"">
                                <thead>
                                    <tr>

                                        <th>
                                            List of Canditates
                                        </th>

                                        <th>
                                            No of Votes
                                        </th>
                                        <th>
                                            No of Votes(%)
                                        </th>
                                        <th>
                                            Status
                                        </th>
                                    </tr>
                                </thead>
                                <tbody>

");
#nullable restore
#line 84 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Elections\Results.cshtml"
                                     foreach (var item in Model.Candidates)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr class=\"odd gradeX\">\r\n\r\n                                            <td>\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "de856149a9681a955f53eddab37bdbb28fb8178611768", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Elections\Results.cshtml"
                                              WriteLiteral(item.MemberNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 89 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Elections\Results.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                ");
#nullable restore
#line 90 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Elections\Results.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.CandidateName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                            </td>\r\n                                            <td>\r\n                                                <label style=\"cursor:pointer;color:#337ab7\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4457, "\"", 4495, 3);
            WriteAttributeValue("", 4467, "Details(\'", 4467, 9, true);
#nullable restore
#line 94 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Elections\Results.cshtml"
WriteAttributeValue("", 4476, item.CandidateId, 4476, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4493, "\')", 4493, 2, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 94 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Elections\Results.cshtml"
                                                                                                                              Write(item.TotalVotes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n\r\n                                            </td>\r\n\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 99 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Elections\Results.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Percentage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                <select id=\"cars\" class=\"form-control\">\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de856149a9681a955f53eddab37bdbb28fb8178616130", async() => {
                WriteLiteral("For Approval");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de856149a9681a955f53eddab37bdbb28fb8178617348", async() => {
                WriteLiteral("Accept");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de856149a9681a955f53eddab37bdbb28fb8178618560", async() => {
                WriteLiteral("Decline");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                                </select>\r\n                                            </td>\r\n\r\n                                        </tr>\r\n");
#nullable restore
#line 111 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Elections\Results.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                    <!-- /.col-lg-6 (nested) -->
                    <div class=""col-lg-5"">
                        <div class=""form-group"">
                            <canvas id=""myChart"" width=""400"" height=""300""></canvas>
                        </div>

                    </div>
                    <!-- /.col-lg-6 (nested) -->
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
     ");
            WriteLiteral(@"           </div>


            </div>
            <div class=""modal-footer"">
                <div class=""row"">
                    <div class=""col-lg-4"">

                    </div>
                    <div class=""col-lg-4"">

                    </div>
                    <div class=""col-lg-4"">

                        <button type=""button"" class=""btn  btn-danger"" data-dismiss=""modal"">Close</button>

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
              url: '/Elections/GetAllCandidatesDetails',
              data: { Id: _Id },
              success: function (data) {
               var jsonObj = data;
                $('#divtxt').html("""");
                var  table_body = "" "";


                   ");
            WriteLiteral(@" table_body += ""<div class='col-md-12'>"";
                     table_body += '<b>';
                    table_body += '<p>' + jsonObj.positionName + '</p>';
                    table_body += ""</b>"";
                     table_body += ""</div>"";

                    $.each(jsonObj.votes, function (i, c) {
                       table_body+=""<div class='col-md-6'>"";
                    table_body += '<p>' + c.vFullName + '</p>';
                     table_body += ""</div>"";
                })



                 $('#divtxt').html(table_body);
               $(""#myModal"").modal(""show"");
            }

        });

        }
    $(function () {
       var chartDiv = $(""#myChart"");


         var myChart = new Chart(chartDiv, {
            type: 'pie',
             data: {
                 labels: JSON.parse('");
#nullable restore
#line 216 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Elections\Results.cshtml"
                                Write(Html.Raw(ViewBag.canditateNameList));

#line default
#line hidden
#nullable disable
            WriteLiteral("\'),\r\n\r\n                datasets: [\r\n                    {\r\n\r\n                    data: JSON.parse(\'");
#nullable restore
#line 221 "G:\2020\Diego Project\V25\OSPI.Voting\Views\Elections\Results.cshtml"
                                 Write(Html.Raw(ViewBag.PercentageList));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'),
                        backgroundColor: [
                            ""#FF6384"",
                            ""#4BC0C0"",
                            ""#FFCE56"",
                            ""#E7E9ED""

                        ]
                    }]
            },
            options: {
                title: {
                    display: true,
                    text: 'Election Result Chart'
                },
                responsive: true,
                maintainAspectRatio: false,
            }
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OSPI.Infrastructure.Models.CPositionModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
