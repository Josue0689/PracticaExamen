using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograWeb.Lunes.PracticaExamen.Logica.Especificacion
{
    public class Cuadrado
    {
        public bool calcularCuadrado(double Lado)
        {
            var accion = new Logica.Accion.clsCuadrado();
            if (accion.Calcular(Lado))
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