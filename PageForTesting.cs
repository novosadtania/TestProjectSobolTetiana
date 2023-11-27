using OpenQA.Selenium;

namespace PageObject
{
    public class PageForTesting : BasePage
    {
        public PageForTesting(IWebDriver driver) : base(driver) { }
        private static class Locators
        {
            public static readonly By ButtonByLogin = By.Id("lbKeyEnter");
            public static readonly By InputLineLogin = By.Name("UserName");
            public static readonly By InputLinePassword = By.Name("Password");
            public static readonly By ButtonLogin = By.Name("LoginButton");
            public static readonly By LineTermInternalTransfer = By.Id("ctl00___ACC___ACC_49");
            public static readonly By SelectIBANPayer = By.Id("ctl00_MainContentPlaceHolder_listPayerAccount");
            public static readonly By InputLineSumm = By.Id("ctl00_MainContentPlaceHolder_textSum_text");
            public static readonly By InputLineIBANRecipient = By.Name("ctl00$MainContentPlaceHolder$textRecAccount");
            public static readonly By InputLineFullNameRecipient = By.Name("ctl00$MainContentPlaceHolder$textRecName");
            public static readonly By InputLineCodOfRecipient = By.Name("ctl00$MainContentPlaceHolder$textRecIdCode");
            public static readonly By InputLinePurposeOfPayment = By.Name("ctl00$MainContentPlaceHolder$textPaymentDetails$textDetails");
            public static readonly By CheckBoxAgreeCommission = By.Id("ctl00_MainContentPlaceHolder_ckAgree");
            public static readonly By ButtonSave = By.Name("ctl00$MainContentPlaceHolder$btPay");
            public static readonly By TextMainPage = By.Id("ctl00_lblTitle");
            public static readonly By TextEstimatedBalance = By.Id("ctl00_MainContentPlaceHolder_lbForecastErrorMessage");
            public static readonly By TextCreateDocumentBasedOn = By.Id("ctl00_MainContentPlaceHolder_createHeader_pnlAction0");
            public static readonly By TextCardOfDocument = By.Id("ctl00_lblTitle");
            public static readonly By TextInCardOfDocumentIBANPayer = By.XPath("//tr[@style= 'height:19px;'][5]/td[@class='wrs9']");
            public static readonly By TextInCardOfDocumentIBANRecipient = By.XPath("//tr[@style= 'height:19px;'][7]/td[@class='wrs9']");
            public static readonly By TextInCardOfDocumentFullNameRecipient = By.XPath("//tr[@style= 'height:28px;'][4]/td[@class='wrs5']");
            public static readonly By TextInCardOfDocumentSumm = By.XPath("//tr[@style= 'height:19px;'][8]/td[@class='wrs11']");
            public static readonly By TextInCardOfDocumentPurposeOfPayment = By.XPath("//tr[@style= 'height:66px;']/td[@class='wrs5']");
            public static readonly By SelectedIBANPayer = By.XPath("//select[@id='ctl00_MainContentPlaceHolder_listPayerAccount']/option[@value='269134']");

        }
        private class Labels
        {
            public const string BaseUrl = "http://obcorp2tw.unity-bars.com/ibank/";
            public const string TextLogin = "MESHKANETSEL1";
            public const string TextPassword = "testtest";
            public const string TextSumm = "\b1000";
            public const string TextIBANRecipient = "UA263004650000026009300813715";
            public const string TextFullNameRecipient = "Тестовий Одержувач Платежу";
            public const string TextCodOfRecipient = "23354545";
            public const string TextMainPage = "Головна сторінка";
            public const string ValueForChoiseSelect = "269134";
            public const string ExpectedTextInCardOfDocumentSumm = "Одна тисяча грн. 00 коп.";
            public const string TestNameAndResult = "Автотест на створення платежу. Результат автотесту : Успішний. Дата та час проходження тесту : ";
        }
        
