#pragma checksum "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "934745a4a93cdf894e226b07e65372ff186a9916"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Slownik.Pages.Slowa.Pages_Slowa_Index2), @"mvc.1.0.razor-page", @"/Pages/Slowa/Index2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Slowa/Index2.cshtml", typeof(Slownik.Pages.Slowa.Pages_Slowa_Index2), null)]
namespace Slownik.Pages.Slowa
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\_ViewImports.cshtml"
using Slownik;

#line default
#line hidden
#line 3 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\_ViewImports.cshtml"
using Slownik.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"934745a4a93cdf894e226b07e65372ff186a9916", @"/Pages/Slowa/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1b974b7044b93413ac53f99eb31741a0cc5e918", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Slowa_Index2 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("SearchBox"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sx"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Product/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sx pull-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top:20px;margin-bottom: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Slowa/Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Slowa/Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: green; height: 40px; margin-top: 0px; border:0px solid;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height: 40px; margin-top: 0px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'Usunąć to słówko ze słownika?\');"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
  
    ViewData["Title"] = "Product page";

#line default
#line hidden
            BeginContext(99, 312, true);
            WriteLiteral(@"<script>
    function myFunction(x) {
        $(""#item_view"").modal();
    };
    $(document).ready(function () {
        $(""#success-alert"").hide();
        $(""#success-alert"").fadeTo(2000, 500).slideUp(500, function () {
            $(""#success-alert"").slideUp(500);
        });
    });

</script>
");
            EndContext();
#line 20 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
 if (@User.Identity.Name != "czemek17@gmail.com")
{

#line default
#line hidden
            BeginContext(465, 29, true);
            WriteLiteral("    <h3>BRAK UPRAWNIEŃ</h3>\r\n");
            EndContext();
#line 23 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(506, 211, true);
            WriteLiteral("    <div class=\"container\">\r\n        <div class=\"mail-box\">\r\n            <aside class=\"lg-side\">\r\n                <div class=\"inbox-head\">\r\n                    <h3>Zarządzaj Słownikiem</h3>\r\n                    ");
            EndContext();
            BeginContext(717, 282, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "934745a4a93cdf894e226b07e65372ff186a991610566", async() => {
                BeginContext(737, 96, true);
                WriteLiteral("\r\n                        <label class=\"labelki\">Szukaj słówko</label>\r\n                        ");
                EndContext();
                BeginContext(833, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "934745a4a93cdf894e226b07e65372ff186a991611047", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#line 33 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.SearchString);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(883, 109, true);
                WriteLiteral("\r\n                        <button class=\"btn btn-primary btn-xs\">Szukaj Słówka</button>\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(999, 26, true);
            WriteLiteral("<br>\r\n                    ");
            EndContext();
            BeginContext(1025, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "934745a4a93cdf894e226b07e65372ff186a991614128", async() => {
                BeginContext(1085, 16, true);
                WriteLiteral("Wszystkie Słówka");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1105, 26, true);
            WriteLiteral("\r\n                </div>\r\n");
            EndContext();
#line 38 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
                 if (@User.Identity.Name == "czemek17@gmail.com")
                {

#line default
#line hidden
            BeginContext(1217, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(1237, 216, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "934745a4a93cdf894e226b07e65372ff186a991615934", async() => {
                BeginContext(1348, 101, true);
                WriteLiteral("\r\n                        <i class=\"glyphicon glyphicon-plus\"></i> Dodaj Słówko\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1453, 30, true);
            WriteLiteral("\r\n                    <br />\r\n");
            EndContext();
#line 44 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
                }

#line default
#line hidden
            BeginContext(1502, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 46 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
                 if (!string.IsNullOrEmpty(Model.Message))
                {

#line default
#line hidden
            BeginContext(1583, 225, true);
            WriteLiteral("                    <div class=\"alert alert-success\" id=\"success-alert\" style=\"margin-top: 40px;\">\r\n                        <button type=\"button\" class=\"close\" data-dismiss=\"alert\">x</button>\r\n                        <strong>");
            EndContext();
            BeginContext(1809, 13, false);
#line 50 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
                           Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(1822, 42, true);
            WriteLiteral(" ! </strong>\r\n                    </div>\r\n");
            EndContext();
#line 52 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
                }

#line default
#line hidden
            BeginContext(1883, 559, true);
            WriteLiteral(@"

                <div class=""inbox-body"" style=""margin-top:20px;"">
                    <div class=""mail-option"">

                        <table class=""table table-inbox table-hover"" style=""border:2px solid black;"">
                            <thead>
                                <tr class=""unread"">
                                    <th class=""col-sm-2 view-message  dont-show"">ID</th>
                                    <th class=""view-message col-sm-3"">Polski</th>
                                    <th class=""col-sm-2"">Angielski</th>
");
            EndContext();
#line 64 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
                                     if (@User.Identity.Name == "czemek17@gmail.com")
                                    {

#line default
#line hidden
            BeginContext(2568, 100, true);
            WriteLiteral("                                        <th class=\"view-message  text-left col-sm-2\">Operacja</th>\r\n");
            EndContext();
#line 67 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
                                    }

#line default
#line hidden
            BeginContext(2707, 114, true);
            WriteLiteral("                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
            EndContext();
#line 71 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
                                 foreach (var item in Model.productList)
                                {

#line default
#line hidden
            BeginContext(2930, 149, true);
            WriteLiteral("                                    <tr>\r\n                                        <td onclick=\"myFunction(this)\" class=\"view-message  dont-show\"><h5>");
            EndContext();
            BeginContext(3080, 7, false);
#line 74 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
                                                                                                      Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(3087, 108, true);
            WriteLiteral("</h5></td>\r\n                                        <td onclick=\"myFunction(this)\" class=\"view-message\"><h4>");
            EndContext();
            BeginContext(3196, 21, false);
#line 75 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
                                                                                           Write(item.Polski.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(3217, 147, true);
            WriteLiteral("</h4></td>\r\n                                        <td onclick=\"myFunction(this)\"><h4 style=\"margin-top: 5px;\"><span class=\"label label-success \">");
            EndContext();
            BeginContext(3365, 24, false);
#line 76 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
                                                                                                                                  Write(item.Angielski.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(3389, 65, true);
            WriteLiteral("</span></h4></td>\r\n                                        <td>\r\n");
            EndContext();
#line 78 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
                                             if (@User.Identity.Name == "czemek17@gmail.com")
                                            {

#line default
#line hidden
            BeginContext(3596, 48, true);
            WriteLiteral("                                                ");
            EndContext();
            BeginContext(3644, 1130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "934745a4a93cdf894e226b07e65372ff186a991622795", async() => {
                BeginContext(3664, 171, true);
                WriteLiteral("\r\n                                                    <span class=\"btn-group pull-right\" style=\"margin-top: 5px\">\r\n                                                        ");
                EndContext();
                BeginContext(3835, 335, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "934745a4a93cdf894e226b07e65372ff186a991623357", async() => {
                    BeginContext(3998, 168, true);
                    WriteLiteral("\r\n                                                            <i class=\"far fa-edit\" style=\"color:white;\"></i>\r\n                                                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 82 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
                                                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4170, 60, true);
                WriteLiteral("\r\n\r\n                                                        ");
                EndContext();
                BeginContext(4230, 426, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "934745a4a93cdf894e226b07e65372ff186a991626271", async() => {
                    BeginContext(4495, 152, true);
                    WriteLiteral("\r\n                                                            <i class=\"far fa-trash-alt\"></i>\r\n                                                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_12.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 86 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
                                                                                                                                        WriteLiteral(item.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4656, 111, true);
                WriteLiteral("\r\n                                                    </span>\r\n                                                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
#line 91 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
                                                       }

#line default
#line hidden
            BeginContext(4777, 90, true);
            WriteLiteral("                                        </td>\r\n                                    </tr>\r\n");
            EndContext();
#line 94 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
                                }

#line default
#line hidden
            BeginContext(4902, 174, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n            </aside>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 102 "G:\Coding\SLOWNIK V2\Slownik\Slownik\Pages\Slowa\Index2.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Slownik.Pages.Slowa.IndexModel2> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Slownik.Pages.Slowa.IndexModel2> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Slownik.Pages.Slowa.IndexModel2>)PageContext?.ViewData;
        public Slownik.Pages.Slowa.IndexModel2 Model => ViewData.Model;
    }
}
#pragma warning restore 1591
