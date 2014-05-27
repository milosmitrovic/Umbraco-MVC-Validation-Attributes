Umbraco MVC Validation Attributes
=================================

Umbraco MVC validation allows you to use umbraco dictionary items for error messages and regular expressions. Also there are some additional attibutes for date validation, date comparison and conditional requierd validation. This assembly is available for umbraco 6.2.0 (.net 4.0) and umbraco 7.1.1 (.net 4.5).

##How to use


    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.Web.Mvc;
    using mUtility.Umbraco.Validation;

    namespace WebApp.Models
    {
        public class FormModel
        {
            //Getting error text from dictionary
            [UmbracoRequred("TitleRequiredErrorKey")]
            public string Title { get; set; }
            
            //Getting regular expression from dictionary
            [UmbracoRegEx("RegExPhoneFormatKey", "PhoneFormatErrorKey")]
            public string PhoneNumber { get; set; }
            
           //Email address error messages from umbraco dictionary
           [UmbracoRequred("EmailRequiredErrorKey")]
           [UmbracoEmail("EmailFormatErrorKey")]
           public override string Email { get; set; }
            
        }
    }
    
    
##Additional attributes
