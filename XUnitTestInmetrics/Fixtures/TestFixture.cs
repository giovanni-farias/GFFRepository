using Inmetrics.HomologacaoGlobo.Selenium.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Inmetrics.HomologacaoGlobo.Selenium.Fixtures
{
    public class TestFixture : IDisposable
    {
        public IWebDriver Driver { get; private set; }

        //Setup
        public TestFixture()
        {
            Driver = new ChromeDriver(TestHelper.PastadoExecutavel);
        }

        //TearDown
        public void Dispose()
        {
            Driver.Quit();
        }

        
    }
}
