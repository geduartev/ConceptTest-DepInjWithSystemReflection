using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaz
{
    /// <summary>
    /// Interfaz que representa el contrato con una funcionalidad específica.
    /// </summary>
    public interface IFuncionalidad
    {
        string Texto { get; set; }
        string ObtenerTexto();
    }
}
