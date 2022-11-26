using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3_JhonSebastian
{
    internal class PilaCDT
    {
        Stack<CDT> cdts;

        public PilaCDT()
        {
            cdts = new Stack<CDT>();
        }

        public void agregarCDT(CDT cdt)
        {
            cdts.Push(cdt);
        }

        public void eliminarCDT()
        {
            cdts.Pop();
        }

        public CDT obtenerPrimerCDT()
        {
            return cdts.Peek();
        }

        public Stack<CDT> getCdts()
        {
            return cdts;
        }
    }
}
