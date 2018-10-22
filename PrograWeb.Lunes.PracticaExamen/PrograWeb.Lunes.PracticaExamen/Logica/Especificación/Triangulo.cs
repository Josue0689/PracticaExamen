using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograWeb.Lunes.PracticaExamen.Logica.Especificación
{
    public class Triangulo
    {
        public bool calculaTriangulo(double LadoA, double LadoB, double LadoC) {
            var accion = new Logica.Accion.clsTriangulo();
            if (accion.Calcular(LadoA, LadoB, LadoC))
            {
                return true;
            }
            else
            {
                return false;
            }   
        }
    }
}