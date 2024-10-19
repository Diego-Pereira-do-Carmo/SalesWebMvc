using OpenQA.Selenium;
using SalesWebMvc.Test.Helper;

namespace SalesWebMvc.Test.PageObjects
{
    public class DepartmentPageObject
    {
        private IWebDriver Driver;
        private By ByName;
        private By BybtnSaveDepartment;
        private By ByNameError;

        public DepartmentPageObject(IWebDriver driver)
        {
            Driver = driver;
            ByName = By.Id("Name");
            BybtnSaveDepartment = By.Id("btnSaveDepartment");
            ByNameError = By.Id("Name-error");
        }

        public void NavigateToPageCreateDepartments()
        {
            Driver.Navigate().GoToUrl(TestHelper.BaseUrl + "Departments/Create");
        }

        public void SetDepartmentName(string name)
        {
            Driver.FindElement(ByName).SendKeys(name);
        }

        public void ClickBtnCreateDepartment()
        {
            Driver.FindElement(BybtnSaveDepartment).Click();
        }

        public string GetTextNameError()
        {
           return Driver.FindElement(ByNameError).Text;
        }
    }
}
