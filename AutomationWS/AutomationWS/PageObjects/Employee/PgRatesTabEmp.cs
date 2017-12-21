using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationWS.PageObjects.Employee
{
  public  class PgRatesTabEmp
    {
        [FindsBy(How = How.Id, Using = "txtEmpBR")]
        public IWebElement txtEmployeeBR { get; set; }

        [FindsBy(How = How.Id, Using = "txtEmpCR")]
        public IWebElement txtEmployeeCR { get; set; }

        public void SetEmpRates()
        {
            txtEmployeeBR.EnterData("100");
            txtEmployeeCR.EnterData("50");
        }
    }
}
