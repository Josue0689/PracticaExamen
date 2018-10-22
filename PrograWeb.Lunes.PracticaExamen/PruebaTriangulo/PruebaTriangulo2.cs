using PrograWeb;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PruebaTriangulo
{
    [TestClass]
    public class PruebaTriangulo2
    {
        [TestMethod]
        public void SiTriangulo()
        {
            double La1 = 90;
            double La2 = 45;
            double La3 = 55;
            bool resultadoEsperado = true;
            bool resultadoReal = false;

            var operacion = new PrograWeb.Lunes.PracticaExamen.Logica.Especificacion.Triangulo();
            resultadoReal = operacion.calculaTriangulo(La1, La2, La3);
            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }
    }
}
