#pragma checksum "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d607f7046998b06a0c7bd2643979b888843a67f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Index), @"mvc.1.0.view", @"/Views/Users/Index.cshtml")]
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
#line 1 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\_ViewImports.cshtml"
using Compound;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\_ViewImports.cshtml"
using Compound.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d607f7046998b06a0c7bd2643979b888843a67f", @"/Views/Users/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"628968bf8344dc7e33ac9eb5d6b387703f5412c2", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Users\Index.cshtml"
  
    List<UserModel> User = (List<UserModel>)ViewData["Users"];
    List<VilladModel> Villa = (List<VilladModel>)ViewData["Villa"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Compound Resident</h2>



<br />
<br />
<table style=""width:100%"" class=""table table table-striped"">
    <thead class=""thead-dark"">
        <tr>
            <th>ID</th>
            <th>Name</th>
            <th>Phone Number</th>
            <th>Email</th>
            <th>Villa</th>
            <th></th>
        </tr>
    </thead>
");
#nullable restore
#line 26 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Users\Index.cshtml"
     foreach (UserModel prd in User)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th scope=\"row\">");
#nullable restore
#line 29 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Users\Index.cshtml"
                       Write(prd.User_Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <td>");
#nullable restore
#line 30 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Users\Index.cshtml"
           Write(prd.User_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Users\Index.cshtml"
           Write(prd.User_PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 32 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Users\Index.cshtml"
           Write(prd.User_Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 33 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Users\Index.cshtml"
           Write(prd.Villa.Villa_Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> <img style=\"height: 100px; width:12em\"");
            BeginWriteAttribute("src", " src=", 860, "", 885, 1);
#nullable restore
#line 34 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Users\Index.cshtml"
WriteAttributeValue("", 865, prd.Villa.Villa_Img, 865, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=", 885, "", 909, 1);
#nullable restore
#line 34 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Users\Index.cshtml"
WriteAttributeValue("", 890, prd.Villa.Villa_Id, 890, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"window.open()\" /></td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 37 "D:\Tuwaiq\AspDotNet\Project02_EF_ASP.NET_MVC\Compound\Compound\Views\Users\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table> \r\n");
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
