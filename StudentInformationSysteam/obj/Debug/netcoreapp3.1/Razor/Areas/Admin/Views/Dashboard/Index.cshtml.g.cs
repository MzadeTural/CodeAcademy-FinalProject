#pragma checksum "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3b69021db251bf60397f63fdab687fbcfd09bc6"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3b69021db251bf60397f63fdab687fbcfd09bc6", @"/Areas/Admin/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42947ea54445d08770d7576797391323b0074e32", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
 /*   .card-footer {
      overflow:hidden;
          padding:0rem !important;
        transition:0.6s;
        height:0;
        z-index:3;
    }*/
      .card {
       /*padding:1.5rem !important;*/
          border-left: 0px solid #e43370;
            border-right: 0px solid #e43370 ;
             transition:0.6s;

    }
    .card:hover {
       /*padding:1.5rem !important;*/
          border-left: 11px solid #e43370 ;
           border-right: 11px solid #e43370 ;
             transition:0.6s;
           transform: scale(1.1)

    }
</style>
<div class=""container-fluid py-4"">
    <div class=""row"">

        <div class=""col-xl-4 col-sm-6 my-3"">
            <div class=""card"">
                <div class=""card-header p-3 pt-2"">
                    <div class=""icon icon-lg icon-shape bg-gradient-info shadow-info text-center border-radius-xl mt-n4 position-absolute"">
                        <i class=""fas fa-user-graduate""></i>
                    </div>
                   ");
            WriteLiteral(" <div class=\"text-end pt-1\">\r\n                        <h3 class=\"text-white\">\r\n                            ");
#nullable restore
#line 36 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Dashboard\Index.cshtml"
                       Write(ViewBag.UserStudent);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </h3>
                        <p class=""text-white"">
                            Student
                        </p>
                    </div>
                </div>

                <hr class=""dark horizontal my-0"">
                <div class=""card-footer p-3"">
");
            WriteLiteral(@"                </div>
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
#line 58 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Dashboard\Index.cshtml"
                       Write(ViewBag.TeacherCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </h3>
                        <p class=""text-white"">
                            Teacher
                        </p>
                    </div>
                </div>

                <hr class=""dark horizontal my-0"">
                <div class=""card-footer p-3"">
");
            WriteLiteral(@"                </div>
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
#line 80 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Dashboard\Index.cshtml"
                       Write(ViewBag.SubjectCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </h3>
                        <p class=""text-white"">
                            Subject
                        </p>
                    </div>
                </div>

                <hr class=""dark horizontal my-0"">
                <div class=""card-footer p-3"">
");
            WriteLiteral(@"                </div>
            </a>
        </div>


        <div class=""col-xl-4 col-sm-6 my-3"">
            <a class=""card"">
                <div class=""card-header p-3 pt-2"">
                    <div class=""icon icon-lg icon-shape bg-gradient-info shadow-info text-center border-radius-xl mt-n4 position-absolute"">
                        <i class=""fas fa-users""></i>
                    </div>
                    <div class=""text-end pt-1"">
                        <h3 class=""text-white"">
                            ");
#nullable restore
#line 104 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Dashboard\Index.cshtml"
                       Write(ViewBag.GroupCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                        </h3>
                        <p class=""text-white"">
                            Group
                        </p>
                    </div>
                </div>

                <hr class=""dark horizontal my-0"">
                <div class=""card-footer p-3"">
");
            WriteLiteral(@"                </div>
            </a>
        </div>
        <div class=""col-xl-4 col-sm-6 my-3"">
            <a class=""card"">
                <div class=""card-header p-3 pt-2"">
                    <div class=""icon icon-lg icon-shape bg-gradient-info shadow-info text-center border-radius-xl mt-n4 position-absolute"">
                        <i class=""material-icons opacity-10"">account_balance</i>
                    </div>
                    <div class=""text-end pt-1"">
                        <h3 class=""text-white"">
                            ");
#nullable restore
#line 127 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Dashboard\Index.cshtml"
                       Write(ViewBag.FacultyCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </h3>
                        <p class=""text-white"">
                            Faculty
                        </p>
                    </div>
                </div>

                <hr class=""dark horizontal my-0"">
                <div class=""card-footer p-3"">
");
            WriteLiteral(@"                </div>
            </a>
        </div>
         <div class=""col-xl-4 col-sm-6 my-3"">
            <a class=""card"">
                <div class=""card-header p-3 pt-2"">
                    <div class=""icon icon-lg icon-shape bg-gradient-info shadow-info text-center border-radius-xl mt-n4 position-absolute"">
                       <i class=""fas fa-id-card-alt""></i>
                    </div>
                    <div class=""text-end pt-1"">
                        <h3 class=""text-white"">
                            ");
#nullable restore
#line 149 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Dashboard\Index.cshtml"
                       Write(ViewBag.SpecalityCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </h3>
                        <p class=""text-white"">
                            Specality
                        </p>
                    </div>
                </div>

                <hr class=""dark horizontal my-0"">
               <div class=""card-footer p-3"">
                </div>
            </a>
        </div>
    </div>
</div>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
