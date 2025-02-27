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

namespace nuget.ResourcePackages.Bootstrap4.MVC.Views.BlogPost
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
    
    #line 3 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
    using Telerik.Sitefinity.Web.DataResolving;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/BlogPost/List.BlogPostList.cshtml")]
    public partial class List_BlogPostList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_BlogPostList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 234), Tuple.Create("\"", 257)
            
            #line 8 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
, Tuple.Create(Tuple.Create("", 242), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 242), false)
);

WriteLiteral(">\n    <ul");

WriteLiteral(" class=\"list-unstyled\"");

WriteLiteral(">\n\n");

            
            #line 11 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
        
            
            #line default
            #line hidden
            
            #line 11 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
         foreach (var item in Model.Items)
        {
            var navigateUrl = HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix);
            

            
            #line default
            #line hidden
WriteLiteral("            <li ");

            
            #line 15 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
           Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\n                <h3>\n                    <a ");

            
            #line 17 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
                  Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(" href=\"");

            
            #line 17 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
                                                                                 Write(navigateUrl);

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 17 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
                                                                                               Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\n                </h3>\n\n\n                <div");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\n");

WriteLiteral("                    ");

            
            #line 22 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
               Write(item.GetDateTime("PublicationDate", "MMM d, yyyy, HH:mm tt"));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                    ");

            
            #line 23 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
               Write(Html.Resource("By"));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                    ");

            
            #line 24 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
               Write(DataResolver.Resolve(item.DataItem, "Author", null));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("                    ");

            
            #line 25 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
               Write(Html.CommentsCount((string)navigateUrl, item.DataItem));

            
            #line default
            #line hidden
WriteLiteral("\n                </div>\n\n                <div ");

            
            #line 28 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
                Write(Html.InlineEditingFieldAttributes("Summary", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 28 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
                                                                           Write(Html.HtmlSanitize((string)item.Fields.Summary));

            
            #line default
            #line hidden
WriteLiteral("</div>\n\n                <a");

WriteAttribute("href", Tuple.Create(" href=\"", 1271), Tuple.Create("\"", 1290)
            
            #line 30 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
, Tuple.Create(Tuple.Create("", 1278), Tuple.Create<System.Object, System.Int32>(navigateUrl
            
            #line default
            #line hidden
, 1278), false)
);

WriteLiteral(">");

            
            #line 30 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
                                  Write(Html.Resource("FullStory"));

            
            #line default
            #line hidden
WriteLiteral("</a>\n            </li>\n");

            
            #line 32 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\n\n");

            
            #line 35 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 35 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
     if (Model.ShowPager)
    {
        
            
            #line default
            #line hidden
            
            #line 37 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
   Write(Html.Action("Index", "ContentPager", new
           {
               currentPage = Model.CurrentPage,
               totalPagesCount = Model.TotalPagesCount.Value,
               redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
           }));

            
            #line default
            #line hidden
            
            #line 42 "..\..MVC\Views\BlogPost\List.BlogPostList.cshtml"
             
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\n");

        }
    }
}
#pragma warning restore 1591
