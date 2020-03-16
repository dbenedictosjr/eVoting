#pragma checksum "G:\2020\Diego Project\V23\OSPI.Voting\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c89ab417a3b262cf84e72ae774b15ac464f579a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "G:\2020\Diego Project\V23\OSPI.Voting\Views\_ViewImports.cshtml"
using OSPI.Voting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\2020\Diego Project\V23\OSPI.Voting\Views\_ViewImports.cshtml"
using OSPI.Voting.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c89ab417a3b262cf84e72ae774b15ac464f579a", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"247b62a2bdc651d01e4f58f63b873ced4f59b401", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/team/pic1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/team/pic2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/team/pic3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/team/pic4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\2020\Diego Project\V23\OSPI.Voting\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Voting";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>

    #home {
        background: url(""/images/backgrounds/bg3.jpg"") no-repeat center center fixed;
        background-size:contain;
    }
</style>
<!-- =========================
ABOUT US SECTION
============================== -->
<header id=""home"" class=""header"">
    <!-- BIG HEADING WITH CALL TO ACTION BUTTONS AND SHORT MESSAGES -->
    <div class=""container"">

        <!-- HEADING -->
        <h1 class=""intro"">OSPI Multi-Purpose Cooperative</h1>

        <!-- CALL TO ACTION BUTTONS -->
        <div class=""buttons inpage-scroll"">
            <a href=""#works"" class=""btn btn-primary custom-button red-btn"">Our Works</a>
            <a href=""#pricingtable"" class=""btn btn-primary custom-button green-btn"">Our Packages</a>
        </div>

    </div> <!-- / END BIG HEADING WITH CALL TO ACTION BUTTONS AND SHORT MESSAGES  -->
