#pragma checksum "D:\workplace\term4\COMP4976\lab02\AspcoreMvc\Views\Process\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "363959014338f4f0fe6a42aa8b2b4ef503e84f62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Process_Index), @"mvc.1.0.view", @"/Views/Process/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Process/Index.cshtml", typeof(AspNetCore.Views_Process_Index))]
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
#line 1 "D:\workplace\term4\COMP4976\lab02\AspcoreMvc\Views\_ViewImports.cshtml"
using AspcoreMvc;

#line default
#line hidden
#line 2 "D:\workplace\term4\COMP4976\lab02\AspcoreMvc\Views\_ViewImports.cshtml"
using AspcoreMvc.Models;

#line default
#line hidden
#line 4 "D:\workplace\term4\COMP4976\lab02\AspcoreMvc\Views\_ViewImports.cshtml"
using System.Diagnostics;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"363959014338f4f0fe6a42aa8b2b4ef503e84f62", @"/Views/Process/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c27651f6451128749b5128e928f492ccd26ddad", @"/Views/_ViewImports.cshtml")]
    public class Views_Process_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\workplace\term4\COMP4976\lab02\AspcoreMvc\Views\Process\Index.cshtml"
  
    ViewData["Title"] = "Process";
    var p = ViewData["processes"] as System.Diagnostics.Process[];

#line default
#line hidden
            BeginContext(113, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(120, 17, false);
#line 7 "D:\workplace\term4\COMP4976\lab02\AspcoreMvc\Views\Process\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(137, 13, true);
            WriteLiteral("</h1>\r\n<ul>\r\n");
            EndContext();
#line 9 "D:\workplace\term4\COMP4976\lab02\AspcoreMvc\Views\Process\Index.cshtml"
     foreach (var item in p)
    {

#line default
#line hidden
            BeginContext(187, 12, true);
            WriteLiteral("        <li>");
            EndContext();
            BeginContext(200, 16, false);
#line 11 "D:\workplace\term4\COMP4976\lab02\AspcoreMvc\Views\Process\Index.cshtml"
       Write(item.ProcessName);

#line default
#line hidden
            EndContext();
            BeginContext(216, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 12 "D:\workplace\term4\COMP4976\lab02\AspcoreMvc\Views\Process\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(230, 7, true);
            WriteLiteral("</ul>\r\n");
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
