#pragma checksum "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterSektorKemitraan\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c4bd266671feaf3099ad6b29c996725c10179d33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MasterSektorKemitraan_Details), @"mvc.1.0.view", @"/Views/MasterSektorKemitraan/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c4bd266671feaf3099ad6b29c996725c10179d33", @"/Views/MasterSektorKemitraan/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c4b14b0d1e0c8e6b258c5c7986d582bab4f80f4", @"/Views/_ViewImports.cshtml")]
    public class Views_MasterSektorKemitraan_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PKBL.Domain.Entities.Master.M_SektorKemitraan>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterSektorKemitraan\Details.cshtml"
  
    ViewData["Title"] = "Delete Master Sektor Kemitraan";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\'row\'>\r\n    <div class=\'col-md-12 col-sm-12\'>\r\n        <div class=\'x_panel\'>\r\n            <div class=\'x_title no-padding\'>\r\n                <h2>");
#nullable restore
#line 10 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterSektorKemitraan\Details.cshtml"
               Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <div class=\'nav navbar-right panel_toolbox\'>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4bd266671feaf3099ad6b29c996725c10179d335323", async() => {
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
#line 23 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterSektorKemitraan\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.Sector_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\'col-form-label col-md-9 col-sm-9\'>\r\n                                    ");
#nullable restore
#line 26 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterSektorKemitraan\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Sector_Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\'form-group row\'>\r\n                                <div class=\'col-form-label col-md-3 col-sm-3\'>\r\n                                    ");
#nullable restore
#line 31 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterSektorKemitraan\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.Remarks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\'col-form-label col-md-9 col-sm-9\'>\r\n                                    ");
#nullable restore
#line 34 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterSektorKemitraan\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Remarks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\'form-group row\'>\r\n                                <div class=\'col-form-label col-md-3 col-sm-3\'>\r\n                                    ");
#nullable restore
#line 39 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterSektorKemitraan\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\'col-form-label col-md-9 col-sm-9\'>\r\n                                    ");
#nullable restore
#line 42 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterSektorKemitraan\Details.cshtml"
                               Write(Html.DisplayFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\'form-group row\'>\r\n                                <div class=\'col-form-label col-md-3 col-sm-3\'>\r\n                                    ");
#nullable restore
#line 47 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterSektorKemitraan\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.ModifiedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\'col-form-label col-md-9 col-sm-9\'>\r\n                                    ");
#nullable restore
#line 50 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterSektorKemitraan\Details.cshtml"
                               Write(Html.DisplayFor(model => model.ModifiedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\'form-group row\'>\r\n                                <div class=\'col-form-label col-md-3 col-sm-3\'>\r\n                                    ");
#nullable restore
#line 55 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterSektorKemitraan\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\'col-form-label col-md-9 col-sm-9\'>\r\n                                    ");
#nullable restore
#line 58 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterSektorKemitraan\Details.cshtml"
                               Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\'form-group row\'>\r\n                                <div class=\'col-form-label col-md-3 col-sm-3\'>\r\n                                    ");
#nullable restore
#line 63 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterSektorKemitraan\Details.cshtml"
                               Write(Html.DisplayNameFor(model => model.ModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\'col-form-label col-md-9 col-sm-9\'>\r\n                                    ");
#nullable restore
#line 66 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterSektorKemitraan\Details.cshtml"
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4bd266671feaf3099ad6b29c996725c10179d3313398", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterSektorKemitraan\Details.cshtml"
                                                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PKBL.Domain.Entities.Master.M_SektorKemitraan> Html { get; private set; }
    }
}
#pragma warning restore 1591
