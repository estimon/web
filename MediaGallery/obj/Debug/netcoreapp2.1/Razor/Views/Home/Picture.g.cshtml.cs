#pragma checksum "C:\Users\Martin Ploompuu\Desktop\New folder (4)\Polykas2018\14-AspNetCore\MediaGallery\Views\Home\Picture.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4659bc7f892c315067519bfd77b7a2fdbcc2ca1c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Picture), @"mvc.1.0.view", @"/Views/Home/Picture.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Picture.cshtml", typeof(AspNetCore.Views_Home_Picture))]
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
#line 1 "C:\Users\Martin Ploompuu\Desktop\New folder (4)\Polykas2018\14-AspNetCore\MediaGallery\Views\_ViewImports.cshtml"
using MediaGallery;

#line default
#line hidden
#line 2 "C:\Users\Martin Ploompuu\Desktop\New folder (4)\Polykas2018\14-AspNetCore\MediaGallery\Views\_ViewImports.cshtml"
using MediaGallery.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4659bc7f892c315067519bfd77b7a2fdbcc2ca1c", @"/Views/Home/Picture.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d6531bab7f76b3f92639632e531729d736eaa2a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Picture : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MediaGallery.Data.Photo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Sidebar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Martin Ploompuu\Desktop\New folder (4)\Polykas2018\14-AspNetCore\MediaGallery\Views\Home\Picture.cshtml"
  
    ViewData["Title"] = "Picture";

#line default
#line hidden
            BeginContext(108, 159, true);
            WriteLiteral("<div class=\"main\">\r\n    <div class=\"container\">        \r\n\r\n        <!-- BEGIN SIDEBAR & CONTENT -->\r\n        <div class=\"row margin-bottom-10\">\r\n\r\n            ");
            EndContext();
            BeginContext(267, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "80e8e9384a2546bcbb528a6822a55c33", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(294, 105, true);
            WriteLiteral("\r\n\r\n            <!-- BEGIN CONTENT -->\r\n            <div class=\"col-md-9 col-sm-7\">\r\n                <h2>");
            EndContext();
            BeginContext(400, 11, false);
#line 16 "C:\Users\Martin Ploompuu\Desktop\New folder (4)\Polykas2018\14-AspNetCore\MediaGallery\Views\Home\Picture.cshtml"
               Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(411, 29, true);
            WriteLiteral("</h2>\r\n\r\n                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 440, "\"", 486, 1);
#line 18 "C:\Users\Martin Ploompuu\Desktop\New folder (4)\Polykas2018\14-AspNetCore\MediaGallery\Views\Home\Picture.cshtml"
WriteAttributeValue("", 446, Url.Content(_context.GetItemUrl(Model)), 446, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(487, 276, true);
            WriteLiteral(@" style=""max-width:800px; border: 1px solid darkgray"" />
            </div>
            <!-- END CONTENT -->
        </div>
        <div class=""row margin-bottom-40"">
            <div class=""col-md-3""></div>
            <div class=""col-md-9 col-sm-7"">
                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 763, "\"", 819, 1);
#line 25 "C:\Users\Martin Ploompuu\Desktop\New folder (4)\Polykas2018\14-AspNetCore\MediaGallery\Views\Home\Picture.cshtml"
WriteAttributeValue("", 770, Url.Action("Edit","Home", new { id = Model.Id }), 770, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(820, 134, true);
            WriteLiteral(" class=\"btn btn-primary\">Muuda</a>\r\n            </div>\r\n            <!-- END SIDEBAR & CONTENT -->\r\n        </div>\r\n    </div>\r\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public GalleryContext _context { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MediaGallery.Data.Photo> Html { get; private set; }
    }
}
#pragma warning restore 1591
