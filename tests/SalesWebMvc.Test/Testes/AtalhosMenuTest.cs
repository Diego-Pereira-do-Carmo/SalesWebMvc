using OpenQA.Selenium;
using SalesWebMvc.Test.Fixtures;
using SalesWebMvc.Test.PageObjects;
using System.Linq.Expressions;

namespace SalesWebMvc.Test.Testes
{
    [Collection("Chrome Driver")]
    public class AtalhosMenuTest
    {
        private IWebDriver Driver;
        private AtalhosMenuPageObject AtalhosMenuPageObject;

        public AtalhosMenuTest(TestFixture fixture)
        {
            Driver = fixture.Driver;
            AtalhosMenuPageObject = new AtalhosMenuPageObject(Driver);
        }

        [Theory]
        [InlineData("Departments/Create", "Department")]
        [InlineData("Sellers/Create", "Sellers")]
        [InlineData("SalesRecords", "SalesRecords")]
        public void TestesAtalhosMenu(string expectedResult, string menuItemType)
        {
            AtalhosMenuPageObject.NavigateToPageHome();

            IWebElement menuItem = menuItemType switch
            {
                "Department" => AtalhosMenuPageObject.GetAtalhoDepartment(),
                "Sellers" => AtalhosMenuPageObject.GetAtalhoSellers(),
                "SalesRecords" => AtalhosMenuPageObject.GetAtalhoSalesRecords(),
                _ => throw new ArgumentException("Item do menu inválido", nameof(menuItemType))
            };

            AtalhosMenuPageObject.DropDownTest(menuItem);
            Assert.True(Driver.Url.Contains(expectedResult));
        }
    }
}
