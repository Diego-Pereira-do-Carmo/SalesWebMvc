using OpenQA.Selenium;
using SalesWebMvc.Test.Fixtures;
using SalesWebMvc.Test.PageObjects;

namespace SalesWebMvc.Test.Testes
{
    [Collection("Chrome Driver")]
    public class SellerTest
    {
        private IWebDriver Driver;
        private SellerPageObject SellerPageObject;

        public SellerTest(TestFixture fixture)
        {
            Driver = fixture.Driver;
            SellerPageObject = new SellerPageObject(Driver);
        }

        [Theory]
        [InlineData("Teste Automátizado Criar Válido", "Teste.automatizadoValido@gmail.com", "25/10/1996", "3000.00", "Desenvolvimento", true, "Teste Automátizado Criar Válido")]
        [InlineData("Teste Automátizado Criar Invalido 1", "Teste.automatizadoInvalido1@gmail.com", "25/10/1996", "", "Desenvolvimento", false, "Teste Automátizado Criar Invalido 1")]
        [InlineData("Teste Automátizado Criar Invalido 2", "Teste.automatizadoInvalido2@gmail.com", "", "3000.00", "Desenvolvimento", false, "Teste Automátizado Criar Invalido 2")]
        [InlineData("Teste Automátizado Criar Invalido 3", "Teste.automatizadoInvalido3", "25/10/1996", "3000.00", "Desenvolvimento", false, "Teste Automátizado Criar Invalido 3")]
        [InlineData("", "Teste.automatizadoInvalido4@gmail.com", "25/10/1996", "3000.00", "Desenvolvimento", false, "Teste.automatizadoInvalido4@gmail.com")]
        public void CreateSeller(string nomeSeller, string emailSeller, string birthDate, string baseSalary, string DepartmentSeller, bool isValid, string expectedResult)
        {
            SellerPageObject.NavigateToPageCreateSellers();

            SellerPageObject.SetSellerName(nomeSeller);
            SellerPageObject.SetSellerEmail(emailSeller);
            SellerPageObject.SetSellerBirthDate(birthDate);
            SellerPageObject.SetSellerBaseSalary(baseSalary);
            SellerPageObject.SetSellerDepartment(DepartmentSeller);
            SellerPageObject.ClickBtnCreateSeller();

            SellerPageObject.NavigateToPageIndexSellers();

            if (isValid)
            {
                Assert.Contains(expectedResult, Driver.PageSource);
            }
            else
            {
                Assert.DoesNotContain(expectedResult, Driver.PageSource);
            }
        }
    }
}
