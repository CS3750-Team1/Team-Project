#pragma checksum "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6962f5c863902de50f4e6dfc20fa1c00ad22260"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Coding_Coalition_Project.Pages.RegisterClasses.Pages_RegisterClasses_RegisterClassesDetails), @"mvc.1.0.razor-page", @"/Pages/RegisterClasses/RegisterClassesDetails.cshtml")]
namespace Coding_Coalition_Project.Pages.RegisterClasses
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f6962f5c863902de50f4e6dfc20fa1c00ad22260", @"/Pages/RegisterClasses/RegisterClassesDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27d4534cded097f7db5d81415f73e8826a667940", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RegisterClasses_RegisterClassesDetails : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml"
  
    ViewData["Title"] = "RegisterClassesDetails";
    Layout = "~/Pages/Shared/_Navbar.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>RegisterClassesDetails</h1>\r\n\r\n<div>\r\n    <h4>Courses</h4>\r\n    <hr />\r\n");
#nullable restore
#line 14 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml"
      Model.setCourseID(Model.Courses.CourseID);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Courses.CourseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml"
       Write(Html.DisplayFor(model => model.Courses.CourseName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Courses.CourseSubject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml"
       Write(Html.DisplayFor(model => model.Courses.CourseSubject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Courses.CourseNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml"
       Write(Html.DisplayFor(model => model.Courses.CourseNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Courses.InstructorID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml"
       Write(Html.DisplayFor(model => model.Courses.InstructorID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Courses.CourseCredits));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml"
       Write(Html.DisplayFor(model => model.Courses.CourseCredits));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Courses.CourseLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml"
       Write(Html.DisplayFor(model => model.Courses.CourseLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Courses.CourseMeetingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml"
       Write(Html.DisplayFor(model => model.Courses.CourseMeetingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 59 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Courses.CourseMeetingDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml"
       Write(Html.DisplayFor(model => model.Courses.CourseMeetingDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 65 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml"
       Write(Html.DisplayNameFor(model => model.Courses.CourseCapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 68 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\RegisterClasses\RegisterClassesDetails.cshtml"
       Write(Html.DisplayFor(model => model.Courses.CourseCapacity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f6962f5c863902de50f4e6dfc20fa1c00ad2226011236", async() => {
                WriteLiteral("\r\n    <div>\r\n        <div class=\"form-group\">\r\n            <input type=\"submit\" value=\"Register\" class=\"btn btn-primary\" />\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Coding_Coalition_Project.Pages.RegisterClasses.RegisterClassesDetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Coding_Coalition_Project.Pages.RegisterClasses.RegisterClassesDetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Coding_Coalition_Project.Pages.RegisterClasses.RegisterClassesDetailsModel>)PageContext?.ViewData;
        public Coding_Coalition_Project.Pages.RegisterClasses.RegisterClassesDetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
