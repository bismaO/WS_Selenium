using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System.Threading;

namespace AutomationWS.PageObjects.Time
{
    public class PgTime
    {
        [FindsBy(How = How.Id, Using = "cmbViewBy")]
        public IWebElement cmbViewBy { get; set; }

        [FindsBy(How = How.Id, Using = "txtEmpProj")]
        public IWebElement txtEmpPro { get; set; }

        [FindsBy(How = How.Id, Using = "txtQEDate")]
        public IWebElement txtQEDate { get; set; }

        [FindsBy(How = How.Id, Using = "txtQEEmpProj")]
        public IWebElement txtQEProEmp { get; set; }

        [FindsBy(How = How.Id, Using = "txtQEActivity")]
        public IWebElement txtQEActivity { get; set; }

        [FindsBy(How = How.Id, Using = "txtQEDescription")]
        public IWebElement txtQEDescription { get; set; }

        [FindsBy(How = How.Id, Using = "txtQEAHrs")]
        public IWebElement txtQEAHrs { get; set; }

        [FindsBy(How = How.Id, Using = "chkQEApprove")]
        public IWebElement chkboxApprove { get; set; }

        [FindsBy(How = How.Id, Using = "chkQEBillable")]
        public IWebElement chkboxBillable { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='btnQEAdd']")]
        public IWebElement AddTEIcon { get; set; }

        [FindsBy(How = How.Id, Using = "lstcmbEmp1")]
        public IWebElement ddIcon { get; set; }
        

        public void setRequiredFields(string Emp, string Pro, string hrs)
        {
            if(cmbViewBy.GetAttribute("value")=="Employee")
            {
                txtEmpPro.Clear();
                txtEmpPro.SendKeys(Emp);
                //ddIcon.Click();
                //IWebElement ve = propertiesCollection.driver.FindElement(By.XPath("//*[@id='divFullList']/div/table/tbody/tr[2]/td[2]"));
                //ve.waitAndClick();
                //txtEmpPro.EnterData(Emp);
                txtQEDate.EnterData(DateTime.Now.ToString());
                //txtQEProEmp.waitAndClick();
                //IWebElement vp = propertiesCollection.driver.FindElement(By.XPath("//*[@id='lstItem0']"));
                //vp.waitAndClick();
                txtQEProEmp.EnterData(Pro);
                Thread.Sleep(2000);
                txtQEActivity.waitAndClick();
                Thread.Sleep(5000);       
                IWebElement va = propertiesCollection.driver.FindElement(By.XPath("//*[@id='lstItem0']"));
                va.waitAndClick();
                txtQEDescription.Clear();
                txtQEDescription.EnterData(setMethods.randomDataGeneration(10));
                txtQEAHrs.EnterData(hrs);
            }
            else if (cmbViewBy.GetAttribute("value") == "Project")
            {
                txtEmpPro.Clear();
                txtEmpPro.SendKeys(Pro);
                //ddIcon.Click();
                //IWebElement ve = propertiesCollection.driver.FindElement(By.XPath("//*[@id='divFullList']/div/table/tbody/tr[2]/td[2]"));
                //ve.waitAndClick();
                //txtEmpPro.EnterData(Emp);
                txtQEDate.EnterData(DateTime.Now.ToString());
                //txtQEProEmp.waitAndClick();
                //IWebElement vp = propertiesCollection.driver.FindElement(By.XPath("//*[@id='lstItem0']"));
                //vp.waitAndClick();
                txtQEProEmp.EnterData(Emp);
                txtQEActivity.Click();
                Thread.Sleep(1100);
                IWebElement va = propertiesCollection.driver.FindElement(By.XPath("//*[@id='lstItem0']"));
                va.waitAndClick();
                txtQEDescription.Clear();
                txtQEDescription.EnterData(setMethods.randomDataGeneration(10));
                txtQEAHrs.EnterData(hrs);
            }
        }

        public void setHours(string hrs)
        {
            txtQEAHrs.EnterData(hrs);
        }

        public void ApproveEntry()
        {
            chkboxApprove.Click();
        }

        public void makeBillable()
        {
            if(chkboxBillable.Selected==false)
            {
                chkboxBillable.Click();
            }
            
        }

        public void SaveEntry()
        {
            AddTEIcon.Click();
        }
    }
}
