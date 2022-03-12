#pragma checksum "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Group\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "369e8fca066a9a09e2db673f7a2c359a7e50e796"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Group_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Group/Index.cshtml")]
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
#nullable restore
#line 6 "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\_ViewImports.cshtml"
using StudentInformationSysteam.Business.ViewModel.UserGroup;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"369e8fca066a9a09e2db673f7a2c359a7e50e796", @"/Areas/Admin/Views/Group/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1598c4e5c23b94986104874ffc85086e4d85323", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Group_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GroupInfoVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Group\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container-fluid py-4\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Group\Index.cshtml"
         foreach (var group in Model.Groups)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"           <div class=""col-md-4 col-6"">
                  <a class=""card"">
                    <div class=""card-header mx-4 p-3 text-center"">
                      <div class=""icon icon-shape icon-lg bg-gradient-primary shadow text-center border-radius-lg"">
                        <i class=""fas fa-users opacity-10""></i>
                      </div>
                    </div>
                    <div class=""card-body pt-0 p-3 text-center"">
                      <h6 class=""text-center mb-0""> Name: ");
#nullable restore
#line 20 "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Group\Index.cshtml"
                                                     Write(group.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                      <span class=\"text-xl\">Faclty:");
#nullable restore
#line 21 "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Group\Index.cshtml"
                                              Write(group.Faculty.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                      <hr class=\"horizontal dark my-3\">\r\n                      <h5 class=\"mb-0\">Course ");
#nullable restore
#line 23 "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Group\Index.cshtml"
                                         Write(group.Course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                    \r\n                    </div>\r\n                  </a>\r\n                </div>\r\n");
#nullable restore
#line 28 "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Group\Index.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("         \r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GroupInfoVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
