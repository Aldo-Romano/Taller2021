using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassEntidades
{
    public class Revisiones
    {
        public int id_Revision { get; set; }
        public DateTime Entrada { get; set; }
        public string Falla { get; set; }
        public string diagnostico { get; set; }
        public byte Autorizacion { get; set; }
        public int  Auto { get; set; }
        public int Mecanico { get; set; }

    }
}
