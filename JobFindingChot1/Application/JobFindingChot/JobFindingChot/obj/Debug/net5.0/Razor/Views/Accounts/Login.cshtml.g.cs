#pragma checksum "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Accounts\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d8595a0035406fac051a770da84d92eaa6fee3b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Accounts_Login), @"mvc.1.0.view", @"/Views/Accounts/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d8595a0035406fac051a770da84d92eaa6fee3b", @"/Views/Accounts/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed8c01e9d34f7c1f0005db94a4a64a029eb88219", @"/Views/_ViewImports.cshtml")]
    public class Views_Accounts_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobFindingChot.Models.AccountLoginMV>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Accounts\Login.cshtml"
  
    ViewData["Title"] = "Login";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""contact-section"">
    <div class=""container"">
        <div class=""row"">
            <div class=""job-category-listing mb-50"">
                <div class=""col-md-12"">
                    <h2 class=""contact-title"" align=""center"">Login</h2>
                    ");
#nullable restore
#line 11 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Accounts\Login.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n");
#nullable restore
#line 13 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Accounts\Login.cshtml"
                 using (Html.BeginForm("Login", "Accounts", FormMethod.Post,
                        new
                        {
                            @class = "form-contact",
                            @novalidate = "novalidate"
                        }))
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Accounts\Login.cshtml"
               Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row\">\r\n                <div class=\"col-sm-12\">\r\n                    <div class=\"form-group\">\r\n                        ");
#nullable restore
#line 24 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Accounts\Login.cshtml"
                   Write(Html.EditorFor(model => model.Email, new
                   {
                       htmlAttributes = new
                       {
                           @class = "form-control valid",
                           @type = "text",
                           @name = "name",
                           @id = "name",
                           @placeholder = "Enter User Name",
                           @onfocus = "this.placeholder = ''",
                           @onblur = "this.placeholder = 'Enter User Name'",
                           @required = "true"
                       }
                   }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        ");
#nullable restore
#line 38 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Accounts\Login.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Email,
                       "",
                       new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"col-sm-12\">\r\n                    <div class=\"form-group\">\r\n                    </div>\r\n                    ");
#nullable restore
#line 46 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Accounts\Login.cshtml"
               Write(Html.EditorFor(model => model.Password, new
                         {
                             htmlAttributes = new
                             {
                                 @class = "form-control valid",
                                 @type = "password",
                                 @name = "password",
                                 @id = "password",
                                 @placeholder = "Enter Password",
                                 @onfocus = "this.placeholder = ''",
                                 @onblur = "this.placeholder = 'Enter Password'",
                                 @required = "true"
                             }
                         }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 60 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Accounts\Login.cshtml"
               Write(Html.ValidationMessageFor(model => model.Password,
                   "",
                   new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </div>
                </div>
                <div class=""form-group mt-3"">
                    <input type=""submit"" value=""Login"" class=""button boxed-btn"" />
                    <a href=""#"" style=""float:right; padding:15px 0px 0px 0px;"" class=""btn-link"">Forgot Password?</a>
                </div>
");
#nullable restore
#line 69 "D:\JobFindingChot1\Application\JobFindingChot\JobFindingChot\Views\Accounts\Login.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>


                <div class=""col-md-6"" style=""padding: 60px 0px 0px 60px;"">

                    
                        <div class=""media contact-info"">
                            <span class=""contact-info__icon""><i class=""ti-home""></i></span>
                            <div class=""media-body"">
                                <h3>Tasneem Plaz, Peshawar.</h3>
                                <p>KPK, Post Code 25000</p>
                            </div>
                        </div>
                        <div class=""media contact-info"">
                            <span class=""contact-info__icon""><i class=""ti-tablet""></i></span>
                            <div class=""media-body"">
                                <h3>+92 314 307 6781</h3>
                                <p>Mon to Fri 9am to 6pm</p>
                            </div>
                        </div>
                        <div class=""media contact-info"">
                            <span class=""c");
            WriteLiteral(@"ontact-info__icon""><i class=""ti-email""></i></span>
                            <div class=""media-body"">
                                <h3>support@ilyasoft.net</h3>
                                <p>Send us your query anytime!</p>
                            </div>
                        </div>

                </div>
            </div>
    </div>
</section>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobFindingChot.Models.AccountLoginMV> Html { get; private set; }
    }
}
#pragma warning restore 1591