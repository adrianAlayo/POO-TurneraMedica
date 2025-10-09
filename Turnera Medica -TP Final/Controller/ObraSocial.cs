using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Turnera_Medica__TP_Final.Controller
{
    internal class ObraSocial
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public double Descuento { get; set; }

        public ObraSocial(int id, string nombre, double descuento)
        {
            Id = id;
            Nombre = nombre;
            Descuento = descuento;
        }

        public double AplicarDescuento(decimal montoOriginal)
        {
            return 0;
        }
    }
}
