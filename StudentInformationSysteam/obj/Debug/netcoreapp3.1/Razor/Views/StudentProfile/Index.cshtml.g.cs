#pragma checksum "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Views\StudentProfile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cf8368433d5683970e2bf4d77e5784bfcf37737"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_StudentProfile_Index), @"mvc.1.0.view", @"/Views/StudentProfile/Index.cshtml")]
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
#line 1 "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Views\_ViewImports.cshtml"
using StudentInformationSysteam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Views\_ViewImports.cshtml"
using StudentIformationSysteam.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Views\_ViewImports.cshtml"
using StudentInformationSysteam.Business.ViewModel.StudentProfile;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cf8368433d5683970e2bf4d77e5784bfcf37737", @"/Views/StudentProfile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3b41313482990f2a25baee5b04e4a5a8b1df1ce", @"/Views/_ViewImports.cshtml")]
    public class Views_StudentProfile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProfileVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #5567ff;padding: 0.4rem;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("profile_img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/white.svg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
 <section id=""StudentProfil"">
          <!-- Student Profile -->
<div class=""student-profile py-4"">
    <div class=""container"">
      <div class=""row"">
        <div class=""col-lg-4"">
          <div class=""card shadow-sm"">
            <div class=""card-header bg-transparent text-center"">
              <!-- <img class=""profile_img"" src=""https://placeimg.com/640/480/arch/any"" alt=""""> -->
              ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0cf8368433d5683970e2bf4d77e5784bfcf377375345", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
              <h3>Tural Memmedzade</h3>
            </div>
            <div class=""card-body"">
              <p class=""mb-0""><strong class=""pr-1"">Student ID:</strong>201906140</p>
              <p class=""mb-0""><strong class=""pr-1"">Class:</strong>3</p>
              <p class=""mb-0""><strong class=""pr-1"">Section:</strong>A</p>
            </div>
          </div>
        </div>
        <div class=""col-lg-8"">
          <div class=""card shadow-sm"">
            <div class=""card-header bg-transparent border-0"">
              <h3 class=""mb-0""><i class=""far fa-clone pr-1""></i>General Information</h3>
            </div>
            <div class=""card-body pt-0"">
              <table class=""table table-bordered"">
                <tr>
                  <th width=""30%"">Roll</th>
                  <td width=""2%"">:</td>
                  <td>Bachelor</td>
                </tr>
                <tr>
                  <th width=""30%"">Academic Year	</th>
                  <td width=""2%"">:</td>
           ");
            WriteLiteral(@"       <td>2022</td>
                </tr>
                <tr>
                  <th width=""30%"">Gender</th>
                  <td width=""2%"">:</td>
                  <td>Male</td>
                </tr>
                <tr>
                  <th width=""30%"">Religion</th>
                  <td width=""2%"">:</td>
                  
                  <td>Group : ");
#nullable restore
#line 48 "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Views\StudentProfile\Index.cshtml"
                         Write(Model.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                </tr>
                <tr>
                  <th width=""30%"">blood</th>
                  <td width=""2%"">:</td>
                  <td>B+</td>                 
                </tr>
                <tr>
                    <th width=""30%"">Identity card serial number</th>
                    <td width=""2%"">:</td>
                    <td>18513013</td>                 
                  </tr>
                  <tr>
                    <th width=""30%"">Father Name</th>
                    <td width=""2%"">:</td>
                    <td>");
#nullable restore
#line 63 "C:\Users\Tural\Desktop\StudentInformationSysteam\StudentInformationSysteam\Views\StudentProfile\Index.cshtml"
                   Write(Model.FateherName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>                 
                  </tr>
                  <tr>
                    <th width=""30%"">Type of education</th>
                    <td width=""2%"">:</td>
                    <td>State-ordered</td>                 
                  </tr>
                  <tr>
                    <th width=""30%"">Qualification</th>
                    <td width=""2%"">:</td>
                    <td>Computer science</td>                 
                  </tr>
                  <tr>
                    <th width=""30%"">Name of the faculty</th>
                    <td width=""2%"">:</td>
                    <td>Information and telecommunication technologies</td>                 
                  </tr>
                  
                  
              </table>
            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
  
        </section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfileVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
