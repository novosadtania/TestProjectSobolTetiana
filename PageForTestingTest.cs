using NUnit.Framework;

namespace TestProjectSobolTetiana
{
    [TestFixture]
    internal class PageForTestingTestCopy : BaseTest
    {
        [Test]
     public void FirsTestTask()
        {
            pageForTesting.ClickButtonByLoggin();
            assertions.ElementIsDisplay(pageForTesting.InputLineLoginIsDisplay());
            assertions.ElementIsDisplay(pageForTesting.InputLinePasswordIsDisplay());
            pageForTesting.WriteLogin();
            pageForTesting.WritePassword();
            pageForTesting.ClickButtonLogin();
            assertions.ElementIsDisplay(pageForTesting.TextMainPageIsDisplay());
            pageForTesting.ClickLineTermInternalTransfer();
            assertions.ElementIsDisplay(pageForTesting.TextCreateDocumentBasedOnIsDisplay());
            pageForTesting.WriteTextSumm();
            pageForTesting.WriteTextFullNameRecipient();
            pageForTesting.WriteTextIBANRecipient();
            pageForTesting.WriteTextCodOfRecipient();
            pageForTesting.WriteTextPurposeOfPayment();
            pageForTesting.ClickCheckBoxAgreeCommission();
            pageForTesting.ChoiseSelectIBAN();
            assertions.ElementIsDisplay(pageForTesting.TextEstimatedBalanceIsDisplay());
            pageForTesting.ClickButtonSave();
            assertions.ElementIsDisplay(pageForTesting.TextCardOfDocumentIsDisplay());
            assertions.ÑontaintsText(pageForTesting.SelectedIBANPayerString(), pageForTesting.TextInCardOfDocumentIBANPayerString());
            assertions.EqualsText(pageForTesting.TextInCardOfDocumentIBANRecipientString(),pageForTesting.TextIBANRecipientString());
            assertions.EqualsText(pageForTesting.TextInCardOfDocumentFullNameRecipientString(), pageForTesting.TextFullNameRecipientString());
            assertions.EqualsText(pageForTesting.TextInCardOfDocumentSummString(), pageForTesting.ExpectedTextInCardOfDocumentSummString());
        }
    }
}