#pragma checksum "C:\Users\qodir\OneDrive\Desktop\lms_asp_net_core-main\mvclms\Views\Course\StudentCourses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4890ca9c85ddff8aadba6e00d3485fb6b813fbe4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_StudentCourses), @"mvc.1.0.view", @"/Views/Course/StudentCourses.cshtml")]
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
#line 1 "C:\Users\qodir\OneDrive\Desktop\lms_asp_net_core-main\mvclms\Views\_ViewImports.cshtml"
using mvclms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\qodir\OneDrive\Desktop\lms_asp_net_core-main\mvclms\Views\_ViewImports.cshtml"
using mvclms.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4890ca9c85ddff8aadba6e00d3485fb6b813fbe4", @"/Views/Course/StudentCourses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56acd14a8d57512efac5ab292b468f81827b574d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Course_StudentCourses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.List<mvclms.Models.StudentCourse>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowCourse", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\qodir\OneDrive\Desktop\lms_asp_net_core-main\mvclms\Views\Course\StudentCourses.cshtml"
  
    ViewBag.Title = "student courses";
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-left container"">
    <h2>student courses</h2>
    <table border='1'>
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Category</th>
            <th>Teacher</th>
            <th>Start date</th>
            <th>End date</th>
        </tr>
");
#nullable restore
#line 19 "C:\Users\qodir\OneDrive\Desktop\lms_asp_net_core-main\mvclms\Views\Course\StudentCourses.cshtml"
         foreach(var x in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td>");
#nullable restore
#line 22 "C:\Users\qodir\OneDrive\Desktop\lms_asp_net_core-main\mvclms\Views\Course\StudentCourses.cshtml"
               Write(x.Course.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4890ca9c85ddff8aadba6e00d3485fb6b813fbe44957", async() => {
                WriteLiteral("\n                    ");
#nullable restore
#line 24 "C:\Users\qodir\OneDrive\Desktop\lms_asp_net_core-main\mvclms\Views\Course\StudentCourses.cshtml"
               Write(x.Course.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\qodir\OneDrive\Desktop\lms_asp_net_core-main\mvclms\Views\Course\StudentCourses.cshtml"
                                                                         WriteLiteral(x.CourseId);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 26 "C:\Users\qodir\OneDrive\Desktop\lms_asp_net_core-main\mvclms\Views\Course\StudentCourses.cshtml"
               Write(x.Course.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 27 "C:\Users\qodir\OneDrive\Desktop\lms_asp_net_core-main\mvclms\Views\Course\StudentCourses.cshtml"
               Write(x.Course.Teacher.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 28 "C:\Users\qodir\OneDrive\Desktop\lms_asp_net_core-main\mvclms\Views\Course\StudentCourses.cshtml"
               Write(x.Course.StartDate.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 28 "C:\Users\qodir\OneDrive\Desktop\lms_asp_net_core-main\mvclms\Views\Course\StudentCourses.cshtml"
                                                       Write(x.Course.StartDate.ToLongTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td>");
#nullable restore
#line 29 "C:\Users\qodir\OneDrive\Desktop\lms_asp_net_core-main\mvclms\Views\Course\StudentCourses.cshtml"
               Write(x.Course.EndDate.ToLongDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("  ");
#nullable restore
#line 29 "C:\Users\qodir\OneDrive\Desktop\lms_asp_net_core-main\mvclms\Views\Course\StudentCourses.cshtml"
                                                     Write(x.Course.EndDate.ToLongTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            </tr>\n");
#nullable restore
#line 31 "C:\Users\qodir\OneDrive\Desktop\lms_asp_net_core-main\mvclms\Views\Course\StudentCourses.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.List<mvclms.Models.StudentCourse>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
