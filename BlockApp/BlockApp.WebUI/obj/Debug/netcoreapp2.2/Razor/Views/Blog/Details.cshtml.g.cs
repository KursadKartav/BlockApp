#pragma checksum "C:\Users\PC\Desktop\BlockApp\BlockApp.WebUI\Views\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a34d930f0ebf47196979e2e40cd60cc9c51e1c81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Details), @"mvc.1.0.view", @"/Views/Blog/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Details.cshtml", typeof(AspNetCore.Views_Blog_Details))]
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
#line 1 "C:\Users\PC\Desktop\BlockApp\BlockApp.WebUI\Views\_ViewImports.cshtml"
using BlogApp.WebUI.Models;

#line default
#line hidden
#line 2 "C:\Users\PC\Desktop\BlockApp\BlockApp.WebUI\Views\_ViewImports.cshtml"
using BlogApp.Entity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a34d930f0ebf47196979e2e40cd60cc9c51e1c81", @"/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f4c4ed5ac3e278df4824cedd041440483ff138b", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\PC\Desktop\BlockApp\BlockApp.WebUI\Views\Blog\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(56, 99, true);
            WriteLiteral("\r\n<div class=\"container mt-3\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            ");
            EndContext();
            BeginContext(156, 43, false);
#line 9 "C:\Users\PC\Desktop\BlockApp\BlockApp.WebUI\Views\Blog\Details.cshtml"
       Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(199, 150, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n            <div class=\"card mb-2\">\r\n                <div class=\"card-header\">\r\n                    ");
            EndContext();
            BeginContext(350, 11, false);
#line 14 "C:\Users\PC\Desktop\BlockApp\BlockApp.WebUI\Views\Blog\Details.cshtml"
               Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(361, 42, true);
            WriteLiteral("\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(403, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a34d930f0ebf47196979e2e40cd60cc9c51e1c814669", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 413, "~/img/", 413, 6, true);
#line 16 "C:\Users\PC\Desktop\BlockApp\BlockApp.WebUI\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 419, Model.Image, 419, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 16 "C:\Users\PC\Desktop\BlockApp\BlockApp.WebUI\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 459, Model.Title, 459, 12, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(473, 87, true);
            WriteLiteral("\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title\"> ");
            EndContext();
            BeginContext(561, 11, false);
#line 18 "C:\Users\PC\Desktop\BlockApp\BlockApp.WebUI\Views\Blog\Details.cshtml"
                                       Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(572, 49, true);
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\"> ");
            EndContext();
            BeginContext(622, 17, false);
#line 19 "C:\Users\PC\Desktop\BlockApp\BlockApp.WebUI\Views\Blog\Details.cshtml"
                                     Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(639, 47, true);
            WriteLiteral("</p>\r\n                    <p class=\"card-text\">");
            EndContext();
            BeginContext(687, 10, false);
#line 20 "C:\Users\PC\Desktop\BlockApp\BlockApp.WebUI\Views\Blog\Details.cshtml"
                                    Write(Model.Body);

#line default
#line hidden
            EndContext();
            BeginContext(697, 88, true);
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
