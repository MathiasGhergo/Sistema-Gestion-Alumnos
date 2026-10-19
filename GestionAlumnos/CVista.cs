using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlumnos
{
    internal class CVista
    {
        public char MostrarMenu()
        {
            Console.WriteLine("\n" + "Sistema de Gestión de Alumnos");
            Console.WriteLine("[C] Establecer Cuota General");
            Console.WriteLine("[G] Conocer Cuota General");
            Console.WriteLine("[A] Agregar un Alumno");
            Console.WriteLine("[M] Mostrar datos de un Alumno");
            Console.WriteLine("[L] Listar los datos de todos los Alumnos");
            Console.WriteLine("[R] Remover un Alumno");
            Console.WriteLine("[S] Salir de la aplicación");

            Console.WriteLine("Seleccione una opción:");

            string entrada = Console.ReadLine() ?? "";
            entrada = entrada.Trim();

            if (entrada.Length == 0)
            {
                return '\0';
            }

            char opcion = char.ToUpper(entrada[0]);
            return opcion;
        }
        public void PedirDatosAlumno(out string nombre, out string apellido, out string legajo)
        {
            Console.WriteLine("Ingrese el nombre del alumno:");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del alumno:");
            apellido = Console.ReadLine();
            Console.WriteLine("Ingrese el legajo del alumno:");
            legajo = Console.ReadLine();
        }
        public string PedirLegajo() 
        {
            Console.WriteLine("Ingrese el legajo");
            return Console.ReadLine();
        }
        public void MostrarAlumno(CAlumno alumno) 
        {
            Console.WriteLine("Datos del alumno: " + alumno.DarDatos());
        }
        public void MostrarAlumnos(List<CAlumno> alumnos) 
        {
            foreach (CAlumno alumno in alumnos) 
            {
                if(alumno != null)
                {
                    Console.WriteLine(alumno.DarDatos());
                }
            }

        }
        public void MostrarCuota(float cuota)
        {
          Console.WriteLine("La cuota general es de : " + cuota);
        }
        public float PedirCuota()
        {
            float cuota;

            while (true)
            {
                Console.WriteLine("Ingrese la cuota general:");

                if (float.TryParse(Console.ReadLine(), out cuota) && cuota >= 0)
                {
                    return cuota;
                }

                Console.WriteLine("Ingrese un número válido mayor o igual a cero.");
            }
        }
    }
}
