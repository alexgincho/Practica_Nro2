using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica_Nro2.Models
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Telefono { get; set; }
        public string Distrito { get; set; }
        public string Direccion { get; set; }
        public Mascota Mascota { get; set; }

    }
}
