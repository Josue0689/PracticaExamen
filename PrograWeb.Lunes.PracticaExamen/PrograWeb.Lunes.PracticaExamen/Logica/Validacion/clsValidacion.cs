using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrograWeb.Lunes.PracticaExamen.Logica.Validacion
{
    public class clsValidacion
    {
        public bool ValidaLados(double L1, double L2, double L3) {
            double suma = 0;
            if (L1 > L2 && L1 > L3)
            {
                suma = L2 + L3;
                if (suma > L1)
                {
                    return true;
                }
                else
                    return false;
            }
            else if (L2 > L1 && L2 > L3) {
                suma = L1 + L3;
                if (suma > L2)
                {
                    return true;
                }
                else
                    return false;
            }
            else if (L3> L1 && L3 > L2)
            {
                suma = L1 + L2;
                if (suma > L3)
                {
                    return true;
                }
                else
                    return false;
            }
            else
            {
                return false;
            }
        }
    }
}