using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Interfaz;

namespace ImplementacionFuncionalidad
{
    public class Funcionalidad : IFuncionalidad
    {
        public string Texto { get; set; }

        public Funcionalidad ()
        {
            this.Texto = "Mensaje que representa la funcionalidad de devolver algún texto.";
        }

        public string ObtenerTexto()
        {
            return Texto;
        }
    }
}
