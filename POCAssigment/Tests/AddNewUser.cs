using POCAssigment.PageObjects;
using POCAssigment.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCAssigment.Tests
{
    public class AddNewUser : Base
    {
       
        [Test]
        public void admin()
        {
           LoginPage lp=new LoginPage(getDriver());
            lp.validLogin("Admin", "admin123");
            HomePage hm= new HomePage(getDriver());
            bool dashboard =hm.dashbord.Displayed;
            TestContext.WriteLine("Dashboard " + dashboard);
            Assert.That(dashboard, Is.True, "Dashboard");
            hm.getAdminTab().Click();
            hm.getAddButton().Click();
            hm.SelectUserRole("Admin");
            hm.employeenamefield("Ab");
            Thread.Sleep(5000);
            hm.selectFirstSuggestion();
            hm.Statusdropdown("Enabled");
            hm.userPassSave("geeta@123", "Bhapgcolive@123", "Bhapgcolive@123");
            bool uservalidate = hm.validateUser.Displayed;
            TestContext.WriteLine("geeta@123 " + uservalidate);
            Assert.AreEqual(true, uservalidate);

        }
    }
}
