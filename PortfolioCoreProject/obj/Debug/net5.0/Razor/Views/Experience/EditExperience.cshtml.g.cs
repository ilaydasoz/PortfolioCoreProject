#pragma checksum "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Experience/EditExperience.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d842e5fe9e3a276bdc294a0dd7c506b4700d08f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Experience_EditExperience), @"mvc.1.0.view", @"/Views/Experience/EditExperience.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d842e5fe9e3a276bdc294a0dd7c506b4700d08f0", @"/Views/Experience/EditExperience.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68f2d02e313c108021e30538cf8f9f57d7957d52", @"/Views/_ViewImports.cshtml")]
    public class Views_Experience_EditExperience : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Experience>
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
#line 2 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Experience/EditExperience.cshtml"
  
    ViewData["Title"] = "AddSkill";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"card-header border-0\">\n    <h3 class=\"mb-0\">Edit Experience</h3>\n</div>\n\n\n");
#nullable restore
#line 12 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Experience/EditExperience.cshtml"
 using (Html.BeginForm("EditExperience", "Experience", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\n        <div class=\"card\">\n            <div class=\"card-body\">\n                <p class=\"card-description\"> Edit Experience </p>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d842e5fe9e3a276bdc294a0dd7c506b4700d08f04553", async() => {
                WriteLiteral("\n                    <div class=\"form-group\">\n                        <label>ID</label>\n                        ");
#nullable restore
#line 21 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Experience/EditExperience.cshtml"
                   Write(Html.TextBoxFor(x => x.ExperienceID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label>Title</label>\n                        ");
#nullable restore
#line 25 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Experience/EditExperience.cshtml"
                   Write(Html.TextBoxFor(x => x.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label>Date</label>\n                        ");
#nullable restore
#line 29 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Experience/EditExperience.cshtml"
                   Write(Html.TextBoxFor(x => x.Date, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n                    <div class=\"form-group\">\n                        <label>Image</label>\n                        ");
#nullable restore
#line 33 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Experience/EditExperience.cshtml"
                   Write(Html.TextBoxFor(x => x.ImageUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                    </div>\n\n                    <div class=\"form-group\">\n                        <label>Description</label>\n                        ");
#nullable restore
#line 38 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Experience/EditExperience.cshtml"
                   Write(Html.TextAreaFor(x => x.Description, 6, 3, new { @class = "form-control" }));

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
#line 46 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Experience/EditExperience.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Experience> Html { get; private set; }
    }
}
#pragma warning restore 1591
