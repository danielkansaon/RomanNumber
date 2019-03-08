using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace App.Test
{
    [TestClass]
    public class RomanNumberTest
    {
        [TestMethod]
        public void RomanoParaDecimal()
        {
            // converter xx para numero decimal
            int numeroEsperado = 14;
            string numeroRomano = "XIV";
            var romano = new App.Romano();
            int res = romano.ToDecimal(numeroRomano);
            Assert.AreEqual(numeroEsperado, res);
        }

        //[TestMethod]
        //public void DecimalParaRomano()
        //{
        //    // converter xx para numero decimal
        //    int numeroDecimal  = 20;
        //    string numeroEsperado = "XX";
        //    var appDecimal = new App.AppDecimal();
        //    int res = appDecimal.ToRomano(numeroDecimal);
        //    Assert.AreEqual(numeroEsperado, res);
        //}
        [TestMethod]
        public void RomanoParaDecimal2()
        {
            // converter xx para numero decimal
            int numeroEsperado = 86;
            string numeroRomano = "LXXXVI";
            var romano = new App.Romano();
            int res = romano.ToDecimal(numeroRomano);
            Assert.AreEqual(numeroEsperado, res);
        }

        //[TestMethod]
        //public void DecimalParaRomano2()
        //{
        //    // converter xx para numero decimal
        //    int numeroDecimal = 1834;
        //    string numeroEsperado = "MDCCCXXXIV";
        //    var appDecimal = new App.AppDecimal();
        //    int res = appDecimal.ToRomano(numeroDecimal);
        //    Assert.AreEqual(numeroEsperado, res);
        //}
    }
}
