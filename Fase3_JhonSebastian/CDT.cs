using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fase3_JhonSebastian
{
    internal class CDT
    {
        public int idCDT { get; set; }
        public string idCliente { get; set; }
        public string nombreCliente { get; set; }
        public string direccionCliente { get; set; }
        public int estratoCliente { get; set; }
        public string categoria { get; set; }
        public string mesApertura { get; set; }
        public int tiempoMeses { get; set; }
        public double valorCDT { get; set; }
        public double valorTotal { get; set; }
        public DateTime fechaPago { get; set; }
        static public double reporte { get; set; }

        public CDT(int idCDT, string idCliente, string nombreCliente, string direccionCliente, int estratoCliente, string categoria, string mesApertura, int tiempoMeses, double valorCDT, DateTime fechaPago)
        {
            this.idCDT = idCDT;
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.direccionCliente = direccionCliente;
            this.estratoCliente = estratoCliente;
            this.categoria = categoria;
            this.mesApertura = mesApertura;
            this.tiempoMeses = tiempoMeses;
            this.valorCDT = valorCDT;
            this.fechaPago = fechaPago;

            if (tiempoMeses > 0 && tiempoMeses < 12)
            {
                valorTotal = valorCDT + (valorCDT * 0.002 * tiempoMeses);
            }
            else if (tiempoMeses >= 12 && tiempoMeses < 26)
            {
                valorTotal = valorCDT + (valorCDT * 0.002 * tiempoMeses);
            }
            else if (tiempoMeses > 25)
            {
                valorTotal = valorCDT + (valorCDT * 0.002 * tiempoMeses);
            }
        }
    }
}
