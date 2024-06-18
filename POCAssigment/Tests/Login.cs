using POCAssigment.PageObjects;
using POCAssigment.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace POCAssigment
{
    public class Login : Base
    {
        [Test]
        [TestCaseSource("AddTestDataConfig")]
        public void LoginPage(string username, string password)
        {
            LoginPage lp = new LoginPage(getDriver());
            // lp.getUserName().SendKeys("Admin");
            // lp.validLogin("Admin", "admin123");
            lp.validLogin(username, password);
        }

        public static IEnumerable<TestCaseData> AddTestDataConfig()
        {
          yield return new TestCaseData("Admin", "admin123");
         // yield return new TestCaseData("admin", "admin@123");
            
        }
        
    }
}
