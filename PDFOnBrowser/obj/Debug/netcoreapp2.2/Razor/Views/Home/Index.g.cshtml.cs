#pragma checksum "D:\JT\CoreProgramm\Blog\.NET Core\PDFOnBrowser\PDFOnBrowser\PDFOnBrowser\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15995bdb8c6fedd1837d8d2ac337671748b1d333"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\JT\CoreProgramm\Blog\.NET Core\PDFOnBrowser\PDFOnBrowser\PDFOnBrowser\Views\_ViewImports.cshtml"
using PDFOnBrowser;

#line default
#line hidden
#line 2 "D:\JT\CoreProgramm\Blog\.NET Core\PDFOnBrowser\PDFOnBrowser\PDFOnBrowser\Views\_ViewImports.cshtml"
using PDFOnBrowser.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15995bdb8c6fedd1837d8d2ac337671748b1d333", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6640c0b2b65855a6fe68b8e739f657513b67dcb1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\JT\CoreProgramm\Blog\.NET Core\PDFOnBrowser\PDFOnBrowser\PDFOnBrowser\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 129, true);
            WriteLiteral("<script type=\"text/javascript\">\r\n    function OpenPDFByPath() {\r\n        $.ajax({\r\n            method: \'GET\',\r\n            url: \'");
            EndContext();
            BeginContext(175, 33, false);
#line 8 "D:\JT\CoreProgramm\Blog\.NET Core\PDFOnBrowser\PDFOnBrowser\PDFOnBrowser\Views\Home\Index.cshtml"
             Write(Url.Action("OpenPDFPath", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(208, 312, true);
            WriteLiteral(@"',
            data: {}
        }).done(function (data, statusText, xhdr) {
            var URL = ""../"" + data;
            window.open(URL, """", ""width=700,height=600"");
        }).fail(function (xhdr, statusText, errorText) {

        });
    }
    function OpenPDFHidingPath() {
        window.open('");
            EndContext();
            BeginContext(521, 29, false);
#line 18 "D:\JT\CoreProgramm\Blog\.NET Core\PDFOnBrowser\PDFOnBrowser\PDFOnBrowser\Views\Home\Index.cshtml"
                Write(Url.Action("OpenPDF", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(550, 391, true);
            WriteLiteral(@"', """", ""width=700,height=600"")
    }
</script>
<div class=""row"">
    <div class=""col-md-6"">
      <h2>PDF Open with Physical Path</h2> <a href=""#"" onclick=""OpenPDFByPath()"">Click here to Open PDF</a> 
    </div>
    <div class=""col-md-6"">
        <h2>PDF Open with hiding Physical Path</h2> <a href=""#"" onclick=""OpenPDFHidingPath()"">Click here to Open PDF</a>  
    </div>
</div>
");
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
