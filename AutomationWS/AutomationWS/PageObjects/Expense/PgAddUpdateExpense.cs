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
    public class PgAddUpdateExpense
    {
        [FindsBy(How = How.Id, Using = "cmbViewBy")]
        public IWebElement cmbViewBy { get; set; }

        [FindsBy(How = How.Id, Using = "txtEmpProj")]
        public IWebElement txtEmpPro { get; set; }

        [FindsBy(How = How.Id, Using = "lnkNew")]
        public IWebElement btnNew { get; set; }

        [FindsBy(How = How.Id, Using = "txtEmpProj2")]
        public IWebElement txtNEProEmp { get; set; }

        [FindsBy(How = How.Id, Using = "txtExpense")]
        public IWebElement txtNEExpense { get; set; }

        [FindsBy(How = How.Id, Using = "txtELDescription")]
        public IWebElement txtELDescription { get; set; }

        [FindsBy(How = How.Id, Using = "txtUnits")]
        public IWebElement txtUnits { get; set; }

        [FindsBy(How = How.Id, Using = "txtForeignCost")]
        public IWebElement txtCost { get; set; }

        [FindsBy(How = How.Id, Using = "chkApproved")]
        public IWebElement chkboxApprove { get; set; }

        [FindsBy(How = How.Id, Using = "lnkSave")]
        public IWebElement btnSave { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='lblMore']")]
        public IWebElement MoreIcon { get; set; }

        [FindsBy(How = How.Id, Using = "lstExpense")]
        public IWebElement ddIconExpense { get; set; }


        public void setRequiredFields(string Emp, string Pro, string units, string Cost)
        {
            if (cmbViewBy.GetAttribute("value") == "Employee")
            {
                txtEmpPro.Clear();
                txtEmpPro.SendKeys(Emp);
                //Thread.Sleep(5000);
                txtNEProEmp.EnterData(Pro);
                Thread.Sleep(5000);
                ddIconExpense.waitAndClick();
                Thread.Sleep(5000);
                IWebElement va = propertiesCollection.driver.FindElement(By.XPath("//*[@id='divFullList']/div/table/tbody/tr[2]/td[2]"));
                va.waitAndClick();
                // txtELDescription.Clear();
                //txtELDescription.EnterData(setMethods.randomDataGeneration(10));
                txtUnits.Click();
                waitMethods.WaitForAjax();
                //txtUnits.Clear();
                txtUnits.EnterData(units);
                txtCost.Click();
                //waitMethods.WaitForAjax();
                //txtCost.Clear();
                txtCost.EnterData(Cost);
                //txtELDescription.Clear();
                //txtELDescription.EnterData(setMethods.randomDataGeneration(10));
            }
            else if (cmbViewBy.GetAttribute("value") == "Project")
            {
                txtEmpPro.Clear();
                txtEmpPro.SendKeys(Pro);
                txtNEProEmp.EnterData(Emp);
                ddIconExpense.Click();
                Thread.Sleep(1100);
                IWebElement va = propertiesCollection.driver.FindElement(By.XPath("//*[@id='divFullList']/div/table/tbody/tr[2]/td[2]"));
                va.waitAndClick();
                txtELDescription.Clear();
                txtELDescription.EnterData(setMethods.randomDataGeneration(10));
                txtUnits.Clear();
                txtUnits.EnterData(units);
                propertiesCollection.driver.SwitchTo().Alert().Dismiss();
                txtCost.Clear();
                txtCost.EnterData(Cost);
            }
        }

        public void More()
        {
            MoreIcon.Click();
        }

        public void ApproveEntry()
        {
            chkboxApprove.Click();
        }


        public void SaveEntry()
        {
            btnSave.Click();
        }
    }
}
