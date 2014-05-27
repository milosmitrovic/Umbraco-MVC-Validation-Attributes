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


###Conditional required

            //Conditional required if "Text2" property is not null, empty or white space
            [UmbracoConditionlRequired("Text2", "Text1ConditionalRequiredErrorKey")]
            public string Text1 { get; set; }
            
            public string Text2 { get; set; } 


###Date validation attribute

            //Optional date field validator
            [UmbracoDateValidator("DateFormatErrorKey")]
            public string Birthday { get; set; }
            
            //Date validation with forced date format
            [UmbracoDateValidator("dd-MM-yyyy", "DateFormatErrorKey")]
            public string Birthday { get; set; }
            
            //Required date field with forced date format
            [UmbracoDateValidator("dd-MM-yyyy", required: true, "DateFormatErrorKey")]
            public string Birthday { get; set; }
            

###DateTimeNow Comparison Attribute

    //Compare date field with current datetime
    [UmbracoDateTimeNowComparison(DateComparisonType.LowerThan, "BirthdayMaxDateErrorKey")]
    public string Birthday { get; set; }
    
    //Compare date field only with current date
    [UmbracoDateTimeNowComparison(DateComparisonType.Equal, onlyDate: true, "DateNotEqualErrorKey")]
    public string Birthday { get; set; }

    //Compare date field with current datetime and force date format
    [UmbracoDateTimeNowComparison("dd-MM-yyyy", DateComparisonType.LowerThanOrEqual, "BirthdayMaxDateErrorKey"))]
    public string Birthday { get; set; }
    
    
###Date Fields Compare Attribute

    //Comparison of two date fields
    [UmbracoDateFieldsCompare("DateTo",DateComparisonType.GreaterThan, "FromDateMinDateErrorKey")]
    public string FromDate { get; set; }
    
    [UmbracoDateFieldsCompare("FromDate",DateComparisonType.LowerThanOrEqual, "ToDateMaxDateErrorKey")]
    public string ToDate { get; set; }
    
    
