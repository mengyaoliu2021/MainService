#pragma checksum "/Users/MengyaoLiu/Documents/GitHub/MainService/FluffyFriend/FluffyFriend/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59eeb507246010aaf55f4fc4944de36dc43797b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/MengyaoLiu/Documents/GitHub/MainService/FluffyFriend/FluffyFriend/Views/_ViewImports.cshtml"
using FluffyFriend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/MengyaoLiu/Documents/GitHub/MainService/FluffyFriend/FluffyFriend/Views/_ViewImports.cshtml"
using FluffyFriend.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/Users/MengyaoLiu/Documents/GitHub/MainService/FluffyFriend/FluffyFriend/Views/Home/Index.cshtml"
using BlazorFluentUI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59eeb507246010aaf55f4fc4944de36dc43797b4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ae1d5e268643110d89c03e30d1a91d9bec3bf85", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FluffyFriend.Models.PostsModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/MengyaoLiu/Documents/GitHub/MainService/FluffyFriend/FluffyFriend/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"pb-3-main\">\n\n\n    <div class=\"text-center\">\n        <DefaultButton text=\"Standard\" allowDisabledFocus disabled=\"Disabled\" checked=\"Checked\" />\n");
#nullable restore
#line 12 "/Users/MengyaoLiu/Documents/GitHub/MainService/FluffyFriend/FluffyFriend/Views/Home/Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <article class=""PostArticle"">
                <header class=""flex-start-box flex-display post-header"">
                    <div class=""post-user-icon"">
                        <div class=""user-icon"" style=""background-image: url(https://images.pexels.com/photos/3520421/pexels-photo-3520421.jpeg) ""></div>
                    </div>
                    <div class=""post-user-info"">
                        <div class=""text-left-align"">
                            ");
#nullable restore
#line 21 "/Users/MengyaoLiu/Documents/GitHub/MainService/FluffyFriend/FluffyFriend/Views/Home/Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                        </div>\n                        <div class=\"text-left-align post-time\">\n                            ");
#nullable restore
#line 24 "/Users/MengyaoLiu/Documents/GitHub/MainService/FluffyFriend/FluffyFriend/Views/Home/Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </div>
                    </div>
                    <div>
                        <button>...</button>
                    </div>
                </header>

                <div class=""post-content"">
                    <p class=""text-left-align post-message"">
                        ");
#nullable restore
#line 34 "/Users/MengyaoLiu/Documents/GitHub/MainService/FluffyFriend/FluffyFriend/Views/Home/Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Message));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </p>\n                    <div class=\"post-image\" style=\"background-image: url(https://images.pexels.com/photos/3520421/pexels-photo-3520421.jpeg) \"></div>\n                </div>\n            </article>\n");
#nullable restore
#line 39 "/Users/MengyaoLiu/Documents/GitHub/MainService/FluffyFriend/FluffyFriend/Views/Home/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FluffyFriend.Models.PostsModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
