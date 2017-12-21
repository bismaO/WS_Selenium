using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using AutomationWS.PageObjects.Employee;

namespace AutomationWS
{
   public class PgAddUpdateEmployee
    {
       [FindsBy(How = How.Id, Using = "btnEmpGeneral")]
        public IWebElement btnEmpGeneralTab { get; set; }

        [FindsBy(How = How.Id, Using = "btnEmpRate")]
        public IWebElement btnEmpRateTab { get; set; }

        [FindsBy (How=How.Id, Using = "lnkSave")]
        public IWebElement lnkSaveEmployee { get; set; }

        public void GoToGeneralTabEmployee()
        {
            btnEmpGeneralTab.Click();
        }
        public void GoToRateTabEmployee()
        {
            btnEmpRateTab.Click();
        }
        public void SaveEmployee()
        {
            lnkSaveEmployee.Click();
        }
    }
    
}
