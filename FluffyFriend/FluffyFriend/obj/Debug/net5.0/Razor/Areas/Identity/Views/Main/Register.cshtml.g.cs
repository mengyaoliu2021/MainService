#pragma checksum "/Users/MengyaoLiu/Documents/GitHub/MainService/FluffyFriend/FluffyFriend/Areas/Identity/Views/Main/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "033d78e5284a20c8982701be4b25376bc49c9e45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Views_Main_Register), @"mvc.1.0.view", @"/Areas/Identity/Views/Main/Register.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"033d78e5284a20c8982701be4b25376bc49c9e45", @"/Areas/Identity/Views/Main/Register.cshtml")]
    public class Areas_Identity_Views_Main_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FluffyFriend.Areas.Identity.Models.LoginModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/MengyaoLiu/Documents/GitHub/MainService/FluffyFriend/FluffyFriend/Areas/Identity/Views/Main/Register.cshtml"
  
    ViewData["Title"] = "Register Page Title";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Title</h1>\n<div class=\"row\">\n    <div class=\"col-md-4\">\n");
#nullable restore
#line 9 "/Users/MengyaoLiu/Documents/GitHub/MainService/FluffyFriend/FluffyFriend/Areas/Identity/Views/Main/Register.cshtml"
         using (Html.BeginForm("Register", "Main", FormMethod.Post))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div asp-validation-summary=\"ModelOnly\" class=\"text-danger\"></div>\n");
            WriteLiteral("            <div class=\"form-group\">\n                ");
#nullable restore
#line 14 "/Users/MengyaoLiu/Documents/GitHub/MainService/FluffyFriend/FluffyFriend/Areas/Identity/Views/Main/Register.cshtml"
           Write(Html.LabelFor(model => model.Username, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 15 "/Users/MengyaoLiu/Documents/GitHub/MainService/FluffyFriend/FluffyFriend/Areas/Identity/Views/Main/Register.cshtml"
           Write(Html.TextBoxFor(model => model.Username, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <span asp-validation-for=\"Username\" class=\"text-danger\"></span>\n            </div>\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 19 "/Users/MengyaoLiu/Documents/GitHub/MainService/FluffyFriend/FluffyFriend/Areas/Identity/Views/Main/Register.cshtml"
           Write(Html.LabelFor(model => model.Email, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 20 "/Users/MengyaoLiu/Documents/GitHub/MainService/FluffyFriend/FluffyFriend/Areas/Identity/Views/Main/Register.cshtml"
           Write(Html.TextBoxFor(model => model.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                <span asp-validation-for=\"Email\" class=\"text-danger\"></span>\n            </div>\n            <div class=\"form-group\">\n                ");
#nullable restore
#line 24 "/Users/MengyaoLiu/Documents/GitHub/MainService/FluffyFriend/FluffyFriend/Areas/Identity/Views/Main/Register.cshtml"
           Write(Html.LabelFor(model => model.Password, new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                ");
#nullable restore
#line 25 "/Users/MengyaoLiu/Documents/GitHub/MainService/FluffyFriend/FluffyFriend/Areas/Identity/Views/Main/Register.cshtml"
           Write(Html.TextBoxFor(model => model.Password, new { @class = "form-control", @type= "password" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                <span asp-validation-for=""Password"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label class=""control-label"">Confirm password</label>
                <input type=""password"" required class=""form-control"" />
                <span class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Register"" class=""btn btn-primary"" />
            </div>
");
#nullable restore
#line 36 "/Users/MengyaoLiu/Documents/GitHub/MainService/FluffyFriend/FluffyFriend/Areas/Identity/Views/Main/Register.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FluffyFriend.Areas.Identity.Models.LoginModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
