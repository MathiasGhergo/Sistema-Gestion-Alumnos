using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionAlumnos
{
    internal class CAlumnos
    {
        private List<CAlumno> lista;

        public CAlumnos() 
        {
            lista = new List<CAlumno>();
        }
        public void AgregarAlumno(CAlumno alumno) 
        {
            lista.Add(alumno);
        }
        public CAlumno BuscarAlumno(string legajo) 
        {
            foreach (CAlumno alumno in lista) 
            {
                if (alumno.Legajo == legajo)
                {
                    return alumno;
                }
            }
            return null;
        }
        public List<CAlumno> ObtenerTodos()
        {
            return lista;
        }
        public bool RemoverAlumno(string legajo)
        {
            CAlumno alumno = BuscarAlumno(legajo);

            if (alumno != null)
            {
                lista.Remove(alumno);
                return true;
            }

            return false;
        }

    }
}
