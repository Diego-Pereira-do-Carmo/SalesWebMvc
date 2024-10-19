using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SalesWebMvc.Test.Fixtures
{
    public class TestFixture : IDisposable
    {
        public IWebDriver Driver { get; private set; }

        public TestFixture()
        {
            Driver = new ChromeDriver();
        }

        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
