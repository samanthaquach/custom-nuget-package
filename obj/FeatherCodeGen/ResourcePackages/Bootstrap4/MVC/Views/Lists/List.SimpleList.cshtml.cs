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

namespace nuget.ResourcePackages.Bootstrap4.MVC.Views.Lists
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
    
    #line 2 "..\..MVC\Views\Lists\List.SimpleList.cshtml"
    using Telerik.Sitefinity.Frontend.Lists.Mvc.Models;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\Lists\List.SimpleList.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/Lists/List.SimpleList.cshtml")]
    public partial class List_SimpleList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_SimpleList()
        {
        }
        public override void Execute()
        {
WriteLiteral("\n<div");

WriteAttribute("class", Tuple.Create(" class=\"", 173), Tuple.Create("\"", 196)
            
            #line 5 "..\..MVC\Views\Lists\List.SimpleList.cshtml"
, Tuple.Create(Tuple.Create("", 181), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 181), false)
);

WriteLiteral(">\n\n");

            
            #line 7 "..\..MVC\Views\Lists\List.SimpleList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 7 "..\..MVC\Views\Lists\List.SimpleList.cshtml"
     foreach (var item in Model.Items)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3 ");

            
            #line 9 "..\..MVC\Views\Lists\List.SimpleList.cshtml"
       Write(Html.InlineEditingAttributes(Model.ProviderName, Model.ContentType.FullName, (Guid)item.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral("\n");

WriteLiteral("            ");

            
            #line 10 "..\..MVC\Views\Lists\List.SimpleList.cshtml"
       Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">\n\n");

WriteLiteral("            ");

            
            #line 12 "..\..MVC\Views\Lists\List.SimpleList.cshtml"
       Write(item.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\n        </h3>\n");

WriteLiteral("        <ul>\n");

            
            #line 15 "..\..MVC\Views\Lists\List.SimpleList.cshtml"
            
            
            #line default
            #line hidden
            
            #line 15 "..\..MVC\Views\Lists\List.SimpleList.cshtml"
             foreach (var listItem in ((ListViewModel)item).ListItemViewModel.Items)
            {

            
            #line default
            #line hidden
WriteLiteral("                <li ");

            
            #line 17 "..\..MVC\Views\Lists\List.SimpleList.cshtml"
               Write(Html.InlineEditingAttributes(Model.ProviderName, ((ListViewModel)item).ListItemViewModel.ContentType.FullName, (Guid)listItem.Fields.Id));

            
            #line default
            #line hidden
WriteLiteral(">\n                    <div ");

            
            #line 18 "..\..MVC\Views\Lists\List.SimpleList.cshtml"
                    Write(Html.InlineEditingFieldAttributes("Title", "ShortText"));

            
            #line default
            #line hidden
WriteLiteral(">\n");

WriteLiteral("                        ");

            
            #line 19 "..\..MVC\Views\Lists\List.SimpleList.cshtml"
                   Write(listItem.Fields.Title);

            
            #line default
            #line hidden
WriteLiteral("\n                    </div>\n                </li>\n");

            
            #line 22 "..\..MVC\Views\Lists\List.SimpleList.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </ul>\n");

            
            #line 24 "..\..MVC\Views\Lists\List.SimpleList.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\n</div>\n");

        }
    }
}
#pragma warning restore 1591
