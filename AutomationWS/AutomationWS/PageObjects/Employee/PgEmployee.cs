using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationWS.PageObjects
{
   public class PgEmployee
    {
        [FindsBy(How = How.Id, Using ="lnkNew")]
        public IWebElement lnkNewEmp { get; set; }

        public void CreateNewEmployee()
        {
            try
            {
                
                lnkNewEmp.Navigate();
                lnkNewEmp.Click();
            }
            catch (NoSuchElementException e)
            {
                throw e;
            }
        }
    }
}
