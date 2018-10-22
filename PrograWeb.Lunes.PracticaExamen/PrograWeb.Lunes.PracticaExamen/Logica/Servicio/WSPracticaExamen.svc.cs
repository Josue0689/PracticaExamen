using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PrograWeb.Lunes.PracticaExamen
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSPracticaExamen: ISPracticaExamen
    {
        public bool Cuadrad(double Lad) {
            Logica.Especificacion.Cuadrado laEspecificacion = new Logica.Especificacion.Cuadrado();
            return laEspecificacion.calcularCuadrado(Lad);
        } 

        public bool Triangul(double A, double B, double C)
        {
            Logica.Especificacion.Triangulo laEspecificacion = new Logica.Especificacion.Triangulo();
            return laEspecificacion.calculaTriangulo(A, B, C);
        }

        public bool Rectan(double bas, double alt) {
            Logica.Especificacion.Rectangulo laEspecificacion = new Logica.Especificacion.Rectangulo();
            return laEspecificacion.calcularRectangulo(bas, alt);
        }
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }
    }

}
