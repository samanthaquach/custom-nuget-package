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

namespace nuget.ResourcePackages.Talon.MVC.Views.LoginStatus
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
    
    #line 3 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
    using Telerik.Sitefinity.Mvc.Proxy;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/LoginStatus/LoginStatus.LoginName.cshtml")]
    public partial class LoginStatus_LoginName : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Identity.Mvc.Models.LoginStatus.LoginStatusViewModel>
    {
        public LoginStatus_LoginName()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 7 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 9 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
  
var SignOutUrl = string.Concat(Url.Action("SignOut"),string.Format("?{0}={1}", MvcControllerProxy.ControllerKey, ViewData[MvcControllerProxy.ControllerKey]));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 442), Tuple.Create("\"", 465)
            
            #line 13 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 450), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 450), false)
);

WriteLiteral(">\r\n    <div");

WriteLiteral(" data-sf-role=\"sf-logged-in-view\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n        <span>");

            
            #line 15 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
         Write(Html.Resource("LoggedAs"));

            
            #line default
            #line hidden
WriteLiteral(" </span>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 595), Tuple.Create("\"", 632)
            
            #line 16 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 602), Tuple.Create<System.Object, System.Int32>(Model.ProfilePageUrl ?? "#"
            
            #line default
            #line hidden
, 602), false)
);

WriteLiteral(" data-sf-role=\"sf-logged-in-name\"");

WriteLiteral(" class=\"mr-2\"");

WriteLiteral("></a>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 696), Tuple.Create("\"", 714)
            
            #line 17 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 703), Tuple.Create<System.Object, System.Int32>(SignOutUrl
            
            #line default
            #line hidden
, 703), false)
);

WriteLiteral(">");

            
            #line 17 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
                         Write(Html.Resource("Logout"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </div>\r\n\r\n    <div");

WriteLiteral(" data-sf-role=\"sf-logged-out-view\"");

WriteLiteral(" style=\"display: none\"");

WriteLiteral(">\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 837), Tuple.Create("\"", 872)
            
            #line 21 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 844), Tuple.Create<System.Object, System.Int32>(Model.LoginPageUrl ?? "#"
            
            #line default
            #line hidden
, 844), false)
);

WriteLiteral(" class=\"mr-2\"");

WriteLiteral(">");

            
            #line 21 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
                                                       Write(Html.Resource("Login"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        <a");

WriteAttribute("href", Tuple.Create(" href=\"", 926), Tuple.Create("\"", 968)
            
            #line 22 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 933), Tuple.Create<System.Object, System.Int32>(Model.RegistrationPageUrl ?? "#"
            
            #line default
            #line hidden
, 933), false)
);

WriteLiteral(">");

            
            #line 22 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
                                                 Write(Html.Resource("RegisterNow"));

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n    </div>\r\n</div>\r\n\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-status-json-endpoint-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1090), Tuple.Create("\"", 1121)
            
            #line 26 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 1098), Tuple.Create<System.Object, System.Int32>(Model.StatusServiceUrl
            
            #line default
            #line hidden
, 1098), false)
);

WriteLiteral("/>\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-logout-redirect-url\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1184), Tuple.Create("\"", 1212)
            
            #line 27 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 1192), Tuple.Create<System.Object, System.Int32>(Model.LogoutPageUrl
            
            #line default
            #line hidden
, 1192), false)
);

WriteLiteral("/>\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-is-design-mode-value\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1276), Tuple.Create("\"", 1316)
            
            #line 28 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 1284), Tuple.Create<System.Object, System.Int32>(ViewBag.IsDesignMode.ToString()
            
            #line default
            #line hidden
, 1284), false)
);

WriteLiteral(" />\r\n<input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"sf-allow-windows-sts-login\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1384), Tuple.Create("\"", 1430)
            
            #line 29 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
, Tuple.Create(Tuple.Create("", 1392), Tuple.Create<System.Object, System.Int32>(Model.AllowWindowsStsLogin.ToString()
            
            #line default
            #line hidden
, 1392), false)
);

WriteLiteral(" />\r\n\r\n");

            
            #line 31 "..\..MVC\Views\LoginStatus\LoginStatus.LoginName.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/LoginStatus/login-status.js"), "bottom", true));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
