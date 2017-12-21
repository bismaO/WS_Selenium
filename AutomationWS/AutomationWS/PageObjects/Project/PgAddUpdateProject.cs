using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationWS.PageObjects.Project
{
    public class PgAddUpdateProject
    {
        [FindsBy(How = How.Id, Using = "btnGeneral")]
        public IWebElement btnProjectGeneralTab { get; set; }


        [FindsBy(How = How.Id, Using = "lnkSave")]
        public IWebElement lnkSaveProject{ get; set; }

        public void GoToGeneralTabClient()
        {
            btnProjectGeneralTab.Click();
        }

        public void SaveProject()
        {
            lnkSaveProject.Click();
        }
    }
}
