using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3_JhonSebastian
{
    internal class Estudiante
    {
        public string TipoID { get; set; }
        public string ID { get; set; }
        public string NombreApellido { get; set; }
        public int Edad { get; set; }
        public int Estrato { get; set; }
        public string Voto { get; set; }
        public DateTime FechaRegistro { get; set; }

        public Estudiante(string tipoID, string ID, string nombreApellido, int edad, int estrato, string voto, DateTime fecha)
        {
            this.TipoID = tipoID;
            this.ID = ID;
            this.NombreApellido = nombreApellido;
            this.Edad = edad;
            this.Estrato = estrato;
            this.Voto = voto;
            this.FechaRegistro = fecha;
        }
    }
}
