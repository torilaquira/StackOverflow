#pragma checksum "C:\DevBuild\Week10\StackOverflowLab\Views\Answers\ListAnswers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43e9ba28c4a98972d7c2a7731910c43095660f74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Answers_ListAnswers), @"mvc.1.0.view", @"/Views/Answers/ListAnswers.cshtml")]
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
#line 1 "C:\DevBuild\Week10\StackOverflowLab\Views\_ViewImports.cshtml"
using StackOverflowLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\DevBuild\Week10\StackOverflowLab\Views\_ViewImports.cshtml"
using StackOverflowLab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43e9ba28c4a98972d7c2a7731910c43095660f74", @"/Views/Answers/ListAnswers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29c8d0e2e969865db08c096d00aa85bf68e1a8a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Answers_ListAnswers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuestionsAnswers>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\DevBuild\Week10\StackOverflowLab\Views\Answers\ListAnswers.cshtml"
  
    ViewData["Title"] = "ListAnswers";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>List Answers</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\DevBuild\Week10\StackOverflowLab\Views\Answers\ListAnswers.cshtml"
Write(Model.ques.detail);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\r\n");
#nullable restore
#line 9 "C:\DevBuild\Week10\StackOverflowLab\Views\Answers\ListAnswers.cshtml"
 foreach (answers ans in Model.ans)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\DevBuild\Week10\StackOverflowLab\Views\Answers\ListAnswers.cshtml"
           Write(ans.detail);

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\DevBuild\Week10\StackOverflowLab\Views\Answers\ListAnswers.cshtml"
                       Write(ans.posted);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <a");
            BeginWriteAttribute("href", " href=\"", 220, "\"", 260, 2);
            WriteAttributeValue("", 227, "/answers/editanswer?ansid=", 227, 26, true);
#nullable restore
#line 11 "C:\DevBuild\Week10\StackOverflowLab\Views\Answers\ListAnswers.cshtml"
WriteAttributeValue("", 253, ans.id, 253, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n");
#nullable restore
#line 12 "C:\DevBuild\Week10\StackOverflowLab\Views\Answers\ListAnswers.cshtml"
            }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuestionsAnswers> Html { get; private set; }
    }
}
#pragma warning restore 1591
