#pragma checksum "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\Shared\_Layout_noneSide.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "627fadd733100dd876718f8101c0665e4d3728a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout_noneSide), @"mvc.1.0.view", @"/Views/Shared/_Layout_noneSide.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"627fadd733100dd876718f8101c0665e4d3728a6", @"/Views/Shared/_Layout_noneSide.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fcfc5c5ebe59075999039033919dcf135362289c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout_noneSide : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("home-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("home-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("home-title", "Trang Chủ", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::BootstrapBreadcrumbs.Core.TagHelpers.BreadcrumbsNavTagHelper __BootstrapBreadcrumbs_Core_TagHelpers_BreadcrumbsNavTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "627fadd733100dd876718f8101c0665e4d3728a64573", async() => {
                WriteLiteral("\r\n    <meta http-equiv=\"content-type\" content=\"text/html;charset=UTF-8\" />\r\n    <meta charset=\"utf-8\" />\r\n    <title>TNH ERP - ");
#nullable restore
#line 6 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\Shared\_Layout_noneSide.cshtml"
                Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no, shrink-to-fit=no"" />
    <link rel=""apple-touch-icon"" href=""pages/ico/60.png"">
    <link rel=""apple-touch-icon"" sizes=""76x76"" href=""pages/ico/76.png"">
    <link rel=""apple-touch-icon"" sizes=""120x120"" href=""pages/ico/120.png"">
    <link rel=""apple-touch-icon"" sizes=""152x152"" href=""pages/ico/152.png"">
    <link rel=""icon"" type=""image/x-icon"" href=""favicon.ico"" />
    <meta name=""apple-mobile-web-app-capable"" content=""yes"">
    <meta name=""apple-touch-fullscreen"" content=""yes"">
    <meta name=""apple-mobile-web-app-status-bar-style"" content=""default"">
    <meta content=""Meet pages - The simplest and fastest way to build web UI for your dashboard or app."" name=""description"" />
    <meta content=""Ace"" name=""author"" />

    <!-- ================== BEGIN BASE CSS STYLE ================== -->
    <link href=""/custom/scss/customSCSS.min.css"" rel=""stylesheet"" />
    <link href=""/assets/c");
                WriteLiteral("ss/default/app.min.css\" rel=\"stylesheet\" />\r\n    <!-- ================== END BASE CSS STYLE ================== -->\r\n    <!-- Customer -->\r\n    <link href=\"/custom/scss/customSCSS.css\" rel=\"stylesheet\" />\r\n\r\n    ");
