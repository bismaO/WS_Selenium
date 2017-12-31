using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationWS.PageObjects.Invoice
{
    public class PgInvoiceReview
    {
        [FindsBy(How = How.Id, Using = "txtProj")]
        public IWebElement txtProject { get; set; }

        [FindsBy(How = How.Id, Using = "lnkRefresh")]
        public IWebElement btnRefresh { get; set; }

        [FindsBy(How = How.Id, Using = "chkProj")]
        public IWebElement chckbxPro { get; set; }
        
        public void viewInvoices(string pro)
        {
            if (chckbxPro.Selected == false)
            {
                chckbxPro.Click();
            }            
            txtProject.Clear();
            txtProject.EnterData(pro);
            btnRefresh.waitAndClick();
        }
    }
}
