#pragma checksum "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Faculty\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8fd21e486a16b1de00d388a02401a462cf8c258"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Faculty_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Faculty/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8fd21e486a16b1de00d388a02401a462cf8c258", @"/Areas/Admin/Views/Faculty/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42947ea54445d08770d7576797391323b0074e32", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Faculty_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Paginate<FacultyListVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Group", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Faculty\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Faculty\Index.cshtml"
  
    ViewData["Title"] = "Index";
    int count = ViewBag.TakeCount;
    int page = Model.PageCount;
    int productNum = ((Model.CurrentPage - 1) * count) + 1;
    int previous = Model.CurrentPage - 1;
    int next = Model.CurrentPage + 1;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n  <div class=\"container-fluid py-4\">\r\n    <div class=\"row\">\r\n       \r\n");
#nullable restore
#line 19 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Faculty\Index.cshtml"
        foreach (var item in Model.Item)
      {
          
      

#line default
#line hidden
#nullable disable
            WriteLiteral("           <div class=\"col-md-4 col-6\">\r\n                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8fd21e486a16b1de00d388a02401a462cf8c2587112", async() => {
                WriteLiteral(@" 
                    <div class=""card-header mx-4 p-3 text-center"">
                      <div class=""icon icon-shape icon-lg bg-gradient-primary shadow text-center border-radius-lg"">
                          <i class=""material-icons opacity-10"">account_balance</i>
                      </div>
                    </div>
                    <div class=""card-body pt-0 p-3 text-center"">
                      <h3 class=""text-center mb-0""> ");
#nullable restore
#line 31 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Faculty\Index.cshtml"
                                               Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                      <span class=\"text-xl\"></span>\r\n                      <hr class=\"horizontal dark my-3\">\r\n                      <h6 class=\"mb-0\">Group Count:");
#nullable restore
#line 34 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Faculty\Index.cshtml"
                                              Write(item.GroupCount);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </h6>\r\n                    \r\n                    </div>\r\n                  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 24 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Faculty\Index.cshtml"
                                                                                WriteLiteral(item.Id);

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
            WriteLiteral("\r\n                  <div>  </div>\r\n                </div>\r\n");
#nullable restore
#line 40 "D:\Folders\CodeAcademyProjetc(Final)\StudentInformationSysteam\StudentInformationSysteam\Areas\Admin\Views\Faculty\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Paginate<FacultyListVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
