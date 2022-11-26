using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3_JhonSebastian
{
    internal class ListaEstudiante
    {
        List<Estudiante> estudiantes;

        public ListaEstudiante()
        {
            estudiantes = new List<Estudiante>();
        }

        public void Registrar(Estudiante estudiante)
        {
            estudiantes.Add(estudiante);
        }

        public Estudiante Consultar(string id)
        {
            return estudiantes.Find(estudiante => estudiante.ID.Equals(id));
        }

        public void Eliminar(Estudiante estudiante)
        {
            estudiantes.Remove(estudiante);
        }

        public List<Estudiante> GetEstudiantes()
        {
            return estudiantes;
        }
    }
}
