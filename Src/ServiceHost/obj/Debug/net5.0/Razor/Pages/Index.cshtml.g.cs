#pragma checksum "C:\Users\A\source\repos\BehinafzaCV\Src\ServiceHost\Pages\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "25b8dea6fb971bfbc6cf80e491d210b318b0f7d19de0f7e0b1efea07540ddc33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ServiceHost.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\A\source\repos\BehinafzaCV\Src\ServiceHost\Pages\_ViewImports.cshtml"
using ServiceHost;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"25b8dea6fb971bfbc6cf80e491d210b318b0f7d19de0f7e0b1efea07540ddc33", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"84e67cc624686472d6ee628a8fd93a67c79f2978653a37fe57c229fa14270597", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\A\source\repos\BehinafzaCV\Src\ServiceHost\Pages\Index.cshtml"
  
    ViewData["AccountTitle"] = "صفحه اصلی";
    Layout = "_AccountLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page main-signin-wrapper bg-primary construction\">\r\n\r\n    <div class=\"container \">\r\n        <div class=\"construction1 text-center details text-white\">\r\n            <div");
            BeginWriteAttribute("class", " class=\"", 292, "\"", 300, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                <img src=""/assets/img/brand/logo-light.png"" class=""mb-5"" alt=""logo"">
                <h4 class=""text-center text-white tx-30 font-weight-bold "">تو لایق بهترین رزومه ای که دیده بشی !</h4>
                <p class=""text-white-50 tx-15"">ما بهت کمک میکنیم که رزومه خودتو بسازی و تو این مسیر همراهتیم</p>

                <a href=""/Resumes/Resume"" class=""btn ripple alert alert-primary btn-lg btn-block"" style="" background-color: #d6e0ff;margin-bottom:12%;margin-top:2%"">بزن بریم</a>
            </div>
            <div class=""text-center"">رزومه ساز<a class=""text-white-50""> BehinAfzarCV </a>AmirKharazi</div>
        </div>
    </div>

</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
