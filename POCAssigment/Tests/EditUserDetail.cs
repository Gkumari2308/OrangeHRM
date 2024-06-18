using OpenQA.Selenium;
using POCAssigment.PageObjects;
using POCAssigment.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCAssigment.Tests
{
    public  class EditUserDetail :Base
    {
        [Test]
        public void EditUser()
        {
            LoginPage lp = new LoginPage(getDriver());
            lp.validLogin("Admin", "admin123");
            HomePage hm = new HomePage(getDriver());
            hm.getAdminTab().Click();
            //hm.getAddButton().Click();
            //hm.SelectUserRole("Admin");
            //hm.employeenamefield("Ravi");
            //Thread.Sleep(5000);
            //hm.selectFirstSuggestion();
            //hm.Statusdropdown("Enabled");
            //hm.userPassSave("geeta@123", "Bhapgcolive@123", "Bhapgcolive@123");
            UserManagement um = new UserManagement(getDriver());
            um.userNameSearch("annnhdh");
            um.getEdituser().Click();
            um.getStatusdropdown().Click();
            //driver.FindElement(By.XPath("//div[text()='Disabled']")).Click();
           
           
            //um.getDisabled().Click();
            //um.Statusdropdown("Disabled");






        }
    }
}
