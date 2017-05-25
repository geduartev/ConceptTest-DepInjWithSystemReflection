using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Interfaz;

namespace DepInjWithSystemReflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var ensambladoExterno = 
                Assembly.LoadFile(@"D:\GD\Doc\Visual Studio 2017\Projects\ProofOfConcepts\DepInjWithSystemReflection\ImplementacionFuncionalidad\bin\Debug\ImplementacionFuncionalidad.dll");
            var tipos = ensambladoExterno.GetExportedTypes();

            // Utilizando el contrato
            IFuncionalidad objectoConcreto = (IFuncionalidad)Activator.CreateInstance(tipos[0]);

            Console.WriteLine(objectoConcreto.ObtenerTexto());

            Console.ReadLine();
        }
    }
}
