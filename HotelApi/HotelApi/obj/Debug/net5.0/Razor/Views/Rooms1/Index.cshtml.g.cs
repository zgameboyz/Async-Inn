#pragma checksum "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\Rooms1\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f481afd42e9ce94068b94fe5c38eee3e22c1ab6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rooms1_Index), @"mvc.1.0.view", @"/Views/Rooms1/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f481afd42e9ce94068b94fe5c38eee3e22c1ab6a", @"/Views/Rooms1/Index.cshtml")]
    public class Views_Rooms1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelApi.Models.Room>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\Rooms1\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\Rooms1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\Rooms1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Layout));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\Rooms1\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Amenities));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\Rooms1\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\Rooms1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\Rooms1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Layout));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\Rooms1\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Amenities));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 961, "\"", 984, 1);
#nullable restore
#line 40 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\Rooms1\Index.cshtml"
WriteAttributeValue("", 976, item.ID, 976, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1037, "\"", 1060, 1);
#nullable restore
#line 41 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\Rooms1\Index.cshtml"
WriteAttributeValue("", 1052, item.ID, 1052, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1115, "\"", 1138, 1);
#nullable restore
#line 42 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\Rooms1\Index.cshtml"
WriteAttributeValue("", 1130, item.ID, 1130, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 45 "C:\Users\joelc\Documents\projects\codefellows\401\Labs\Lab11\HotelApi\HotelApi\Views\Rooms1\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelApi.Models.Room>> Html { get; private set; }
    }
}
#pragma warning restore 1591
