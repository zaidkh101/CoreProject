#pragma checksum "C:\Users\GTS\Desktop\Training\CoreProjectRemasterd\Views\Shared\_OurSuppliers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02fbed3631847400af2fdfe039711e7651b22e0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__OurSuppliers), @"mvc.1.0.view", @"/Views/Shared/_OurSuppliers.cshtml")]
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
#line 1 "C:\Users\GTS\Desktop\Training\CoreProjectRemasterd\Views\_ViewImports.cshtml"
using CoreProjectRemasterd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\GTS\Desktop\Training\CoreProjectRemasterd\Views\_ViewImports.cshtml"
using CoreProjectRemasterd.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02fbed3631847400af2fdfe039711e7651b22e0e", @"/Views/Shared/_OurSuppliers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c78a5f6aef0b13db8422c24a2d1f624fab6e8ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__OurSuppliers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<section id=""aa-agents"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""aa-agents-area"">
                    <div class=""aa-title"">
                        <h2>Our Suppliers</h2>
                        <span></span>
                        <p>Suppliers</p>
                    </div>
                    <!-- agents content -->
                    <div class=""aa-agents-content"">
                       ");
#nullable restore
#line 13 "C:\Users\GTS\Desktop\Training\CoreProjectRemasterd\Views\Shared\_OurSuppliers.cshtml"
                  Write(await Component.InvokeAsync("Supplier"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
