#pragma checksum "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\TeacherSubject\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b58bda836c7daccd60f492ae89121f861cabe0cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Teacher_Views_TeacherSubject_Details), @"mvc.1.0.view", @"/Areas/Teacher/Views/TeacherSubject/Details.cshtml")]
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
#line 1 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\_ViewImports.cshtml"
using StudentInformationSysteam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\_ViewImports.cshtml"
using StudentIformationSysteam.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\_ViewImports.cshtml"
using StudentInformationSysteam.Business.ViewModel.StudentProfile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\_ViewImports.cshtml"
using StudentInformationSysteam.Business.ViewModel.DocumentVMs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\_ViewImports.cshtml"
using StudentInformationSysteam.Business.ViewModel.TeacherSubject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\_ViewImports.cshtml"
using StudentInformationSysteam.Business.ViewModel.TeacherLesson;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b58bda836c7daccd60f492ae89121f861cabe0cd", @"/Areas/Teacher/Views/TeacherSubject/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0c8dd124ccff6ff2118fcf27d8e93f62f90c9a4", @"/Areas/Teacher/Views/_ViewImports.cshtml")]
    public class Areas_Teacher_Views_TeacherSubject_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SubjectDetailVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success my-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Upload", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Document", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DownloadFile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "TeacherLesson", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\TeacherSubject\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Teacher/Views/Shared/_TeacherLayout.cshtml";
    int count = 1;
    int docCount = 1;

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <section>
           <link
                href=""https://fonts.googleapis.com/css?family=Work+Sans:400,600,700&display=swap""
                rel=""stylesheet"">

            <div class=""layout"">
                <input
                    name=""nav""
                    type=""radio""
                    class=""nav home-radio""
                    id=""home""
                    checked=""checked""/>
                <div class=""page home-page"">
                    <div class=""page-contents"">
                        <div class=""container my-3"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b58bda836c7daccd60f492ae89121f861cabe0cd8373", async() => {
                WriteLiteral("Add Material");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\TeacherSubject\Details.cshtml"
                                                                       WriteLiteral(ViewBag.GroupId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\TeacherSubject\Details.cshtml"
                                                                                                          WriteLiteral(ViewBag.SubjectId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sbjId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sbjId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sbjId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <ul class=""responsive-table"">
                                <li class=""table-header"">
                                    <div class=""col col-2"">№</div>
                                    <div class=""col col-6"">File Name</div>
                                    <div class=""col col-2"">Dwonload</div>

                                </li>
");
#nullable restore
#line 32 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\TeacherSubject\Details.cshtml"
                         if (Model.Documents.Count() != 0)
                        {
                            
                      
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\TeacherSubject\Details.cshtml"
                         foreach (var doc in Model.Documents)
                               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li class=\" table-row\">\r\n                                    <div class=\"col col-2\" data-label=\"№\">");
#nullable restore
#line 39 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\TeacherSubject\Details.cshtml"
                                                                     Write(docCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                    <div class=\"col col-6\" data-label=\"File Name\"> ");
#nullable restore
#line 40 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\TeacherSubject\Details.cshtml"
                                                                              Write(doc.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"col col-2\" data-label=\"Attendance\">\r\n                                       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b58bda836c7daccd60f492ae89121f861cabe0cd13986", async() => {
                WriteLiteral(" <i class=\"fas fa-file-download\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 43 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\TeacherSubject\Details.cshtml"
                                                                                                WriteLiteral(doc.Id);

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
            WriteLiteral("\r\n                                    </div>\r\n\r\n                            </li>\r\n");
#nullable restore
#line 47 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\TeacherSubject\Details.cshtml"
                            docCount++;
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\TeacherSubject\Details.cshtml"
                         
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                    <li class="" table-row"">
                                        <div class=""col-lg-12"">
                                            <h2 class=""text-center"">No Yet Document</h2>
                                        </div>
                                   </li>
");
#nullable restore
#line 57 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\TeacherSubject\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                

                            </ul>
                        </div>

                    </div>
                </div>
                <label class=""nav"" for=""home"">
                    <span>
                        <i class=""fas fa-file-alt""></i>
                    </polyline>
                </svg>
                Didactic material
            </span>
        </label>

        <input name=""nav"" type=""radio"" class=""about-radio"" id=""about""/>
        <div class=""page about-page"">
            <div class=""page-contents"">
                <div class=""container my-3"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b58bda836c7daccd60f492ae89121f861cabe0cd18513", async() => {
                WriteLiteral("\r\n                        <input type=\"date\"");
                BeginWriteAttribute("name", " name=\"", 3390, "\"", 3397, 0);
                EndWriteAttribute();
                BeginWriteAttribute("id", " id=\"", 3398, "\"", 3403, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <ul class=""attendance-table my-4"">
                            <li class=""table-header"">
                                <div class=""col col-1"">№</div>
                                <div class=""col col-4"">Studnet Name</div>
                                <div class=""col col-4"">Attendance</div>

                            </li>

                            <li class="" table-row"">
                                <div class=""col col-1"" data-label=""№"">1</div>
                                <div class=""col col-lg-4"" data-label=""Lesson Date"">Tural Memmedzade
                                </div>
                                <div class=""col col-3 "" data-label=""Attendance"">
                                    <label class=""onoffbtn""><input type=""checkbox""></label>
                                </div>

                            </li>
                            <li class="" table-row"">
                                <div class=""col col-1"" data-label=""№"">2</div>");
                WriteLiteral(@"
                                <div class=""col col-4"" data-label=""Lesson Date"">Orkhan Ganbarov</div>
                                <div class=""col col-3"" data-label=""Download"">
                                    <label class=""onoffbtn""><input type=""checkbox""></label>
                                </div>

                            </li>

                        </ul>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <label class=""nav"" for=""about"">
            <span>
                <svg><use href=""~/assets/img/attendance.svg""/></svg>
                <svg
                    viewbox=""0 0 24 24""
                    width=""24""
                    height=""24""
                    stroke=""currentColor""
                    stroke-width=""2""
                    fill=""none""
                    stroke-linecap=""round""
                    stroke-linejoin=""round""
                    class=""css-i6dzq1"">
                    <circle cx=""12"" cy=""12"" r=""10""></circle>
                    <path d=""M9.09 9a3 3 0 0 1 5.83 1c0 2-3 3-3 3""></path>
                    <line x1=""12"" y1=""17"" x2=""12"" y2=""17""></line>
                </svg>
                Attendance
            </span>
        </label>

                <input name=""nav"" type=""radio"" class=""contact-radio"" id=""contact""/>
                <div class=""page contact-page"">
                    <div cl");
            WriteLiteral("ass=\"page-contents\">\r\n                      <div class=\"col-lg-10\"> ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b58bda836c7daccd60f492ae89121f861cabe0cd22827", async() => {
                WriteLiteral("Add");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-groupId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 135 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\TeacherSubject\Details.cshtml"
                                                        WriteLiteral(ViewBag.GroupId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["groupId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-groupId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["groupId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 135 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\TeacherSubject\Details.cshtml"
                                                                                           WriteLiteral(ViewBag.SubjectId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sbjId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sbjId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sbjId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@" </div>
                       
                <section class=""mt-5 "">
    <div class=""container animate_animated animatebackInDown animate_delay-0.5s"">
        
        <div class=""row"">
            <div class=""col-12"">
                <table class=""table table-hover"">
                    <thead>
                      <tr>
                        <th scope=""col"">Students name</th>
                        <th scope=""col"">Type</th>
                        <th scope=""col"">Topic</th>
                        <th scope=""col"">Score</th>
                       
                      </tr>
                    </thead>
                    <tbody>
                         
");
#nullable restore
#line 154 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\TeacherSubject\Details.cshtml"
                              foreach(var lesson in Model.Lessons){

#line default
#line hidden
#nullable disable
            WriteLiteral("                               <tr> \r\n                                   <td>\r\n                                       ");
#nullable restore
#line 157 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\TeacherSubject\Details.cshtml"
                                  Write(lesson.AppUser.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                   </td>\r\n                                    <td>\r\n                                       ");
#nullable restore
#line 160 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\TeacherSubject\Details.cshtml"
                                  Write(lesson.LessonType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                   </td>\r\n                                   <td>\r\n                                       ");
#nullable restore
#line 163 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\TeacherSubject\Details.cshtml"
                                  Write(lesson.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                   </td>\r\n                                    <td>\r\n                                       ");
#nullable restore
#line 166 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\TeacherSubject\Details.cshtml"
                                  Write(lesson.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                   </td>\r\n                            \r\n                            </tr>   \r\n");
#nullable restore
#line 170 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Teacher\Views\TeacherSubject\Details.cshtml"
                             } 

#line default
#line hidden
#nullable disable
            WriteLiteral("                        \r\n                       \r\n                        \r\n                \r\n                    </tbody>\r\n                  </table>\r\n                \r\n            </div>\r\n            <div class=\"col-12 my-4\">\r\n");
            WriteLiteral(@"            </div>
        </div>
    </div>

</section>

                       
                    </div>
                </div>
                <label class=""nav"" for=""contact"">
                    <span>
                        <svg
                            viewbox=""0 0 24 24""
                            width=""24""
                            height=""24""
                            stroke=""currentColor""
                            stroke-width=""2""
                            fill=""none""
                            stroke-linecap=""round""
                            stroke-linejoin=""round""
                            class=""css-i6dzq1"">
                            <path
                                d=""M21 11.5a8.38 8.38 0 0 1-.9 3.8 8.5 8.5 0 0 1-7.6 4.7 8.38 8.38 0 0 1-3.8-.9L3 21l1.9-5.7a8.38 8.38 0 0 1-.9-3.8 8.5 8.5 0 0 1 4.7-7.6 8.38 8.38 0 0 1 3.8-.9h.5a8.48 8.48 0 0 1 8 8v.5z""></path>
                        </svg>
                        Evaluation
                   ");
            WriteLiteral(" </span>\r\n\r\n                </label>\r\n            </div>\r\n        </section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SubjectDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
