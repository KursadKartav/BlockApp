#pragma checksum "C:\Users\PC\Desktop\BlockApp\BlockApp.WebUI\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c7153a19a7b291bb67897c9415a609acfe47560"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Index.cshtml", typeof(AspNetCore.Views_Blog_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c7153a19a7b291bb67897c9415a609acfe47560", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f4c4ed5ac3e278df4824cedd041440483ff138b", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\PC\Desktop\BlockApp\BlockApp.WebUI\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(67, 101, true);
            WriteLiteral("\r\n<div class=\"container mt-3\">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col-md-3\">\r\n            ");
            EndContext();
            BeginContext(169, 43, false);
#line 10 "C:\Users\PC\Desktop\BlockApp\BlockApp.WebUI\Views\Blog\Index.cshtml"
       Write(await Component.InvokeAsync("CategoryMenu"));

#line default
#line hidden
            EndContext();
            BeginContext(212, 64, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n\r\n            ");
            EndContext();
            BeginContext(277, 32, false);
#line 14 "C:\Users\PC\Desktop\BlockApp\BlockApp.WebUI\Views\Blog\Index.cshtml"
       Write(Html.Partial("_BlogList", Model));

#line default
#line hidden
            EndContext();
            BeginContext(309, 36, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591