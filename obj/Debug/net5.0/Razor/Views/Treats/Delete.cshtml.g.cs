#pragma checksum "C:\Users\Tyler\epicodus\C#\Authentication_With_Identity\PierreSweets\Views\Treats\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d01d58f03fc32cb09d8628786ed38adcc5d9a611"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Treats_Delete), @"mvc.1.0.view", @"/Views/Treats/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d01d58f03fc32cb09d8628786ed38adcc5d9a611", @"/Views/Treats/Delete.cshtml")]
    public class Views_Treats_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PierreSweets.Models.Treat>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Tyler\epicodus\C#\Authentication_With_Identity\PierreSweets\Views\Treats\Delete.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"jumbotron text-center\">\r\n  <h2>Are you sure you want to delete this?</h2>\r\n</div>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Tyler\epicodus\C#\Authentication_With_Identity\PierreSweets\Views\Treats\Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 11 "C:\Users\Tyler\epicodus\C#\Authentication_With_Identity\PierreSweets\Views\Treats\Delete.cshtml"
                                      Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 12 "C:\Users\Tyler\epicodus\C#\Authentication_With_Identity\PierreSweets\Views\Treats\Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Delete\" />\r\n");
#nullable restore
#line 15 "C:\Users\Tyler\epicodus\C#\Authentication_With_Identity\PierreSweets\Views\Treats\Delete.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Tyler\epicodus\C#\Authentication_With_Identity\PierreSweets\Views\Treats\Delete.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PierreSweets.Models.Treat> Html { get; private set; }
    }
}
#pragma warning restore 1591
