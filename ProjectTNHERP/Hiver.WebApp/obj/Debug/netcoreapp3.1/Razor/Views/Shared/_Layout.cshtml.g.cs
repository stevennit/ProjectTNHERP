#pragma checksum "C:\Users\Doanh\Source\Repos\Stevennit\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf641500dae39d58225370a43bcec91ce022260c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\Doanh\Source\Repos\Stevennit\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\_ViewImports.cshtml"
using Hiver.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Doanh\Source\Repos\Stevennit\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\_ViewImports.cshtml"
using Hiver.WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Doanh\Source\Repos\Stevennit\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\_ViewImports.cshtml"
using Hiver.WebApp.CustomAttributes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf641500dae39d58225370a43bcec91ce022260c", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d8b91c53108d6d92cecbd0a8200031e2a0ddd47", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sb-nav-fixed"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf641500dae39d58225370a43bcec91ce022260c3928", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\" />\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 260, "\"", 270, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <meta name=\"author\"");
                BeginWriteAttribute("content", " content=\"", 299, "\"", 309, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <title>");
#nullable restore
#line 11 "C:\Users\Doanh\Source\Repos\Stevennit\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\_Layout.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" - Administration</title>

    <!-- Font Awesome -->
    <link rel=""stylesheet"" href=""../plugins/fontawesome-free/css/all.min.css"">
    <!-- Ionicons -->
    <link rel=""stylesheet"" href=""https://code.ionicframework.com/ionicons/2.0.1/css/ionicons.min.css"">
    <!-- overlayScrollbars -->
    <link rel=""stylesheet"" href=""../dist/css/adminlte.min.css"">
    <!-- Google Font: Source Sans Pro -->
    <link href=""https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,400i,700"" rel=""stylesheet"">
    <link href=""../Style/site.css"" rel=""stylesheet"" />


    ");
#nullable restore
#line 24 "C:\Users\Doanh\Source\Repos\Stevennit\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\_Layout.cshtml"
Write(RenderSection("Css",required :false));

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf641500dae39d58225370a43bcec91ce022260c6617", async() => {
                WriteLiteral("\r\n    <!-- Site wrapper -->\r\n    <div class=\"wrapper\">\r\n\r\n        <!-- Navbar -->\r\n        ");
#nullable restore
#line 32 "C:\Users\Doanh\Source\Repos\Stevennit\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("~/Views/Shared/CustomLayout/_Header.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <!-- /.navbar -->\r\n        <!-- Main Sidebar Container -->\r\n        ");
#nullable restore
#line 35 "C:\Users\Doanh\Source\Repos\Stevennit\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("~/Views/Shared/CustomLayout/_SideMenu.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <!-- Content Wrapper. Contains page content -->\r\n        <div class=\"content-wrapper\">\r\n");
#nullable restore
#line 39 "C:\Users\Doanh\Source\Repos\Stevennit\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\_Layout.cshtml"
             if (TempData["AlertMessage"] != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div");
                BeginWriteAttribute("class", " class=\"", 1495, "\"", 1536, 3);
                WriteAttributeValue("", 1503, "alert", 1503, 5, true);
#nullable restore
#line 41 "C:\Users\Doanh\Source\Repos\Stevennit\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\_Layout.cshtml"
WriteAttributeValue(" ", 1508, TempData["AlertType"], 1509, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue(" ", 1531, "hide", 1532, 5, true);
                EndWriteAttribute();
                WriteLiteral(" role=\"alert\">\r\n                    ");
#nullable restore
#line 42 "C:\Users\Doanh\Source\Repos\Stevennit\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\_Layout.cshtml"
               Write(TempData["AlertMessage"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 44 "C:\Users\Doanh\Source\Repos\Stevennit\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\_Layout.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
#nullable restore
#line 45 "C:\Users\Doanh\Source\Repos\Stevennit\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
        </div>
        <!-- /.content-wrapper -->

        <footer class=""main-footer"">
            <div class=""float-right d-none d-sm-block"">
                <b>Version</b> 3.0.4
            </div>
            <strong>Copyright &copy; 2014-2019 <a href=""http://adminlte.io"">AdminLTE.io</a>.</strong> All rights
            reserved.
        </footer>

        <!-- Control Sidebar -->
        <aside class=""control-sidebar control-sidebar-dark"">
            <!-- Control sidebar content goes here -->
        </aside>
        <!-- /.control-sidebar -->
        ");
#nullable restore
#line 62 "C:\Users\Doanh\Source\Repos\Stevennit\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\_Layout.cshtml"
   Write(await Html.PartialAsync("/Views/Chat/Index.cshtml"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    </div>
    <!-- ./wrapper -->
    <!-- jQuery -->
    <script src=""../plugins/jquery/jquery.min.js""></script>
    <!-- Bootstrap 4 -->
    <script src=""../plugins/bootstrap/js/bootstrap.bundle.min.js""></script>
    <!-- AdminLTE App -->
    <script src=""../dist/js/adminlte.min.js""></script>
    <!-- AdminLTE for demo purposes -->
    <script src=""../dist/js/demo.js""></script>

    ");
#nullable restore
#line 74 "C:\Users\Doanh\Source\Repos\Stevennit\ProjectTNHERP\ProjectTNHERP\Hiver.WebApp\Views\Shared\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <script src=""../microsoft/signalr/dist/browser/signalr.js""></script>

    <script type=""text/javascript"">
        ""use strict"";

        var connection = new signalR.HubConnectionBuilder().withUrl(""/chatHub"").build();

        //Disable send button until connection is established
        document.getElementById(""sendButton"").disabled = true;

        connection.on(""ReceiveMessage"", function (user, message) {
            var li = document.createElement(""li"");

            document.getElementById(""messagesList1"").appendChild(li);
            // We can assign user-supplied strings to an element's textContent because it
            // is not interpreted as markup. If you're assigning in any other way, you
            // should be aware of possible script injection concerns.
            li.textContent = `${user} says ${message}`;
            //li.textContent =
            //    `<div class=""direct-chat-msg"">`
            //        + `<div class=""direct-chat-infos clearfix"">`
          ");
                WriteLiteral(@"  //            + `<span class=""direct-chat-name float-left"">${user}</span>`
            //            + `<span class=""direct-chat-timestamp float-right"">23 Jan 2:00 pm</span>`
            //        + `</div>`
            //        + `<img class=""direct-chat-img"" src=""../dist/img/user1-128x128.jpg"" alt=""Message User Image"">`
            //        + `<div class=""direct-chat-text"">`
            //        + `${message}`
            //        + `</div>`
            //    + `/div>`
            // ;
        });

        connection.start().then(function () {
            document.getElementById(""sendButton"").disabled = false;
        }).catch(function (err) {
            return console.error(err.toString());
        });

        document.getElementById(""sendButton"").addEventListener(""click"", function (event) {
            var user = document.getElementById(""userInput"").value;
            var message = document.getElementById(""messageInput"").value;
            connection.invoke(""SendMessage"", user,");
                WriteLiteral(" message).catch(function (err) {\r\n                return console.error(err.toString());\r\n            });\r\n            event.preventDefault();\r\n        });\r\n    </script>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
