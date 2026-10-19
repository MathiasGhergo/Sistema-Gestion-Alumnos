using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlumnos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CAlumnoControladora controladora = new CAlumnoControladora();
            controladora.Ejecutar();
        }
    }
}
