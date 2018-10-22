using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograWeb.Lunes.PracticaExamen.Logica.Accion
{
    public class clsTriangulo
    {
        Logica.Validacion.clsValidacion valida = new Logica.Validacion.clsValidacion();

        private double LadoA;

        public double _LadoA
        {
            get { return LadoA; }
            set { LadoA = value; }
        }

        private double LadoB;

        public double _LadoB
        {
            get { return LadoB; }
            set { LadoB = value; }
        }

        private double LadoC;

        public double _LadoC
        {
            get { return LadoC; }
            set { LadoC = value; }
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

        public bool Calcular(double LadA, double LadB, double LadC) {
            if (valida.ValidaLados(LadA, LadB, LadC)) {
                double s = (LadA + LadB + LadC) / 2;
                _Area = Math.Sqrt(s * (s - LadA) * (s - LadB) * (s - LadC));
                _Perimetro = LadA + LadB + LadC;
                return true;
            }
            else
                return false;
        }

        
    }
}