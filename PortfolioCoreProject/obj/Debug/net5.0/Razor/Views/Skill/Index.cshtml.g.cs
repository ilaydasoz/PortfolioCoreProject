#pragma checksum "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Skill/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7db80f08733bcbe1c02d8fe7db2865e6c6cc416d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Skill_Index), @"mvc.1.0.view", @"/Views/Skill/Index.cshtml")]
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
#line 1 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Skill/Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7db80f08733bcbe1c02d8fe7db2865e6c6cc416d", @"/Views/Skill/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68f2d02e313c108021e30538cf8f9f57d7957d52", @"/Views/_ViewImports.cshtml")]
    public class Views_Skill_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Skill>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Skill/Index.cshtml"
   
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card-header border-0"">
    <h3 class=""mb-0"">Skill Table</h3>
</div>
<!-- Light table -->
<div class=""table-responsive"">
    <table class=""table align-items-center table-flush"">
        <thead class=""thead-light"">
            <tr>
                <th scope=""col"" class=""sort"" data-sort=""name"">#</th>
                <th scope=""col"" class=""sort"" data-sort=""budget"">Title</th>
                <th scope=""col"" class=""sort"" data-sort=""status"">Percentage</th>
                <th scope=""col"">Delete</th>
                <th scope=""col"" class=""sort"" data-sort=""completion"">Edit</th>
                <th scope=""col""></th>
            </tr>
        </thead>
        <tbody class=""list"">
");
#nullable restore
#line 26 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Skill/Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                    <th>\n                        ");
#nullable restore
#line 30 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Skill/Index.cshtml"
                   Write(item.SkillID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </th>\n                    <td class=\"budget\">\n                        ");
#nullable restore
#line 33 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Skill/Index.cshtml"
                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </td>\n                    <td>\n                        <div class=\"d-flex align-items-center\">\n                            <span class=\"completion mr-2\">");
#nullable restore
#line 37 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Skill/Index.cshtml"
                                                     Write(item.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral(" %</span>\n                            <div>\n                                <div class=\"progress\">\n                                    <div class=\"progress-bar bg-success\" role=\"progressbar\"");
            BeginWriteAttribute("aria-valuenow", " aria-valuenow=\"", 1447, "\"", 1474, 1);
#nullable restore
#line 40 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Skill/Index.cshtml"
WriteAttributeValue("", 1463, item.Value, 1463, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-valuemin=\"0\" aria-valuemax=\"100\" style=\"width: 100%;\"></div>\n                                </div>\n                            </div>\n                        </div>\n                    </td>\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1699, "\"", 1738, 2);
            WriteAttributeValue("", 1706, "/Skill/DeleteSkill/", 1706, 19, true);
#nullable restore
#line 45 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Skill/Index.cshtml"
WriteAttributeValue("", 1725, item.SkillID, 1725, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1805, "\"", 1842, 2);
            WriteAttributeValue("", 1812, "/Skill/EditSkill/", 1812, 17, true);
#nullable restore
#line 46 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Skill/Index.cshtml"
WriteAttributeValue("", 1829, item.SkillID, 1829, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Edit</a></td>\n                </tr>\n");
#nullable restore
#line 48 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Skill/Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\n    </table>\n    <a href=\"/Skill/AddSkill/\" class=\"btn btn-primary\">New Skill</a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Skill>> Html { get; private set; }
    }
}
#pragma warning restore 1591
