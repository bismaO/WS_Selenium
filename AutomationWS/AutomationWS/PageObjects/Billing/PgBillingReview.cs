using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationWS.PageObjects.Billing
{
    public class PgBillingReview
    {
        [FindsBy(How = How.Id, Using = "cmbViewBy")]
        public IWebElement viewBy { get; set; }

        [FindsBy(How = How.Id, Using = "txtIDFrom")]
        public IWebElement proFrom { get; set; }

        [FindsBy(How = How.Id, Using = "txtIDTo")]
        public IWebElement proTo { get; set; }

        [FindsBy(How = How.Id, Using = "lnkRefresh")]
        public IWebElement btnRefresh { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='conformationFalseButton']")]
        public IWebElement btnCancel { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='gridBR_ctl02_chkBill']")]
        public IWebElement chckbxBill { get; set; }

        [FindsBy(How = How.Id, Using = "lnkProcessOption")]
        public IWebElement btnProcess { get; set; }

        [FindsBy(How = How.Id, Using = "lnkProcess")]
        public IWebElement lnkProcess { get; set; }

        public void createInvoice(string project)
        {
           // try
           // {
            //    propertiesCollection.driver.SwitchTo().Alert().Accept();

           // }
           // catch (Exception e)
           // {

//}
            //finally
            //{
                viewBy.SelectValueFromDd("Project");
                proFrom.Clear();
                proFrom.EnterData(project);
                proTo.Clear();
                proTo.EnterData(project);
                string mainWindow = propertiesCollection.driver.CurrentWindowHandle;
                btnRefresh.Click();
                foreach (string window in propertiesCollection.driver.WindowHandles)
                {
                    propertiesCollection.driver.SwitchTo().Window(window);
                }
                btnCancel.waitAndClick();
                propertiesCollection.driver.SwitchTo().Window(mainWindow);
                propertiesCollection.driver.SwitchTo().Frame("f1");
                Thread.Sleep(5000);
                chckbxBill.Click();
                btnProcess.Navigate();
                Thread.Sleep(1500);
                lnkProcess.Click();
            }

        //}

    }
}
