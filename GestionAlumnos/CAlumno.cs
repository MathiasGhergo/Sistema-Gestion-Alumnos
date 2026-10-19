using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlumnos
{
    internal class CAlumno
    {
        private string nombre;
        private string apellido;
        private string legajo;
        private static float cuota;

        public CAlumno(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }
        public static void EstablecerCuota(float cuota)
        {
            CAlumno.cuota = cuota;
        }
        public static float ConocerCuota()
        {
            return cuota;
        }
        public string DarDatos()
        {
            return "\n" + "Nombre: " + this.nombre + "\n" + "Apellido: " + this.apellido + "\n" + "Legajo: " + this.legajo;
        }
        public string Legajo
        {
            get { return legajo; }
        }
    }
}
