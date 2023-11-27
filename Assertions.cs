using NUnit.Framework;
using OpenQA.Selenium;
namespace PageObject
{
    public class Assertions
    {
        private IWebDriver driver;
        private Elements elements;
        private Waiters waiters;
        private Action action;

        public Assertions(IWebDriver driver)
        {
            this.driver = driver;
            elements = new Elements(driver);
            waiters = new Waiters(driver);
            action = new Action(driver);
        }

        public void EqualsText(string expected, string actual)
        {
            try
            {
                Assert.AreEqual(expected, actual);
            }
            catch (Exception)
            {
                Console.WriteLine($"Очікувалося отримати текст: \"{expected}\", а отримано: \"{actual}\".");
                throw;
            }
        }
        public void СontaintsText(String longText , String shortText)
        {
            Assert.IsTrue(longText.Contains(shortText));
        }

        public void ElementIsDisplay(By by)
        {
            Assert.IsTrue(elements.FindElement(by).Displayed);
        }

        public void ElementIEnabled(By by)
        {
            Assert.IsTrue(elements.FindElement(by).Enabled);
        }

        public void EqualsInt(int expected, int actual)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}
