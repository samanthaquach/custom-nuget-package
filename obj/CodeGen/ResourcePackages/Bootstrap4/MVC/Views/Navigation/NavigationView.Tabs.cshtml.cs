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
    
    #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
    using Telerik.Sitefinity.Frontend.Navigation.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/Navigation/NavigationView.Tabs.cshtml")]
    public partial class NavigationView_Tabs : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Navigation.Mvc.Models.INavigationModel>
    {

#line 19 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
public System.Web.WebPages.HelperResult RenderRootLevelNode(IList<NodeViewModel> nodes)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 20 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
 


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"nav nav-tabs\"");

WriteLiteralTo(__razor_helper_writer, " role=\"tablist\"");

WriteLiteralTo(__razor_helper_writer, ">\n");


#line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
        

#line default
#line hidden

#line 22 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
         foreach(var node in nodes)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <li");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-item\"");

WriteLiteralTo(__razor_helper_writer, " role=\"tab\"");

WriteLiteralTo(__razor_helper_writer, ">\n                <a");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 757), Tuple.Create("\"", 789)
, Tuple.Create(Tuple.Create("", 765), Tuple.Create("nav-link", 765), true)

#line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create(" ", 773), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 774), false)
);

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 790), Tuple.Create("\"", 806)

#line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 797), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 797), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 807), Tuple.Create("\"", 832)

#line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 816), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 816), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 25 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
                                                                 WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\n            </li>\n");


#line 27 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </ul>\n");


#line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"


#line default
#line hidden
});

#line 29 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
}
#line default
#line hidden

#line 32 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
public System.Web.WebPages.HelperResult RenderSubLevelsRecursive(IList<NodeViewModel> nodes)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 33 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
 
    var selectedNode = nodes.SingleOrDefault(node => node.IsCurrentlyOpened || node.HasChildOpen);

    if(selectedNode !=null)
    {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "         <ul");

WriteLiteralTo(__razor_helper_writer, " class=\"nav nav-pills\"");

WriteLiteralTo(__razor_helper_writer, " role=\"tablist\"");

WriteLiteralTo(__razor_helper_writer, ">\n");


#line 39 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
            

#line default
#line hidden

#line 39 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
             foreach (var node in selectedNode.ChildNodes)
            {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                <li");

WriteLiteralTo(__razor_helper_writer, " class=\"nav-item\"");

WriteLiteralTo(__razor_helper_writer, " role=\"tab\"");

WriteLiteralTo(__razor_helper_writer, ">\n                    <a");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 1340), Tuple.Create("\"", 1372)
, Tuple.Create(Tuple.Create("", 1348), Tuple.Create("nav-link", 1348), true)

#line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create(" ", 1356), Tuple.Create<System.Object, System.Int32>(GetClass(node)

#line default
#line hidden
, 1357), false)
);

WriteAttributeTo(__razor_helper_writer, "href", Tuple.Create(" href=\"", 1373), Tuple.Create("\"", 1389)

#line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 1380), Tuple.Create<System.Object, System.Int32>(node.Url

#line default
#line hidden
, 1380), false)
);

WriteAttributeTo(__razor_helper_writer, "target", Tuple.Create(" target=\"", 1390), Tuple.Create("\"", 1415)

#line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
 , Tuple.Create(Tuple.Create("", 1399), Tuple.Create<System.Object, System.Int32>(node.LinkTarget

#line default
#line hidden
, 1399), false)
);

WriteLiteralTo(__razor_helper_writer, ">");


#line 42 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
                                                                     WriteTo(__razor_helper_writer, node.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a>\n                </li>\n");


#line 44 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
            }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "        </ul>\n");


#line 46 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
        

#line default
#line hidden

#line 46 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
WriteTo(__razor_helper_writer, RenderSubLevelsRecursive(selectedNode.ChildNodes));


#line default
#line hidden

#line 46 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
                                                          ;
    }


#line default
#line hidden
});

#line 48 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
}
#line default
#line hidden

#line 51 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
public System.Web.WebPages.HelperResult GetClass(NodeViewModel node)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 52 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
 
    if (node.IsCurrentlyOpened)
    {
        

#line default
#line hidden

#line 55 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("active"));


#line default
#line hidden

#line 55 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
                                    ;
    }
    else if (node.HasChildOpen)
    {
        

#line default
#line hidden

#line 59 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
WriteTo(__razor_helper_writer, Html.HtmlSanitize("active"));


#line default
#line hidden

#line 59 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
                                    ;
    }


#line default
#line hidden
});

#line 61 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
}
#line default
#line hidden

        public NavigationView_Tabs()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n");

WriteLiteral("\n\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 260), Tuple.Create("\"", 283)
            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
, Tuple.Create(Tuple.Create("", 268), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 268), false)
);

WriteLiteral(">\n    <nav>\n        ");

WriteLiteral("\r\n\n");

WriteLiteral("        ");

            
            #line 13 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
   Write(RenderRootLevelNode(@Model.Nodes));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("        ");

            
            #line 14 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Navigation\NavigationView.Tabs.cshtml"
   Write(RenderSubLevelsRecursive(@Model.Nodes));

            
            #line default
            #line hidden
WriteLiteral("\n    </nav>\n</div>\n\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n");

WriteLiteral("\n");

        }
    }
}
#pragma warning restore 1591
