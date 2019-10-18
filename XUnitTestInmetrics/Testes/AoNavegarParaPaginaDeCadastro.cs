using Inmetrics.HomologacaoGlobo.Selenium.Fixtures;
using Inmetrics.HomologacaoGlobo.Selenium.PageObjects;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using Xunit;

namespace Inmetrics.HomologacaoGlobo.Selenium.Testes
{
    [Collection("Chrome Driver")]
    public class AoNavegarParaPaginaDeCadastro
    {


        private IWebDriver driver;

        //Setup
        public AoNavegarParaPaginaDeCadastro(TestFixture fixture)
        {
            driver = fixture.Driver;
        }

        [Fact]
        public void DadoChromeAbertoQuandoAcessarPaginaCadastroDeveExibirInfoDeCadastro()
        {
            //arrange
            var CadastroPO = new CadastroPO(driver);

            //act
            CadastroPO.Visitar();

            //assert
            Assert.Contains("SEUS DADOS", driver.PageSource);
            Assert.Contains("Cadastro - Globo Imprensa", driver.Title);
        }

        [Fact]
        public void DadoPaginaCadastroEInfoValidasDeveRealizarCadastro()
        {
            //arrange
            var CadastroPO = new CadastroPO(driver);
            CadastroPO.Visitar();
            CadastroPO.PreencheFormulario("Pedro"
                , "Segundo"
                , "Imperador"
                , "Masculino"
                , "D.pedro8@exemplo.com"
                , "Produtor"
                , "Política"
                , "Carro"
                , "Brasil"
                , "Rio de Janeiro"
                , "Rio de Janeiro"
                , "21"
                , "32582345"
                , "2356"
                , "21"
                , "988755849"
                , ""
                , ""
                , "##Dom123456"
                , "##Dom123456"
                );
            driver.FindElement(By.Id("id_termos")).Click();
            driver.FindElement(By.Id("id_deseja_receber_releases")).Click();


            //act
            CadastroPO.EfetuaCadastro();


            //assert
            Assert.Contains("Home - Globo Imprensa", driver.Title);
            Assert.True(true, "Seu cadastro foi realizado.Aguarde a revisão e aprovação da sua conta.");
        }

      
        [Fact]
        public void DadoPaginaCadastroECampoNomeVazioDeveExibirMensagemErro()
        {
            //arrange
            var CadastroPO = new CadastroPO(driver);
            CadastroPO.Visitar();
            
            //act
            CadastroPO.EfetuaCadastro();

            //assert            
            var campo = driver.FindElement(By.Id("id_first_name"));
            Assert.Contains("Preencha este campo.",campo.GetAttribute("validationMessage"));
        }

        [Fact]
        public void DadoPaginaCadastroEEmailIncompletoDeveExibirMensagemErro()
        {
            //arrange
            var CadastroPO = new CadastroPO(driver);
            CadastroPO.Visitar();

            //act
            driver.FindElement(By.Id("id_username")).SendKeys("Tester");
            driver.FindElement(By.Id("id_username")).SendKeys(Keys.Tab);


            //assert 
            
            var campo = driver.FindElement(By.Id("id_username"));
            Assert.Contains("Inclua um  @  no endereço de e-mail.  Tester  está com um  @  faltando.", campo.GetProperty("validationMessage").Replace('"',' '));
        }

        [Fact]
        public void DadoEmailIncompletoDeveExibirMensagemErro()
        {
            //arrange
            var CadastroPO = new CadastroPO(driver);
            CadastroPO.Visitar();

            //act
            driver.FindElement(By.Id("id_username")).SendKeys("Tester@");
            driver.FindElement(By.Id("id_username")).SendKeys(Keys.Tab);


            //assert 

            var campo = driver.FindElement(By.Id("id_username"));
            Assert.Equal("Insira uma parte depois de  @ .  Tester@  está incompleto.", campo.GetProperty("validationMessage").Replace('"', ' '));
        }

        [Fact]
        public void DadoPaginaCadastroESenhaSemLetraMauisculaDeveExibirMensagemErro()
        {
            //arrange
            var CadastroPO = new CadastroPO(driver);
            CadastroPO.Visitar();
            CadastroPO.PreencheFormulario("fabio"
                                        , "Junior"
                                        , "Fabio"
                                        , "Masculino"
                                        , "FabioJJ@exemplo.com"
                                        , "Produtor"
                                        , "Humor"
                                        , "Carro"
                                        , "Brasil"
                                        , "Rio de Janeiro"
                                        , "Rio de Janeiro"
                                        , "21"
                                        , "32582345"
                                        , "2356"
                                        , "21"
                                        , "988755849"
                                        , ""
                                        , ""
                                        , "zcx"
                                        , "zcx"
                                        );
            driver.FindElement(By.Id("id_termos")).Click();

            //act
            CadastroPO.EfetuaCadastro();

            //assert 
            var campo = driver.FindElement(By.TagName("li"));
            Assert.Contains($"Esta senha é muito curta. " +
                $"Ela precisa conter pelo menos 10 caracteres.", campo.GetProperty("textContent"));
        }

    }
}
