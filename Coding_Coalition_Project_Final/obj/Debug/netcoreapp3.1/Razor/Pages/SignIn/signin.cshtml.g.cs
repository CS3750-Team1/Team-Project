#pragma checksum "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\SignIn\signin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5afc31a0bdcc753619f29b0ba08a021d35df6626"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Coding_Coalition_Project.Pages.SignIn.Pages_SignIn_signin), @"mvc.1.0.razor-page", @"/Pages/SignIn/signin.cshtml")]
namespace Coding_Coalition_Project.Pages.SignIn
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
#line 1 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\_ViewImports.cshtml"
using Coding_Coalition_Project;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5afc31a0bdcc753619f29b0ba08a021d35df6626", @"/Pages/SignIn/signin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27d4534cded097f7db5d81415f73e8826a667940", @"/Pages/_ViewImports.cshtml")]
    public class Pages_SignIn_signin : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\SignIn\signin.cshtml"
  
    ViewData["Title"] = "signin";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<hr />
<!--
<div class=""login-form"" style=""width: 340px; margin: 50px auto;"">
    <form method=""post"" style=""margin-bottom: 15px; background: #f7f7f7; box-shadow: 0px 2px 2px rgba(0, 0, 0, 0.3); padding: 30px;"">
        <h2 class=""text-center"" style=""margin: 0 0 15px;"">Log in</h2>
        <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
        <div class=""form-group"">
             <label asp-for=""SignInViewModel.Email"" class=""control-label"">Email</label>
            <input asp-for=""SignInViewModel.Email"" class=""form-control"" />
            <span asp-validation-for=""SignInViewModel.Email"" class=""text-danger""></span>
        </div>
        <div class=""form-group"">
            <div class=""form-group"">
                <label asp-for=""SignInViewModel.Password"" class=""control-label"">Password</label>
                <input asp-for=""SignInViewModel.Password"" class=""form-control"" />
                <span asp-validation-for=""SignInViewModel.Password"" class=""text-danger""></span>
      ");
            WriteLiteral("      </div>\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <button type=\"submit\" class=\"btn btn-primary btn-block\" style=\" font-size: 15px; font-weight: bold;\">Sign in</button>\r\n        </div>\r\n\r\n    </form>\r\n    <h1>");
#nullable restore
#line 29 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\SignIn\signin.cshtml"
   Write(Html.ViewData["Message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n</div>\r\n    -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Coding_Coalition_Project.Pages.SignIn.signinModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Coding_Coalition_Project.Pages.SignIn.signinModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Coding_Coalition_Project.Pages.SignIn.signinModel>)PageContext?.ViewData;
        public Coding_Coalition_Project.Pages.SignIn.signinModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
