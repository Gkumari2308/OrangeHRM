using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace POCAssigment.PageObjects
{
    public class HomePage
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//h6[@class='oxd-text oxd-text--h6 oxd-topbar-header-breadcrumb-module']")]
        public IWebElement dashbord;
        [FindsBy(How = How.XPath, Using = "(//span[@class='oxd-text oxd-text--span oxd-main-menu-item--name'])[1]")]
        private IWebElement admintab;
        [FindsBy(How = How.XPath, Using = "//button[@class='oxd-button oxd-button--medium oxd-button--secondary']")]
        private IWebElement addbutton;
        [FindsBy(How = How.XPath, Using = "(//div[@class='oxd-select-text oxd-select-text--active'])[1]")]
        private IWebElement selectdropdown;
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Type for hints...']")]
        private IWebElement employeedropdown;
        [FindsBy(How = How.XPath, Using = "//div[@role='option']")]
        private IList<IWebElement> suggestions;
        [FindsBy(How = How.XPath, Using = "(//div[@class='oxd-select-text-input'])[2]")]
        private IList<IWebElement> suggestionsdropdown;
        [FindsBy(How = How.XPath, Using = "(//div[@class='oxd-select-text-input'])[2]")]
        private IWebElement Status;
        [FindsBy(How = How.XPath, Using = "(//input[@class='oxd-input oxd-input--active'])[2]")]
        private IWebElement UsernameTab;
        [FindsBy(How = How.XPath, Using = "(//input[@type='password'])[1]")]
        private IWebElement passwordTab;
        [FindsBy(How = How.XPath, Using = "(//input[@type='password'])[2]")]
        private IWebElement confirmpasswordTab;
        [FindsBy(How = How.XPath, Using = "//button[@type='submit']")]
        private IWebElement savebutton;
        [FindsBy(How = How.XPath, Using = "//div[text()='geeta@123']")]
        public IWebElement validateUser;






        public IWebElement getAdminTab()
        {
            return admintab;
        }
        public IWebElement getAddButton()
        {
            return addbutton;
        }
        public IWebElement getDropdown()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(selectdropdown));
            return selectdropdown;
        }

        public IWebElement getEmployeedropdown()
        {
            return employeedropdown;
        }
        public IWebElement getStatus()
        {
            wait.Until(ExpectedConditions.ElementToBeClickable(Status));
            return Status;
        }
        public IWebElement getSavebutton()
        {
            return savebutton;
        }
       
       // public IWebElement getUserNameTab()
       // {
            //return UsernameTab;
       // }



        public void SelectUserRole(string role)
        {
            selectdropdown.Click();
            wait.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.XPath("//div[@role='listbox']")));
            IList<IWebElement> items = driver.FindElements(By.XPath("//div[@role='listbox']"));
            foreach (IWebElement item in items)
            {
                if (item.Text.Contains(role))
                {
                    item.Click();
                    //selectdropdown.SendKeys(Keys.Escape);
                    break; 

                }

            }
        }

        public void employeenamefield(string name)
        {

            employeedropdown.SendKeys(name);
        }

        public void selectFirstSuggestion()
        {
            suggestions.First().Click();
        }
        public void Statusdropdown(string option)
        {
            Status.Click();

            IList<IWebElement> lists = driver.FindElements(By.XPath("//div[@role='listbox']"));
            foreach (IWebElement list in lists)
            {
                if (list.Text.Contains(option))
                {
                    list.Click();
                   // Status.SendKeys(Keys.Escape);
                    break;
                }
            }


        }

        public void userPassSave(String un, string pt, string cpt)
        {
            UsernameTab.SendKeys(un);
            passwordTab.SendKeys(pt);
            confirmpasswordTab.SendKeys(cpt);
            savebutton.Click();
        }
    }

}