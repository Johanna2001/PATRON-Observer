using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRON_Observer
{
    class Aplicacion
    {
        public int IdJob { get; set; }
        public string NombreAplicacion { get; set; }

        public Aplicacion(int idJob, string NombreAplicacion)
        {
            this.IdJob = IdJob;
            this.NombreAplicacion = NombreAplicacion;
        }
    }
}
