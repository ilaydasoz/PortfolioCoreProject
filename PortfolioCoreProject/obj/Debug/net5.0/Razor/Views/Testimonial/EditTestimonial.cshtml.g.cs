#pragma checksum "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Testimonial/EditTestimonial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23fa4ef3e367102ad1b9a07ae44364a18159caae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Testimonial_EditTestimonial), @"mvc.1.0.view", @"/Views/Testimonial/EditTestimonial.cshtml")]
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
#line 1 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/_ViewImports.cshtml"
using PortfolioCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/_ViewImports.cshtml"
using PortfolioCoreProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23fa4ef3e367102ad1b9a07ae44364a18159caae", @"/Views/Testimonial/EditTestimonial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68f2d02e313c108021e30538cf8f9f57d7957d52", @"/Views/_ViewImports.cshtml")]
    public class Views_Testimonial_EditTestimonial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Testimonial>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Testimonial/EditTestimonial.cshtml"
  
    ViewData["Title"] = "EditTestimonial";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"card-header border-0\">\n    <h3 class=\"mb-0\">Testimonal Details</h3>\n</div>\n");
#nullable restore
#line 10 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Testimonial/EditTestimonial.cshtml"
 using (Html.BeginForm("EditTestimonial", "Testimonial", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\n        <div class=\"card\">\n            <div class=\"card-body\">\n                <p class=\"card-description\"> Edit Testimonial  </p>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23fa4ef3e367102ad1b9a07ae44364a18159caae4581", async() => {
                WriteLiteral("\n                    <div class=\"form-group\">\n                        <label>ID</label>\n                        ");
#nullable restore
#line 19 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Testimonial/EditTestimonial.cshtml"
                   Write(Html.TextBoxFor(x => x.TestimonialID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label>Name and Surname</label>\n                        ");
#nullable restore
#line 23 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Testimonial/EditTestimonial.cshtml"
                   Write(Html.TextBoxFor(x => x.ClientName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label>Company</label>\n                        ");
#nullable restore
#line 27 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Testimonial/EditTestimonial.cshtml"
                   Write(Html.TextBoxFor(x => x.Company, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label>Image URL</label>\n                        ");
#nullable restore
#line 31 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Testimonial/EditTestimonial.cshtml"
                   Write(Html.TextBoxFor(x => x.Image, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label>Comment</label>\n                        ");
#nullable restore
#line 35 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Testimonial/EditTestimonial.cshtml"
                   Write(Html.TextAreaFor(x => x.Comment, 8, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <button type=\"submit\" class=\"btn btn-primary mr-2\">Save</button>\n                    <button class=\"btn btn-dark\">Cancel</button>\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n");
#nullable restore
#line 43 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Testimonial/EditTestimonial.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Testimonial> Html { get; private set; }
    }
}
#pragma warning restore 1591
