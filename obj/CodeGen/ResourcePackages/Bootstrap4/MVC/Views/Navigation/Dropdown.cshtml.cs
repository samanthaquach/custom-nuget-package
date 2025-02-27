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

namespace nuget.ResourcePackages.Bootstrap4.MVC.Views.Navigation
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
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/Navigation/Dropdown.cshtml")]
    public partial class Dropdown : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.INavigationModel>
    {

#line 18 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
public System.Web.WebPages.HelperResult RenderSubLevelsRecursive(NodeViewModel node, string prefix)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 19 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
 
    var selectedAttribute = "";
    prefix += "-";

    if (Model.CurrentSiteMapNode != null && node.OriginalSiteMapNode !=null &&
        Model.CurrentSiteMapNode.Key == node.OriginalSiteMapNode.Key)
    {
        selectedAttribute = "selected";
    }



#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <option");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 872), Tuple.Create("\"", 895)

#line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
, Tuple.Create(Tuple.Create("", 880), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 880), false)
);

WriteAttributeTo(__razor_helper_writer, "value", Tuple.Create(" value=\"", 896), Tuple.Create("\"", 913)

#line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
, Tuple.Create(Tuple.Create("", 904), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 904), false)
);

WriteLiteralTo(__razor_helper_writer, " ");


#line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
                        WriteTo(__razor_helper_writer, selectedAttribute);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, ">");


#line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
                                            WriteTo(__razor_helper_writer, prefix + " " + node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</option>\n");


#line 30 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"

    foreach (var childNode in node.ChildNodes)
    {
        

#line default
#line hidden

#line 33 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(childNode, prefix));


#line default
#line hidden

#line 33 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
                                                    ;
    }


#line default
#line hidden
});

#line 35 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
}
#line default
#line hidden

#line 38 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
public System.Web.WebPages.HelperResult GetClass(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 39 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
 
    if (node.IsCurrentlyOpened)
    {
        

#line default
#line hidden

#line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("active"));


#line default
#line hidden

#line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
                                    ;
    }
    else if (node.HasChildOpen)
    {
        

#line default
#line hidden

#line 46 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("active"));


#line default
#line hidden

#line 46 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
                                    ;
    }


#line default
#line hidden
});

#line 48 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
}
#line default
#line hidden

        public Dropdown()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

WriteLiteral("\n");

            
            #line 8 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/Navigation.js"), "bottom", false));

            
            #line default
            #line hidden
WriteLiteral("\n\n<select");

WriteLiteral(" class=\"nav-select form-control\"");

WriteLiteral(">\n");

            
            #line 11 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
    
            
            #line default
            #line hidden
            
            #line 11 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
     foreach (var node in Model.Nodes)
    {
        
            
            #line default
            #line hidden
            
            #line 13 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
   Write(RenderSubLevelsRecursive(node, ""));

            
            #line default
            #line hidden
            
            #line 13 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\Dropdown.cshtml"
                                           ;
    }

            
            #line default
            #line hidden
WriteLiteral("</select>\n\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591
