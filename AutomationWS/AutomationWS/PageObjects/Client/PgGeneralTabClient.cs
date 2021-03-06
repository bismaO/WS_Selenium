﻿using AutomationWS.PageObjects.Client;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationWS.PageObjects.Client
{
   public class PgGeneralTabClient
    {
        [FindsBy (How=How.Id, Using = "txtCliID")]
        public IWebElement txtClientID { get; set; }
        [FindsBy(How = How.Id, Using = "txtcClientManager")]
        public IWebElement txtClientManager { get; set; }


        [FindsBy(How = How.Id, Using = "imgListCli")]
        public IWebElement ddIcon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='divFullList']/div/table/tbody/tr[2]/td[2]")]
        public IWebElement row { get; set; }
        

        public void setID()
        {
            txtClientID.EnterData(setMethods.randomDataGeneration(4));
        }
        public void setManager()//string manager)
        {
            ddIcon.Click();
            row.waitAndClick();            
            propertiesCollection.driver.SwitchTo().Alert().Accept();
        }


    }
}
