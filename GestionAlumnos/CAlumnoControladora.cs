using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlumnos
{
    internal class CAlumnoControladora
    {
        private CAlumnos conjunto;
        private CVista vista;
        public CAlumnoControladora()
        {
            conjunto = new CAlumnos();
            vista = new CVista();
        }
        public void EstablecerCuotaGeneral()
        {

            float cuota = vista.PedirCuota();
            CAlumno.EstablecerCuota(cuota);

        }
        public void ConocerCuotaGeneral()
        {
            float cuota = CAlumno.ConocerCuota();
            vista.MostrarCuota(cuota);

        }
        public void AgregarAlumno()
        {
            string nombre, apellido, legajo;

            vista.PedirDatosAlumno(out nombre, out apellido, out legajo);

            CAlumno alumno = new CAlumno(nombre, apellido, legajo);

            conjunto.AgregarAlumno(alumno);
        }
        public void MostrarAlumno()
        {
            string legajo = vista.PedirLegajo();

            CAlumno alumno = conjunto.BuscarAlumno(legajo);

            if (alumno != null)
            {
                vista.MostrarAlumno(alumno);
            }
            else
                Console.WriteLine("No se encontró el alumno con legajo: " + legajo);
        }
        public void ListarAlumnos()
        {
            Console.WriteLine("Lista de Alumnos: ");
            List<CAlumno> alumnos = conjunto.ObtenerTodos();
            vista.MostrarAlumnos(alumnos);
        }
        public void RemoverAlumno() 
        {
            string legajo = vista.PedirLegajo();

            bool eliminado = conjunto.RemoverAlumno(legajo);
            if(eliminado)
            {
                Console.WriteLine("Alumno con legajo " + legajo + " eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("No se encontró el alumno con legajo: " + legajo);
            }
        }
        public void Ejecutar()
        {
            char opcion;
            do
            {
                opcion = vista.MostrarMenu();
                switch (opcion)
                {
                    case 'C':
                        EstablecerCuotaGeneral();
                        break;
                    case 'G':
                        ConocerCuotaGeneral();
                        break;
                    case 'A':
                        AgregarAlumno();
                        break;
                    case 'M':
                        MostrarAlumno();
                        break;
                    case 'L':
                        ListarAlumnos();
                        break;
                    case 'R':
                        RemoverAlumno();
                        break;
                    case 'S':
                        Console.WriteLine("Saliendo de la aplicación...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            } while (opcion != 'S');
        }
    }
}
