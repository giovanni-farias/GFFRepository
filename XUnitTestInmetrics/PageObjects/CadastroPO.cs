using System;
using OpenQA.Selenium;

namespace Inmetrics.HomologacaoGlobo.Selenium.PageObjects
{
    class CadastroPO
    {
        private IWebDriver driver;
        private By byInputCadastro;
        private By byInputNome;
        private By byInputSobrenome;
        private By byInputApelido;
        private By byInputSexo;
        private By byInputEmail;
        private By byInputCargo;
        private By byInputEditoria;
        private By byInputVeiculo;
        private By byInputPais;
        private By byInputEstado;
        private By byInputCidade;
        private By byInputTelefoneDDD;
        private By byInputTelefoneNumero;
        private By byInputTelefoneRamal;
        private By byInputCelularDDD;
        private By byInputCelularNumero;
        private By byInputTwiter;
        private By byInputInstagram;
        private By byInputSenha;
        private By byInputConfirmaSenha;
        private By byInputTermos;
        private By byInputReceberReleases;
        private By byBotaoSolicitaCadastro;

        public CadastroPO(IWebDriver driver)
        {
            this.driver             = driver;
            byInputCadastro         = By.ClassName("Container");
            byInputNome             = By.Id("id_first_name");
            byInputSobrenome        = By.Id("id_last_name");
            byInputApelido          = By.Id("id_como_gostaria_de_ser_chamado");
            byInputSexo             = By.Id("id_sexo");
            byInputEmail            = By.Id("id_username");
            byInputCargo            = By.Id("id_cargo");
            byInputEditoria         = By.Id("id_editoria");
            byInputVeiculo          = By.Id("id_veiculo"); 
            byInputPais             = By.Id("id_pais");
            byInputEstado           = By.Id("id_estado");
            byInputCidade           = By.Id("id_cidade");
            byInputTelefoneDDD      = By.Id("id_telefone_ddd");
            byInputTelefoneNumero   = By.Id("id_telefone_numero");
            byInputTelefoneRamal    = By.Id("id_telefone_ramal");
            byInputCelularDDD       = By.Id("id_celular_ddd");
            byInputCelularNumero    = By.Id("id_celular_numero");
            byInputTwiter           = By.Id("id_twitter");
            byInputInstagram        = By.Id("id_instagram");
            byInputSenha            = By.Id("id_password1");
            byInputConfirmaSenha    = By.Id("id_password2");
            byInputTermos           = By.Id("id_termos");
            byInputReceberReleases  = By.Id("id_deseja_receber_releases");
            byBotaoSolicitaCadastro = By.ClassName("btn");

        }

        public void Visitar()
        {
            driver.Navigate().GoToUrl("https://homologacao.imprensa.globo.com/cadastro/");
        }

        public void EfetuaCadastro()
        {
            driver.FindElement(byBotaoSolicitaCadastro).Click();
        }

        public void PreencheFormulario(
           string   nome            ,
           string   sobrenome       ,
           string   apelido         ,
           string   sexo            ,
           string   email           ,
           string   cargo           ,
           string   editoria        ,
           string   veiculo         ,
           string   pais            ,
           string   estado          ,
           string   cidade          ,
           string   telefoneDDD     ,
           string   telefoneNumero  ,
           string   telefoneRamal   ,
           string   celularDDD      ,
           string   celularNumero   ,
           string   twiter          ,
           string   instagram       ,
           string   senha           ,
           string   confirmaSenha    
            )
        {
            driver.FindElement(byInputNome).SendKeys(nome);
            driver.FindElement(byInputSobrenome).SendKeys(sobrenome);
            driver.FindElement(byInputApelido).SendKeys(apelido);
            driver.FindElement(byInputSexo).SendKeys(sexo);
            driver.FindElement(byInputEmail).SendKeys(email);
            driver.FindElement(byInputCargo).SendKeys(cargo);
            driver.FindElement(byInputEditoria).SendKeys(editoria);
            driver.FindElement(byInputVeiculo).SendKeys(veiculo);
            driver.FindElement(byInputPais).SendKeys(pais);
            driver.FindElement(byInputEstado).SendKeys(estado);
            driver.FindElement(byInputCidade).SendKeys(cidade);
            driver.FindElement(byInputTelefoneDDD).SendKeys(telefoneDDD);
            driver.FindElement(byInputTelefoneNumero).SendKeys(telefoneNumero);
            driver.FindElement(byInputTelefoneRamal).SendKeys(telefoneRamal);
            driver.FindElement(byInputCelularDDD).SendKeys(celularDDD);
            driver.FindElement(byInputCelularNumero).SendKeys(celularNumero );
            driver.FindElement(byInputTwiter).SendKeys(twiter);
            driver.FindElement(byInputInstagram).SendKeys(instagram);
            driver.FindElement(byInputSenha).SendKeys(senha);
            driver.FindElement(byInputConfirmaSenha).SendKeys(confirmaSenha);
        }

    }



}
