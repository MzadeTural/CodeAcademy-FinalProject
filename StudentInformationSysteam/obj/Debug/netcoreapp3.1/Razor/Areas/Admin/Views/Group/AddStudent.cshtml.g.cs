#pragma checksum "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Group\AddStudent.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1d392cef27dc55b73e9ab8ae5feae4d87abd9f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Group_AddStudent), @"mvc.1.0.view", @"/Areas/Admin/Views/Group/AddStudent.cshtml")]
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
#line 1 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\_ViewImports.cshtml"
using StudentInformationSysteam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\_ViewImports.cshtml"
using StudentIformationSysteam.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\_ViewImports.cshtml"
using StudentInformationSysteam.Business.ViewModel.StudentProfile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\_ViewImports.cshtml"
using StudentInformationSysteam.Business.ViewModel.Student;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\_ViewImports.cshtml"
using StudentInformationSysteam.Business.ViewModel.Group;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\_ViewImports.cshtml"
using StudentInformationSysteam.Business.ViewModel.UserGroup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\_ViewImports.cshtml"
using StudentInformationSysteam.Business.ViewModel.FacultyVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\_ViewImports.cshtml"
using StudentInformationSysteam.Business.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1d392cef27dc55b73e9ab8ae5feae4d87abd9f7", @"/Areas/Admin/Views/Group/AddStudent.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42947ea54445d08770d7576797391323b0074e32", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Group_AddStudent : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddStudent", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(" \r\n");
#nullable restore
#line 2 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Group\AddStudent.cshtml"
  
    ViewData["Title"] = "AddStudent";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Group\AddStudent.cshtml"
  
    ViewData["Title"] = "AddSubject";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container-fluid py-4\">\r\n      <div class=\"row\">\r\n           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b1d392cef27dc55b73e9ab8ae5feae4d87abd9f76666", async() => {
                WriteLiteral(@"
           <div class=""col-lg-2 mx-2""><button type=""submit"" class=""btn btn-outline-success"">Add</button> </div>
        <div class=""col-12"">
          <div class=""card my-4"">
            <div class=""card-header p-0 position-relative mt-n4 mx-3 z-index-2"">
              <div class=""bg-gradient-primary shadow-primary border-radius-lg pt-4 pb-3"">
                <h6 class=""text-white text-capitalize ps-3"">Group table</h6>
              </div>
            </div>
            <div class=""card-body px-0 pb-2"">
              <div class=""table-responsive p-0"">
                <table class=""table align-items-center mb-0"">
                  <thead>
                    <tr>
                      <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7""><i class=""fas fa-check-square""></i></th>
                      <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2 text-center"">Full Name</th>
                      <th class=""text-center text-uppercase");
                WriteLiteral(@" text-secondary text-xxs font-weight-bolder opacity-7"">User Name</th>
                      <th class=""text-center text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">Father Name</th>
                     
                    </tr>
                  </thead>
                  <tbody>
                      
");
#nullable restore
#line 62 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Group\AddStudent.cshtml"
                       foreach (var group in ViewBag.Students)
                     {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                          <tr>
                      <td>
                        <div class=""d-flex px-2 py-1"">
                          <div>
                            <input style=""width: 1% !important;"" name=""StudentId"" type=""checkbox"" class=""mx-2""");
                BeginWriteAttribute("value", " value=\"", 2744, "\"", 2761, 1);
#nullable restore
#line 68 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Group\AddStudent.cshtml"
WriteAttributeValue("", 2752, group.Id, 2752, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                        </div>\r\n                      </td>\r\n                     \r\n                      <td class=\"align-middle text-center\" >\r\n                        <h2 class=\"badge  \">");
#nullable restore
#line 73 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Group\AddStudent.cshtml"
                                       Write(group.FullName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n                      </td>\r\n                      <td class=\"align-middle text-center\">\r\n                           <h5 class=\"mb-0 bg-gradient-success\"> ");
#nullable restore
#line 76 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Group\AddStudent.cshtml"
                                                            Write(group.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h5>\r\n                      </td>\r\n                       <td class=\"align-middle text-center\">\r\n                           <h5 class=\"mb-0\"> ");
#nullable restore
#line 79 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Group\AddStudent.cshtml"
                                        Write(group.FatherName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h5>\r\n                      </td>\r\n                     \r\n                    </tr>\r\n");
#nullable restore
#line 83 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Group\AddStudent.cshtml"
                     }

#line default
#line hidden
#nullable disable
                WriteLiteral("                   \r\n                   \r\n              \r\n                  </tbody>\r\n                </table>\r\n              </div>\r\n            </div>\r\n          </div>\r\n              ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
