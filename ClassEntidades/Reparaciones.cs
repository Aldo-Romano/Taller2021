using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntidades
{
    public class Reparaciones
    {
        public int id_reparacion { get; set; }
        public string detalles { get; set; }
        public string garantia { get; set; }
        public DateTime salida { get; set; }
        public int Fk_revision { get; set; }
    }
}
