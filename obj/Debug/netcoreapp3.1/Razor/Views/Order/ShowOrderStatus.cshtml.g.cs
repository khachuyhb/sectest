#pragma checksum "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80a09012bf3b73e6b91048f6f29defd1521f3053"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_ShowOrderStatus), @"mvc.1.0.view", @"/Views/Order/ShowOrderStatus.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80a09012bf3b73e6b91048f6f29defd1521f3053", @"/Views/Order/ShowOrderStatus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30d652e32e50049a3a6fb731130cf3a1e6ecd20d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Order_ShowOrderStatus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 60%; padding:5px 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 30%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n\r\n\r\n<meta http-equiv=\"pragma\" content=\"no-cache\" />\r\n\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--<p>Mã đơn hàng: item.ID</p>  -->\r\n    <div class=\"order-title\" style=\"margin-top:50px; margin-bottom:20px;\">\r\n        <p style=\"font-weight: bold;\">Ngày đặt: ");
#nullable restore
#line 12 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
                                           Write(item.OrderDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 13 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
         if (item.Status == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"font-weight:bold;\">Trạng thái: Chờ xác nhận</p>\r\n");
#nullable restore
#line 16 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
        }
        else if (item.Status == 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"font-weight:bold;\">Trạng thái: Chờ lấy hàng</p>\r\n");
#nullable restore
#line 20 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
        }
        else if (item.Status == 2)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"font-weight:bold;\">Trạng thái: Đang giao</p>\r\n");
#nullable restore
#line 24 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
        }
        else if (item.Status == 3)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"font-weight:bold;\">Trạng thái: Đã giao</p>\r\n");
#nullable restore
#line 28 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
        }
        else if (item.Status == 4)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"font-weight:bold;\">Trạng thái: Đã huỷ</p>\r\n");
#nullable restore
#line 32 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p style=\"font-weight:bold;\">Trạng thái: Trả hàng</p>\r\n");
#nullable restore
#line 36 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </div>
    <div class=""order-table-list"">
        <table style=""width:90%"">
            <tr>

                <th style=""width:150px;""><p style=""width: 60%; "">Hình</p></th>
                <th>Tên</th>
                <th>Size</th>
                <th>Màu</th>
                <th>Số lượng</th>
                <th>Giá</th>



            </tr>



");
#nullable restore
#line 56 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
             foreach (var index in item.orderlist)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"img-pro-order\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "80a09012bf3b73e6b91048f6f29defd1521f30537497", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1562, "~/image/", 1562, 8, true);
#nullable restore
#line 59 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
AddHtmlAttributeValue("", 1570, index.ProductImage, 1570, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <td style=\"text-align:center\">");
#nullable restore
#line 60 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
                                             Write(index.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"text-align:center\">");
