#pragma checksum "C:\Users\vmirc\Desktop\repository\MyAppRestaurant\WebRestaurant\Views\AfisareProduse\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "915e49ebda43036eb91727b1ae3bceea796ac18b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AfisareProduse_Details), @"mvc.1.0.view", @"/Views/AfisareProduse/Details.cshtml")]
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
#line 2 "C:\Users\vmirc\Desktop\repository\MyAppRestaurant\WebRestaurant\Views\_ViewImports.cshtml"
using WebRestaurant.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\vmirc\Desktop\repository\MyAppRestaurant\WebRestaurant\Views\AfisareProduse\Details.cshtml"
using WebRestaurant;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"915e49ebda43036eb91727b1ae3bceea796ac18b", @"/Views/AfisareProduse/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44ca95f1f0139c2bd6a9cc44bf60315d6dcd7dea", @"/Views/_ViewImports.cshtml")]
    public class Views_AfisareProduse_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Produs>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n\r\n    <h2>");
#nullable restore
#line 6 "C:\Users\vmirc\Desktop\repository\MyAppRestaurant\WebRestaurant\Views\AfisareProduse\Details.cshtml"
   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p><em>");
#nullable restore
#line 7 "C:\Users\vmirc\Desktop\repository\MyAppRestaurant\WebRestaurant\Views\AfisareProduse\Details.cshtml"
      Write(Model.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</em></p>\r\n    <h3>Price in RON:");
#nullable restore
#line 8 "C:\Users\vmirc\Desktop\repository\MyAppRestaurant\WebRestaurant\Views\AfisareProduse\Details.cshtml"
                Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 160, "\"", 181, 1);
#nullable restore
#line 9 "C:\Users\vmirc\Desktop\repository\MyAppRestaurant\WebRestaurant\Views\AfisareProduse\Details.cshtml"
WriteAttributeValue("", 166, Model.ImageUrl, 166, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"600\" />\r\n\r\n\r\n\r\n\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Produs> Html { get; private set; }
    }
}
#pragma warning restore 1591
