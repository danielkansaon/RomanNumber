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
            int numeroEsperado = 20;
            string numeroRomano = "XX";
            int res = App.Romano.ToDecimal("XX");
            Assert.AreEqual(numeroEsperado, res);
        }
    }
}
