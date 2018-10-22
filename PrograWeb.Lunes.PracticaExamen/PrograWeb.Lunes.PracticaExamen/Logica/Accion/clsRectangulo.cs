using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograWeb.Lunes.PracticaExamen.Logica.Accion
{
    public class clsRectangulo
    {
        Logica.Validacion.clsValidacion valida = new Logica.Validacion.clsValidacion();

        private double Base;

        public double _Base
        {
            get { return Base; }
            set { Base = value; }
        }

        private double Altura;

        public double _Altura
        {
            get { return Altura; }
            set { Altura = value; }
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

        public bool Calcular(double bas, double alt)
        {
            if (valida.ValidaRect(bas, alt))
            {
                _Area = (bas* alt) / 2;
                _Perimetro = (bas*2) + (alt*2);
                return true;
            }
            else
                return false;
        }

    }
}