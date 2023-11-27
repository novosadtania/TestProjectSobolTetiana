using NUnit.Framework;
using OpenQA.Selenium;
using PageObject;
using Action = PageObject.Action;

namespace TestProjectSobolTetiana
{
    public class BaseTest
    {
        protected IWebDriver driver;
        protected Action action;
        protected Assertions assertions;
        protected Elements elements;
        protected Waiters waiters;
        protected BasePage basePage;
        protected PageForTesting pageForTesting;


        [OneTimeSetUp]
        public void SetUp()
        {
            driver = DriverFactory.StartChromeDriver();
            action = new Action(driver);
            assertions = new Assertions(driver);
            elements = new Elements(driver);
            waiters = new Waiters(driver);
            basePage = new BasePage(driver);
            pageForTesting = new PageForTesting(driver);
            pageForTesting.OpenHomePage();
        }

        [OneTimeTearDown]
        public void closeDriver()
        {
            driver.Close();
        }
    }
}
