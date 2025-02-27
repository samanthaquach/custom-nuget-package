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

namespace nuget.ResourcePackages.Talon.MVC.Views.MultipleChoiceField
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
    
    #line 4 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Frontend.Forms.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 5 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Frontend.Mvc.Helpers;
    
    #line default
    #line hidden
    
    #line 6 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.Modules.Pages;
    
    #line default
    #line hidden
    
    #line 3 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    using Telerik.Sitefinity.UI.MVC;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/MVC/Views/MultipleChoiceField/Write.Default_Inline.cshtml")]
    public partial class Write_Default_Inline : System.Web.Mvc.WebViewPage<Telerik.Sitefinity.Frontend.Forms.Mvc.Models.Fields.MultipleChoiceField.MultipleChoiceFieldViewModel>
    {
        public Write_Default_Inline()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");

            
            #line 8 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
Write(Html.Script(ScriptRef.JQuery, "top", false));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 10 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
  
    var fieldName = string.IsNullOrEmpty(Model.MetaField.FieldName) ? "multiple-choice-field-name" : Model.MetaField.FieldName;
    var requiredAttributes = MvcHtmlString.Create(Model.ValidationAttributes);
    var isRequired = Model.IsRequired ? "true" : "false";
    var hasDescription = !string.IsNullOrEmpty(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<fieldset");

WriteAttribute("class", Tuple.Create(" class=\"", 706), Tuple.Create("\"", 740)
            
            #line 17 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 714), Tuple.Create<System.Object, System.Int32>(Model.CssClass
            
            #line default
            #line hidden
, 714), false)
, Tuple.Create(Tuple.Create(" ", 729), Tuple.Create("form-group", 730), true)
);

WriteLiteral(" data-sf-role=\"multiple-choice-field-container\"");

WriteLiteral(">\r\n    <legend");

WriteLiteral(" class=\"h6\"");

WriteAttribute("id", Tuple.Create(" id=\'", 813), Tuple.Create("\'", 851)
            
            #line 18 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 818), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupLabel")
            
            #line default
            #line hidden
, 818), false)
);

WriteLiteral(">");

            
            #line 18 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                         Write(Model.MetaField.Title);

            
            #line default
            #line hidden
WriteLiteral("</legend>\r\n\r\n    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-role=\"violation-messages\"");

WriteAttribute("value", Tuple.Create(" value=\'", 946), Tuple.Create("\'", 1002)
, Tuple.Create(Tuple.Create("", 954), Tuple.Create("{", 954), true)
, Tuple.Create(Tuple.Create(" ", 955), Tuple.Create("\"required\":", 956), true)
, Tuple.Create(Tuple.Create(" ", 967), Tuple.Create("\"", 968), true)
            
            #line 20 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
  , Tuple.Create(Tuple.Create("", 969), Tuple.Create<System.Object, System.Int32>(Model.RequiredViolationMessage
            
            #line default
            #line hidden
, 969), false)
, Tuple.Create(Tuple.Create("", 1000), Tuple.Create("\"}", 1000), true)
);

WriteLiteral(" />\r\n\r\n    <ul");

WriteLiteral(" class=\"list-inline\"");

WriteAttribute("aria-labelledby", Tuple.Create(" aria-labelledby=\'", 1037), Tuple.Create("\'", 1088)
            
            #line 22 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1055), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupLabel")
            
            #line default
            #line hidden
, 1055), false)
);

WriteLiteral(" ");

            
            #line 22 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                  if (hasDescription) {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("aria-describedby=\'");

            
            #line 22 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                           Write(Html.UniqueId("RadioGroupInfo"));

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 22 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                                            Write(Html.UniqueId("RadioGroupErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" ");

            
            #line 22 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                                                                                                  } else {
            
            #line default
            #line hidden
WriteLiteral(" ");

WriteLiteral("aria-describedby=\'");

            
            #line 22 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                                                                                                                              Write(Html.UniqueId("RadioGroupErrorMessage"));

            
            #line default
            #line hidden
WriteLiteral("\'");

WriteLiteral(" ");

            
            #line 22 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                                                                                                                                                                                    } 
            
            #line default
            #line hidden
WriteLiteral(" >\r\n");

            
            #line 23 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        
            
            #line default
            #line hidden
            
            #line 23 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
         foreach (var choice in Model.Choices)
        {
            string value = !string.IsNullOrEmpty(Model.Value as string) ? Model.Value as string : string.Empty;
            bool isSelected = (!string.IsNullOrEmpty(value) && choice == value) ||
                                (string.IsNullOrEmpty(value) && !Model.IsRequired && choice == Model.MetaField.DefaultValue as string);

            var selctedAttributes = isSelected ? "checked" : string.Empty;

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"list-inline-item\"");

WriteLiteral(">\r\n                <label>\r\n                    <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 1887), Tuple.Create("\"", 1904)
            
            #line 32 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1894), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 1894), false)
);

WriteAttribute("value", Tuple.Create(" value=\"", 1905), Tuple.Create("\"", 1920)
            
            #line 32 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 1913), Tuple.Create<System.Object, System.Int32>(choice
            
            #line default
            #line hidden
, 1913), false)
);

