using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationWS.PageObjects.Employee
{
    public class PgGeneralTabEmp
    {

        [FindsBy(How = How.Id, Using = "txtEmpID")]
        public IWebElement txtEmployeeID { get; set; }

        [FindsBy(How = How.Id, Using = "txtEmpFName")]
        public IWebElement txtEmployeeFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "txtEmpLName")]
        public IWebElement txtEmployeeLastName { get; set; }

        public void SetIDandName()
        {
            txtEmployeeID.EnterData("101"+ setMethods.randomDataGeneration(2));
            txtEmployeeFirstName.EnterData(setMethods.randomDataGeneration(5));
            txtEmployeeLastName.EnterData(setMethods.randomDataGeneration(5));
        }

       }
    
}
