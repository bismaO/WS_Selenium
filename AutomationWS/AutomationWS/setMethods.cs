using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationWS
{
    
    public static class setMethods
    {
        
        public static void EnterData(this IWebElement element, string value)
        {
            element.WaitForElementToBeClickable();
            element.SendKeys(value);
        }

        public static void waitAndClick(this IWebElement element)
        {
            element.WaitForElementToBeClickable();
            element.Click();
        }
        public static void Navigate(this IWebElement elementToHover )
        {
            Actions action = new Actions(propertiesCollection.driver);
            elementToHover.WaitForElementToBeClickable();
            action.MoveToElement(elementToHover).Perform();
        }

        public static void SelectValueFromDd(this IWebElement element, string value)
        {
            SelectElement ddList = new SelectElement(element);
            //Actions keyDown = new Actions(propertiesCollection.driver);
            //keyDown.SendKeys(Keys.chord(Keys.Down, Keys.Down)).perform();
            ddList.SelectByText(value);
            ddList.SelectedOption.Click();
        }
       public static string randomDataGeneration(int length)
        {
            Random rd = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrsqtuvwxyz";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[rd.Next(s.Length)]).ToArray());
            
        
    }

        public static IWebElement ClickOnInvisibleElement(this IWebDriver driver, By by)
        {
            IWebElement element = driver.FindElement(by);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].hidden = false;", element);
            element.Click();
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].hidden = true;", element);
            return element;
        }
    }
}
