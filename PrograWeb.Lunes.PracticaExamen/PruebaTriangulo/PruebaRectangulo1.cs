using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaTriangulo
{
    /// <summary>
    /// Descripción resumida de PruebaRectangulo1
    /// </summary>
    [TestClass]
    public class PruebaRectangulo1
    {
        [TestMethod]
        public void SiRectangulo()
        {
            double ba = 50;
            double al = 10;
            bool resultadoEsperado = true;
            bool resultadoReal = false;

            var operacion = new PrograWeb.Lunes.PracticaExamen.Logica.Especificacion.Rectangulo();
            resultadoReal = operacion.calcularRectangulo(ba, al);
            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }
    }
}