#nullable restore
#line 26 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\Shared\_Layout_noneSide.cshtml"
Write(RenderSection("Css", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "627fadd733100dd876718f8101c0665e4d3728a67538", async() => {
                WriteLiteral("\r\n    <!-- begin #page-loader -->\r\n    <div id=\"page-loader\" class=\"fade show\">\r\n        <span class=\"spinner\"></span>\r\n    </div>\r\n    <!-- end #page-loader -->\r\n    <!-- begin #page-container -->\r\n    <div id=\"page-container\"");
                BeginWriteAttribute("class", " class=\"", 1705, "\"", 1776, 4);
                WriteAttributeValue("", 1713, "fade", 1713, 4, true);
                WriteAttributeValue(" ", 1717, "page-without-sidebar", 1718, 21, true);
                WriteAttributeValue(" ", 1738, "page-header-fixed", 1739, 18, true);
#nullable restore
#line 36 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\Shared\_Layout_noneSide.cshtml"
WriteAttributeValue(" ", 1756, ViewBag.PageOption, 1757, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n        <!-- begin #header -->\r\n        ");
#nullable restore
#line 38 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\Shared\_Layout_noneSide.cshtml"
   Write(await Html.PartialAsync("~/Views/Shared/CustomLayout/_Header.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <!-- end #header -->\r\n\r\n");
#nullable restore
#line 41 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\Shared\_Layout_noneSide.cshtml"
         if (ViewBag.LayoutPageContent == null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <!-- begin #content -->\r\n            <div id=\"content\" class=\"content\">\r\n                <!-- begin breadcrumb -->\r\n                <ol class=\"breadcrumb float-xl-right\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("breadcrumbs-nav", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "627fadd733100dd876718f8101c0665e4d3728a69556", async() => {
                }
                );
                __BootstrapBreadcrumbs_Core_TagHelpers_BreadcrumbsNavTagHelper = CreateTagHelper<global::BootstrapBreadcrumbs.Core.TagHelpers.BreadcrumbsNavTagHelper>();
                __tagHelperExecutionContext.Add(__BootstrapBreadcrumbs_Core_TagHelpers_BreadcrumbsNavTagHelper);
                __BootstrapBreadcrumbs_Core_TagHelpers_BreadcrumbsNavTagHelper.HomeAction = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __BootstrapBreadcrumbs_Core_TagHelpers_BreadcrumbsNavTagHelper.HomeController = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __BootstrapBreadcrumbs_Core_TagHelpers_BreadcrumbsNavTagHelper.HomeTitle = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </ol>\r\n                <!-- end breadcrumb -->\r\n                <!-- begin page-header -->\r\n                <h1 class=\"page-header\">");
#nullable restore
#line 51 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\Shared\_Layout_noneSide.cshtml"
                                   Write(ViewBag.PageTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(" A<small>");
#nullable restore
#line 51 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\Shared\_Layout_noneSide.cshtml"
                                                              Write(ViewBag.PageDescriptionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</small></h1>
                <!-- end page-header -->
                <!-- begin panel -->
                <div class=""panel panel-inverse"">
                    <div class=""panel-heading"">
                        <h4 class=""panel-title"">Panel Title here</h4>
                        <div class=""panel-heading-btn"">
                            <a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-default"" data-click=""panel-expand""><i class=""fa fa-expand""></i></a>
                            <a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-success"" data-click=""panel-reload""><i class=""fa fa-redo""></i></a>
                            <a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-warning"" data-click=""panel-collapse""><i class=""fa fa-minus""></i></a>
                            <a href=""javascript:;"" class=""btn btn-xs btn-icon btn-circle btn-danger"" data-click=""panel-remove""><i class=""fa fa-times""></i></a>
                        </div>
                    </di");
                WriteLiteral("v>\r\n                    <div class=\"panel-body\">\r\n                        ");
#nullable restore
#line 65 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\Shared\_Layout_noneSide.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <!-- end panel -->\r\n            </div>\r\n            <!-- end #content -->\r\n");
#nullable restore
#line 71 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\Shared\_Layout_noneSide.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <!-- begin #content -->\r\n            <div id=\"content\"");
                BeginWriteAttribute("class", " class=\"", 3853, "\"", 3895, 2);
                WriteAttributeValue("", 3861, "content", 3861, 7, true);
#nullable restore
#line 75 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\Shared\_Layout_noneSide.cshtml"
WriteAttributeValue(" ", 3868, ViewBag.LayoutPageContent, 3869, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                ");
#nullable restore
#line 76 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\Shared\_Layout_noneSide.cshtml"
           Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <!-- end #content -->\r\n");
#nullable restore
#line 79 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\Shared\_Layout_noneSide.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <!-- begin scroll to top btn -->
        <a href=""javascript:;"" class=""btn btn-icon btn-circle btn-success btn-scroll-to-top fade"" data-click=""scroll-top""><i class=""fa fa-angle-up""></i></a>
        <!-- end scroll to top btn -->
    </div>
    <!-- end page container -->
    <!-- ================== BEGIN BASE JS ================== -->
    <script src=""/assets/js/app.min.js""></script>
");
                WriteLiteral("    <!-- ================== END BASE JS ================== -->\r\n\r\n\r\n\r\n    ");
#nullable restore
#line 92 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.AdminUI\Views\Shared\_Layout_noneSide.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
