#pragma checksum "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8270a7ddc799558118aaa5b6fc5b5c4fb028d8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Views\_ViewImports.cshtml"
using StudentInformationSysteam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Views\_ViewImports.cshtml"
using StudentIformationSysteam.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Views\_ViewImports.cshtml"
using StudentInformationSysteam.Business.ViewModel.StudentProfile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Views\_ViewImports.cshtml"
using StudentInformationSysteam.Business.ViewModel.TeacherSubject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8270a7ddc799558118aaa5b6fc5b5c4fb028d8f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75d3b29760879f223548e023442c6451b5aa6794", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"   <section id=""Notification"" class=""my-3"">
                <div class=""container"">
                    <h2 style=""display:inline-block;border-bottom:2px solid cyan ;"">Notifications</h2>
                    <div class=""row"">
                   
                  
");
#nullable restore
#line 7 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Views\Home\Index.cshtml"
                      foreach (var item in ViewBag.Notifications)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                          <div class=""card my-2"">
                        <div class=""card__icon"">
                          <svg width=""20"" height=""20"" viewBox=""0 0 20 20"" fill=""none"" xmlns=""http://www.w3.org/2000/svg"">
                      <path d=""M12.0964 16.6667C12.0964 18.5077 10.6039 20 8.76297 20C6.922 20 5.42969 18.5077 5.42969 16.6667C5.42969 14.8257 6.922 13.3333 8.76297 13.3333C10.6039 13.3333 12.0964 14.8257 12.0964 16.6667Z"" fill=""#22215B""/>
                      <path d=""M14.603 9.93424C11.778 9.5308 9.59641 7.1016 9.59641 4.16673C9.59641 3.33329 9.77463 2.54258 10.0905 1.82496C9.66385 1.72501 9.22058 1.66673 8.76297 1.66673C5.54642 1.66673 2.92969 4.2833 2.92969 7.50001V9.82331C2.92969 11.4725 2.20718 13.0292 0.939636 14.1008C0.61554 14.3774 0.429688 14.7817 0.429688 15.2083C0.429688 16.0126 1.08383 16.6667 1.88797 16.6667H15.638C16.4423 16.6667 17.0964 16.0126 17.0964 15.2083C17.0964 14.7817 16.9106 14.3774 16.5781 14.0933C15.3481 13.0525 14.6347 11.5416 14.603 9.93424Z"" fill=""#22215B""/>");
            WriteLiteral(@"
                      <path d=""M19.5964 4.16672C19.5964 6.4679 17.7309 8.33328 15.4297 8.33328C13.1285 8.33328 11.263 6.4679 11.263 4.16672C11.263 1.86554 13.1285 0 15.4297 0C17.7309 0 19.5964 1.86554 19.5964 4.16672Z"" fill=""#4CE364""/>
                      </svg>
                      
                        </div>
                        <div class=""card__message"">
                          <h2>");
#nullable restore
#line 19 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Views\Home\Index.cshtml"
                         Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                          <p>");
#nullable restore
#line 20 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Views\Home\Index.cshtml"
                        Write(item.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                      </div>\n");
#nullable restore
#line 23 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n            </section>");
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
