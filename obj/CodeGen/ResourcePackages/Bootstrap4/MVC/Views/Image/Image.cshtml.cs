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

namespace nuget.ResourcePackages.Bootstrap4.MVC.Views.Image
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
    
    #line 1 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Image\Image.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Helpers;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/ResourcePackages/Bootstrap4/MVC/Views/Image/Image.cshtml")]
    public partial class Image : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Media.Mvc.Models.Image.ImageViewModel>
    {

#line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Image\Image.cshtml"
public System.Web.WebPages.HelperResult ImageTag() {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 4 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Image\Image.cshtml"
                      


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <img");

WriteAttributeTo(__razor_helper_writer, "class", Tuple.Create(" class=\"", 160), Tuple.Create("\"", 183)

#line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Image\Image.cshtml"
, Tuple.Create(Tuple.Create("", 168), Tuple.Create<System.Object, System.Int32>(Model.CssClass

#line default
#line hidden
, 168), false)
);

WriteAttributeTo(__razor_helper_writer, "src", Tuple.Create(" src=\"", 184), Tuple.Create("\"", 212)

#line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Image\Image.cshtml"
, Tuple.Create(Tuple.Create("", 190), Tuple.Create<System.Object, System.Int32>(Model.SelectedSizeUrl

#line default
#line hidden
, 190), false)
);

WriteAttributeTo(__razor_helper_writer, "title", Tuple.Create(" title=\"", 213), Tuple.Create("\"", 233)

#line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Image\Image.cshtml"
, Tuple.Create(Tuple.Create("", 221), Tuple.Create<System.Object, System.Int32>(Model.Title

#line default
#line hidden
, 221), false)
);

WriteAttributeTo(__razor_helper_writer, "alt", Tuple.Create(" alt=\"", 234), Tuple.Create("\"", 262)

#line 5 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Image\Image.cshtml"
         , Tuple.Create(Tuple.Create("", 240), Tuple.Create<System.Object, System.Int32>(Model.AlternativeText

#line default
#line hidden
, 240), false)
);

WriteLiteralTo(__razor_helper_writer, " \n                ");


#line 6 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Image\Image.cshtml"
WriteTo(__razor_helper_writer, Html.GetWidthAttributeForVectorGraphics(Model.CustomSize, Model.Item.DataItem));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\n");

WriteLiteralTo(__razor_helper_writer, "                ");


#line 7 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Image\Image.cshtml"
WriteTo(__razor_helper_writer, Html.GetHeightAttributeForVectorGraphics(Model.CustomSize, Model.Item.DataItem));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " /> \n");


#line 8 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Image\Image.cshtml"


#line default
#line hidden
});

#line 8 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Image\Image.cshtml"
}
#line default
#line hidden

        public Image()
        {
        }
        public override void Execute()
        {
WriteLiteral(" \n");

            
            #line 10 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Image\Image.cshtml"
 if (string.IsNullOrEmpty(Model.LinkedContentUrl)) 
{ 
    
            
            #line default
            #line hidden
            
            #line 12 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Image\Image.cshtml"
Write(ImageTag());

            
            #line default
            #line hidden
            
            #line 12 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Image\Image.cshtml"
                
} 
else 
{ 

            
            #line default
            #line hidden
WriteLiteral("    <a");

WriteAttribute("href", Tuple.Create(" href=\"", 557), Tuple.Create("\"", 587)
            
            #line 16 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Image\Image.cshtml"
, Tuple.Create(Tuple.Create("", 564), Tuple.Create<System.Object, System.Int32>(Model.LinkedContentUrl
            
            #line default
            #line hidden
, 564), false)
);

WriteLiteral(" title=\"Open image in original size\"");

WriteLiteral("> \n");

WriteLiteral("        ");

            
            #line 17 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Image\Image.cshtml"
   Write(ImageTag());

            
            #line default
            #line hidden
WriteLiteral(" \n    </a> \n");

            
            #line 19 "..\..\ResourcePackages\Bootstrap4\MVC\Views\Image\Image.cshtml"
}
            
            #line default
            #line hidden
WriteLiteral(" ");

        }
    }
}
#pragma warning restore 1591
