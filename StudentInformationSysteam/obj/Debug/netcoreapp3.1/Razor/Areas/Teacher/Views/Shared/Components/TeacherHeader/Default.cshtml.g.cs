#pragma checksum "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\Shared\Components\TeacherHeader\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6310ae4338c7d1786eb2705330e47888ac15e168"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Teacher_Views_Shared_Components_TeacherHeader_Default), @"mvc.1.0.view", @"/Areas/Teacher/Views/Shared/Components/TeacherHeader/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6310ae4338c7d1786eb2705330e47888ac15e168", @"/Areas/Teacher/Views/Shared/Components/TeacherHeader/Default.cshtml")]
    public class Areas_Teacher_Views_Shared_Components_TeacherHeader_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"  <header id=""MainNav"" class=""d-flex"">
            <button id=""shw"" class=""navbar-toggle"">
                <i class=""fas fa-bars""></i>
            </button>
            <nav class=""navbar navbar-light "">
                <div class=""container-fluid"" style=""padding:0 !important;"">
                    <a  class=""navbar-brand nav-logo"">
                        <img style=""padding:0.5rem 0;"" src=""/FinalProject/assets/img/logo.png""");
            BeginWriteAttribute("alt", " alt=\"", 436, "\"", 442, 0);
            EndWriteAttribute();
            WriteLiteral("></a>\r\n                </div>\r\n            </nav>\r\n            <ul class=\"navbar-nav ms-auto \">\r\n                <li><a style=\"color: white !Important;\" class=\"user-link\"");
            BeginWriteAttribute("href", " href=\"", 613, "\"", 620, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-user\"></i><span class=\"username\">Tural Memmedzade</span></a></li>\r\n                   <li><a class=\"signout\"");
            BeginWriteAttribute("href", " href=\"", 747, "\"", 754, 0);
            EndWriteAttribute();
            WriteLiteral("> <i class=\"fad fa-sign-out\"></i></a></li>\r\n            </ul>\r\n        </header>\r\n");
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
