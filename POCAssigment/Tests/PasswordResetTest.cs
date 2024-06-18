using POCAssigment.PageObjects;
using POCAssigment.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCAssigment.Tests
{
    
    public class PasswordResetTest : Base
    {
        [Test]
        public void userPassReset()
        {
            LoginPage lp = new LoginPage(getDriver());
            lp.validLogin("Admin", "admin123");
            PasswordReset pr = new PasswordReset(getDriver());
            pr.passwordReset("FMLName1", "LKJname@8979123", "LKJname@8979123");
        }
    }
}
