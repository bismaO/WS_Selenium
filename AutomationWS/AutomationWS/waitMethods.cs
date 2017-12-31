using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationWS
{
    public static class waitMethods
    {
        public static void WaitForElementToBeClickable(this IWebElement element)
        {

            var wait = new WebDriverWait(propertiesCollection.driver, TimeSpan.FromSeconds(120));
            //wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            //WebDriverWait wait = new WebDriverWait(, TimeSpan.FromSeconds(200));
            //wait.Until(fun => element.Displayed && element.Enabled );
           // wait.Until(ExpectedConditions.ElementToBeClickable(element));
                        
        }

        public static void WaitForAjax() 
        {

        while (true)
        {

                Boolean ajaxIsComplete = (Boolean)((IJavaScriptExecutor) propertiesCollection.driver).ExecuteScript("return jQuery.active == 0");
                if (ajaxIsComplete)
                {
                    break;
                }
                Thread.Sleep(100);
        }
        }

        public static void WaitForLoad()
        {

            WebDriverWait wait = new WebDriverWait(propertiesCollection.driver, TimeSpan.FromSeconds(60));
            wait.Until(fun =>
           {
               return (bool)((IJavaScriptExecutor)propertiesCollection.driver).ExecuteScript("return document.readyState").Equals("complete");
           });
            
        }
    }
}
