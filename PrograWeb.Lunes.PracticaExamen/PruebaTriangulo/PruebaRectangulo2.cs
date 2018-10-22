using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaTriangulo
{
    /// <summary>
    /// Descripción resumida de PruebaRectangulo2
    /// </summary>
    [TestClass]
    public class PruebaRectangulo2
    {
        [TestMethod]
        public void NoRec_Base()
        {
            double ba = -5;
            double al = 10;
            bool resultadoEsperado = false;
            bool resultadoReal = false;

            var operacion = new PrograWeb.Lunes.PracticaExamen.Logica.Especificacion.Rectangulo();
            resultadoReal = operacion.calcularRectangulo(ba, al);
            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }
    }
}
