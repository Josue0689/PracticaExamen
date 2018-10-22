using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograWeb.Lunes.PracticaExamen.Logica.Especificacion
{
    public class Rectangulo
    {
        public bool calcularRectangulo(double ba, double al)
        {
            var accion = new Logica.Accion.clsRectangulo();
            if (accion.Calcular(ba, al))
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