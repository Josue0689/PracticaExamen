using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebaTriangulo
{
    /// <summary>
    /// Descripción resumida de PruebaRectangulo3
    /// </summary>
    [TestClass]
    public class PruebaRectangulo3
    {
        [TestMethod]
        public void NoRec_Altura()
        {
            double ba = 5;
            double al = -1;
            bool resultadoEsperado = false;
            bool resultadoReal = false;

            var operacion = new PrograWeb.Lunes.PracticaExamen.Logica.Especificacion.Rectangulo();
            resultadoReal = operacion.calcularRectangulo(ba, al);
            Assert.AreEqual(resultadoEsperado, resultadoReal);
        }
    }
}
