#pragma checksum "E:\Cognizant Handson\Stage 3a - .NET Advanced Features\day05\cSharpCRUD\WebApplication\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b68da32784bbefa2be7b406a37cbc21d874cd71f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Index), @"mvc.1.0.view", @"/Views/Products/Index.cshtml")]
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
#line 1 "E:\Cognizant Handson\Stage 3a - .NET Advanced Features\day05\cSharpCRUD\WebApplication\Views\_ViewImports.cshtml"
using ProductCrudList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Cognizant Handson\Stage 3a - .NET Advanced Features\day05\cSharpCRUD\WebApplication\Views\_ViewImports.cshtml"
using ProductCrudList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b68da32784bbefa2be7b406a37cbc21d874cd71f", @"/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4c62bc977986a66d98468c1ef232fcbf9103223", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table contactForm"">
    <thead>
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Price</th>
            <th scope=""col""></th>
            <th scope=""col""></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 14 "E:\Cognizant Handson\Stage 3a - .NET Advanced Features\day05\cSharpCRUD\WebApplication\Views\Products\Index.cshtml"
         foreach (var product in Model)

        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <th scope=\"row\">");
#nullable restore
#line 18 "E:\Cognizant Handson\Stage 3a - .NET Advanced Features\day05\cSharpCRUD\WebApplication\Views\Products\Index.cshtml"
                           Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n                <td>");
#nullable restore
#line 19 "E:\Cognizant Handson\Stage 3a - .NET Advanced Features\day05\cSharpCRUD\WebApplication\Views\Products\Index.cshtml"
               Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 20 "E:\Cognizant Handson\Stage 3a - .NET Advanced Features\day05\cSharpCRUD\WebApplication\Views\Products\Index.cshtml"
               Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>\n                    ");
#nullable restore
#line 22 "E:\Cognizant Handson\Stage 3a - .NET Advanced Features\day05\cSharpCRUD\WebApplication\Views\Products\Index.cshtml"
               Write(Html.ActionLink("Update", "Update", new { id = product.Id
                }, new { @class = "btn btn-warning"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    |\n                <td>\n                        ");
#nullable restore
#line 26 "E:\Cognizant Handson\Stage 3a - .NET Advanced Features\day05\cSharpCRUD\WebApplication\Views\Products\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = product.Id
                }, new { @class = "btn btn-danger"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 30 "E:\Cognizant Handson\Stage 3a - .NET Advanced Features\day05\cSharpCRUD\WebApplication\Views\Products\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n<div class=\"d-flex justify-content-end\">\n    ");
#nullable restore
#line 35 "E:\Cognizant Handson\Stage 3a - .NET Advanced Features\day05\cSharpCRUD\WebApplication\Views\Products\Index.cshtml"
Write(Html.ActionLink("Create", "Create", new object { }, new { @class = "btn btn-primary btn-lg"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
