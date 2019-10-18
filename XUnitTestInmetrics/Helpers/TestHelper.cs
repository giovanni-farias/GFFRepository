using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Reflection;

namespace Inmetrics.HomologacaoGlobo.Selenium.Helpers
{
    public static class TestHelper
    {
        public static string PastadoExecutavel => Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
    }
}
