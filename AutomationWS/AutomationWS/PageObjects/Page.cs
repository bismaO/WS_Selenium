using AutomationWS.PageObjects;
using AutomationWS.PageObjects.Billing;
using AutomationWS.PageObjects.Client;
using AutomationWS.PageObjects.Employee;
using AutomationWS.PageObjects.Expense;
using AutomationWS.PageObjects.Invoice;
using AutomationWS.PageObjects.Project;
using AutomationWS.PageObjects.Time;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationWS
{
   public class Page
    {
        //generic function to open any page
        public static T OpenPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(propertiesCollection.driver, page);
            return page;
        }

        public static PgHome home
        {
            get { return OpenPage<PgHome>(); }
        }

        public static LoginWS login
        {
            get { return OpenPage<LoginWS>(); }
        }

        public static PgEmployee empList
        {
            get { return OpenPage<PgEmployee>(); }
        }

        public static PgAddUpdateEmployee AddEmp
        {
            get { return OpenPage<PgAddUpdateEmployee>(); }
        }

        public static PgGeneralTabEmp empGen
        {
            get { return OpenPage<PgGeneralTabEmp>(); }
        }

        public static PgRatesTabEmp empRates
        {
            get { return OpenPage<PgRatesTabEmp>(); }
        }

        public static PgClient ClientList
        {
            get { return OpenPage<PgClient>(); }
        }

        public static PgAddUpdateClient AddClient
        {
            get { return OpenPage<PgAddUpdateClient>(); }
        }

        public static PgGeneralTabClient clientGen
        {
            get { return OpenPage<PgGeneralTabClient>(); }
        }

        public static PgProject ProjectList
        {
            get { return OpenPage<PgProject>(); }
        }

        public static PgAddUpdateProject AddProject
        {
            get { return OpenPage<PgAddUpdateProject>(); }
        }

        public static PgGeneralTabProject ProjectGen
        {
            get { return OpenPage<PgGeneralTabProject>(); }
        }
        public static PgTime TimeEntries
        {
            get { return OpenPage<PgTime>(); }
        }

        public static PgExpense ExpenseEntriesList
        {
            get { return OpenPage<PgExpense>(); }
        }
        public static PgAddUpdateExpense ExpenseEntry
        {
            get { return OpenPage<PgAddUpdateExpense>(); }
        }
        public static PgBillingReview createInvoices
        {
            get { return OpenPage<PgBillingReview>(); }
        }

        public static PgInvoiceReview invoiceReview
        {
            get { return OpenPage<PgInvoiceReview>(); }
        }
    }
}
