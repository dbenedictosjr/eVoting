#pragma checksum "G:\2020\Diego Project\V21\OSPI.Voting\Views\Elections\Results.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9ec503b79f81c65bcc057172dd7b3560f1058b7"
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
#line 1 "G:\2020\Diego Project\V21\OSPI.Voting\Views\_ViewImports.cshtml"
using OSPI.Voting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\2020\Diego Project\V21\OSPI.Voting\Views\_ViewImports.cshtml"
using OSPI.Voting.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9ec503b79f81c65bcc057172dd7b3560f1058b7", @"/Views/Elections/Results.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247b62a2bdc651d01e4f58f63b873ced4f59b401", @"/Views/_ViewImports.cshtml")]
    public class Views_Elections_Results : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OSPI.Infrastructure.Models.CPositionModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Results"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("rounded-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("40"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\2020\Diego Project\V21\OSPI.Voting\Views\Elections\Results.cshtml"
  
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
                    <div class=""col-sm-4""><h4>Elections Dashboard</h4></div>
                    <div class=""col-sm-6""></div>
                    <div class=""col-sm-2"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9ec503b79f81c65bcc057172dd7b3560f1058b75810", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 707, "\"", 732, 1);
#nullable restore
#line 21 "G:\2020\Diego Project\V21\OSPI.Voting\Views\Elections\Results.cshtml"
WriteAttributeValue("", 715, Model.PositionId, 715, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"id\" />\r\n                            <input type=\"submit\" value=\"<\" id=\"btnPrev\" name=\"ButtonType\" />\r\n                            <input type=\"submit\" value=\">\" id=\"btnNext\" name=\"ButtonType\" />\r\n                        ");
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
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n");
            WriteLiteral("            </div>\r\n            <div class=\"panel-body\">\r\n\r\n                <div class=\"row\">\r\n                    <div class=\"col-lg-6\">\r\n                        <div class=\"dataTable_wrapper table-responsive\">\r\n                            <p><b>");
#nullable restore
#line 51 "G:\2020\Diego Project\V21\OSPI.Voting\Views\Elections\Results.cshtml"
                             Write(Model.PositionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n                            <table");
            BeginWriteAttribute("id", " id=\"", 2257, "\"", 2262, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""table table-striped table-bordered table-hover  display nowrap"">
                                <thead>
                                    <tr>
                                        <th class=""text-center"">

                                        </th>

                                        <th>
                                            List of Canditates
                                        </th>

                                        <th>
                                            No of Votes
                                        </th>
                                        <th>
                                            No of Votes(%)
                                        </th>
                                    </tr>
                                </thead>
                                <tbody>

");
#nullable restore
#line 73 "G:\2020\Diego Project\V21\OSPI.Voting\Views\Elections\Results.cshtml"
                                     foreach (var item in Model.Candidates)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <tr class=""odd gradeX"">
                                            <td class=""text-center"">
                                                <input type=""checkbox"" value=""1"">
                                            </td>
                                            <td>
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a9ec503b79f81c65bcc057172dd7b3560f1058b710308", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "G:\2020\Diego Project\V21\OSPI.Voting\Views\Elections\Results.cshtml"
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
#line 80 "G:\2020\Diego Project\V21\OSPI.Voting\Views\Elections\Results.cshtml"
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
#line 81 "G:\2020\Diego Project\V21\OSPI.Voting\Views\Elections\Results.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.CandidateName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 85 "G:\2020\Diego Project\V21\OSPI.Voting\Views\Elections\Results.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.TotalVotes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 89 "G:\2020\Diego Project\V21\OSPI.Voting\Views\Elections\Results.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Percentage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n\r\n                                        </tr>\r\n");
#nullable restore
#line 93 "G:\2020\Diego Project\V21\OSPI.Voting\Views\Elections\Results.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                    <!-- /.col-lg-6 (nested) -->
                    <div class=""col-lg-6"">
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
<script>
    $(function () {
        //var chartDiv = $(""#myChart"");
        debugger
        var UserName = '");
#nullable restore
#line 121 "G:\2020\Diego Project\V21\OSPI.Voting\Views\Elections\Results.cshtml"
                   Write(Html.Raw(this.ViewData["canditateNameList"]));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n        var rew = JSON.parse(\'");
#nullable restore
#line 122 "G:\2020\Diego Project\V21\OSPI.Voting\Views\Elections\Results.cshtml"
                         Write(ViewData["canditateNameList"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n       // var rew2 = JSON.parse(");
#nullable restore
#line 123 "G:\2020\Diego Project\V21\OSPI.Voting\Views\Elections\Results.cshtml"
                           Write(ViewData["canditateNameList"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@");
         //var myChart = new Chart(chartDiv, {
        //    type: 'pie',
        //    data: {
        //    //   labels: [""Diego Jr Benedictos"", ""Joy Benedictos"", ""Ajay Gujjar"", ""Ram""],
              
        //        datasets: [
        //            {
                       
        //                //data: _data[1],
        //                backgroundColor: [
        //                    ""#FF6384"",
        //                    ""#4BC0C0"",
        //                    ""#FFCE56"",
        //                    ""#E7E9ED""

        //                ]
        //            }]
        //    },
        //    options: {
        //        title: {
        //            display: true,
        //            text: 'Election Result Chart'
        //        },
        //        responsive: true,
        //        maintainAspectRatio: false,
        //    }
        //});
    });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OSPI.Infrastructure.Models.CPositionModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
