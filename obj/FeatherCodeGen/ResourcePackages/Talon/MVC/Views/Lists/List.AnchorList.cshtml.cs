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

namespace nuget.ResourcePackages.Talon.MVC.Views.Lists
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    
    #line 5 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
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
    
    #line 3 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
    using Telerik.Sitefinity.Frontend.Lists.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Lists/List.AnchorList.cshtml")]
    public partial class List_AnchorList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_AnchorList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 200), Tuple.Create("\"", 223)
            
            #line 7 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
, Tuple.Create(Tuple.Create("", 208), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 208), false)
);

WriteLiteral(">\r\n\r\n");

            
            #line 9 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 9 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
     foreach (var item in Model.Items)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h1 ");

            
            #line 11 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
       Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n            <a");

WriteAttribute("id", Tuple.Create(" id=\"", 404), Tuple.Create("\"", 428)
            
            #line 12 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
, Tuple.Create(Tuple.Create("", 409), Tuple.Create<System.Object, System.Int32>(item.Fields.Id
            
            #line default
            #line hidden
, 409), false)
, Tuple.Create(Tuple.Create("", 424), Tuple.Create("-Top", 424), true)
);

WriteLiteral("\r\n               ");

            
            #line 13 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
          Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral("\r\n               href=\"#");

            
            #line 14 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
                 Write(item.Fields.Id);

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 14 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
                                  Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n        </h1>\r\n");

            
            #line 16 "..\..MVC\Views\Lists\List.AnchorList.cshtml"


            
            #line default
            #line hidden
WriteLiteral("        <ul>\r\n");

            
            #line 18 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 18 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
             foreach (var listItem in ((ListViewModel)item).ListItemViewModel.Items)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li ");

            
            #line 20 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
               Write(Html.InlineEditingAttributes(Model.ProviderName, ((ListViewModel)item).ListItemViewModel.ContentType.FullName, (Guid)listItem.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n                    <a ");

            
            #line 21 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
                  Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                       href=\"#");

            
            #line 22 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
                         Write(listItem.Fields.Id);

            
            #line default
            #line hidden
WriteLiteral("\">");

            
            #line 22 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
                                              Write(listItem.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n                </li>\r\n");

            
            #line 24 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\r\n");

            
            #line 26 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 28 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 28 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
     foreach (var item in Model.Items)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h1 ");

            
            #line 30 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
       Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 31 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
       Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral("\r\n            id=\"");

            
            #line 32 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
           Write(item.Fields.Id);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n");

WriteLiteral("            ");

            
            #line 33 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
       Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n        </h1>\r\n");

            
            #line 35 "..\..MVC\Views\Lists\List.AnchorList.cshtml"

        foreach (var listItem in ((ListViewModel)item).ListItemViewModel.Items)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div ");

            
            #line 38 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
            Write(Html.InlineEditingAttributes(Model.ProviderName, ((ListViewModel)item).ListItemViewModel.ContentType.FullName, (Guid)listItem.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\r\n                <h3 ");

            
            #line 39 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
               Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    id=\"");

            
            #line 40 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
                   Write(listItem.Fields.Id);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n");

WriteLiteral("                    ");

            
            #line 41 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
               Write(listItem.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </h3>\r\n\r\n                <div ");

            
            #line 44 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
                Write(Html.InlineEditingFieldAttributes("Content", "LongText"));

            
            #line default
            #line hidden
WriteLiteral(">");

            
            #line 44 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
                                                                          Write(Html.HtmlSanitize((string)listItem.Fields.Content));

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n                <p><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1999), Tuple.Create("\"", 2026)
, Tuple.Create(Tuple.Create("", 2006), Tuple.Create("#", 2006), true)
            
            #line 46 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
, Tuple.Create(Tuple.Create("", 2007), Tuple.Create<System.Object, System.Int32>(item.Fields.Id
            
            #line default
            #line hidden
, 2007), false)
, Tuple.Create(Tuple.Create("", 2022), Tuple.Create("-Top", 2022), true)
);

WriteLiteral(">");

            
            #line 46 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
                                             Write(Html.Resource("BackToTop"));

            
            #line default
            #line hidden
WriteLiteral("</a></p>\r\n            </div>\r\n");

            
            #line 48 "..\..MVC\Views\Lists\List.AnchorList.cshtml"
        }
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n</div>\r\n");

        }
    }
}
#pragma warning restore 1591
