#pragma checksum "D:\workplace\term4\COMP4976\lab02\AspcoreMvc\Views\Process\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f90b118e3376be2c237351e68b72d8323bb7d9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Process_Welcome), @"mvc.1.0.view", @"/Views/Process/Welcome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Process/Welcome.cshtml", typeof(AspNetCore.Views_Process_Welcome))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f90b118e3376be2c237351e68b72d8323bb7d9f", @"/Views/Process/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c27651f6451128749b5128e928f492ccd26ddad", @"/Views/_ViewImports.cshtml")]
    public class Views_Process_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Process>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Process", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Display", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\workplace\term4\COMP4976\lab02\AspcoreMvc\Views\Process\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";

#line default
#line hidden
            BeginContext(74, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(81, 17, false);
#line 7 "D:\workplace\term4\COMP4976\lab02\AspcoreMvc\Views\Process\Welcome.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(98, 15, true);
            WriteLiteral("</h1>\r\n\r\n<ul>\r\n");
            EndContext();
#line 10 "D:\workplace\term4\COMP4976\lab02\AspcoreMvc\Views\Process\Welcome.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(154, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(162, 149, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f90b118e3376be2c237351e68b72d8323bb7d9f4796", async() => {
                BeginContext(261, 14, true);
                WriteLiteral("\r\n        <li>");
                EndContext();
                BeginContext(276, 16, false);
#line 16 "D:\workplace\term4\COMP4976\lab02\AspcoreMvc\Views\Process\Welcome.cshtml"
       Write(item.ProcessName);

#line default
#line hidden
                EndContext();
                BeginContext(292, 15, true);
                WriteLiteral("</li>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 15 "D:\workplace\term4\COMP4976\lab02\AspcoreMvc\Views\Process\Welcome.cshtml"
         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(311, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 18 "D:\workplace\term4\COMP4976\lab02\AspcoreMvc\Views\Process\Welcome.cshtml"
    }

#line default
#line hidden
            BeginContext(320, 9, true);
            WriteLiteral("</ul>\r\n\r\n");
            EndContext();
            BeginContext(330, 33, false);
#line 21 "D:\workplace\term4\COMP4976\lab02\AspcoreMvc\Views\Process\Welcome.cshtml"
Write(Html.Partial("_BogusPartialView"));

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Process>> Html { get; private set; }
    }
}
#pragma warning restore 1591
