#pragma checksum "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\CustomLayout\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c764bb840bb1bde8213450821e5d100a4efa45f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_CustomLayout__Header), @"mvc.1.0.view", @"/Views/Shared/CustomLayout/_Header.cshtml")]
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
#line 1 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\_ViewImports.cshtml"
using Hiver.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\_ViewImports.cshtml"
using Hiver.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\_ViewImports.cshtml"
using Hiver.WebApp.CustomAttributes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c764bb840bb1bde8213450821e5d100a4efa45f7", @"/Views/Shared/CustomLayout/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d8b91c53108d6d92cecbd0a8200031e2a0ddd47", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_CustomLayout__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""main-header navbar navbar-expand navbar-white navbar-light"">
    <!-- Left navbar links -->
    <ul class=""navbar-nav"">
        <li class=""nav-item"">
            <a class=""nav-link"" data-widget=""pushmenu"" href=""#"" role=""button""><i class=""fas fa-bars""></i></a>
        </li>
        <li class=""nav-item d-none d-sm-inline-block"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c764bb840bb1bde8213450821e5d100a4efa45f75631", async() => {
                WriteLiteral("Trang Chủ");
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
            WriteLiteral(@"
        </li>
        <li class=""nav-item d-none d-sm-inline-block"">
            <a href=""#"" class=""nav-link"">Báo Lỗi</a>
        </li>
    </ul>

    <!-- Right navbar links -->
    <ul class=""navbar-nav ml-auto"">
        <!-- Messages Dropdown Menu -->
        <li class=""nav-item dropdown"">
            <a class=""nav-link"" data-toggle=""dropdown"" href=""#"">
                <i class=""far fa-comments""></i>
                <span class=""badge badge-danger navbar-badge"">3</span>
            </a>
            <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-right"">
                <a href=""#"" class=""dropdown-item"">
                    <!-- Message Start -->
                    <div class=""media"">
                        <img src=""../../dist/img/user1-128x128.jpg"" alt=""User Avatar"" class=""img-size-50 mr-3 img-circle"">
                        <div class=""media-body"">
                            <h3 class=""dropdown-item-title"">
                                Brad Diesel
                 ");
            WriteLiteral(@"               <span class=""float-right text-sm text-danger""><i class=""fas fa-star""></i></span>
                            </h3>
                            <p class=""text-sm"">Call me whenever you can...</p>
                            <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
                        </div>
                    </div>
                    <!-- Message End -->
                </a>
                <div class=""dropdown-divider""></div>
                <a href=""#"" class=""dropdown-item"">
                    <!-- Message Start -->
                    <div class=""media"">
                        <img src=""../../dist/img/user8-128x128.jpg"" alt=""User Avatar"" class=""img-size-50 img-circle mr-3"">
                        <div class=""media-body"">
                            <h3 class=""dropdown-item-title"">
                                John Pierce
                                <span class=""float-right text-sm text-muted""><i class=""fas fa-star""></i></s");
            WriteLiteral(@"pan>
                            </h3>
                            <p class=""text-sm"">I got your message bro</p>
                            <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
                        </div>
                    </div>
                    <!-- Message End -->
                </a>
                <div class=""dropdown-divider""></div>
                <a href=""#"" class=""dropdown-item"">
                    <!-- Message Start -->
                    <div class=""media"">
                        <img src=""../../dist/img/user3-128x128.jpg"" alt=""User Avatar"" class=""img-size-50 img-circle mr-3"">
                        <div class=""media-body"">
                            <h3 class=""dropdown-item-title"">
                                Nora Silvester
                                <span class=""float-right text-sm text-warning""><i class=""fas fa-star""></i></span>
                            </h3>
                            <p class=""text-sm"">The");
            WriteLiteral(@" subject goes here</p>
                            <p class=""text-sm text-muted""><i class=""far fa-clock mr-1""></i> 4 Hours Ago</p>
                        </div>
                    </div>
                    <!-- Message End -->
                </a>
                <div class=""dropdown-divider""></div>
                <a href=""#"" class=""dropdown-item dropdown-footer"">Xem hết tin nhắn</a>
            </div>
        </li>
        <!-- Notifications Dropdown Menu -->
        <li class=""nav-item dropdown"">
            <a class=""nav-link"" data-toggle=""dropdown"" href=""#"">
                <i class=""far fa-bell""></i>
                <span class=""badge badge-warning navbar-badge"">15</span>
            </a>
            <div class=""dropdown-menu dropdown-menu-lg dropdown-menu-right"">
                <span class=""dropdown-item dropdown-header"">15 Notifications</span>
                <div class=""dropdown-divider""></div>
                <a href=""#"" class=""dropdown-item"">
                    <i class=""fa");
            WriteLiteral(@"s fa-envelope mr-2""></i> 4 new messages
                    <span class=""float-right text-muted text-sm"">3 mins</span>
                </a>
                <div class=""dropdown-divider""></div>
                <a href=""#"" class=""dropdown-item"">
                    <i class=""fas fa-users mr-2""></i> 8 friend requests
                    <span class=""float-right text-muted text-sm"">12 hours</span>
                </a>
                <div class=""dropdown-divider""></div>
                <a href=""#"" class=""dropdown-item"">
                    <i class=""fas fa-file mr-2""></i> 3 new reports
                    <span class=""float-right text-muted text-sm"">2 days</span>
                </a>
                <div class=""dropdown-divider""></div>
                <a href=""#"" class=""dropdown-item dropdown-footer"">Xem hết thông báo</a>
            </div>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" id=""userDropdown"" href=""#"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""tr");
            WriteLiteral(@"ue"" aria-expanded=""false"">
                <i class=""fas fa-users-cog""></i>
            </a>
            
            <div class=""dropdown-menu dropdown-menu-right"" aria-labelledby=""userDropdown"">
                <a class=""dropdown-item"" href=""/User/Index"">");
#nullable restore
#line 108 "D:\Project Code\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\CustomLayout\_Header.cshtml"
                                                       Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                <a class=\"dropdown-item\" href=\"#\">Activity Log</a>\r\n                <div class=\"dropdown-divider\"></div>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c764bb840bb1bde8213450821e5d100a4efa45f712969", async() => {
                WriteLiteral("\r\n                    <button type=\"submit\" class=\"dropdown-item\">Đăng xuất</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </li>\r\n    </ul>\r\n</nav>");
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
