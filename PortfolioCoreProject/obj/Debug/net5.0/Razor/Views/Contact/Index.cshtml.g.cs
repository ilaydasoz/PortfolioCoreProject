#pragma checksum "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Contact/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8436a45d5db8816589368e281eb6bacfee3b0a46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Contact/Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8436a45d5db8816589368e281eb6bacfee3b0a46", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68f2d02e313c108021e30538cf8f9f57d7957d52", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Message>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Contact/Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_NewAdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-12 grid-margin stretch-card"">
    <div class=""card"">
        <div class=""card-body"">
            <h4 class=""card-title"">Contact Box</h4>

            <div class=""table-responsive"">
                <table class=""table"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Sender</th>
                            <th>Date</th>
                            <th>Delete</th>
                            <th>See message</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 25 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Contact/Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 28 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Contact/Index.cshtml"
                               Write(item.MessageID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 29 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Contact/Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 30 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Contact/Index.cshtml"
                               Write(item.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1053, "\"", 1098, 2);
            WriteAttributeValue("", 1060, "/Contact/DeleteContact/", 1060, 23, true);
#nullable restore
#line 31 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Contact/Index.cshtml"
WriteAttributeValue("", 1083, item.MessageID, 1083, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Delete</a></td>\n                                <td><a");
            BeginWriteAttribute("href", " href=\"", 1185, "\"", 1231, 2);
            WriteAttributeValue("", 1192, "/Contact/ContactDetails/", 1192, 24, true);
#nullable restore
#line 32 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Contact/Index.cshtml"
WriteAttributeValue("", 1216, item.MessageID, 1216, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-success\">Click to see</a></td>\n                            </tr>\n");
#nullable restore
#line 34 "/Users/ilaydasozyilmaz/Projects/PortfolioCoreProject/PortfolioCoreProject/Views/Contact/Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n            </div>\n        </div>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Message>> Html { get; private set; }
    }
}
#pragma warning restore 1591
