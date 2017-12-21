using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AutomationWS.PageObjects;
using System.Threading;
using NUnit.Framework;
using AutomationWS.PageObjects.Employee;
using AutomationWS.PageObjects.Client;

namespace AutomationWS
{
    [TestClass]
    public class BillingCycle
    {
        [TestMethod]
        [Test]
        public void BillingCycleTest()
        {
            propertiesCollection.driver = new ChromeDriver();
            propertiesCollection.driver.Navigate().GoToUrl(propertiesCollection.url);
            propertiesCollection.driver.Manage().Window.Maximize();

            //Log Into Websuite
            Page.login.ClkLogIn();

            //create Employee
            Page.home.goTo(Page.home.btnlist, Page.home.lnkEmployee);
            Page.empList.CreateNewEmployee();
            Page.AddEmp.GoToGeneralTabEmployee();
            Page.empGen.SetIDandName();
            string EmployeeCreated = Page.empGen.txtEmployeeID.GetAttribute("value");
            Page.AddEmp.GoToRateTabEmployee();
            Page.empRates.SetEmpRates();
            Page.AddEmp.SaveEmployee(); 

            //create Client
            Page.home.goTo(Page.home.btnlist, Page.home.lnkClient);
            Page.ClientList.CreateNewClient();
            Page.AddClient.GoToGeneralTabClient();
            Page.clientGen.setID();
            string clientCreated = Page.clientGen.txtClientID.GetAttribute("value");
            Page.clientGen.setManager();//EmployeeCreated);
            Page.AddClient.SaveClient();

            //propertiesCollection.driver.Close();

            //create Project
            Page.home.goTo(Page.home.btnlist, Page.home.lnkProject);
            Page.ProjectList.CreateNewProject();
            Page.AddProject.GoToGeneralTabClient();
            Page.ProjectGen.setIDandName();
            String projectCreated = Page.ProjectGen.txtProjectCode.GetAttribute("value");
            Page.ProjectGen.setClient(clientCreated);
            Page.AddProject.SaveProject();

            //create Time entry
            Page.home.goTo(Page.home.btntime, Page.home.lnkTime);
            Page.TimeEntries.setRequiredFields(EmployeeCreated, projectCreated+":", "10");
            Page.TimeEntries.makeBillable();           
            Page.TimeEntries.ApproveEntry();
            Page.TimeEntries.SaveEntry();
            //create unapproved entry
            Page.TimeEntries.setHours("1");
            Page.TimeEntries.makeBillable();
            Page.TimeEntries.SaveEntry();

            //create Expense Entry
            Page.home.goTo(Page.home.btnExpense,Page.home.lnkExpense);
            Page.ExpenseEntriesList.AddNewExpense();
            Page.ExpenseEntry.setRequiredFields(EmployeeCreated,projectCreated+":", "2","10.00");
            Page.ExpenseEntry.More();
            Page.ExpenseEntry.ApproveEntry();
            Page.ExpenseEntry.SaveEntry();

            //create invoice
            Page.home.goTo(Page.home.btnbilling,Page.home.lnkBillingReview);
            Page.createInvoices.createInvoice(projectCreated+":");

            //view created invoice
            Page.home.goTo(Page.home.btnbilling,Page.home.lnkInvoiceReview);
            Page.invoiceReview.viewInvoices(projectCreated+":");

            //TearDown
            //propertiesCollection.driver.Close();

        }
    }
}
