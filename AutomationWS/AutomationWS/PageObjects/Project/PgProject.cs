
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationWS.PageObjects.Project
{
    public class PgProject
    {
        [FindsBy(How = How.Id, Using = "lnkNew")]
        public IWebElement lnkNewProject { get; set; }

        public void CreateNewProject()
        {
                lnkNewProject.Navigate();
                lnkNewProject.Click();           
        }
    }
}
