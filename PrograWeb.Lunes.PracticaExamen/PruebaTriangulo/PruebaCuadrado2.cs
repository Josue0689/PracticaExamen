using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    /// <summary>
    /// Descripción resumida de PruebaCuadrado2
    /// </summary>
    [TestClass]
    public class PruebaCuadrado2
    {
        [TestMethod]
        public void SiCuadrado()
        {
            double L = 5;
            bool resultadoEsperado = true;
            bool resultadoReal = false;

            var operacion = new PrograWeb.Lunes.PracticaExamen.Logica.Especificacion.Cuadrado();
            resultadoReal = operacion.calcularCuadrado(L);
            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }
    }
}
