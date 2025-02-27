#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace nuget.ResourcePackages.Bootstrap4.MVC.Views.LoginForm
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
    using Telerik.Sitefinity.Services;
    
    #line default
    #line hidden
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/LoginForm/ResetPassword.ResetPassword.csh" +
        "tml")]
    public partial class ResetPassword_ResetPassword : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginForm.ResetPasswordViewModel>
    {
        public ResetPassword_ResetPassword()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 211), Tuple.Create("\"", 234)
            
            #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
, Tuple.Create(Tuple.Create("", 219), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 219), false)
);

WriteLiteral(">\n\n    <h3>");

            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
   Write(Html.Resource("ResetPasswordHeader"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n\n");

            
            #line 11 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
     if (Model.ResetComplete)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3>");

            
            #line 13 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
       Write(Html.Resource("ResetPasswordSuccess"));

            
            #line default
            #line hidden
WriteLiteral("</h3>\n");

WriteLiteral("        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 392), Tuple.Create("\"", 418)
            
            #line 14 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
, Tuple.Create(Tuple.Create("", 399), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl
            
            #line default
            #line hidden
, 399), false)
);

WriteLiteral(">");

            
            #line 14 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
                                 Write(Html.Resource("ResetPasswordBackToLogin"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n");

            
            #line 15 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
    }
    else if (Model.RequiresQuestionAndAnswer && string.IsNullOrEmpty(Model.ResetPasswordQuestion))
    {    

            
            #line default
            #line hidden
WriteLiteral("        <div");

WriteLiteral(" class=\"alert alert-danger\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(">");

            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
                                                                      Write(Html.Resource("CannotResetPasswordError"));

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

            
            #line 19 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
    }
    else
    {

            
            #line default
            #line hidden
WriteLiteral("        <form");

WriteAttribute("action", Tuple.Create(" action=\"", 740), Tuple.Create("\"", 792)
            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
, Tuple.Create(Tuple.Create("", 749), Tuple.Create<System.Object, System.Int32>(Url.Action("ResetPassword", "LoginForm")
            
            #line default
            #line hidden
, 749), false)
);

WriteLiteral(" method=\"post\"");

WriteLiteral(" autocomplete=\"off\"");

WriteLiteral(">\n");

WriteLiteral("            ");

            
            #line 23 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
       Write(Model.Error);

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 24 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
       Write(Html.HiddenFor(u => u.SecurityToken));

            
            #line default
            #line hidden
WriteLiteral("\n\n");

            
            #line 26 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
            
            
            #line default
            #line hidden
            
            #line 26 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
             if (Model.RequiresQuestionAndAnswer)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n");

WriteLiteral("                    ");

            
            #line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
               Write(Html.LabelFor(u => u.ResetPasswordAnswer, Model.ResetPasswordQuestion));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                    ");

            
            #line 30 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
               Write(Html.TextBoxFor(u => u.ResetPasswordAnswer, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n                </div>\n");

            
            #line 32 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n");

WriteLiteral("                ");

            
            #line 35 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
           Write(Html.LabelFor(u => u.NewPassword, Html.Resource("ResetPasswordNewPassword")));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                ");

            
            #line 36 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
           Write(Html.TextBoxFor(u => u.NewPassword, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n            </div>\n\n            <div");

WriteLiteral(" class=\"form-group\"");

WriteLiteral(">\n");

WriteLiteral("                ");

            
            #line 40 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
           Write(Html.LabelFor(u => u.RepeatNewPassword, Html.Resource("ResetPasswordRepeatNewPassword")));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                ");

            
            #line 41 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
           Write(Html.TextBoxFor(u => u.RepeatNewPassword, new { @class = "form-control" }));

            
            #line default
            #line hidden
WriteLiteral("\n            </div>\n\n            <input");

WriteLiteral(" class=\"btn btn-primary\"");

WriteLiteral(" type=\"submit\"");

WriteAttribute("value", Tuple.Create(" value=\'", 1785), Tuple.Create("\'", 1834)
            
            #line 44 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
, Tuple.Create(Tuple.Create("", 1793), Tuple.Create<System.Object, System.Int32>(Html.Resource("ResetPasswordSaveButton")
            
            #line default
            #line hidden
, 1793), false)
);

WriteLiteral(" ");

            
            #line 44 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
                                                                                                       Write(SystemManager.IsDesignMode ? "disabled" : "");

            
            #line default
            #line hidden
WriteLiteral(" />      \n        </form>\n");

            
            #line 46 "..\..\ResourcePackages\Bootstrap4\MVC\Views\LoginForm\ResetPassword.ResetPassword.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\n</div>\n");

        }
    }
}
#pragma warning restore 1591
