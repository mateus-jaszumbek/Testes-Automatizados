using Microsoft.Azure.Amqp.Framing;
using OpenQA.Selenium;
using NUnit.Framework;

namespace TestProject3
{
    internal class BuscaCep : Begin
    {
        [Test]
        public void Teste()
        {
            driver.FindElement(By.Id("endereco")).SendKeys("83030760");
            driver.FindElement(By.Id("btn_pesquisar")).Click();
            Assert.That(driver.FindElement(By.XPath("//*[@id=\'resultado-DNEC\']/tbody/tr/td[1]")).Text, Does.Contain("Rua Padre Carlos Dworaczek"));
        }
    }
}
