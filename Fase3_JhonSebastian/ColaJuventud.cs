using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3_JhonSebastian
{
    internal class ColaJuventud
    {
        private Queue<Juventud> jovenes;

        public ColaJuventud()
        {
            jovenes = new Queue<Juventud>();
        }

        public void agregarJoven(Juventud joven)
        {
            jovenes.Enqueue(joven);
        }

        public void eliminarJoven()
        {
            jovenes.Dequeue();
        }

        public int getCantidadRegistros()
        {
            return jovenes.Count;
        }

        public Queue<Juventud> getJovenes()
        {
            return jovenes;
        }
    }
}
