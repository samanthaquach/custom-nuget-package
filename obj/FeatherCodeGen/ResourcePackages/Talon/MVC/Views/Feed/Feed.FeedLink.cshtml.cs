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

namespace nuget.ResourcePackages.Talon.MVC.Views.Feed
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
    
    #line 3 "..\..MVC\Views\Feed\Feed.FeedLink.cshtml"
    using Telerik.Sitefinity.Frontend.Publishing.Mvc.Models;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Feed/Feed.FeedLink.cshtml")]
    public partial class Feed_FeedLink : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Publishing.Mvc.Models.FeedViewModel>
    {
        public Feed_FeedLink()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 139), Tuple.Create("\"", 162)
            
            #line 5 "..\..MVC\Views\Feed\Feed.FeedLink.cshtml"
, Tuple.Create(Tuple.Create("", 147), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 147), false)
);

WriteLiteral(">\r\n");

            
            #line 6 "..\..MVC\Views\Feed\Feed.FeedLink.cshtml"
 if ((Model.InsertionOption == FeedInsertionOption.PageOnly || Model.InsertionOption == FeedInsertionOption.PageAndAddressBar) && !string.IsNullOrEmpty(Model.Url))
{

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteLiteral(" class=\"d-inline-flex\"");

WriteAttribute("href", Tuple.Create(" href=\"", 362), Tuple.Create("\"", 379)
            
            #line 8 "..\..MVC\Views\Feed\Feed.FeedLink.cshtml"
, Tuple.Create(Tuple.Create("", 369), Tuple.Create<System.Object, System.Int32>(Model.Url
            
            #line default
            #line hidden
, 369), false)
);

WriteAttribute("title", Tuple.Create(" title=\"", 380), Tuple.Create("\"", 402)
            
            #line 8 "..\..MVC\Views\Feed\Feed.FeedLink.cshtml"
, Tuple.Create(Tuple.Create("", 388), Tuple.Create<System.Object, System.Int32>(Model.Tooltip
            
            #line default
            #line hidden
, 388), false)
);

WriteLiteral(" ");

            
            #line 8 "..\..MVC\Views\Feed\Feed.FeedLink.cshtml"
                                                                  Write(Model.OpenInNewWindow ? "target=_blank" : "");

            
            #line default
            #line hidden
WriteLiteral(">\r\n        <svg");

WriteLiteral(" class=\"sf-icon-feed sf-icon-sm\"");

WriteLiteral(" aria-hidden=\"true\"");

WriteLiteral(">\r\n            <use");

WriteAttribute("xlink:href", Tuple.Create(" xlink:href=\"", 536), Tuple.Create("\"", 619)
, Tuple.Create(Tuple.Create("", 549), Tuple.Create<System.Object, System.Int32>(Href("~/ResourcePackages/Bootstrap4/assets/dist/sprites/solid.svg#rss-square")
, 549), false)
);

WriteLiteral("></use>\r\n        </svg>\r\n");

WriteLiteral("        ");

            
            #line 12 "..\..MVC\Views\Feed\Feed.FeedLink.cshtml"
   Write(Model.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n    </a>\r\n");

            
            #line 14 "..\..MVC\Views\Feed\Feed.FeedLink.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("</div>");

        }
    }
}
#pragma warning restore 1591
