#pragma checksum "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "305529b740642f7a7b18b567436e8b62ea2b6b56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Dashboard_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\_ViewImports.cshtml"
using StudentInformationSysteam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\_ViewImports.cshtml"
using StudentIformationSysteam.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\_ViewImports.cshtml"
using StudentInformationSysteam.Business.ViewModel.StudentProfile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\_ViewImports.cshtml"
using StudentInformationSysteam.Business.ViewModel.Student;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\_ViewImports.cshtml"
using StudentInformationSysteam.Business.ViewModel.Group;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"305529b740642f7a7b18b567436e8b62ea2b6b56", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bf62be1a437f32501b67dc6a5b1091ca0b090fd", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"        <style>

        </style>   
<div class=""container-fluid py-4"">
      <div class=""row"">
        
       <div class=""col-xl-4 col-sm-6 my-3"">
          <div class=""card"">
            <div class=""card-header p-3 pt-2"">
              <div class=""icon icon-lg icon-shape bg-gradient-info shadow-info text-center border-radius-xl mt-n4 position-absolute"">
                 <i class=""fas fa-user-graduate""></i>
              </div>
              <div class=""text-end pt-1"">
                <h3 class=""text-white"">
                                ");
#nullable restore
#line 15 "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Dashboard\Index.cshtml"
                           Write(ViewBag.UserStudent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                           </h3>
                            <p class=""text-white"">
                                Student                            </p>
              </div>
            </div>
             
            <hr class=""dark horizontal my-0"">
            <div class=""card-footer p-3"">
");
            WriteLiteral(@"            </div>
          </div>
        </div>
        <div class=""col-xl-4 col-sm-6 my-3"">
          <div class=""card"">
            <div class=""card-header p-3 pt-2"">
              <div class=""icon icon-lg icon-shape bg-gradient-info shadow-info text-center border-radius-xl mt-n4 position-absolute"">
               <i class=""fas fa-chalkboard-teacher""></i>
              </div>
              <div class=""text-end pt-1"">
                <h3 class=""text-white"">
                                ");
#nullable restore
#line 35 "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Dashboard\Index.cshtml"
                           Write(ViewBag.TeacherCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                           </h3>
                            <p class=""text-white"">
                                Teacher                            </p>
              </div>
            </div>
             
            <hr class=""dark horizontal my-0"">
            <div class=""card-footer p-3"">
");
            WriteLiteral(@"            </div>
          </div>
        </div>
        <div class=""col-xl-4 col-sm-6 my-3"">
          <a class=""card"">
            <div class=""card-header p-3 pt-2"">
              <div class=""icon icon-lg icon-shape bg-gradient-info shadow-info text-center border-radius-xl mt-n4 position-absolute"">
                <i class=""fas fa-book""></i>
              </div>
              <div class=""text-end pt-1"">
                <h3 class=""text-white"">
                              ");
#nullable restore
#line 55 "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Dashboard\Index.cshtml"
                         Write(ViewBag.SubjectCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                          </h3>
                            <p class=""text-white"">
                                Subject                            </p>
              </div>
            </div>
             
            <hr class=""dark horizontal my-0"">
            <div class=""card-footer p-3"">
");
            WriteLiteral("            </div>\r\n          </a>\r\n        </div>\r\n        \r\n      </div>\r\n      </div>");
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
