#pragma checksum "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\HotelRooms\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9c1b41011e60cc1a50c0d53b06ed0d5fee8fe37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HotelRooms_Index), @"mvc.1.0.view", @"/Views/HotelRooms/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9c1b41011e60cc1a50c0d53b06ed0d5fee8fe37", @"/Views/HotelRooms/Index.cshtml")]
    public class Views_HotelRooms_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelApi.Models.HotelRoom>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\HotelRooms\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\HotelRooms\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\HotelRooms\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PetFriendly));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\HotelRooms\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Amenities));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\HotelRooms\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\HotelRooms\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\HotelRooms\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PetFriendly));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\HotelRooms\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Amenities));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 976, "\"", 999, 1);
#nullable restore
#line 40 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\HotelRooms\Index.cshtml"
WriteAttributeValue("", 991, item.Id, 991, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1052, "\"", 1075, 1);
#nullable restore
#line 41 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\HotelRooms\Index.cshtml"
WriteAttributeValue("", 1067, item.Id, 1067, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1130, "\"", 1153, 1);
#nullable restore
#line 42 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\HotelRooms\Index.cshtml"
WriteAttributeValue("", 1145, item.Id, 1145, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\HotelRooms\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelApi.Models.HotelRoom>> Html { get; private set; }
    }
}
#pragma warning restore 1591
