#pragma checksum "C:\Users\vmirc\Desktop\repository\MyAppRestaurant\WebRestaurant\Views\AfisareProduse\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04f6c9d8d52942b0475faff4d2663ec0f3676db3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AfisareProduse_Index), @"mvc.1.0.view", @"/Views/AfisareProduse/Index.cshtml")]
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
#line 1 "C:\Users\vmirc\Desktop\repository\MyAppRestaurant\WebRestaurant\Views\AfisareProduse\Index.cshtml"
using WebRestaurant;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04f6c9d8d52942b0475faff4d2663ec0f3676db3", @"/Views/AfisareProduse/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44ca95f1f0139c2bd6a9cc44bf60315d6dcd7dea", @"/Views/_ViewImports.cshtml")]
    public class Views_AfisareProduse_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Produs>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline mt-2 mb-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<a");
            BeginWriteAttribute("href", " href=\"", 46, "\"", 97, 1);
#nullable restore
#line 3 "C:\Users\vmirc\Desktop\repository\MyAppRestaurant\WebRestaurant\Views\AfisareProduse\Index.cshtml"
WriteAttributeValue("", 53, Url.Action("ListByPrice", "AfisareProduse"), 53, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("class=\"btn btn-primary\">Sort by Price</a>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04f6c9d8d52942b0475faff4d2663ec0f3676db34415", async() => {
                WriteLiteral("\r\n    <input type=\"text\" name=\"criteria\" class=\"form-control m1-1 mr-1\" />\r\n    <button type=\"submit\" class=\"btn btn-info form-control m1-1 mr-1 \">Search</button>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 4 "C:\Users\vmirc\Desktop\repository\MyAppRestaurant\WebRestaurant\Views\AfisareProduse\Index.cshtml"
AddHtmlAttributeValue("", 155, Url.Action("Search"), 155, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\" d-flex flex-row flex-wrap\">\r\n\r\n");
#nullable restore
#line 12 "C:\Users\vmirc\Desktop\repository\MyAppRestaurant\WebRestaurant\Views\AfisareProduse\Index.cshtml"
     foreach (Produs item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\" card\">\r\n            <div class=\" card-header\">\r\n                <div class=\"card-title\">\r\n                    ");
#nullable restore
#line 17 "C:\Users\vmirc\Desktop\repository\MyAppRestaurant\WebRestaurant\Views\AfisareProduse\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n                <p class=\" card-subtitle\">Pret in RON:");
#nullable restore
#line 20 "C:\Users\vmirc\Desktop\repository\MyAppRestaurant\WebRestaurant\Views\AfisareProduse\Index.cshtml"
                                                 Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n            <div class=\" card-body\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 806, "\"", 826, 1);
#nullable restore
#line 23 "C:\Users\vmirc\Desktop\repository\MyAppRestaurant\WebRestaurant\Views\AfisareProduse\Index.cshtml"
WriteAttributeValue("", 812, item.ImageUrl, 812, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"200\" />\r\n                <div class=\"card-text\">\r\n                    <p>");
#nullable restore
#line 25 "C:\Users\vmirc\Desktop\repository\MyAppRestaurant\WebRestaurant\Views\AfisareProduse\Index.cshtml"
                  Write(item.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1028, "\"", 1095, 1);
#nullable restore
#line 29 "C:\Users\vmirc\Desktop\repository\MyAppRestaurant\WebRestaurant\Views\AfisareProduse\Index.cshtml"
WriteAttributeValue("", 1035, Url.Action("Details" ,"AfisareProduse", new {Id = item.Id}), 1035, 60, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Details</a>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 1152, "\"", 1222, 1);
#nullable restore
#line 30 "C:\Users\vmirc\Desktop\repository\MyAppRestaurant\WebRestaurant\Views\AfisareProduse\Index.cshtml"
WriteAttributeValue("", 1159, Url.Action("AdaugaInCos","AfisareProduse", new {Id = item.Id}), 1159, 63, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-dark\" style=\"float:right\">Adauga in cos</a>\r\n            </div>\r\n\r\n\r\n        </div>\r\n");
#nullable restore
#line 35 "C:\Users\vmirc\Desktop\repository\MyAppRestaurant\WebRestaurant\Views\AfisareProduse\Index.cshtml"


    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Produs>> Html { get; private set; }
    }
}
#pragma warning restore 1591
