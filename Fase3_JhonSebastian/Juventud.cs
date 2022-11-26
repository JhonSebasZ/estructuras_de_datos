using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3_JhonSebastian
{
    internal class Juventud
    {
        public string identificaion { get; set; }
        public string nombreApellido { get; set; }
        public string direccion { get; set; }
        public string sexo { get; set; }
        public DateTime fechaActualizacion { get; set; }
        private float auxilio = 0;

        public Juventud(string identificacion, string nombreApellido, string direccion, string sexo, DateTime fechaActualizacion)
        {
            this.identificaion = identificacion;
            this.nombreApellido = nombreApellido;
            this.direccion = direccion;
            this.sexo = sexo;
            this.fechaActualizacion = fechaActualizacion;

            auxilio = direccion switch
            {
                "Comuna 1" or "Comuna 8" or "Comuna 10" => 100000,
                _ => 50000
            };
        }

        public float getAuxilio()
        {
            return auxilio;
        }
    }
}
