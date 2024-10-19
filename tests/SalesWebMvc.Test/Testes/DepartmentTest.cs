
using OpenQA.Selenium;
using SalesWebMvc.Test.Fixtures;
using SalesWebMvc.Test.Helper;

namespace SalesWebMvc.Test.Testes
{
    [Collection("Chrome Driver")]
    public class DepartmentTest
    {
        private IWebDriver driver;

        public DepartmentTest(TestFixture fixture)
        {
            driver = fixture.Driver;
        }

        [Fact]
        public void CreateDepartmentValidNameRegister()
        {
            driver.Navigate().GoToUrl(TestHelper.BaseUrl + "Departments");
            var buttonCreatDepartment = driver.FindElement(By.Id("btnCreatDepartment"));
            buttonCreatDepartment.Click();

            var inputNameDepartment = driver.FindElement(By.Id("Name"));
            var btnSaveDepartment = driver.FindElement(By.Id("btnSaveDepartment"));

            inputNameDepartment.SendKeys("Teste Automátizado");
            btnSaveDepartment.Click();

            Assert.Contains("Teste Automátizado", driver.PageSource);
        }

        [Fact]
        public void CreateDepartmentInvalidNameNotRegister()
        {
            driver.Navigate().GoToUrl(TestHelper.BaseUrl + "Departments");
            var buttonCreatDepartment = driver.FindElement(By.Id("btnCreatDepartment"));
            buttonCreatDepartment.Click();

            var btnSaveDepartment = driver.FindElement(By.Id("btnSaveDepartment"));
            btnSaveDepartment.Click();

            IWebElement spanErrorInputName = driver.FindElement(By.Id("Name-error"));

            Assert.Equal("The Nome field is required.", spanErrorInputName.Text);
        }
    }
}
