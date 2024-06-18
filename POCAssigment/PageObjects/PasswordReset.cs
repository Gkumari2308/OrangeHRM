using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCAssigment.PageObjects
{
    public class PasswordReset
    {
        private IWebDriver driver;
        public PasswordReset(IWebDriver driver) 
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
        [FindsBy(How = How.XPath, Using = "(//button[@class='oxd-icon-button oxd-table-cell-action-space'])[2]")]
        private IWebElement editicon;
        [FindsBy(How = How.XPath, Using = "//span[@class='oxd-checkbox-input oxd-checkbox-input--active --label-right oxd-checkbox-input']")]
        private IWebElement passwordCheckbox;
        [FindsBy(How = How.XPath, Using = "(//input[@type='password'])[1]")]
        private IWebElement passwordtab;
        [FindsBy(How = How.XPath, Using = "(//input[@type='password'])[2]")]
        private IWebElement cnfpasswordtab;
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement savebutton;

        
        public void passwordReset(string passchangeuser, string newpassword, string cnfnewpassword)
        {
            admintab.Click();
            userSearch.SendKeys(passchangeuser);
            searchButton.Click();
            editicon.Click();
            passwordCheckbox.Click();
            passwordtab.SendKeys(newpassword);
            cnfpasswordtab.SendKeys(cnfnewpassword);
            savebutton.Click();
        }

    }
}
