using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
namespace AutomationWS
{
    public class LoginWS
    {

        public LoginWS()
        {
            Pagefactory.initElements(propertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id, Using = "cmdOK")]
        public IWebElement btnLogin { get; set; }

        public HomePage ClkLogIn()
        {
            btnLogIn.Click();
            return new HomePage();
        }

    }
}
