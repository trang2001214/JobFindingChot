#pragma checksum "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Categories\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "303be30ff9d926cfdf2ca44f85718c9e12447d3e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_Create), @"mvc.1.0.view", @"/Views/Categories/Create.cshtml")]
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
#line 1 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\_ViewImports.cshtml"
using JobFindingChot;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\_ViewImports.cshtml"
using JobFindingChot.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"303be30ff9d926cfdf2ca44f85718c9e12447d3e", @"/Views/Categories/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed8c01e9d34f7c1f0005db94a4a64a029eb88219", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobFindingChot.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Categories\Create.cshtml"
  
    ViewData["Title"] = "New";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"section-top-border\">\r\n    <div class=\"row\">\r\n        <div class=\"col-lg-6 col-md-6\">\r\n            <h3 class=\"mb-30\">New Category</h3>\r\n");
#nullable restore
#line 11 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Categories\Create.cshtml"
             using (Html.BeginForm())
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Categories\Create.cshtml"
           Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Categories\Create.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"mt-4\">\r\n                    ");
#nullable restore
#line 16 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Categories\Create.cshtml"
               Write(Html.EditorFor(model => model.CatName, new
               {
                   htmlAttributes = new
                   {
                       @class = "form-control single-input",
                       @type = "text",
                       @name = "first_name",
                   @placeholder = "Enter Category",
                   @onfocus = "this.placeholder = ''",
                   @onblur = "this.placeholder = 'Enter Category'",
                   @required = "true"
                   }
               }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 29 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Categories\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.CatName, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"mt-4\">\r\n                    ");
#nullable restore
#line 32 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Categories\Create.cshtml"
               Write(Html.EditorFor(model => model.Description, new
               {
                   htmlAttributes = new
                   {
                       @class = "form-control single-input",
                       @type = "text",
                       @name = "first_name",
                       @placeholder = "Enter Description",
                       @onfocus = "this.placeholder = ''",
                       @onblur = "this.placeholder = 'Enter Description'",
                       @required = "true"
                   }
               }
                   ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 46 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Categories\Create.cshtml"
               Write(Html.ValidationMessageFor(model => model.Description, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <hr />\r\n                <div class=\"form-group mt-4\">\r\n                    <input type=\"submit\" value=\"Save\" class=\"genric-btn success e-large\" style=\"float:right;\" />\r\n                    ");
#nullable restore
#line 51 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Categories\Create.cshtml"
               Write(Html.ActionLink("Back to List", "Index", null, new { @class = "btn btn-default", @style = "float:left;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 53 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Categories\Create.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobFindingChot.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
