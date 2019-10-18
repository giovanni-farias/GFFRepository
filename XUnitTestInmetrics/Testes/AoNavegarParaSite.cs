using Inmetrics.HomologacaoGlobo.Selenium.Fixtures;
using Inmetrics.HomologacaoGlobo.Selenium.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using Xunit;


namespace Inmetrics.HomologacaoGlobo.Selenium.Testes
{ 

    [Collection("Chrome Driver")]
    public class AoNavegarParaSite 
    {
        private IWebDriver driver;

        //Setup
        public AoNavegarParaSite(TestFixture fixture)
        {
            driver = fixture.Driver;
        }


        [Fact]
        public void DadoChromeAbertoQuandorAcessarDeveExibirGloboNoTitulo()
        {
            //arrange - dado acesso ao navegador


            //act
            driver.Navigate().GoToUrl("https://homologacao.imprensa.globo.com/");

            //assert
            Assert.Contains("Globo", driver.Title);
        }

        
    }
}
