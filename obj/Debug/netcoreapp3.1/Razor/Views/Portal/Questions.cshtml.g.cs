#pragma checksum "C:\Users\ksanjiv\Desktop\MiniProj\Exmination\Exmination\Views\Portal\Questions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "534940e0efddc729300e754afc675bedf6f38518"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portal_Questions), @"mvc.1.0.view", @"/Views/Portal/Questions.cshtml")]
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
#line 1 "C:\Users\ksanjiv\Desktop\MiniProj\Exmination\Exmination\Views\_ViewImports.cshtml"
using Exmination;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ksanjiv\Desktop\MiniProj\Exmination\Exmination\Views\_ViewImports.cshtml"
using Exmination.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ksanjiv\Desktop\MiniProj\Exmination\Exmination\Views\_ViewImports.cshtml"
using Exmination.Models.Student;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"534940e0efddc729300e754afc675bedf6f38518", @"/Views/Portal/Questions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"103968db727d0bd3c08098acb7dcc6416a96a11a", @"/Views/_ViewImports.cshtml")]
    public class Views_Portal_Questions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("regForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/action_page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ksanjiv\Desktop\MiniProj\Exmination\Exmination\Views\Portal\Questions.cshtml"
  
    ViewData["Title"] = "Questions";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "534940e0efddc729300e754afc675bedf6f385184387", async() => {
                WriteLiteral(@"
    <h1>Register:</h1>
    <!-- One ""tab"" for each step in the form: -->
    <div class=""tab"">
        Name:
        <p><input placeholder=""First name..."" oninput=""this.className = ''"" name=""fname""></p>
        <p><input placeholder=""Last name..."" oninput=""this.className = ''"" name=""lname""></p>
    </div>
    <div class=""tab"">
        Contact Info:
        <p><input placeholder=""E-mail..."" oninput=""this.className = ''"" name=""email""></p>
        <p><input placeholder=""Phone..."" oninput=""this.className = ''"" name=""phone""></p>
    </div>
    <div class=""tab"">
        Birthday:
        <p><input placeholder=""dd"" oninput=""this.className = ''"" name=""dd""></p>
        <p><input placeholder=""mm"" oninput=""this.className = ''"" name=""nn""></p>
        <p><input placeholder=""yyyy"" oninput=""this.className = ''"" name=""yyyy""></p>
    </div>
    <div class=""tab"">
        Login Info:
        <p><input placeholder=""Username..."" oninput=""this.className = ''"" name=""uname""></p>
        <p><input placeholder=""");
                WriteLiteral(@"Password..."" oninput=""this.className = ''"" name=""pword"" type=""password""></p>
    </div>
    <div style=""overflow:auto;"">
        <div style=""float:right;"">
            <button type=""button"" id=""prevBtn"" onclick=""nextPrev(-1)"">Previous</button>
            <button type=""button"" id=""nextBtn"" onclick=""nextPrev(1)"">Next</button>
        </div>
    </div>
    <!-- Circles which indicates the steps of the form: -->
    <div style=""text-align:center;margin-top:40px;"">
        <span class=""step""></span>
        <span class=""step""></span>
        <span class=""step""></span>
        <span class=""step""></span>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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