#pragma checksum "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\Calender\Calender.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54c00aeb00e61dd156ad164265f6d86b5c7336a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Coding_Coalition_Project.Pages.Calender.Pages_Calender_Calender), @"mvc.1.0.razor-page", @"/Pages/Calender/Calender.cshtml")]
namespace Coding_Coalition_Project.Pages.Calender
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54c00aeb00e61dd156ad164265f6d86b5c7336a0", @"/Pages/Calender/Calender.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27d4534cded097f7db5d81415f73e8826a667940", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Calender_Calender : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#nullable restore
#line 3 "D:\Users\Kelton\Documents\GitHub\Team-Project\Coding_Coalition_Project_Final\Pages\Calender\Calender.cshtml"
  
       Layout = "~/Pages/Shared/_Navbar.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54c00aeb00e61dd156ad164265f6d86b5c7336a03448", async() => {
                WriteLiteral(@"
    <meta name=""viewport"" content=""width=device-width"" />
    <title>Index</title>
    <link href=""https://cdn.dhtmlx.com/scheduler/edge/dhtmlxscheduler_material.css""
          rel=""stylesheet"" type=""text/css"" />
    <script src=""https://cdn.dhtmlx.com/scheduler/edge/dhtmlxscheduler.js""></script>
    <script>
        document.addEventListener(""DOMContentLoaded"", function(event) {
            // initializing scheduler
            scheduler.init(""scheduler_here"", new Date(2020,0,15));

            // initiating data loading
            scheduler.load(""/api/scheduler"");
            // initializing dataProcessor
            var dp = new dataProcessor(""/api/scheduler"");
            // and attaching it to scheduler
            dp.init(scheduler);
            // setting the REST mode for dataProcessor
            dp.setTransactionMode(""REST"");
        });
    </script>
    <style>
        body {
            padding-top: 50px;
            padding-bottom: 20px;
        }

        .scheduler");
                WriteLiteral("_container {\r\n            width: 100%;\r\n            height: 600px;\r\n            border: 1px solid #aeaeae;\r\n        }\r\n    </style>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54c00aeb00e61dd156ad164265f6d86b5c7336a05637", async() => {
                WriteLiteral(@"
    <div class=""scheduler_container"">
        <div id=""scheduler_here"" class=""dhx_cal_container"" style='width:100%; height:100%;'>
            <div class=""dhx_cal_navline"">
                <div class=""dhx_cal_prev_button"">&nbsp;</div>
                <div class=""dhx_cal_next_button"">&nbsp;</div>
                <div class=""dhx_cal_today_button""></div>
                <div class=""dhx_cal_date""></div>
                <div class=""dhx_cal_tab"" name=""day_tab""></div>
                <div class=""dhx_cal_tab"" name=""week_tab""></div>
                <div class=""dhx_cal_tab"" name=""month_tab""></div>
            </div>
            <div class=""dhx_cal_header""></div>
            <div class=""dhx_cal_data""></div>
        </div>
    </div>
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Coding_Coalition_Project.Pages.Calender.CalenderModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Coding_Coalition_Project.Pages.Calender.CalenderModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Coding_Coalition_Project.Pages.Calender.CalenderModel>)PageContext?.ViewData;
        public Coding_Coalition_Project.Pages.Calender.CalenderModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
