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

namespace nuget.ResourcePackages.Bootstrap4.MVC.Views.FlatTaxonomy
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/FlatTaxonomy/FlatTaxonomy.SimpleList.csht" +
        "ml")]
    public partial class FlatTaxonomy_SimpleList : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Taxonomies.Mvc.Models.TaxonomyViewModel>
    {
        public FlatTaxonomy_SimpleList()
        {
        }
        public override void Execute()
        {
WriteLiteral("<ul");

WriteAttribute("class", Tuple.Create(" class=\"", 79), Tuple.Create("\"", 124)
            
            #line 3 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleList.cshtml"
, Tuple.Create(Tuple.Create("", 87), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 87), false)
, Tuple.Create(Tuple.Create(" ", 102), Tuple.Create("sf-Tags", 103), true)
, Tuple.Create(Tuple.Create(" ", 110), Tuple.Create("list-unstyled", 111), true)
);

WriteLiteral(">\n");

            
            #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleList.cshtml"
    
            
            #line default
            #line hidden
            
            #line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleList.cshtml"
     foreach (var taxa in Model.Taxa)
    {

            
            #line default
            #line hidden
WriteLiteral("        <li>\n            <a");

WriteAttribute("href", Tuple.Create(" href=\"", 198), Tuple.Create("\"", 214)
            
            #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleList.cshtml"
, Tuple.Create(Tuple.Create("", 205), Tuple.Create<System.Object, System.Int32>(taxa.Url
            
            #line default
            #line hidden
, 205), false)
);

WriteLiteral(">");

            
            #line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleList.cshtml"
                           Write(taxa.Title);

            
            #line default
            #line hidden
WriteLiteral("</a>\n            <span");

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">\n");

            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleList.cshtml"
                
            
            #line default
            #line hidden
            
            #line 9 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleList.cshtml"
                 if (Model.ShowItemCount)
                {

            
            #line default
            #line hidden
WriteLiteral("                  ");

WriteLiteral("(");

            
            #line 11 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleList.cshtml"
                Write(taxa.Count);

            
            #line default
            #line hidden
WriteLiteral(")\n");

            
            #line 12 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleList.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </span>\n        </li>\n");

            
            #line 15 "..\..\ResourcePackages\Bootstrap4\MVC\Views\FlatTaxonomy\FlatTaxonomy.SimpleList.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("</ul>");

        }
    }
}
#pragma warning restore 1591
