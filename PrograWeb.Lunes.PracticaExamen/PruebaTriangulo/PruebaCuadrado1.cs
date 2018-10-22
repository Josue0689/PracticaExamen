using PrograWeb;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PruebasUnitarias
{
    [TestClass]
    public class PruebaCuadrado1
    {
        [TestMethod]
        public void NoCuadrado()
        {
            double L= -5;
            bool resultadoEsperado = false;
            bool resultadoReal = false;

            var operacion = new PrograWeb.Lunes.PracticaExamen.Logica.Especificacion.Cuadrado();
            resultadoReal = operacion.calcularCuadrado(L);
            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }
    }
}