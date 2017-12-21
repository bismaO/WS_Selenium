using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationWS
{
    public static class waitMethods
    {
        public static void WaitForElementToBeClickable(this IWebElement element)
        {

            var wait = new WebDriverWait(propertiesCollection.driver, TimeSpan.FromSeconds(200));
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
            //WebDriverWait wait = new WebDriverWait(, TimeSpan.FromSeconds(200));
            //wait.Until(fun => element.Displayed && element.Enabled );
           // wait.Until(ExpectedConditions.ElementToBeClickable(element));
                        
        }
    }
}
