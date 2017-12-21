using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationWS.PageObjects.Project
{
    public class PgGeneralTabProject
    {
        [FindsBy(How = How.Id, Using = "txtCode")]
        public IWebElement txtProjectCode { get; set; }

        [FindsBy(How = How.Id, Using = "txtName")]
        public IWebElement txtProjectName { get; set; }

        [FindsBy(How = How.Id, Using = "txtClientAjax")]
        public IWebElement txtClient { get; set; }

        [FindsBy(How = How.Id, Using = "txtMangr")]
        public IWebElement txtProjectManager { get; set; }



        public void setIDandName()
        {
            txtProjectCode.EnterData(setMethods.randomDataGeneration(4));
            txtProjectName.EnterData(setMethods.randomDataGeneration(10));
        }
        public void setClient(string client)
        {
            txtClient.EnterData(client);
        }
        public void setManager(string manager)
        {
            txtProjectManager.EnterData(manager);
        }
    }
}
