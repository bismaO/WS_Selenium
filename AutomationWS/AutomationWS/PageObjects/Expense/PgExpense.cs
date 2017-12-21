using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationWS.PageObjects.Expense
{
    public class PgExpense
    {
        [FindsBy(How = How.Id, Using = "cmbViewBy")]
        public IWebElement cmbViewBy { get; set; }

        [FindsBy(How = How.Id, Using = "txtEmpProj")]
        public IWebElement txtEmpPro { get; set; }

        [FindsBy(How = How.Id, Using = "lnkNew")]
        public IWebElement btnNew { get; set; }


       public void AddNewExpense()
        {
            btnNew.Click();
        }

    }
}