</header>
<section class=""about-us"" id=""aboutus"">
    <div class=""container"">

        <!-- SECTION HEADER -->
        <div class=""section-header"">

       ");
            WriteLiteral(@"     <!-- SECTION TITLE -->
            <h2 class=""white-text"">Vision</h2>

            <!-- SHORT DESCRIPTION ABOUT THE SECTION -->
            <h6 class=""white-text"">
                The Cooperative is dedicated to provide reliable investment facilities, business opportunities and services beneficial to its stakeholders.
            </h6>
        </div>
        <!-- / END SECTION HEADER -->
        <!-- 3 COLUMNS OF ABOUT US-->
        <div class=""row"">

            <h2 class=""white-text"">Mission</h2>
            <h6 class=""white-text"">
                To be a ROBUST investment organization for OSPI employees.
            </h6>
            
            <!-- COLUMN 1 - SKILSS-->
            <div class=""col-lg-4 col-md-4 column"">
                <ul class=""skills wow fadeInRight animated animated"" data-wow-offset=""30"" data-wow-duration=""1.5s"" data-wow-delay=""0.15s"" style=""visibility: visible;-webkit-animation-duration: 1.5s; -moz-animation-duration: 1.5s; animation-duration: 1.5s;-webkit-an");
            WriteLiteral(@"imation-delay: 0.15s; -moz-animation-delay: 0.15s; animation-delay: 0.15s;"">

                    <!-- SKILL ONE -->
                    <li class=""skill"">
                        <input type=""text"" value=""R"" data-thickness="".2"" class=""skill1"" readonly=""readonly"" style=""width: 36px; height: 21px; position: absolute; vertical-align: middle; margin-top: 21px; margin-left: -50px; border: 0px none; background: rgba(0, 0, 0, 0) none repeat scroll 0% 0%; font: bold 12px Arial; text-align: center; color: rgb(255, 255, 255); padding: 0px; -moz-appearance: none;"">
                        <p>
                            reliable officers and staff
                        </p>
                    </li>

                    <!-- SKILL TWO -->
                    <li class=""skill"">
                        <div class=""skill-count"">
                            <div style=""display: inline; width: 64px; height: 200px;""><canvas width=""64"" height=""200""></canvas><input type=""text"" value=""O"" data-thickness="".2"" class");
            WriteLiteral(@"=""skill2"" readonly=""readonly"" style=""width: 36px; height: 21px; position: absolute; vertical-align: middle; margin-top: 21px; margin-left: -50px; border: 0px none; background: rgba(0, 0, 0, 0) none repeat scroll 0% 0%; font: bold 12px Arial; text-align: center; color: rgb(255, 255, 255); padding: 0px; -moz-appearance: none;""></div>
                        </div>
                        <p>
                            outstanding investment philosophy;
                        </p>
                    </li>

                    <!-- SKILL THREE -->
                    <li class=""skill"">
                        <div class=""skill-count"">
                            <div style=""display: inline; width: 64px; height: 200px;""><canvas width=""64"" height=""200""></canvas><input type=""text"" value=""B"" data-thickness="".2"" class=""skill3"" readonly=""readonly"" style=""width: 36px; height: 21px; position: absolute; vertical-align: middle; margin-top: 21px; margin-left: -50px; border: 0px none; background: rgba(0, 0, 0, 0");
            WriteLiteral(@") none repeat scroll 0% 0%; font: bold 12px Arial; text-align: center; color: rgb(255, 255, 255); padding: 0px; -moz-appearance: none;""></div>
                        </div>
                        <p>
                            best financial management;
                        </p>
                    </li>

                    <!-- SKILL FOUR -->
                    <li class=""skill"">
                        <div class=""skill-count"">
                            <div style=""display: inline; width: 64px; height: 200px;""><canvas width=""64"" height=""200""></canvas><input type=""text"" value=""U"" data-thickness="".2"" class=""skill4"" readonly=""readonly"" style=""width: 36px; height: 21px; position: absolute; vertical-align: middle; margin-top: 21px; margin-left: -50px; border: 0px none; background: rgba(0, 0, 0, 0) none repeat scroll 0% 0%; font: bold 12px Arial; text-align: center; color: rgb(255, 255, 255); padding: 0px; -moz-appearance: none;""></div>
                        </div>
                        ");
            WriteLiteral(@"<p>
                            unquestionable integrity;
                        </p>
                    </li>

                    <li class=""skill"">
                        <div class=""skill-count"">
                            <div style=""display: inline; width: 64px; height: 200px;""><canvas width=""64"" height=""200""></canvas><input type=""text"" value=""S"" data-thickness="".2"" class=""skill4"" readonly=""readonly"" style=""width: 36px; height: 21px; position: absolute; vertical-align: middle; margin-top: 21px; margin-left: -50px; border: 0px none; background: rgba(0, 0, 0, 0) none repeat scroll 0% 0%; font: bold 12px Arial; text-align: center; color: rgb(255, 255, 255); padding: 0px; -moz-appearance: none;""></div>
                        </div>
                        <p>
                            superior service to its members & employees; and
                        </p>
                    </li>

                    <li class=""skill"">
                        <div class=""skill-count"">
         ");
            WriteLiteral(@"                   <div style=""display: inline; width: 64px; height: 200px;""><canvas width=""64"" height=""200""></canvas><input type=""text"" value=""T"" data-thickness="".2"" class=""skill4"" readonly=""readonly"" style=""width: 36px; height: 21px; position: absolute; vertical-align: middle; margin-top: 21px; margin-left: -50px; border: 0px none; background: rgba(0, 0, 0, 0) none repeat scroll 0% 0%; font: bold 12px Arial; text-align: center; color: rgb(255, 255, 255); padding: 0px; -moz-appearance: none;""></div>
                        </div>
                        <p>
                            time tested practices
                        </p>
                    </li>

                </ul>
            </div> <!-- / END SKILLS COLUMN-->
        </div> 
    <!-- / END 3 COLUMNS OF ABOUT US-->

    </div> <!-- / END CONTAINER -->

</section> <!-- END ABOUT US SECTION -->
<!-- =========================
   FOCUS SECTION
============================== -->

<section class=""focus"" id=""focus"">
    <div c");
            WriteLiteral(@"lass=""container"">
        <!-- SECTION HEADER -->
        <div class=""section-header"">

            <!-- SECTION TITLE -->
            <h2 class=""dark-text"">Services</h2>

            <!-- SHORT DESCRIPTION ABOUT THE SECTION -->
            <h6>
                We design &amp; develop qaulity products to help small &amp; medium level business.
            </h6>
        </div>
        <!-- / END SECTION HEADER -->
        <!-- 4 FOCUS BOXES -->
        <div class=""row"">

            <!-- FIRST FOCUS BOXES -->
            <div class=""col-lg-3 col-sm-3 focus-box red wow fadeInLeft animated animated"" data-wow-offset=""30"" data-wow-duration=""1.5s"" data-wow-delay=""0.15s"" style=""visibility: visible;-webkit-animation-duration: 1.5s; -moz-animation-duration: 1.5s; animation-duration: 1.5s;-webkit-animation-delay: 0.15s; -moz-animation-delay: 0.15s; animation-delay: 0.15s;"">
                <div class=""service-icon"">
                    <i class=""fa fa-desktop"" style=""font-size: 5em;padding-top: 30px;");
            WriteLiteral(@"""></i> <!-- FOCUS ICON-->
                </div>
                <h5 class=""red-border-bottom"">Web Design</h5> <!-- FOCUS HEADING -->
                <p>
                    <!-- FOCUS DESCRIPTION -->
                    Created cattle form fruit. Saying from given together face without waters, whose. Second first. Face it saw give creature was thing. Over upon is brought. Him you'll above kind set
                </p>
            </div>
            <!-- / END FIRST FOCUS BOX. Other boxes has same format -->

            <div class=""col-lg-3 col-sm-3 focus-box green wow fadeInLeft animated animated"" data-wow-offset=""30"" data-wow-duration=""1.5s"" data-wow-delay=""0.15s"" style=""visibility: visible;-webkit-animation-duration: 1.5s; -moz-animation-duration: 1.5s; animation-duration: 1.5s;-webkit-animation-delay: 0.15s; -moz-animation-delay: 0.15s; animation-delay: 0.15s;"">
                <div class=""service-icon"">
                    <span class=""fa fa-camera"" style=""font-size: 5em;padding-top: 30px;"">");
            WriteLiteral(@"</span>
                </div>
                <h5 class=""green-border-bottom"">Photography</h5>
                <p>
                    Created cattle form fruit. Saying from given together face without waters, whose. Second first. Face it saw give creature was thing. Over upon is brought. Him you'll above kind set
                </p>
            </div>

            <div class=""col-lg-3 col-sm-3 focus-box blue wow fadeInRight animated animated"" data-wow-offset=""30"" data-wow-duration=""1.5s"" data-wow-delay=""0.15s"" style=""visibility: visible;-webkit-animation-duration: 1.5s; -moz-animation-duration: 1.5s; animation-duration: 1.5s;-webkit-animation-delay: 0.15s; -moz-animation-delay: 0.15s; animation-delay: 0.15s;"">
                <div class=""service-icon"">
                    <i class=""fa fa-inbox"" style=""font-size: 5em;padding-top: 30px;""></i>
                </div>
                <h5 class=""blue-border-bottom"">Email Marketing</h5>
                <p>
                    Created cattle form fru");
            WriteLiteral(@"it. Saying from given together face without waters, whose. Second first. Face it saw give creature was thing. Over upon is brought. Him you'll above kind set
                </p>
            </div>

            <div class=""col-lg-3 col-sm-3 focus-box yellow wow fadeInRight animated animated"" data-wow-offset=""30"" data-wow-duration=""1.5s"" data-wow-delay=""0.15s"" style=""visibility: visible;-webkit-animation-duration: 1.5s; -moz-animation-duration: 1.5s; animation-duration: 1.5s;-webkit-animation-delay: 0.15s; -moz-animation-delay: 0.15s; animation-delay: 0.15s;"">
                <div class=""service-icon"">
                    <i class=""fa fa-inbox"" style=""font-size: 5em;padding-top: 30px;""></i>
                </div>
                <h5 class=""yellow-border-bottom"">SEO &amp; SMM</h5>
                <p>
                    Created cattle form fruit. Saying from given together face without waters, whose. Second first. Face it saw give creature was thing. Over upon is brought. Him you'll above kind set
  ");
            WriteLiteral(@"              </p>
            </div>
        </div>
        <!-- / END 4 FOCUS BOXES -->
        <!-- OTHER FOCUSES -->
        <div class=""other-focuses"">
            <h5><span class=""section-footer-title"">ALSO WE FOCUS ON</span></h5>
        </div>

        <!-- OTHER FOCUS LIST -->
        <div class=""other-focus-list wow fadeInUp animated animated"" data-wow-offset=""30"" data-wow-duration=""1.5s"" data-wow-delay=""0.15s"" style=""visibility: visible;-webkit-animation-duration: 1.5s; -moz-animation-duration: 1.5s; animation-duration: 1.5s;-webkit-animation-delay: 0.15s; -moz-animation-delay: 0.15s; animation-delay: 0.15s;"">
            <ul>
                <li><i class=""icon-fontawesome-webfont-8""></i>WEB APPLICATIONS</li>
                <li><i class=""icon-fontawesome-webfont-267""></i>SEARCH ENGINE OPTIMIZATION</li>
                <li><i class=""icon-fontawesome-webfont-75""></i>CLOUD STORAGE</li>
                <li><i class=""icon-fontawesome-webfont-358""></i>Project Management</li>
            ");
            WriteLiteral(@"    <li><i class=""icon-fontawesome-webfont-102""></i>IOS APP</li>
                <li><i class=""icon-fontawesome-webfont-328""></i>ANDROId APP</li>
                <li><i class=""icon-fontawesome-webfont-195""></i>WINDOWS APP</li>
                <li><i class=""icon-fontawesome-webfont-297""></i>UX STRATEGY</li>
            </ul>
        </div> <!-- / END OTHER FOCUS LIST -->
    </div> <!-- / END CONTAINER -->
</section>  <!-- / END FOCUS SECTION -->
<!-- =========================
   OUR TEAM SECTION
============================== -->

<section class=""our-team"" id=""team"">
    <div class=""container"">

        <!-- SECTION HEADER -->
        <div class=""section-header"">

            <!-- SECTION TITLE -->
            <h2 class=""dark-text"">Board and Officers</h2>

            <!-- SHORT DESCRIPTION ABOUT THE SECTION -->
            <h6>
                Check our awesome team memebers who always work hard to provide quality products.
            </h6>
        </div>
        <!-- / END SECTION");
            WriteLiteral(@" HEADER -->
        <!-- TEAM MEMBERS -->
        <div class=""row wow fadeInRight animated animated"" data-wow-offset=""40"" data-wow-duration=""3s"" data-wow-delay=""0.15s"" style=""visibility: visible;-webkit-animation-duration: 3s; -moz-animation-duration: 3s; animation-duration: 3s;-webkit-animation-delay: 0.15s; -moz-animation-delay: 0.15s; animation-delay: 0.15s;"">
            <!-- MEMBER -->
            <div class=""col-lg-3 col-sm-3"">
                <div class=""team-member"">
                    <figure class=""profile-pic"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3c89ab417a3b262cf84e72ae774b15ac464f579a19599", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" <!-- MEMBER PROFILE PIC -->
                    </figure>
                    <div class=""member-details"">
                        <h5 class=""dark-text red-border-bottom"">Jason Daniels</h5>
                        <div class=""position"">
                            Founder
                        </div>
                    </div>
                    <div class=""social-icons"">
                        <ul>
                            <li><a");
            BeginWriteAttribute("href", " href=\"", 14561, "\"", 14568, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-facebook\"></i></a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 14644, "\"", 14651, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-twitter-alt\"></i></a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 14730, "\"", 14737, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-behance\"></i></a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 14812, "\"", 14819, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""icon-dribbble""></i></a></li>
                        </ul>
                    </div>
                    <div class=""details"">
                        <p>
                            Lorem ipsum dolor sit amet, consectetur adipisicing elit. Praesentium sapiente voluptate nostrum ipsa tempora optio facilis beatae quo aut error corrupti officiis dolore accusantium rem rerum illum nulla sed quisquam.
                        </p>
                    </div>
                </div>
            </div>
            <!-- / END MEMBER -->

            <div class=""col-lg-3 col-sm-3"">
                <div class=""team-member"">
                    <figure class=""profile-pic"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3c89ab417a3b262cf84e72ae774b15ac464f579a22709", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </figure>
                    <div class=""member-details"">
                        <h5 class=""dark-text green-border-bottom"">Patricia Medina</h5>
                        <div class=""position"">
                            Senior Desigener
                        </div>
                    </div>
                    <div class=""social-icons"">
                        <ul>
                            <li><a");
            BeginWriteAttribute("href", " href=\"", 16018, "\"", 16025, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-facebook\"></i></a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 16101, "\"", 16108, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-twitter-alt\"></i></a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 16187, "\"", 16194, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-behance\"></i></a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 16269, "\"", 16276, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""icon-linkedin""></i></a></li>
                        </ul>
                    </div>
                    <div class=""details"">
                        <p>
                            Lorem ipsum dolor sit amet, consectetur adipisicing elit. Praesentium sapiente voluptate nostrum ipsa tempora optio facilis beatae quo aut error corrupti officiis dolore accusantium rem rerum illum nulla sed quisquam.
                        </p>
                    </div>
                </div>
            </div>

            <div class=""col-lg-3 col-sm-3"">
                <div class=""team-member"">
                    <figure class=""profile-pic"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3c89ab417a3b262cf84e72ae774b15ac464f579a25769", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </figure>
                    <div class=""member-details"">
                        <h5 class=""dark-text blue-border-bottom"">Eugene Lane</h5>
                        <div class=""position"">
                            Lead Developer
                        </div>
                    </div>
                    <div class=""social-icons"">
                        <ul>
                            <li><a");
            BeginWriteAttribute("href", " href=\"", 17433, "\"", 17440, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-facebook\"></i></a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 17516, "\"", 17523, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-twitter-alt\"></i></a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 17602, "\"", 17609, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-behance\"></i></a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 17684, "\"", 17691, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""icon-linkedin""></i></a></li>
                        </ul>
                    </div>
                    <div class=""details"">
                        <p>
                            Lorem ipsum dolor sit amet, consectetur adipisicing elit. Praesentium sapiente voluptate nostrum ipsa tempora optio facilis beatae quo aut error corrupti officiis dolore accusantium rem rerum illum nulla sed quisquam.
                        </p>
                    </div>
                </div>
            </div>

            <div class=""col-lg-3 col-sm-3"">
                <div class=""team-member"">
                    <figure class=""profile-pic"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3c89ab417a3b262cf84e72ae774b15ac464f579a28822", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </figure>
                    <div class=""member-details"">
                        <h5 class=""dark-text yellow-border-bottom"">Kathy Hudson</h5>
                        <div class=""position"">
                            Art Director
                        </div>
                    </div>
                    <div class=""social-icons"">
                        <ul>
                            <li><a");
            BeginWriteAttribute("href", " href=\"", 18849, "\"", 18856, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-facebook\"></i></a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 18932, "\"", 18939, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-twitter-alt\"></i></a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 19018, "\"", 19025, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"icon-behance\"></i></a></li>\r\n                            <li><a");
            BeginWriteAttribute("href", " href=\"", 19100, "\"", 19107, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""icon-linkedin""></i></a></li>
                        </ul>
                    </div>
                    <div class=""details"">
                        <p>
                            Lorem ipsum dolor sit amet, consectetur adipisicing elit. Praesentium sapiente voluptate nostrum ipsa tempora optio facilis beatae quo aut error corrupti officiis dolore accusantium rem rerum illum nulla sed quisquam.
                        </p>
                    </div>
                </div>
            </div>

        </div> <!-- / END TEAM MEMBER LIST -->

    </div> <!-- / END CONTAINER -->
</section> <!-- / END OUR TEAM SECTION -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
