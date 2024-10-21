using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SalesWebMvc.Test.Helper;

namespace SalesWebMvc.Test.PageObjects
{
    public class AtalhosMenuPageObject
    {
        private IWebDriver Driver;
        private readonly Lazy<IWebElement> _atalhos;

        public AtalhosMenuPageObject (IWebDriver driver)
        {
            Driver = driver;
            _atalhos = new Lazy<IWebElement>(() => Driver.FindElement(By.Id("atalhos")));
        }

        public IWebElement Atalhos => _atalhos.Value;

        public IWebElement GetAtalhoDepartment() => Driver.FindElement(By.Id("atalhoDepartment"));
        public IWebElement GetAtalhoSellers() => Driver.FindElement(By.Id("atalhoSellers"));
        public IWebElement GetAtalhoSalesRecords() => Driver.FindElement(By.Id("atalhoSalesRecords"));
        public void NavigateToPageHome()
        {
            Driver.Navigate().GoToUrl(TestHelper.BaseUrl);
        }

        public void DropDownTest(IWebElement element)
        {
            IAction testingDropdown = new Actions(Driver)
                .Click(Atalhos)
                .MoveToElement(element).Click()
                .Build();

            testingDropdown.Perform();
        }
    }
}
