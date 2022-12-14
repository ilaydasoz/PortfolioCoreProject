#pragma checksum "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/ExperienceAjax/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "380e32ed838d80e6b98c3a3f6837e8627c0380f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ExperienceAjax_Index), @"mvc.1.0.view", @"/Views/ExperienceAjax/Index.cshtml")]
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
#nullable restore
#line 1 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/ExperienceAjax/Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"380e32ed838d80e6b98c3a3f6837e8627c0380f3", @"/Views/ExperienceAjax/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68f2d02e313c108021e30538cf8f9f57d7957d52", @"/Views/_ViewImports.cshtml")]
    public class Views_ExperienceAjax_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Experience>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/ExperienceAjax/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-6"">
    <div class=""p-2"">
        <button type=""button"" id=""btngetlistall"" class=""btn btn-outline-primary"">Get Experiences</button>
        <button type=""button"" id=""btnadd"" class=""btn btn-outline-info"">Save</button>
        <button type=""button"" id=""btnid"" class=""btn btn-outline-warning"">Get By Id</button>
        <button type=""button"" id=""btndelete"" class=""btn btn-outline-danger"">Delete</button>
        <button type=""button"" id=""btnupdate"" class=""btn btn-outline-success"">Edit</button>
    </div>
</div>

<div class=""p-2"" id=""listexperience"">

</div>

<br />

<div class=""p-2"" id=""listbyidexperience"">

</div>

<br />

<div class=""col-md-12"">
    <h5>Add Experience</h5>
    <input type=""text"" class=""form-control"" id=""inpname"" placeholder=""Title"" />
    <br />
    <input type=""text"" class=""form-control"" id=""inpdate"" placeholder=""Date"" />
</div>
<br />
<div class=""col-md-12"">
    <h5>Get Experience By Id</h5>
    <input type=""text"" class=""form-control"" id=""inpid"" placeholder=""Id"" />
</div>

<b");
            WriteLiteral(@"r />

<div class=""col-md-12"">
    <h5>Delete Experience</h5>
    <input type=""text"" class=""form-control"" id=""inpexpid"" placeholder=""Id"" />
</div>
<br />
<div class=""col-md-12"">
    <h5>Edit Experience</h5>
    <input type=""text"" class=""form-control"" id=""inpeditexpid"" placeholder=""Id"" />
    <br />
    <input type=""text"" class=""form-control"" id=""inpeditexpname"" placeholder=""Date"" />
</div>

");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script>

        $(""#btngetlistall"").click(function () {
            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/ExperienceAjax/ListExperience/"",

                success: function (funk) {
                    let values = jQuery.parseJSON(funk);
                    console.log(values);

                    let htmlst = ""<table class=table table-bordered> <tr> <th> ID </th> <th> Title </th> <th> Date </th> </tr>"";
                    $.each(values, (index, value) => {
                        htmlst += `<tr> <td>${value.ExprerienceID}</td> <td>${value.Name}</td> <td>${value.Date}</td> </tr>`
                    });
                    htmlst += ""</table>"";
                    $(""#listexperience"").html(htmlst);
                }
            });
        });

        $(""#btnadd"").click(function () {
            let values = {
                Name: $(""#inpname"").val(),
                Date: $(""#inpdate"").val()");
                WriteLiteral(@"
            };

            $.ajax({
                type: ""Post"",
                url: ""/ExperienceAjax/AddExperience/"",
                data: values,
                success: function (funk1) {
                    let result = jQuery.parseJSON(funk1);
                    alert(""Successfully added!"");
                }
            });
        });

        $(""#btnid"").click(x => {
            let id = $(""#inpid"").val();

            $.ajax({
                contentType: ""application/json"",
                dataType: ""json"",
                type: ""Get"",
                url: ""/ExperienceAjax/GetById/"",
                data: { ExperienceID: id },
                success: function (funk2) {
                    let result = jQuery.parseJSON(funk2);
                    console.log(result);
                    let htmlstr = `<table class=table table-hover> <tr> <th>Deneyim ID</th> <td>${result.ExprerienceID}</td></tr> <tr> <th> Deneyim Ba??l?????? </th> <td> ${result.Name}</td> </tr> </table>`;
                    $(""#l");
                WriteLiteral(@"istbyidexperience"").html(htmlstr);
                }
            });

        });

        $(""#btndelete"").click(x => {
            let id = $(""#inpexpid"").val();
            $.ajax({
                url: ""/ExperienceAjax/DeleteExperience/"" + id,
                type: ""post"",
                contentType: ""application/json"",
                dataType: ""json"",
                success: function (funk3) {
                    loadData();
                }
            });
        });

        $(""#btnupdate"").click(function () {
            let values = {
                ExperienceID: $(""#inpeditexpid"").val(),
                Name: $(""#inpeditexpname"").val()
            };

            $.ajax({
                type: ""post"",
                url: ""/ExperienceAjax/UpdateExperince/"",
                data: values,
                success: function (func4) {
                    alert(""Successfully updated!"");
                }
            });
        });

    </script>
");
            }
            );
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "380e32ed838d80e6b98c3a3f6837e8627c0380f38858", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Experience>> Html { get; private set; }
    }
}
#pragma warning restore 1591
