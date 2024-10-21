using OpenQA.Selenium;
using SalesWebMvc.Test.Fixtures;
using SalesWebMvc.Test.PageObjects;

namespace SalesWebMvc.Test.Testes
{
    [Collection("Chrome Driver")]
    public class DepartmentTest
    {
        private IWebDriver Driver;
        DepartmentPageObject DepartmentPageObject;

        public DepartmentTest(TestFixture fixture)
        {
            Driver = fixture.Driver;
            DepartmentPageObject = new DepartmentPageObject(Driver);
        }

        [Theory]
        [InlineData("Teste Automátizado", true, "Teste Automátizado")]
        [InlineData("", false, "The Nome field is required.")]
        public void CreateDepartment(string departmentName, bool isValid, string expectedResult)
        {
            DepartmentPageObject.NavigateToPageCreateDepartments();

            if (!string.IsNullOrEmpty(departmentName))
            {
                DepartmentPageObject.SetDepartmentName(departmentName);
            }

            DepartmentPageObject.ClickBtnCreateDepartment();

            if(isValid)
            {
                Assert.Contains(expectedResult, Driver.PageSource);
            }
            else
            {
                Assert.Equal(expectedResult, DepartmentPageObject.GetTextNameError());
            } 
        }

    }
}
