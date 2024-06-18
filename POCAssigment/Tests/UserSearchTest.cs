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
    public class UserSearchTest :Base
    {
        [Test]
        public void UserSearch()
        {
            LoginPage lp = new LoginPage(getDriver());
            lp.validLogin("Admin", "admin123");

            UserManagement um = new UserManagement(getDriver());
            um.userNameSearch("Admin");


        }
         
    }
}
