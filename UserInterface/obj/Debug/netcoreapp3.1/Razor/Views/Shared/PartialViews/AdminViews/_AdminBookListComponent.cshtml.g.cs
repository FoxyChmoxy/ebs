#pragma checksum "C:\Users\Almas\source\repos\ebs\UserInterface\Views\Shared\PartialViews\AdminViews\_AdminBookListComponent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb3c546a22bf99ec0966a1e5ce96af949619dcca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PartialViews_AdminViews__AdminBookListComponent), @"mvc.1.0.view", @"/Views/Shared/PartialViews/AdminViews/_AdminBookListComponent.cshtml")]
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
#line 1 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\_ViewImports.cshtml"
using UserInterface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\_ViewImports.cshtml"
using UserInterface.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cb3c546a22bf99ec0966a1e5ce96af949619dcca", @"/Views/Shared/PartialViews/AdminViews/_AdminBookListComponent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e43315f7187e02b91fbe085b63d31aa8b4d17d98", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViews_AdminViews__AdminBookListComponent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserInterface.ViewModels.BookListViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<table class=""table table-dark"">
    <thead>
        <tr>
            <th scope=""col"">#</th>
            <th scope=""col"">Author</th>
            <th scope=""col"">Title</th>
            <th scope=""col"">User</th>
            <th scope=""col"">Created Date</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 14 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\Shared\PartialViews\AdminViews\_AdminBookListComponent.cshtml"
         foreach (var book in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
#nullable restore
#line 17 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\Shared\PartialViews\AdminViews\_AdminBookListComponent.cshtml"
                           Write(book.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\Shared\PartialViews\AdminViews\_AdminBookListComponent.cshtml"
               Write(book.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\Shared\PartialViews\AdminViews\_AdminBookListComponent.cshtml"
               Write(book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\Shared\PartialViews\AdminViews\_AdminBookListComponent.cshtml"
               Write(book.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\Shared\PartialViews\AdminViews\_AdminBookListComponent.cshtml"
               Write(book.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Users\Almas\source\repos\ebs\UserInterface\Views\Shared\PartialViews\AdminViews\_AdminBookListComponent.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserInterface.ViewModels.BookListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
