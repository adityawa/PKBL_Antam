#pragma checksum "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f8ea526114fcae22c128332590ee3c80648a9c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MasterMitra_Details), @"mvc.1.0.view", @"/Views/MasterMitra/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f8ea526114fcae22c128332590ee3c80648a9c7", @"/Views/MasterMitra/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c4b14b0d1e0c8e6b258c5c7986d582bab4f80f4", @"/Views/_ViewImports.cshtml")]
    public class Views_MasterMitra_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PKBL.Domain.Entities.Master.M_Mitra>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
  
    ViewData["Title"] = "Detail Master Mitra";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h4>");
#nullable restore
#line 6 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 10 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RequestorAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 13 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.RequestorAddress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AddressDistrict));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.AddressDistrict));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HomeOwnershipId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.HomeOwnershipId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RequestorPhone1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.RequestorPhone1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RequestorPhone2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.RequestorPhone2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.RequestorMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.RequestorMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MaritalStatusId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaritalStatusId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EducationLevelId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.EducationLevelId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyDataId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.CompanyDataId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Family_Relative_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Family_Relative_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Other_Relative_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Other_Relative_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Car_Mortage_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 79 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Car_Mortage_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 82 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Motorcycle_Mortage_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 85 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Motorcycle_Mortage_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 88 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Other_Mortage_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 91 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Other_Mortage_ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 94 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MortageRemarks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 97 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.MortageRemarks));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 100 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Administrative_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 103 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Administrative_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 106 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Production_Activity_Id1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 109 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Production_Activity_Id1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 112 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Production_Activity_Id2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 115 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Production_Activity_Id2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 118 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Production_Activity_Id3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 121 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Production_Activity_Id3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 124 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Production_Activity_Id4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 127 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Production_Activity_Id4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 130 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsProductHandMade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 133 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsProductHandMade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 136 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsMachineMade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 139 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsMachineMade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 142 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Owned_Tool1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 145 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Owned_Tool1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 148 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Owned_Tool1_count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 151 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Owned_Tool1_count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 154 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Owned_Tool2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 157 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Owned_Tool2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 160 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Owned_Tool2_count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 163 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Owned_Tool2_count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 166 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Owned_Tool3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 169 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Owned_Tool3));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 172 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Owned_Tool3_count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 175 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Owned_Tool3_count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 178 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Owned_Tool4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 181 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Owned_Tool4));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 184 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Owned_Tool4_count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 187 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Owned_Tool4_count));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 190 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Service_Provided));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 193 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Service_Provided));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 196 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Marketing));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 199 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Marketing));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 202 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsLocalMarket));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 205 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsLocalMarket));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 208 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IsExport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 211 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.IsExport));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 214 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Checklist_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 217 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.Checklist_Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 220 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UploadedFile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 223 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.UploadedFile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 226 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InventoryUpdateId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 229 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.InventoryUpdateId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 232 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MGRNoProposal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 235 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.MGRNoProposal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 238 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TglBermasalah));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 241 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.TglBermasalah));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 244 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 247 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 250 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ModifiedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 253 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.ModifiedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 256 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 259 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 262 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 265 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
       Write(Html.DisplayFor(model => model.ModifiedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f8ea526114fcae22c128332590ee3c80648a9c733545", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 270 "E:\Projects\Antam\PKBL\03 - Development\PKBL_Antam\PKBL.Web\Views\MasterMitra\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f8ea526114fcae22c128332590ee3c80648a9c735702", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PKBL.Domain.Entities.Master.M_Mitra> Html { get; private set; }
    }
}
#pragma warning restore 1591
