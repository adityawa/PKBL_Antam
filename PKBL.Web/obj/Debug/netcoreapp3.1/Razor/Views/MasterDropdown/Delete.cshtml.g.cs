#pragma checksum "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterDropdown\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d569633c702279ec35cdbeaf6171a5d36b67437d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MasterDropdown_Delete), @"mvc.1.0.view", @"/Views/MasterDropdown/Delete.cshtml")]
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
#line 1 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\_ViewImports.cshtml"
using PKBL.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\_ViewImports.cshtml"
using PKBL.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d569633c702279ec35cdbeaf6171a5d36b67437d", @"/Views/MasterDropdown/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c4b14b0d1e0c8e6b258c5c7986d582bab4f80f4", @"/Views/_ViewImports.cshtml")]
    public class Views_MasterDropdown_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PKBL.Domain.Entities.Master.M_Dropdown>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
#line 3 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterDropdown\Delete.cshtml"
  
    ViewData["Title"] = "Delete Master Dropdown";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\'row\'>\r\n    <div class=\'col-md-12 col-sm-12\'>\r\n        <div class=\'x_panel\'>\r\n            <div class=\'x_title no-padding\'>\r\n                <h2>");
#nullable restore
#line 10 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterDropdown\Delete.cshtml"
               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("<small>Are you sure you want to delete this?</small></h2>\r\n                <div class=\'nav navbar-right panel_toolbox\'>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d569633c702279ec35cdbeaf6171a5d36b67437d5656", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class='clearfix'></div>
            </div>
            <div class='x_content'>
                <br />
                <div class='form-label-left'>
                    <div class='row'>
                        <div class='col-md-6'>

                            <div class='form-group row'>
                                <div class='col-form-label col-md-3 col-sm-3'>
                                    ");
#nullable restore
#line 24 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterDropdown\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\'col-form-label col-md-9 col-sm-9\'>\r\n                                    ");
#nullable restore
#line 27 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterDropdown\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Item));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\'form-group row\'>\r\n                                <div class=\'col-form-label col-md-3 col-sm-3\'>\r\n                                    ");
#nullable restore
#line 32 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterDropdown\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\'col-form-label col-md-9 col-sm-9\'>\r\n                                    ");
#nullable restore
#line 35 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterDropdown\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Value));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\'form-group row\'>\r\n                                <div class=\'col-form-label col-md-3 col-sm-3\'>\r\n                                    ");
#nullable restore
#line 40 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterDropdown\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\'col-form-label col-md-9 col-sm-9\'>\r\n                                    ");
#nullable restore
#line 43 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterDropdown\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\'form-group row\'>\r\n                                <div class=\'col-form-label col-md-3 col-sm-3\'>\r\n                                    ");
#nullable restore
#line 48 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterDropdown\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\'col-form-label col-md-9 col-sm-9\'>\r\n                                    ");
#nullable restore
#line 51 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterDropdown\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\'form-group row\'>\r\n                                <div class=\'col-form-label col-md-3 col-sm-3\'>\r\n                                    ");
#nullable restore
#line 56 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterDropdown\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.ModifiedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\'col-form-label col-md-9 col-sm-9\'>\r\n                                    ");
#nullable restore
#line 59 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterDropdown\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.ModifiedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\'form-group row\'>\r\n                                <div class=\'col-form-label col-md-3 col-sm-3\'>\r\n                                    ");
#nullable restore
#line 64 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterDropdown\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\'col-form-label col-md-9 col-sm-9\'>\r\n                                    ");
#nullable restore
#line 67 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterDropdown\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\'form-group row\'>\r\n                                <div class=\'col-form-label col-md-3 col-sm-3\'>\r\n                                    ");
#nullable restore
#line 72 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterDropdown\Delete.cshtml"
                               Write(Html.DisplayNameFor(model => model.ModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\'col-form-label col-md-9 col-sm-9\'>\r\n                                    ");
#nullable restore
#line 75 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterDropdown\Delete.cshtml"
                               Write(Html.DisplayFor(model => model.ModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class='ln_solid'></div>
                    <div class='row'>
                        <div class='col-md-6'>
                            <div class='form-group row'>
                                <div class='offset-md-3 col-md-9 col-sm-9'>
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d569633c702279ec35cdbeaf6171a5d36b67437d14623", async() => {
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d569633c702279ec35cdbeaf6171a5d36b67437d14922", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 86 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterDropdown\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        <input type=\'submit\' value=\'Delete\' class=\'btn btn-danger\' />\r\n                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PKBL.Domain.Entities.Master.M_Dropdown> Html { get; private set; }
    }
}
#pragma warning restore 1591
