using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograWeb.Lunes.PracticaExamen.Logica.Accion
{
    public class clsCuadrado
    {
        Logica.Validacion.clsValidacion valida = new Logica.Validacion.clsValidacion();

        private double lado;

        public double _lado
        {
            get { return lado; }
            set { lado = value; }
        }

        private double Area;

        public double _Area
        {
            get { return Area; }
            set { Area = value; }
        }
        private double Perimetro;

        public double _Perimetro
        {
            get { return Perimetro; }
            set { Perimetro = value; }
        }

        public bool Calcular(double la)
        {
            if (valida.ValidaLado(la))
            {
                _Area = la * la;
                _Perimetro = la * 4;
                return true;
            }
            else
                return false;
        }

    }
}