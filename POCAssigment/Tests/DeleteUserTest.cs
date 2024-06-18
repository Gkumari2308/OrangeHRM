using POCAssigment.PageObjects;
using POCAssigment.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCAssigment.Tests
{
    public class DeleteUserTest : Base
    {
        [Test]
        public void DeleteUser() 
        {
            LoginPage lp = new LoginPage(getDriver());
            lp.validLogin("Admin", "admin123");
            DeleteUser dl = new DeleteUser(getDriver());
            dl.UserDelete("FMLName");
        }
    }
}
