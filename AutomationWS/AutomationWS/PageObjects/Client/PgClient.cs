using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationWS.PageObjects.Client
{
   public class PgClient
    {

        [FindsBy (How= How.Id, Using = "lnkNew")]
        public IWebElement lnkNewClient { get; set; }

        public void CreateNewClient()
        {
            try
            {

                lnkNewClient.Navigate();
                lnkNewClient.Click();
            }
            catch (NoSuchElementException e)
            {
                throw e;
            }
        }
    }
}
