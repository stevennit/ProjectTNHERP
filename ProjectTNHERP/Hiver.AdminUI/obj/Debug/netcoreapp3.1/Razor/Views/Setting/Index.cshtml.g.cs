#pragma checksum "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\Setting\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8cd06a21e7298015fdebe3a1250b19e60fcd7615"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Setting_Index), @"mvc.1.0.view", @"/Views/Setting/Index.cshtml")]
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
#line 1 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\_ViewImports.cshtml"
using Hiver.AdminUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\_ViewImports.cshtml"
using Hiver.AdminUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8cd06a21e7298015fdebe3a1250b19e60fcd7615", @"/Views/Setting/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcfc5c5ebe59075999039033919dcf135362289c", @"/Views/_ViewImports.cshtml")]
    public class Views_Setting_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\Setting\Index.cshtml"
  
    ViewData["Title"] = "Cài đặt Chính";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral(@"
<!-- begin #sidebar -->
<div id=""sidebar"" class=""sidebar"">
    <!-- begin sidebar scrollbar -->
    <div data-scrollbar=""true"" data-height=""100%"">
        <!-- begin sidebar nav -->
        <ul class=""nav"">
            <li class=""nav-header"">Chức năng</li>
            <li>
                <a href=""widget.html"">
                    <i class=""fab fa-simplybuilt""></i>
                    <span>Widgets</span>
                </a>
            </li>
            <!-- begin sidebar minify button -->
            <li><a href=""javascript:;"" class=""sidebar-minify-btn"" data-click=""sidebar-minify""><i class=""fa fa-angle-double-left""></i></a></li>
            <!-- end sidebar minify button -->
        </ul>
        <!-- end sidebar nav -->
    </div>
    <!-- end sidebar scrollbar -->
</div>
<div class=""sidebar-bg""></div>
<!-- end #sidebar -->

<!-- begin #content -->
<div id=""content"" class=""content"">
    <!-- begin breadcrumb -->
    <ol class=""breadcrumb float-xl-right"">
        <li class=""br");
            WriteLiteral(@"eadcrumb-item""><a href=""javascript:;"">Home</a></li>
        <li class=""breadcrumb-item""><a href=""javascript:;"">Page Options</a></li>
        <li class=""breadcrumb-item active"">Page with Two Sidebar</li>
    </ol>
    <!-- end breadcrumb -->
    <!-- begin page-header -->
    <h1 class=""page-header"">Page with Two Sidebar <small>header small text goes here...</small></h1>
    <!-- end page-header -->
    <!-- begin panel -->
    <div class=""panel panel-inverse"">
        <div class=""panel-heading"">
            <h4 class=""panel-title"">Panel Title here</h4>
            <div class=""panel-heading-btn"">
                <a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-default"" data-click=""panel-expand""><i class=""fa fa-expand""></i></a>
                <a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-success"" data-click=""panel-reload""><i class=""fa fa-redo""></i></a>
                <a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-warning"" data-click=""panel-co");
            WriteLiteral(@"llapse""><i class=""fa fa-minus""></i></a>
                <a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-danger"" data-click=""panel-remove""><i class=""fa fa-times""></i></a>
            </div>
        </div>
        <div class=""panel-body"">
            Panel Content Here
        </div>
    </div>
    <!-- end panel -->
</div>
<!-- end #content -->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
