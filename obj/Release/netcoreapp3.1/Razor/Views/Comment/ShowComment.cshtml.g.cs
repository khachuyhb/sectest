#pragma checksum "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Comment\ShowComment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33fdfb82076b2eaa94ecd6ec8e798a0804889139"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comment_ShowComment), @"mvc.1.0.view", @"/Views/Comment/ShowComment.cshtml")]
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
#line 1 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\_ViewImports.cshtml"
using ShoesLover;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\_ViewImports.cshtml"
using ShoesLover.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33fdfb82076b2eaa94ecd6ec8e798a0804889139", @"/Views/Comment/ShowComment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30d652e32e50049a3a6fb731130cf3a1e6ecd20d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Comment_ShowComment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Comment\ShowComment.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""display-comment"">
        <div class=""comment-customer"">
            <div class=""img-comment"">
                <input type=""hidden"" name=""comment_product_id"" class=""comment_product_id"" />
                <p style=""width: 40px; height: 40px; background: rgb(242,242,242); border-radius:50%;text-align:center;""><span style=""position: relative; top: 12px;"">User</span></p>
            </div>

            <div class=""text-comment"">
                <div class=""infor-comment"">
                    <span style=""color: blue;"">");
#nullable restore
#line 19 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Comment\ShowComment.cshtml"
                                          Write(item.CommentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span>");
#nullable restore
#line 20 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Comment\ShowComment.cshtml"
                     Write(item.CommentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\r\n                </div>\r\n                <div>\r\n                    ");
#nullable restore
#line 23 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Comment\ShowComment.cshtml"
               Write(item.CommentText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n       \r\n");
#nullable restore
#line 28 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Comment\ShowComment.cshtml"
         foreach (var index in item.listparentcomment)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""comment-admin"">
                <div class=""img-comment "">
                    <input type=""hidden"" name=""comment_product_id"" class=""comment_product_id"" />
                    <p style=""width: 40px; height: 40px; background: rgb(242,242,242); border-radius:50%;text-align:center;""><span style=""position: relative; top: 12px;"">Ad</span></p>
                </div>

                <div class=""text-comment"">
                    <div class=""infor-comment"">
                        <span style=""color: blue;"">");
#nullable restore
#line 39 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Comment\ShowComment.cshtml"
                                              Write(index.CommentName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <span>");
#nullable restore
#line 40 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Comment\ShowComment.cshtml"
                         Write(index.CommentDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> <br />\r\n                    </div>\r\n                    <div>\r\n                        ");
#nullable restore
#line 43 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Comment\ShowComment.cshtml"
                   Write(index.CommentText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 47 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Comment\ShowComment.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n");
#nullable restore
#line 52 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Comment\ShowComment.cshtml"


}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .comment-customer{
        display: flex;

    }
    .show-comment-admin {
        display: flex;
        margin: 30px 0 30px 50px;
    }

    .info-com {
        display: flex;
        justify-content: space-between;
    }

    .comment-admin {
        margin-top: 10px;
        margin-left : 30px;
        display: flex;
        
    }
</style>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
