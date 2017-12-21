using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using AutomationWS.PageObjects;

namespace AutomationWS
{
    public class LoginWS
    {

        [FindsBy(How = How.Id, Using = "cmdOK")]
        public IWebElement btnLogin { get; set; }

        public void ClkLogIn()
        {
            btnLogin.Click();
        }

    }
}
