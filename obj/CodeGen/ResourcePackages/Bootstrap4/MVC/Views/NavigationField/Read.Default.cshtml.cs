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

namespace nuget.ResourcePackages.Bootstrap4.MVC.Views.NavigationField
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.Default.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
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
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.Default.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.Default.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/NavigationField/Read.Default.cshtml")]
    public partial class Read_Default : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.NavigationField.NavigationFieldViewModel>
    {
        public Read_Default()
        {
        }
        public override void Execute()
        {
            
            #line 6 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.Default.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.Default.cshtml"
  
    var totalPages = Model.Pages.Count();

            
            #line default
            #line hidden
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 315), Tuple.Create("\"", 349)
            
            #line 10 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.Default.cshtml"
, Tuple.Create(Tuple.Create("", 323), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 323), false)
, Tuple.Create(Tuple.Create(" ", 338), Tuple.Create("form-group", 339), true)
);

WriteLiteral(" data-sf-role=\"navigation-field-container\"");

WriteLiteral(">\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"step-of-resources\"");

WriteAttribute("value", Tuple.Create(" value=\"", 452), Tuple.Create("\"", 484)
            
            #line 11 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.Default.cshtml"
, Tuple.Create(Tuple.Create("", 460), Tuple.Create<System.Object, System.Int32>(Html.Resource("StepOf")
            
            #line default
            #line hidden
, 460), false)
);

WriteLiteral(" />\r\n    <ol");

WriteLiteral(" data-sf-role=\"sr-progressbar\"");

WriteLiteral(" class=\"sf-FormNav\"");

WriteLiteral(" tabindex=\"0\"");

WriteLiteral(" role=\"progressbar\"");

WriteLiteral(" aria-valuemin=\"1\"");

WriteAttribute("aria-valuemax", Tuple.Create(" aria-valuemax=\"", 596), Tuple.Create("\"", 623)
            
            #line 12 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.Default.cshtml"
                                           , Tuple.Create(Tuple.Create("", 612), Tuple.Create<System.Object, System.Int32>(totalPages
            
            #line default
            #line hidden
, 612), false)
);

WriteLiteral(" aria-valuenow=\"1\"");

WriteAttribute("aria-valuetext", Tuple.Create(" aria-valuetext=\"", 642), Tuple.Create("\"", 680)
, Tuple.Create(Tuple.Create("", 659), Tuple.Create("Step", 659), true)
, Tuple.Create(Tuple.Create(" ", 663), Tuple.Create("1", 664), true)
, Tuple.Create(Tuple.Create(" ", 665), Tuple.Create("of", 666), true)
            
            #line 12 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.Default.cshtml"
                                                                                                   , Tuple.Create(Tuple.Create(" ", 668), Tuple.Create<System.Object, System.Int32>(totalPages
            
            #line default
            #line hidden
, 669), false)
);

WriteLiteral(">\r\n");

            
            #line 13 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.Default.cshtml"
        
            
            #line default
            #line hidden
            
            #line 13 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.Default.cshtml"
          
            var pageCounter = 0;
            foreach (var page in Model.Pages)
            {
                pageCounter++;

            
            #line default
            #line hidden
WriteLiteral("                <li");

WriteLiteral(" class=\"d-inline-flex align-items-center\"");

WriteLiteral(" data-sf-navigation-index=\"");

            
            #line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.Default.cshtml"
                                                                                  Write(page.Index);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n                    <span");

WriteLiteral(" class=\"sf-FormNav-page d-inline-flex align-items-center justify-content-center\"");

WriteLiteral(">\r\n                        <span");

WriteLiteral(" class=\"sf-FormNav-page-number\"");

WriteLiteral(">");

            
            #line 20 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.Default.cshtml"
                                                        Write(pageCounter);

            
            #line default
            #line hidden
WriteLiteral(" </span>\r\n                    </span>\r\n                    <span");

WriteLiteral(" data-sf-page-title=\"");

            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.Default.cshtml"
                                         Write(page.Title);

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteLiteral(">");

            
            #line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.Default.cshtml"
                                                      Write(Html.HtmlSanitize(page.Title));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </li>\r\n");

            
            #line 24 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.Default.cshtml"
            }
        
            
            #line default
            #line hidden
WriteLiteral("\r\n    </ol>\r\n</div>\r\n\r\n");

            
            #line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\NavigationField\Read.Default.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Form/form.all.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
