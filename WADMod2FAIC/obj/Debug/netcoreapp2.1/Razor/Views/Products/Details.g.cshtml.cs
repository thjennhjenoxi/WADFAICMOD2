#pragma checksum "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14add4254ff841b17073914e9cdec467bd6834f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Details), @"mvc.1.0.view", @"/Views/Products/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Details.cshtml", typeof(AspNetCore.Views_Products_Details))]
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
#line 1 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\_ViewImports.cshtml"
using WADMod2FAIC;

#line default
#line hidden
#line 2 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\_ViewImports.cshtml"
using WADMod2FAIC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14add4254ff841b17073914e9cdec467bd6834f1", @"/Views/Products/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e2be8df2df947fa0ef453f3f60958ee19d7363f", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WADMod2FAIC.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(80, 121, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Product</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(202, 47, false);
#line 14 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(249, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(293, 43, false);
#line 17 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(336, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(380, 46, false);
#line 20 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(426, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(470, 42, false);
#line 23 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.SupplierID));

#line default
#line hidden
            EndContext();
            BeginContext(512, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(556, 51, false);
#line 26 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.QuantityPerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(607, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(651, 47, false);
#line 29 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.QuantityPerUnit));

#line default
#line hidden
            EndContext();
            BeginContext(698, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(742, 45, false);
#line 32 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(787, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(831, 41, false);
#line 35 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.UnitPrice));

#line default
#line hidden
            EndContext();
            BeginContext(872, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(916, 48, false);
#line 38 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitsInStock));

#line default
#line hidden
            EndContext();
            BeginContext(964, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1008, 44, false);
#line 41 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.UnitsInStock));

#line default
#line hidden
            EndContext();
            BeginContext(1052, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1096, 48, false);
#line 44 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UnitsOnOrder));

#line default
#line hidden
            EndContext();
            BeginContext(1144, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1188, 44, false);
#line 47 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.UnitsOnOrder));

#line default
#line hidden
            EndContext();
            BeginContext(1232, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1276, 48, false);
#line 50 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ReorderLevel));

#line default
#line hidden
            EndContext();
            BeginContext(1324, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1368, 44, false);
#line 53 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.ReorderLevel));

#line default
#line hidden
            EndContext();
            BeginContext(1412, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1456, 48, false);
#line 56 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Discontinued));

#line default
#line hidden
            EndContext();
            BeginContext(1504, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1548, 44, false);
#line 59 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Discontinued));

#line default
#line hidden
            EndContext();
            BeginContext(1592, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1636, 44, false);
#line 62 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1680, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1724, 51, false);
#line 65 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml"
       Write(Html.DisplayFor(model => model.Category.CategoryID));

#line default
#line hidden
            EndContext();
            BeginContext(1775, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1822, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2efb94773b91452c908cc070f7f18535", async() => {
                BeginContext(1875, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 70 "C:\Users\VTA\source\repos\WADMod2FAIC\WADMod2FAIC\Views\Products\Details.cshtml"
                           WriteLiteral(Model.ProductID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1883, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1891, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dacbb25871d24664967f90e485ae6f07", async() => {
                BeginContext(1913, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1929, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WADMod2FAIC.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
