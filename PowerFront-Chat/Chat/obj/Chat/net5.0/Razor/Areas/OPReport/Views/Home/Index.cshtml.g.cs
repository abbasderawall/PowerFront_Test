#pragma checksum "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eebc21ef9cb3501f05c06823f0bdd6ef13ee1379"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_OPReport_Views_Home_Index), @"mvc.1.0.view", @"/Areas/OPReport/Views/Home/Index.cshtml")]
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
#line 1 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\_ViewImports.cshtml"
using Chat;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\_ViewImports.cshtml"
using Chat.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eebc21ef9cb3501f05c06823f0bdd6ef13ee1379", @"/Areas/OPReport/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d70151e05cafaed5818b9c5bf31d34dbd7b3758a", @"/Areas/OPReport/Views/_ViewImports.cshtml")]
    public class Areas_OPReport_Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Chat.Models.ViewModels.OperatorReportItems>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-format", "{0:yyyy-MM-ddTHH:mm}", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\Home\Index.cshtml"
   ViewBag.Title = "Operator Report"; 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eebc21ef9cb3501f05c06823f0bdd6ef13ee13794584", async() => {
                WriteLiteral(@"
    <div class=""row pb-3 backgroundWhite"">
        <br />
        <div class=""row"">
            <div class=""m-2"">
                <h2 class=""text-primary"">Operator Report</h2>
            </div>

        </div>

        <br />
        <br />
        <div class=""p-4 border rounded"">
            <div class=""form-group row"">
                <div class=""col-4"">
                    WebSite
                </div>
                <div class=""col-8"">
                    ");
#nullable restore
#line 21 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\Home\Index.cshtml"
               Write(Html.DropDownListFor(m => m.Conversation.Website, Model.WebSiteList, "-Select a Website",
                                                                     new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n\n                </div>\n            </div>\n            <div class=\"form-group row\">\n                <div class=\"col-4\">\n                    Device\n                </div>\n                <div class=\"col-8\">\n                    ");
#nullable restore
#line 31 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\Home\Index.cshtml"
               Write(Html.DropDownListFor(m => m.Visitor.Device, Model.DeviceList, "-Select a Device",
                                                                                         new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                </div>
            </div>

            <div class=""form-group row"">
                <div class=""col-4"">

                    Pre-Defined:
                    <input id=""filter"" class=""radio"" name=""filter"" value=""Pre-Defined"" type=""radio"">
                    Custom:
                    <input id=""filter"" name=""filter"" class=""radio"" value=""Custom"" type=""radio"">

                </div>
                <div class=""col-8"">
                    <div id=""Predefine"">
                        ");
#nullable restore
#line 48 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\Home\Index.cshtml"
                   Write(Html.DropDownListFor(m => m.PreDefineFilterValue.value, Model.PreDefineFilter, "-Select a filter",
                                                                                             new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <br />\n                    <div id=\"Custom\">\n                        <div class=\"form-group row\">\n                            <div class=\"col-6\">\n                                From Date: ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eebc21ef9cb3501f05c06823f0bdd6ef13ee13797643", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 55 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Conversation.StartDate);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Format = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n\n                            </div>\n                            <div class=\"col-6\">\n                                To Date: ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "eebc21ef9cb3501f05c06823f0bdd6ef13ee13799571", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 59 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Conversation.EndDate);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Format = (string)__tagHelperAttribute_1.Value;
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
                        </div>
                    </div>
                </div>

            </div>
            <div class=""form-group row align-content-center"">
                <div class=""col-10""></div>
                <div class=""col-2 align-items-md-end"">
                    <button type=""submit"" class=""btn btn-success form-control align-content-center"">Search</button>
                </div>
            </div>
            <br />
            <br />
            <div class=""form-group"">
                <span style=""float:right; text-align:right""> ");
#nullable restore
#line 75 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\Home\Index.cshtml"
                                                        Write(Html.ActionLink("Excel Export", "Export", new { @class = "btn btn-success form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span>
            </div>

            <table id=""tblData"" class=""table table-striped table-bordered"" style=""width:100%"">
                <thead class=""alert-light"">
                    <tr class=""table-info"">
                        <th>S.No.</th>
                        <th>Operator Name</th>
                        <th>Proactive Sent</th>
                        <th>Proactive Answered</th>
                        <th>Proactive Response Rate</th>
                        <th>Reactive Received</th>
                        <th>Reactive Answered</th>
                        <th>Reactive Response Rate</th>
                        <th>Total Chat Length</th>
                        <th>Average Chat Length</th>
                    </tr>
");
#nullable restore
#line 92 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\Home\Index.cshtml"
                     foreach (var item in Model.OperatorProductivity)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 95 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\Home\Index.cshtml"
           Write(item.OperatorID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td>");
#nullable restore
#line 96 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\Home\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td>");
#nullable restore
#line 97 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\Home\Index.cshtml"
           Write(item.ProactiveSent);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td>");
#nullable restore
#line 98 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\Home\Index.cshtml"
           Write(item.ProactiveAnswered);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td>");
#nullable restore
#line 99 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\Home\Index.cshtml"
           Write(item.ProactiveResponseRate);

#line default
#line hidden
#nullable disable
                WriteLiteral("%</td>\n            <td>");
#nullable restore
#line 100 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\Home\Index.cshtml"
           Write(item.ReactiveReceived);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td>");
#nullable restore
#line 101 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\Home\Index.cshtml"
           Write(item.ReactiveAnswered);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td>");
#nullable restore
#line 102 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\Home\Index.cshtml"
           Write(item.ReactiveResponseRate);

#line default
#line hidden
#nullable disable
                WriteLiteral("%</td>\n            <td>");
#nullable restore
#line 103 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\Home\Index.cshtml"
           Write(item.TotalChatLength);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n            <td>");
#nullable restore
#line 104 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\Home\Index.cshtml"
           Write(item.AverageChatLength);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n        </tr>");
#nullable restore
#line 105 "D:\Projects\ABBAS_TEST\PowerFront-Chat\Chat\Areas\OPReport\Views\Home\Index.cshtml"
             }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </thead>\n            </table>\n        </div>\n\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
   
    <script>
        $(document).ready(function () {
            $(""input[Value='Pre-Defined']"").click(function () {
                $(""#Predefine"").show();
                $(""#Custom"").hide();
            });
            $(""input[Value='Custom']"").click(function () {
                $(""#Custom"").show();
                $(""#Predefine"").hide();
            });
        });
    </script>

");
            }
            );
            WriteLiteral("\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Chat.Models.ViewModels.OperatorReportItems> Html { get; private set; }
    }
}
#pragma warning restore 1591
