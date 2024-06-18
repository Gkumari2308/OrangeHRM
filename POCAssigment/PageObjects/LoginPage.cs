using OpenQA.Selenium;
using POCAssigment.Utilities;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCAssigment.PageObjects
{
    public class LoginPage 
    {   private IWebDriver driver;
        public LoginPage(IWebDriver driver) 
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//input[@name='username']")]
        private IWebElement username;

        [FindsBy(How = How.CssSelector, Using = "input[name='password']")]
        private IWebElement password;

        [FindsBy(How = How.XPath, Using = "//button[@class='oxd-button oxd-button--medium oxd-button--main orangehrm-login-button']")]
        private IWebElement loginbutton;

        public void validLogin(String user, string pass)
        {
            username.SendKeys(user);
            password.SendKeys(pass);
            loginbutton.Click();
        }

        public IWebElement getUserName()
        {
            return username;
        }
    }
}
