using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PFAseguramientoCS;


namespace PruebasUnitariasPFACS
{
    [TestClass]
    public class TestPFAS
    {
        [TestMethod]
        public void TestMethod1()
        {
            var cadena1 = "douglasf";
            var cadena2 = "douglas";
            int resultadoesperado = 1;

            Index calcular = new Index();

            var result = calcular.Compute(cadena1, cadena2);
            Assert.AreEqual(resultadoesperado, result);
        }
    }
}
