#pragma checksum "C:\Users\ksanjiv\Desktop\MiniProj\Exmination\Exmination\Views\Student\Enrolled.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9133699a2c07f0e1d62cd12011c63459bc1c5481"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Enrolled), @"mvc.1.0.view", @"/Views/Student/Enrolled.cshtml")]
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
#nullable restore
#line 4 "C:\Users\ksanjiv\Desktop\MiniProj\Exmination\Exmination\Views\_ViewImports.cshtml"
using Exmination.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ksanjiv\Desktop\MiniProj\Exmination\Exmination\Views\_ViewImports.cshtml"
using Exmination.ModelView.Student;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ksanjiv\Desktop\MiniProj\Exmination\Exmination\Views\_ViewImports.cshtml"
using Exmination.ModelView.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9133699a2c07f0e1d62cd12011c63459bc1c5481", @"/Views/Student/Enrolled.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5d13cde76e809d60fec9029202340f86daf70e3e", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Enrolled : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Enrollment>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>You are Enrolled :  ");
#nullable restore
#line 3 "C:\Users\ksanjiv\Desktop\MiniProj\Exmination\Exmination\Views\Student\Enrolled.cshtml"
                    Write(Model.Registration_number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Enrollment> Html { get; private set; }
    }
}
#pragma warning restore 1591
