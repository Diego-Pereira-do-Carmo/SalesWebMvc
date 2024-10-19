using OpenQA.Selenium;
using SalesWebMvc.Test.Helper;

namespace SalesWebMvc.Test.PageObjects
{
    public class SellerPageObject
    {
        IWebDriver Driver;
        private By SellerName;
        private By SellerEmail;
        private By SellerBirthDate;
        private By SellerBaseSalary;
        private By SellerDepartment;
        private By CreatSeller;


        public SellerPageObject(IWebDriver driver)
        {
            Driver = driver;
            SellerName = By.Id("Seller_Name");
            SellerEmail = By.Id("Seller_Email");
            SellerBirthDate = By.Id("Seller_BirthDate");
            SellerBaseSalary = By.Id("Seller_BaseSalary");
            SellerDepartment = By.Id("Seller_DepartmentId");
            CreatSeller = By.Id("Creat_Seller");
        }

        public void NavigateToPageIndexSellers()
        {
            Driver.Navigate().GoToUrl(TestHelper.BaseUrl + "Sellers");
        }

        public void NavigateToPageCreateSellers()
        {
            Driver.Navigate().GoToUrl(TestHelper.BaseUrl + "Sellers/create");
        }

        public void SetSellerName(string name)
        {
            Driver.FindElement(SellerName).SendKeys(name);
        }

        public void SetSellerEmail(string email)
        {
            Driver.FindElement(SellerEmail).SendKeys(email);
        }

        public void SetSellerBirthDate(string birthDate)
        {
            Driver.FindElement(SellerBirthDate).SendKeys(birthDate);
        }

        public void SetSellerBaseSalary(string baseSalary)
        {
            Driver.FindElement(SellerBaseSalary).SendKeys(baseSalary);
        }

        public void SetSellerDepartment(string departmentName)
        {
            Driver.FindElement(SellerDepartment).SendKeys(departmentName);
        }

        public void ClickBtnCreateSeller()
        {
            Driver.FindElement(CreatSeller).Click();
        }
    }
}
