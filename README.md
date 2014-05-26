Umbraco MVC Validation Attributes
=================================

Umbraco MVC validation allows you to use umbraco dictionary items for error messages and regular expressions. Also there are some additional attibutes for date validation, date comparison and conditional requierd validation.

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
            [UmbracoRequred("TitleRequiredError")]
            public string Title { get; set; }
            
            //Getting regular expression from dictionary
            [UmbracoRegEx("RegExPhoneFormat", "PhoneFormatError")]
            public string PhoneNumber { get; set; }
            
        }
    }
    
    
##Additional attributes