#nullable restore
#line 61 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
                                             Write(index.SizeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td class=\"img-color-order\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "80a09012bf3b73e6b91048f6f29defd1521f30539783", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1824, "~/image/", 1824, 8, true);
#nullable restore
#line 62 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
AddHtmlAttributeValue("", 1832, index.ColorImage, 1832, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                    <td style=\"text-align:center\">");
#nullable restore
#line 63 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
                                             Write(index.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td style=\"text-align:center\">");
#nullable restore
#line 64 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
                                             Write(index.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 66 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n        </table>\r\n    </div>\r\n    <div class=\"order-cancel-status\">\r\n");
#nullable restore
#line 75 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
         if (item.Status != 4)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button");
            BeginWriteAttribute("id", " id=\"", 2184, "\"", 2205, 1);
#nullable restore
#line 77 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
WriteAttributeValue(" ", 2189, item.OrderDate, 2190, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-right: 30px; padding:5px; height:30px;\" class=\"btn-cancel-order\"");
            BeginWriteAttribute("value", " value=\"", 2285, "\"", 2301, 1);
#nullable restore
#line 77 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
WriteAttributeValue("", 2293, item.ID, 2293, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Huỷ đơn hàng</button>\r\n");
#nullable restore
#line 78 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
         if (item.Status == 4)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"order-total\">Tổng tiền: 0<sup>đ</sup></p>\r\n");
#nullable restore
#line 83 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p class=\"order-total\">Tổng tiền:");
#nullable restore
#line 86 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
                                        Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("<sup>đ</sup></p>\r\n");
#nullable restore
#line 87 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 90 "C:\Users\19521\Desktop\ShoesLover\ShoesLoverFinal\Views\Order\ShowOrderStatus.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    #get-text {
        border-bottom: 1px solid #ccc;
        margin-top: 20px;
        padding-bottom: 20px;
        width: 100%;
        height: 150px;
        font-size: 16px;
    }

    .modal-delete {
        position: fixed;
        top: 0;
        right: 0;
        bottom: 0;
        left: 0;
        display: none;
        z-index: 3;
    }

    .delete-order-title {
        display: flex;
        justify-content: space-between;
        border-bottom: 1px solid #ccc;
    }

    .modal-body {
        background: white;
        z-index: 1;
        margin: auto;
        width: 600px;
        height: 330px;
        position: relative;
        margin-top: 300px;
    }

    .modal-overlay {
        position: absolute;
        width: 100%;
        height: 100%;
        background: rgba(0,0,0,0.3);
    }

    li {
        list-style: none;
    }

    .order-detail-info {
        background: white;
        margin-top: 50px;
        margin-bottom: 50px");
            WriteLiteral(@";
        padding-bottom: 40px;
    }

    .row-item {
        display: flex;
        align-items: center;
    }

    .btn-cancel-order {
        background: rgb(215,52,67);
        color: white;
        border: 1px solid white;
        border-radius: 5px;
        font-size: 16px;
    }

    .order-cancel-status {
        display: flex;
        margin-top: 20px;
        justify-content: flex-end;
        align-items: center;
    }

    .order-detail-info-table {
        padding-top: 60px;
        display: flex;
        flex-direction: column;
    }

    .order-title {
        display: flex;
        justify-content: space-around;
    }

    .order-table-list {
        display: flex;
        justify-content: center;
    }

    .order-total {
        text-align: right;
        margin-right: 50px;
        font-size: 16px;
        font-weight: bold;
    }

    .container {
        background: rgb(245,245,245);
    }

    .list-function li {
        margin-bottom:");
            WriteLiteral(@" 20px;
    }

    .list-status-order {
        display: flex;
        justify-content: space-around;
        background: white;
        color: black;
        align-items: center;
        height: 50px;
        font-size: 16px;
    }

    .customer-infor-order {
        display: flex;
        margin-bottom: 70px;
    }

    .customer-name {
        display: flex;
        flex-direction: column;
    }

    .customer-img img {
        width: 40px;
    }

    tr:first-child, tr:last-child {
        border-bottom: 1px solid #ccc;
    }

    table {
        border-collapse: collapse;
    }
    /*.img-pro-order{
        display: flex;
        justify-content: center;
    }   */
    .img-color-order img {
        margin-left: auto;
        margin-right: auto;
        display: block;
    }

    .list-status-order li {
        padding: 15px;
    }

    .active-order-status {
        border-bottom: 1px solid red;
    }

    .li-item-status {
        cursor: pointer;
 ");
            WriteLiteral(@"   }
</style>
<script src=""https://code.jquery.com/jquery-3.6.0.js"" integrity=""sha256-H+K7U5CnXl1h5ywQfKtSj8PCmoN9aaq30gDh27Xc0jk="" crossorigin=""anonymous""></script>

<script>
   
    $("".btn-cancel-order"").on(""click"", function () {
        $("".modal-delete"").css(""display"", ""block"");
    })

    $("".btn-x-modal"").on(""click"", function () {
        $("".modal-delete"").css(""display"", ""none"");
    })

   


    $("".btn-cancel-order"").each(function () {
        $(this).on(""click"", function () {

            var order_id = $(this).val();
            var old_order_date = $(this).attr(""id"");


            $("".btn-order-cancel"").on(""click"", function () {

              

                $("".btn-order-cancel"").on(""click"", function () {

                    var reason = $(""#get-reason"").val();
                    $.ajax({
                        url: ""../Order/UpdateOrderReason"",
                        type: ""POST"",
                        dataType: ""html"",
                        data");
            WriteLiteral(@": { order_id: order_id, old_order_date: old_order_date, text: reason },
                        success: function (data) {
                            alert(""Đơn hàng đã huỷ thành công"");
                        },
                        error: () => alert(""something wrong"")
                    });
                });
            });



        });
    });
</script>");
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
