using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrograWeb;

namespace PruebaTriangulo
{
    class PruebaUnitaria1
    {
        public void MetodoPrueba1() {
            double La1 = 9;
            double La2 = 4;
            double La3 = 5;

            var operacion = new PrograWeb.Lunes.PracticaExamen.Logica.Especificacion.Triangulo();
            operacion.calculaTriangulo(La1, La2, La3);
        }
    }
}
