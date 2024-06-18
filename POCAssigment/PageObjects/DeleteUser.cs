using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCAssigment.PageObjects
{
    public class DeleteUser
    {
        private IWebDriver driver;
        public DeleteUser(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "(//span[@class='oxd-text oxd-text--span oxd-main-menu-item--name'])[1]")]
        private IWebElement admintab;
        [FindsBy(How = How.XPath, Using = "(//input[@class='oxd-input oxd-input--active'])[2]")]
        private IWebElement userSearch;
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement searchButton;
        [FindsBy(How = How.XPath, Using = "(//span[@class='oxd-checkbox-input oxd-checkbox-input--active --label-right oxd-checkbox-input'])[2]")]
        private IWebElement checkbox;
        [FindsBy(How = How.XPath, Using = "(//button[@type='button'])[7]")]
        private IWebElement deleteUser;
        [FindsBy(How = How.XPath, Using = "(//button[@type='button'])[10]")]
        private IWebElement confirmdeleteUser;

   
        public void UserDelete(string username)
        {
            admintab.Click();
            userSearch.SendKeys(username);
            searchButton.Click();
            checkbox.Click();
            deleteUser.Click();
            confirmdeleteUser.Click();
        }

    }
   

}
