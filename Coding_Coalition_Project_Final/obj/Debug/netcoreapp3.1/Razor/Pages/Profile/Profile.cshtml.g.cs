#pragma checksum "C:\Users\Janetp\source\repos\Team-Project\Coding_Coalition_Project_Final\Pages\Profile\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6c6ea0421501ecbfac2cc811c392598477dda32b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Coding_Coalition_Project.Pages.Profile.Pages_Profile_Profile), @"mvc.1.0.razor-page", @"/Pages/Profile/Profile.cshtml")]
namespace Coding_Coalition_Project.Pages.Profile
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
#line 1 "C:\Users\Janetp\source\repos\Team-Project\Coding_Coalition_Project_Final\Pages\_ViewImports.cshtml"
using Coding_Coalition_Project;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c6ea0421501ecbfac2cc811c392598477dda32b", @"/Pages/Profile/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27d4534cded097f7db5d81415f73e8826a667940", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Profile_Profile : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Janetp\source\repos\Team-Project\Coding_Coalition_Project_Final\Pages\Profile\Profile.cshtml"
  

    ViewData["Title"] = "Profile";

    Layout = "~/Pages/Shared/_Navbar.cshtml";
    var imgsrc = "Images/DefaultImage.jpg"; // useful when image is not available

    if (Model.UserInfo.UserImage != null)

    {

        var base64 = Convert.ToBase64String(Model.UserInfo.UserImage);

        imgsrc = string.Format("data:image/jpg;base64,{0}", base64);

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c6ea0421501ecbfac2cc811c392598477dda32b3821", async() => {
                WriteLiteral(@"

    <meta charset=""utf-8"">

    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!--Bootstrap-->

    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css"" crossorigin=""anonymous"">

    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">

    <link rel='stylesheet' href='https://fonts.googleapis.com/css?family=Roboto'>

    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>

    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>



    <style>
        /* Set gray background color and 100% height */
        .sidenav {
            padding-top: 20px;
            background-color: #f1f1f1;
            height: 100%;
        }
        /* Set black background color, white text and some padding */
        footer {
            background-color: #555;
            color: white;
  ");
                WriteLiteral("          padding: 15px;\r\n        }\r\n\r\n");
                WriteLiteral("    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6c6ea0421501ecbfac2cc811c392598477dda32b5959", async() => {
                WriteLiteral("\r\n");
                WriteLiteral(@"    <header class=""header"">
        <div class=""container"">
            <div class=""teacher-name"" style=""padding-top:20px;"">

                <div class=""row"" style=""margin-top:0px;"">
                    <div class=""col-md-9"">
                        <h2 style=""font-size:38px""><strong> ");
#nullable restore
#line 156 "C:\Users\Janetp\source\repos\Team-Project\Coding_Coalition_Project_Final\Pages\Profile\Profile.cshtml"
                                                       Write(Convert.ToString(Model.UserInfo.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"  </strong></h2>
                    </div>
                    <div class=""col-md-3"">
                        <div class=""button"" style=""float:right;"">
                            <a href=""../Profile/ProfileEdit"" class=""btn btn-outline-primary btn-sm"">Edit Profile</a>
                        </div>
                    </div>
                </div>
            </div>
          
        </div>

        <div class=""row"" style=""margin-top:20px;"">
            <div class=""col-md-3"">
                <!-- Image -->
                <a href=""#""> <img class=""rounded-circle""");
                BeginWriteAttribute("src", " src=\"", 5004, "\"", 5017, 1);
#nullable restore
#line 171 "C:\Users\Janetp\source\repos\Team-Project\Coding_Coalition_Project_Final\Pages\Profile\Profile.cshtml"
WriteAttributeValue("", 5010, imgsrc, 5010, 7, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Profile Picture\" style=\"width:200px;height:150px\"></a>\r\n            </div>\r\n\r\n            <div class=\"col-md-6\">\r\n                <!-- Profile Details -->\r\n                <p><span class=\"email\" style=\"font-size:18px\">Names: <strong> ");
#nullable restore
#line 176 "C:\Users\Janetp\source\repos\Team-Project\Coding_Coalition_Project_Final\Pages\Profile\Profile.cshtml"
                                                                         Write(Convert.ToString(Model.UserInfo.FirstName));

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 176 "C:\Users\Janetp\source\repos\Team-Project\Coding_Coalition_Project_Final\Pages\Profile\Profile.cshtml"
                                                                                                                     Write(Convert.ToString(Model.UserInfo.LastName));

#line default
#line hidden
#nullable disable
                WriteLiteral(" </strong></span></p>\r\n                <p><span class=\"email\" style=\"font-size:18px\">Email: <strong> ");
#nullable restore
#line 177 "C:\Users\Janetp\source\repos\Team-Project\Coding_Coalition_Project_Final\Pages\Profile\Profile.cshtml"
                                                                         Write(Convert.ToString(Model.UserInfo.Email));

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></span></p>\r\n                <p><span class=\"bdate\" style=\"font-size:18px\">Birth Date: <strong> ");
#nullable restore
#line 178 "C:\Users\Janetp\source\repos\Team-Project\Coding_Coalition_Project_Final\Pages\Profile\Profile.cshtml"
                                                                              Write(Convert.ToString(Model.UserInfo.Birthdate));

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong></span></p>\r\n                <p><span class=\"email\" style=\"font-size:18px\">Instructor: <strong> ");
#nullable restore
#line 179 "C:\Users\Janetp\source\repos\Team-Project\Coding_Coalition_Project_Final\Pages\Profile\Profile.cshtml"
                                                                              Write(Convert.ToString(Model.UserInfo.IsInstructor));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</strong></span></p>

            </div>

            <div class=""col-md-3 text-center"">
                <!--Social Links -->
                <span class=""number"" style=""font-size:18px""><strong>Profile Links</strong></span>

                <div class=""social-icons"" style=""padding-top:18px"">
                    <a");
                BeginWriteAttribute("href", " href=\"", 6107, "\"", 6156, 1);
#nullable restore
#line 188 "C:\Users\Janetp\source\repos\Team-Project\Coding_Coalition_Project_Final\Pages\Profile\Profile.cshtml"
WriteAttributeValue("", 6114, Convert.ToString(Model.UserInfo.Linkedin), 6114, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        <span class=""fa-stack fa-lg"">
                            <i class=""fa fa-circle fa-stack-2x""></i>
                            <i class=""fa fa-linkedin fa-stack-1x fa-inverse""></i>
                        </span>
                    </a>
                    <a");
                BeginWriteAttribute("href", " href=\"", 6449, "\"", 6497, 1);
#nullable restore
#line 194 "C:\Users\Janetp\source\repos\Team-Project\Coding_Coalition_Project_Final\Pages\Profile\Profile.cshtml"
WriteAttributeValue("", 6456, Convert.ToString(Model.UserInfo.Twitter), 6456, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        <span class=""fa-stack fa-lg"">
                            <i class=""fa fa-circle fa-stack-2x""></i>
                            <i class=""fa fa-twitter fa-stack-1x fa-inverse""></i>
                        </span>
                    </a>
                    <a");
                BeginWriteAttribute("href", " href=\"", 6789, "\"", 6838, 1);
#nullable restore
#line 200 "C:\Users\Janetp\source\repos\Team-Project\Coding_Coalition_Project_Final\Pages\Profile\Profile.cshtml"
WriteAttributeValue("", 6796, Convert.ToString(Model.UserInfo.Facebook), 6796, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                        <span class=""fa-stack fa-lg"">
                            <i class=""fa fa-circle fa-stack-2x""></i>
                            <i class=""fa fa-facebook fa-stack-1x fa-inverse""></i>
                        </span>
                    </a>
                </div>
            </div>
        </div>
       
    </header>
    <!--End of Header-->
    <!-- Main container -->
    <div class=""container"">

        <!-- Section:Biography -->
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card card-block text-xs-left"">
                    <h2 class=""card-title"" style=""color:#0b1b40""><i class=""fa fa-user fa-fw""></i>Biography</h2>
                    <div style=""height: 35px""></div>
                    <p> ");
#nullable restore
#line 221 "C:\Users\Janetp\source\repos\Team-Project\Coding_Coalition_Project_Final\Pages\Profile\Profile.cshtml"
                   Write(Convert.ToString(Model.UserInfo.Biography));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                </div>
            </div>
        </div>
        <!-- End:Biography -->

    </div> <!--End of Container-->

    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.12.4/jquery.min.js""></script>
    <script src=""js/bootstrap.min.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Coding_Coalition_Project.Pages.Profile.ProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Coding_Coalition_Project.Pages.Profile.ProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Coding_Coalition_Project.Pages.Profile.ProfileModel>)PageContext?.ViewData;
        public Coding_Coalition_Project.Pages.Profile.ProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
