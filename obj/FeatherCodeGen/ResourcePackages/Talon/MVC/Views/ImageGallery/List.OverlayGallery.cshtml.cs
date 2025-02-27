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

namespace nuget.ResourcePackages.Talon.MVC.Views.ImageGallery
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
    
    #line 3 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Media.Mvc.Models.ImageGallery;
    
    #line default
    #line hidden
    
    #line 4 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 7 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/ImageGallery/List.OverlayGallery.cshtml")]
    public partial class List_OverlayGallery : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Mvc.Models.ContentListViewModel>
    {
        public List_OverlayGallery()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 9 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 11 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
Write(Html.StyleSheet(Url.WidgetContent("assets/magnific/magnific-popup.css"), "head", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 12 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
Write(Html.Script(Url.WidgetContent("assets/magnific/jquery.magnific-popup.min.js"), "bottom", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 13 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/ImageGallery/overlay-gallery.js"), "bottom", true));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<div");

WriteLiteral(" class=\"sf-Gallery-thumbs-container\"");

WriteLiteral(">\r\n  <ul");

WriteAttribute("class", Tuple.Create(" class=\"", 692), Tuple.Create("\"", 747)
, Tuple.Create(Tuple.Create("", 700), Tuple.Create("sf-Gallery-thumbs", 700), true)
, Tuple.Create(Tuple.Create(" ", 717), Tuple.Create("list-unstyled", 718), true)
            
            #line 16 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create(" ", 731), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 732), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 748), Tuple.Create("\"", 791)
            
            #line 16 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 761), Tuple.Create<System.Object, System.Int32>(Html.Resource("ImageGallery")
            
            #line default
            #line hidden
, 761), false)
);

WriteLiteral(">\r\n");

            
            #line 17 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
    
            
            #line default
            #line hidden
            
            #line 17 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
      int itemIndex = 0;
            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 18 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
    
            
            #line default
            #line hidden
            
            #line 18 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
     foreach (var item in Model.Items)
    {
        var thumbnailViewModel = (ThumbnailViewModel)item;

            
            #line default
            #line hidden
WriteLiteral("        <li");

WriteLiteral(" class=\"d-inline-block\"");

WriteLiteral(">\r\n            <a");

WriteLiteral(" class=\"text-center image-link\"");

WriteAttribute("href", Tuple.Create("\r\n               href=\"", 1011), Tuple.Create("\"", 1064)
            
            #line 23 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1034), Tuple.Create<System.Object, System.Int32>(thumbnailViewModel.MediaUrl
            
            #line default
            #line hidden
, 1034), false)
);

WriteAttribute("title", Tuple.Create("\r\n               title=\"", 1065), Tuple.Create("\"", 1107)
            
            #line 24 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1089), Tuple.Create<System.Object, System.Int32>(item.Fields.Title
            
            #line default
            #line hidden
, 1089), false)
);

WriteAttribute("aria-label", Tuple.Create("\r\n               aria-label=\"", 1108), Tuple.Create("\"", 1206)
            
            #line 25 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1137), Tuple.Create<System.Object, System.Int32>(string.Format(Html.Resource("OpenInModalDialog"), item.Fields.Title)
            
            #line default
            #line hidden
, 1137), false)
);

WriteLiteral(">\r\n                <img");

WriteAttribute("src", Tuple.Create(" src=\"", 1230), Tuple.Create("\"", 1270)
            
            #line 26 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1236), Tuple.Create<System.Object, System.Int32>(thumbnailViewModel.ThumbnailUrl
            
            #line default
            #line hidden
, 1236), false)
);

WriteLiteral("\r\n                     data-detail-url=\"");

            
            #line 27 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
                                 Write(HyperLinkHelpers.GetDetailPageUrl(item, ViewBag.DetailsPageId, ViewBag.OpenInSamePage, Model.UrlKeyPrefix, itemIndex));

            
            #line default
            #line hidden
WriteLiteral("\"");

WriteAttribute("alt", Tuple.Create("\r\n                     alt=\"", 1430), Tuple.Create("\"", 1486)
            
            #line 28 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
, Tuple.Create(Tuple.Create("", 1458), Tuple.Create<System.Object, System.Int32>(item.Fields.AlternativeText
            
            #line default
            #line hidden
, 1458), false)
);

WriteLiteral("\r\n                     ");

            
            #line 29 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
                Write(Html.GetWidthAttributeIfExists(thumbnailViewModel.Width));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                     ");

            
            #line 30 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
                Write(Html.GetHeightAttributeIfExists(thumbnailViewModel.Height));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 30 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
                                                                            Write(Html.GetDetailsImageWidthAttributeIfExists(thumbnailViewModel.DetailsImageWidth));

            
            #line default
            #line hidden
WriteLiteral(" />\r\n            </a>\r\n        </li>\r\n");

            
            #line 33 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
        itemIndex++;
    }

            
            #line default
            #line hidden
WriteLiteral("  </ul>\r\n</div>\r\n\r\n");

            
            #line 38 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
 if (Model.ShowPager)
{
    
            
            #line default
            #line hidden
            
            #line 40 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
Write(Html.Action("Index", "ContentPager", new
       {
           currentPage = Model.CurrentPage,
           totalPagesCount = Model.TotalPagesCount.Value,
           redirectUrlTemplate = ViewBag.RedirectPageUrlTemplate
       }));

            
            #line default
            #line hidden
            
            #line 45 "..\..MVC\Views\ImageGallery\List.OverlayGallery.cshtml"
         
}

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
