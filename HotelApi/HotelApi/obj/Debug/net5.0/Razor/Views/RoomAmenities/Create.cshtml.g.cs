#pragma checksum "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\RoomAmenities\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44bb3deba7d7e87bdca19c5ab720fd3801ea5f66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RoomAmenities_Create), @"mvc.1.0.view", @"/Views/RoomAmenities/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44bb3deba7d7e87bdca19c5ab720fd3801ea5f66", @"/Views/RoomAmenities/Create.cshtml")]
    public class Views_RoomAmenities_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelApi.Models.RoomAmenities>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\RoomAmenities\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>RoomAmenities</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Layout"" class=""control-label""></label>
                <input asp-for=""Layout"" class=""form-control"" />
                <span asp-validation-for=""Layout"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Amenities"" class=""control-label""></label>
                <input asp-for=""Amenities"" class=""form-control"" />
                <span asp-validation-for=""Amenities"" class=""text-danger""></span>
   ");
            WriteLiteral(@"         </div>
            <div class=""form-group"">
                <label asp-for=""Room"" class=""control-label""></label>
                <input asp-for=""Room"" class=""form-control"" />
                <span asp-validation-for=""Room"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 47 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\RoomAmenities\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelApi.Models.RoomAmenities> Html { get; private set; }
    }
}
#pragma warning restore 1591
