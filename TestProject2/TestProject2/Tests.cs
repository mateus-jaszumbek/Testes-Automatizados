using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System.Net;
using OpenQA.Selenium.Edge;

namespace TestProject2
{
    public class Tests
    {
        public IWebDriver driver;

        [SetUp]
        public void InicioTeste()
        {
        }

        [Test]
        public void Teste()
        {
            driver = new EdgeDriver();
            driver.Navigate().GoToUrl("http://www.buscacep.correios.com.br");
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void FimTeste()
        {

        }
    }
}