        public void OpenHomePage()
        {
            driver.Navigate().GoToUrl(Labels.BaseUrl);
        }
        public void ClickButtonByLoggin()
        {
            elements.ClickOnElementAfterWaitForClickable(Locators.ButtonByLogin);
        }
        public void WriteLogin()
        {
            elements.SendKeysToElement(Locators.InputLineLogin, Labels.TextLogin);
        }
        public void WritePassword()
        {
            elements.SendKeysToElement(Locators.InputLinePassword, Labels.TextPassword);
        }
        public void ClickButtonLogin()
        {
            elements.ClickOnElement(Locators.ButtonLogin);
        }
        public void ClickLineTermInternalTransfer()
        {
            elements.ClickOnElementAfterWaitForClickable(Locators.LineTermInternalTransfer);
        }
        public void ChoiseSelectIBAN()
        {
            elements.ChoiseSelectByValue(Locators.SelectIBANPayer, Labels.ValueForChoiseSelect);
        }
        public void WriteTextSumm()
        {
            elements.SendKeysToElement(Locators.InputLineSumm, Labels.TextSumm);

        }
        public void WriteTextIBANRecipient()
        {
            elements.SendKeysToElement(Locators.InputLineIBANRecipient, Labels.TextIBANRecipient);
        }
        public void WriteTextFullNameRecipient()
        {
            elements.SendKeysToElement(Locators.InputLineFullNameRecipient, Labels.TextFullNameRecipient);
        }
        public void WriteTextCodOfRecipient()
        {
            elements.SendKeysToElement(Locators.InputLineCodOfRecipient, Labels.TextCodOfRecipient);
        }
        DateTime dateTime = DateTime.Now;
        public void WriteTextPurposeOfPayment()
        {
            elements.SendKeysToElement(Locators.InputLinePurposeOfPayment, Labels.TestNameAndResult + dateTime);
        }
        public void ClickCheckBoxAgreeCommission()
        {
            elements.ClickOnElementAfterWaitForClickable(Locators.CheckBoxAgreeCommission);
        }
        public void ClickButtonSave()
        {
            elements.ClickOnElementAfterWaitForClickable(Locators.ButtonSave);
        }
        public By TextEstimatedBalanceIsDisplay()
        {

            return (Locators.TextEstimatedBalance);
        }
        public By InputLineLoginIsDisplay()
        {

            return (Locators.InputLineLogin);
        }
        public By InputLinePasswordIsDisplay()
        {

            return (Locators.InputLinePassword);
        }
        public By TextMainPageIsDisplay()
        {

            return (Locators.TextMainPage);
        }
        public By TextCreateDocumentBasedOnIsDisplay()
        {

            return (Locators.TextCreateDocumentBasedOn);
        }
        public By TextCardOfDocumentIsDisplay()
        {

            return (Locators.TextCardOfDocument);
        }
        public String TextInCardOfDocumentIBANPayerString()
        {

            return elements.GetTextOnElementWithWaiters(Locators.TextInCardOfDocumentIBANPayer);
        }
        public String TextInCardOfDocumentIBANRecipientString()
        {

            return elements.GetTextOnElementWithWaiters(Locators.TextInCardOfDocumentIBANRecipient);
        }
        public String TextInCardOfDocumentFullNameRecipientString()
        {

            return elements.GetTextOnElementWithWaiters(Locators.TextInCardOfDocumentFullNameRecipient);
        }
        public String TextInCardOfDocumentSummString()
        {

            return elements.GetTextOnElementWithWaiters(Locators.TextInCardOfDocumentSumm);
        }
        public String SelectedIBANPayerString()
        {

            return elements.GetTextOnElementWithWaiters(Locators.SelectedIBANPayer);
        }
        public String TextIBANRecipientString()
        {
            return elements.GetTextOnElementString(Labels.TextIBANRecipient);
        }
        public String TextFullNameRecipientString()
        {
            return elements.GetTextOnElementString(Labels.TextFullNameRecipient);
        }
        public String ExpectedTextInCardOfDocumentSummString()
        {
            return elements.GetTextOnElementString(Labels.ExpectedTextInCardOfDocumentSumm);
        }
    }
}


