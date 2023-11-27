using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace PageObject
{
    public class DriverFactory
    {
        private static ThreadLocal<IWebDriver> threadLocalDriver = new ThreadLocal<IWebDriver>();
        private static ThreadLocal<Waiters> threadLocalWait = new ThreadLocal<Waiters>();
        private static ThreadLocal<Action> threadLocalAction = new ThreadLocal<Action>();
        private static ThreadLocal<Assertions> threadLocalAssertions = new ThreadLocal<Assertions>();
        private static ThreadLocal<Elements> threadLocalElements = new ThreadLocal<Elements>();

        private static IWebDriver SetUpDriver()
        {
            try
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--headless");

                IWebDriver driver = new ChromeDriver(options);
                driver.Manage().Window.Maximize();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                return driver;
            }
            catch (Exception ex)
            {
                throw new Exception("Помилка при ініціалізації драйвера", ex);
            }
        }

        public static IWebDriver StartChromeDriver()
        {
            if (!threadLocalDriver.IsValueCreated)
            {
                threadLocalDriver.Value = SetUpDriver();
                threadLocalWait.Value = new Waiters(threadLocalDriver.Value);
                threadLocalAction.Value = new Action(threadLocalDriver.Value);
                threadLocalAssertions.Value = new Assertions(threadLocalDriver.Value);
                threadLocalElements.Value = new Elements(threadLocalDriver.Value);
            }
            return threadLocalDriver.Value;
        }

        public static void QuitDriver()
        {
            if (threadLocalDriver.IsValueCreated)
            {
                threadLocalDriver.Value.Quit();
                threadLocalDriver.Dispose();
            }
        }

        public static Waiters GetWaiters()
        {
            return threadLocalWait.Value;
        }

        public static Action GetAction()
        {
            return threadLocalAction.Value;
        }

        public static Assertions GetAssertions()
        {
            return threadLocalAssertions.Value;
        }

        public static Elements GetElements()
        {
            return threadLocalElements.Value;
        }
    }
}