using PrograWeb;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PruebaTriangulo
{
    [TestClass]
    public class PruebaTriangulo1
    {
        [TestMethod]
        public void NoTriangulo()
        {
            double La1 = 10;
            double La2 = 5;
            double La3 = 4;
            bool resultadoEsperado = false;
            bool resultadoReal = false;

            var operacion = new PrograWeb.Lunes.PracticaExamen.Logica.Especificacion.Triangulo();
            resultadoReal = operacion.calculaTriangulo(La1, La2, La3);
            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }
    }
}