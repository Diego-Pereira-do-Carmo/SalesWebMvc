using OpenQA.Selenium;
using SalesWebMvc.Test.Fixtures;
using SalesWebMvc.Test.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesWebMvc.Test.Testes
{
    [Collection("Chrome Driver")]
    public class SellerTest
    {
        private IWebDriver driver;

        public SellerTest(TestFixture fixture)
        {
            driver = fixture.Driver;
        }

        [Fact]
        public void CreateSellerValidDataRegister()
        {
            driver.Navigate().GoToUrl(TestHelper.BaseUrl + "Sellers/create");

            var Seller_Name = driver.FindElement(By.Id("Seller_Name"));
            var Seller_Email = driver.FindElement(By.Id("Seller_Email"));
            var Seller_BirthDate = driver.FindElement(By.Id("Seller_BirthDate"));
            var Seller_BaseSalary = driver.FindElement(By.Id("Seller_BaseSalary"));
            var Seller_DepartmentId = driver.FindElement(By.Id("Seller_DepartmentId"));
            var Creat_Seller = driver.FindElement(By.Id("Creat_Seller"));

            Seller_Name.SendKeys("Teste Automátizado Criar Válido");
            Seller_Email.SendKeys("Teste.automatizado@gmail.com");
            Seller_BirthDate.SendKeys("25/10/1996");
            Seller_BaseSalary.SendKeys("3000.00");
            Seller_DepartmentId.SendKeys("11");
            Creat_Seller.Click();

            driver.Navigate().GoToUrl(TestHelper.BaseUrl + "Sellers");

            Assert.Contains("Teste Automátizado Criar Válido", driver.PageSource);
        }

        [Theory]
        [InlineData("Teste Automátizado Criar Invalido", "Teste.automatizado@gmail.com", "25/10/1996", "", "11")]
        [InlineData("Teste Automátizado Criar Invalido", "Teste.automatizado@gmail.com", "", "3000.00", "11")]
        [InlineData("Teste Automátizado Criar Invalido", "Teste.automatizado", "25/10/1996", "3000.00", "11")]
        [InlineData("", "Teste.automatizado@gmail.com", "25/10/1996", "3000.00", "11")]
        public void CreatSellerIvalidDataNotRegister(string nomeSeller, string emailSeller, string birthDate, string baseSalary, string DepartmentSeller)
        {
            driver.Navigate().GoToUrl(TestHelper.BaseUrl + "Sellers/create");

            var seller_Name = driver.FindElement(By.Id("Seller_Name"));
            var seller_Email = driver.FindElement(By.Id("Seller_Email"));
            var seller_BirthDate = driver.FindElement(By.Id("Seller_BirthDate"));
            var seller_BaseSalary = driver.FindElement(By.Id("Seller_BaseSalary"));
            var seller_DepartmentId = driver.FindElement(By.Id("Seller_DepartmentId"));
            var creat_Seller = driver.FindElement(By.Id("Creat_Seller"));

            seller_Name.SendKeys(nomeSeller);
            seller_Email.SendKeys(emailSeller);
            seller_BirthDate.SendKeys(birthDate);
            seller_BaseSalary.SendKeys(baseSalary);
            seller_DepartmentId.SendKeys(DepartmentSeller);
            creat_Seller.Click();

            driver.Navigate().GoToUrl(TestHelper.BaseUrl + "Sellers");

            Assert.DoesNotContain("Teste Automátizado Criar Invalido", driver.PageSource);
        }
    }
}
