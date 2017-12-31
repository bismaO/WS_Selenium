using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Interactions;
using System.Threading;
using AutomationWS.PageObjects.Employee;
using AutomationWS.PageObjects.Client;

namespace AutomationWS.PageObjects
{
   public class PgHome
    {
       
        [FindsBy(How = How.Id, Using = "btnlist")]
        public IWebElement btnlist { get; set; }

        [FindsBy(How = How.Id, Using = "btntime")]
        public IWebElement btntime { get; set; }

        [FindsBy(How = How.Id, Using = "btnexpense")]
        public IWebElement btnExpense { get; set; }

        [FindsBy(How = How.Id, Using = "tab_employee")]
        public IWebElement lnkEmployee { get; set; }

        [FindsBy(How = How.Id, Using = "btnbilling")]
        public IWebElement btnbilling { get; set; }

        [FindsBy(How = How.Id, Using = "tab_client")]
        public IWebElement lnkClient { get; set; }

        [FindsBy(How = How.Id, Using = "tab_project")]
        public IWebElement lnkProject { get; set; }

        [FindsBy(How = How.Id, Using = "tab_sheetview")]
        public IWebElement lnkTime { get; set; }

        [FindsBy(How = How.Id, Using = "tab_expenselog")]
        public IWebElement lnkExpense { get; set; }

        [FindsBy(How = How.Id, Using = "tab_billingreview")]
        public IWebElement lnkBillingReview { get; set; }

        [FindsBy(How = How.Id, Using = "tab_invoicereview")]
        public IWebElement lnkInvoiceReview { get; set; }
        public void goTo(IWebElement list , IWebElement screen)
        {
            propertiesCollection.driver.SwitchTo().DefaultContent();
            list.Navigate();
            //Thread.Sleep(600);
            screen.waitAndClick();
            propertiesCollection.driver.SwitchTo().Frame("f1");            
            
        }
       // public void goToClient()
       // {
          //  propertiesCollection.driver.SwitchTo().DefaultContent();
           // btnlist.Navigate();
           // Thread.Sleep(600);
          //  lnkClient.Click();
          //  propertiesCollection.driver.SwitchTo().Frame("f1");
       // }

       // public void goToProject()
       // {
          //  propertiesCollection.driver.SwitchTo().DefaultContent();
          //  btnlist.Navigate();
          //  Thread.Sleep(600);
          //  lnkProject.Click();
           // propertiesCollection.driver.SwitchTo().Frame("f1");
       // }
    }
}
