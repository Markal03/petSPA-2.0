#pragma checksum "C:\Users\Marco03\Desktop\petSPA-2.0\Views\Pet\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15f385a6010dc5f5082dbd04974dfbf13776caca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pet_Welcome), @"mvc.1.0.view", @"/Views/Pet/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pet/Welcome.cshtml", typeof(AspNetCore.Views_Pet_Welcome))]
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
#line 1 "C:\Users\Marco03\Desktop\petSPA-2.0\Views\_ViewImports.cshtml"
using PetSPA;

#line default
#line hidden
#line 2 "C:\Users\Marco03\Desktop\petSPA-2.0\Views\_ViewImports.cshtml"
using PetSPA.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15f385a6010dc5f5082dbd04974dfbf13776caca", @"/Views/Pet/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6337f8570f3e9e9d23cb084b76e378f737091924", @"/Views/_ViewImports.cshtml")]
    public class Views_Pet_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Marco03\Desktop\petSPA-2.0\Views\Pet\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
            BeginContext(43, 28, true);
            WriteLiteral("\r\n<h2>Welcome</h2>\r\n\r\n<ul>\r\n");
            EndContext();
#line 8 "C:\Users\Marco03\Desktop\petSPA-2.0\Views\Pet\Welcome.cshtml"
     for (int i = 0; i < (int)ViewData["NumTimes"]; i++)
    {

#line default
#line hidden
            BeginContext(136, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(149, 19, false);
#line 10 "C:\Users\Marco03\Desktop\petSPA-2.0\Views\Pet\Welcome.cshtml"
       Write(ViewData["Message"]);

#line default
#line hidden
            EndContext();
            BeginContext(168, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 11 "C:\Users\Marco03\Desktop\petSPA-2.0\Views\Pet\Welcome.cshtml"
    }

#line default
#line hidden
            BeginContext(182, 5, true);
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
