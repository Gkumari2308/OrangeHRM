using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;
using System.Net.NetworkInformation;

namespace POCAssigment.PageObjects
{
    public class UserManagement
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public UserManagement(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "(//span[@class='oxd-text oxd-text--span oxd-main-menu-item--name'])[1]")]
        private IWebElement admintab;
        [FindsBy(How = How.XPath, Using = "(//input[@class='oxd-input oxd-input--active'])[2]")]
        private IWebElement userSearch;
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement searchButton;
        [FindsBy(How = How.XPath, Using = "(//button[@class='oxd-icon-button oxd-table-cell-action-space'])[2]")]
        private IWebElement edituser;
        [FindsBy(How = How.XPath, Using = "(//div[@class='oxd-select-text-input'])[2]")]
        private IWebElement changestatus;
        [FindsBy(How = How.XPath,Using = "//div(@role='listbox')")]
        private IWebElement drpppp;
        [FindsBy(How = How.XPath, Using = "//div[text()='Disabled']")]
        public IWebElement disabled;

        




        public void userNameSearch(string us)
        {
            admintab.Click();
            userSearch.SendKeys(us);
            searchButton.Click();
        }
        public IWebElement getEdituser()
        {
            return edituser;
        }
        public IWebElement getStatusdropdown()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(changestatus));
            return changestatus;

        }
        //public IWebElement getselectdrppp()
        //{
        //    return drpppp;
        //}
        //public IWebElement getDisabled() 
        //{ 
        //    return disabled;
        //}   
        //public IWebElement getDisabled() 
        //{
        //    wait.Until(ExpectedConditions.ElementToBeClickable(disabled));
        //    return disabled;
        //}
        //    public void Statusdropdown(string option)
        //    {
        //        changestatus.Click();

        //        IList<IWebElement> lists = driver.FindElements(By.XPath("//div[@role='listbox']"));
        //        foreach (IWebElement list in lists)
        //        {
        //            if (list.Text.Contains(option))
        //            {
        //                list.Click();
        //                //changestatus.SendKeys(Keys.Escape);
        //                break;
        //            }
        //        }


        //    }
    }
}
