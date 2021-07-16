#pragma checksum "C:\Users\spAdmin\source\repos\DeskAdvDecoupledOrchardCore\DeskAdvDecoupledOrchardCore\Pages\notice_page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c9f5364075efbb601aeeb0fa1e65cbf3245ecc1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(DeskAdvDecoupledOrchardCore.Pages.Pages_notice_page), @"mvc.1.0.razor-page", @"/Pages/notice_page.cshtml")]
namespace DeskAdvDecoupledOrchardCore.Pages
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
#line 1 "C:\Users\spAdmin\source\repos\DeskAdvDecoupledOrchardCore\DeskAdvDecoupledOrchardCore\Pages\_ViewImports.cshtml"
using DeskAdvDecoupledOrchardCore;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/notice/{slug}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c9f5364075efbb601aeeb0fa1e65cbf3245ecc1", @"/Pages/notice_page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e27a7b5bb65deabdae6e0778906c849b2a4c7087", @"/Pages/_ViewImports.cshtml")]
    public class Pages_notice_page : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\spAdmin\source\repos\DeskAdvDecoupledOrchardCore\DeskAdvDecoupledOrchardCore\Pages\notice_page.cshtml"
  
    var ad_list_id = await Orchard.GetContentItemIdByAliasAsync("alias:объявления");
    var notice = await Orchard.GetContentItemByHandleAsync($"alias:{Slug}");
    string stat_tax_id = @notice.Content.AdItem.StatusAd.TaxonomyContentItemId;
    string stat_term_id = @notice.Content.AdItem.StatusAd.TermContentItemIds[0];
    var stat_text = await Orchard.GetTaxonomyTermAsync(@stat_tax_id, @stat_term_id);
    string сat_tax_id = @notice.Content.AdItem.CategoryAd.TaxonomyContentItemId;
    string сat_term_id = @notice.Content.AdItem.CategoryAd.TermContentItemIds[0];
    var сat_text = await Orchard.GetTaxonomyTermAsync(@сat_tax_id, @сat_term_id);
    var not = notice;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<h1>Страница объявления </h1>\r\n<div class=\"alert alert-success\">\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 951, "\"", 1165, 3);
            WriteAttributeValue("", 958, "../Admin/Contents/ContentItems/", 958, 31, true);
#nullable restore
#line 26 "C:\Users\spAdmin\source\repos\DeskAdvDecoupledOrchardCore\DeskAdvDecoupledOrchardCore\Pages\notice_page.cshtml"
WriteAttributeValue("", 989, notice.ContentItemId, 989, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1010, "/Edit?returnUrl=%2FAdmin%2FContents%2FContentItems%2F@ad_list_id%2FDisplay%3FreturnUrl%3D%252FAdmin%252FContents%252FContentItems%253Fadmin%253D-1933353348", 1010, 155, true);
            EndWriteAttribute();
            WriteLiteral(">Редактировать объявление</a>\r\n    <a");
            BeginWriteAttribute("href", " href=\"", 1203, "\"", 1419, 3);
            WriteAttributeValue("", 1210, "../Admin/Contents/ContentItems/", 1210, 31, true);
#nullable restore
#line 27 "C:\Users\spAdmin\source\repos\DeskAdvDecoupledOrchardCore\DeskAdvDecoupledOrchardCore\Pages\notice_page.cshtml"
WriteAttributeValue("", 1241, notice.ContentItemId, 1241, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1262, "/Delete?returnUrl=%2FAdmin%2FContents%2FContentItems%2F@ad_list_id%2FDisplay%3FreturnUrl%3D%252FAdmin%252FContents%252FContentItems%253Fadmin%253D-1933353348", 1262, 157, true);
            EndWriteAttribute();
            WriteLiteral(">Удалить объявление</a>\r\n    <a href=\"../board\">Доска объявлений</a>\r\n</div>\r\n\r\n");
            WriteLiteral("<div class=\"text-left alert alert-info\">\r\n    <div class=\"alert alert-light\">Заголовок Объявления: ");
#nullable restore
#line 35 "C:\Users\spAdmin\source\repos\DeskAdvDecoupledOrchardCore\DeskAdvDecoupledOrchardCore\Pages\notice_page.cshtml"
                                                    Write(notice.Content.TitlePart.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"alert alert-light\">Дата публикации объявления: ");
#nullable restore
#line 36 "C:\Users\spAdmin\source\repos\DeskAdvDecoupledOrchardCore\DeskAdvDecoupledOrchardCore\Pages\notice_page.cshtml"
                                                          Write(notice.Content.AdItem.PublicateDate.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"alert alert-light\">Автор объявления: ");
#nullable restore
#line 37 "C:\Users\spAdmin\source\repos\DeskAdvDecoupledOrchardCore\DeskAdvDecoupledOrchardCore\Pages\notice_page.cshtml"
                                                Write(notice.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"alert alert-light\">Текст объявления: <p>");
#nullable restore
#line 38 "C:\Users\spAdmin\source\repos\DeskAdvDecoupledOrchardCore\DeskAdvDecoupledOrchardCore\Pages\notice_page.cshtml"
                                                   Write(await Orchard.MarkdownToHtmlAsync((string)notice.Content.MarkdownBodyPart.Markdown));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></div>\r\n    <div class=\"alert alert-light\">Статус объявления: ");
#nullable restore
#line 39 "C:\Users\spAdmin\source\repos\DeskAdvDecoupledOrchardCore\DeskAdvDecoupledOrchardCore\Pages\notice_page.cshtml"
                                                 Write(stat_text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    <div class=\"alert alert-light\">Категория объявления: ");
#nullable restore
#line 40 "C:\Users\spAdmin\source\repos\DeskAdvDecoupledOrchardCore\DeskAdvDecoupledOrchardCore\Pages\notice_page.cshtml"
                                                    Write(сat_text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n</div>\r\n\r\n");
#nullable restore
#line 43 "C:\Users\spAdmin\source\repos\DeskAdvDecoupledOrchardCore\DeskAdvDecoupledOrchardCore\Pages\notice_page.cshtml"
Write(Orchard.ConsoleLog(notice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\spAdmin\source\repos\DeskAdvDecoupledOrchardCore\DeskAdvDecoupledOrchardCore\Pages\notice_page.cshtml"
 
    [FromRoute]
    public string Slug { get; set; }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public OrchardCore.IOrchardHelper Orchard { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_notice_page> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_notice_page> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_notice_page>)PageContext?.ViewData;
        public Pages_notice_page Model => ViewData.Model;
    }
}
#pragma warning restore 1591
