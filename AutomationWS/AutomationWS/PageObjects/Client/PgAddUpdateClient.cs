using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationWS.PageObjects.Client
{
   public class PgAddUpdateClient
    {

        [FindsBy(How = How.Id, Using = "btnGeneral")]
        public IWebElement btnClientGeneralTab { get; set; }


        [FindsBy(How = How.Id, Using = "lnkSave")]
        public IWebElement lnkSaveClient { get; set; }

        public void GoToGeneralTabClient()
        {
            btnClientGeneralTab.Click();
        }
        
        public void SaveClient()
        {
            lnkSaveClient.Click();
        }
    }
}