WriteLiteral(" data-sf-role=\"multiple-choice-field-input\"");

WriteLiteral(" ");

            
            #line 32 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                Write(selctedAttributes);

            
            #line default
            #line hidden
WriteLiteral(" ");

            
            #line 32 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                   Write(requiredAttributes);

            
            #line default
            #line hidden
WriteLiteral(" role=\"radio\" aria-required=\"");

            
            #line 32 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                                                                                                   Write(isRequired);

            
            #line default
            #line hidden
WriteLiteral("\" />\r\n");

WriteLiteral("                    ");

            
            #line 33 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
               Write(choice);

            
            #line default
            #line hidden
WriteLiteral("\r\n                </label>\r\n            </li>\r\n");

            
            #line 36 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 38 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        
            
            #line default
            #line hidden
            
            #line 38 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
         if(Model.HasOtherChoice)
        {

            
            #line default
            #line hidden
WriteLiteral("            <li");

WriteLiteral(" class=\"list-inline-item\"");

WriteLiteral(">\r\n                <label>\r\n                    <input");

WriteLiteral(" type=\"radio\"");

WriteAttribute("name", Tuple.Create(" name=\"", 2289), Tuple.Create("\"", 2306)
            
            #line 42 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 2296), Tuple.Create<System.Object, System.Int32>(fieldName
            
            #line default
            #line hidden
, 2296), false)
);

WriteLiteral(" data-sf-multiple-choice-role=\"other-choice-radio\"");

WriteLiteral(" data-sf-role=\"multiple-choice-field-input\"");

WriteLiteral(" role=\"radio\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 2413), Tuple.Create("\"", 2440)
            
            #line 42 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                                                                   , Tuple.Create(Tuple.Create("", 2429), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 2429), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("                    ");

            
            #line 43 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
               Write(Html.Resource("Other"));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    <span");

WriteLiteral(" class=\"sr-only\"");

WriteLiteral(">");

            
            #line 44 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                     Write(Html.Resource("ThisChoiceWillExpandTextbox"));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                </label>\r\n                <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" data-sf-multiple-choice-role=\"other-choice-text\"");

WriteAttribute("aria-required", Tuple.Create(" aria-required=\"", 2698), Tuple.Create("\"", 2725)
            
            #line 46 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                     , Tuple.Create(Tuple.Create("", 2714), Tuple.Create<System.Object, System.Int32>(isRequired
            
            #line default
            #line hidden
, 2714), false)
);

WriteAttribute("aria-label", Tuple.Create(" aria-label=\"", 2726), Tuple.Create("\"", 2768)
            
            #line 46 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                              , Tuple.Create(Tuple.Create("", 2739), Tuple.Create<System.Object, System.Int32>(Html.Resource("OtherOption")
            
            #line default
            #line hidden
, 2739), false)
);

WriteLiteral(" />\r\n            </li>\r\n");

            
            #line 48 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </ul>\r\n\r\n");

            
            #line 51 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    
            
            #line default
            #line hidden
            
            #line 51 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
     if (hasDescription) 
    {

            
            #line default
            #line hidden
WriteLiteral("        <p");

WriteAttribute("id", Tuple.Create(" id=\'", 2861), Tuple.Create("\'", 2898)
            
            #line 53 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 2866), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupInfo")
            
            #line default
            #line hidden
, 2866), false)
);

WriteLiteral(" class=\"text-muted\"");

WriteLiteral(">");

            
            #line 53 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
                                                               Write(Model.MetaField.Description);

            
            #line default
            #line hidden
WriteLiteral("</p>\r\n");

            
            #line 54 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
    }

            
            #line default
            #line hidden
WriteLiteral("\r\n    <div");

WriteAttribute("id", Tuple.Create(" id=\'", 2970), Tuple.Create("\'", 3015)
            
            #line 56 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
, Tuple.Create(Tuple.Create("", 2975), Tuple.Create<System.Object, System.Int32>(Html.UniqueId("RadioGroupErrorMessage")
            
            #line default
            #line hidden
, 2975), false)
);

WriteLiteral(" data-sf-role=\"error-message\"");

WriteLiteral(" role=\"alert\"");

WriteLiteral(" aria-live=\"assertive\"");

WriteLiteral(" class=\"text-danger\"");

WriteLiteral("></div>\r\n</fieldset>\r\n\r\n");

            
            #line 59 "..\..MVC\Views\MultipleChoiceField\Write.Default_Inline.cshtml"
Write(Html.Script(Url.WidgetContent("Mvc/Scripts/MultipleChoiceField/multiple-choice-field.js"), "bottom", false));

            
            #line default
            #line hidden
        }
    }
}
#pragma warning restore 1591
