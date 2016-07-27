using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase24DeMayo
{
    class Documento
    {
        public static void imprimirStatic(Documento doc)
        {
            //int NumeroUno = 0;
            //int NumeroDos = 10;
            //float resultado = NumeroDos / NumeroUno;

            throw new ImprimirException("No se pudo imprimir", "No hay red para la impresora", "Franco");
        }

        public void imprimirInstancia()
        {
            try
            {
                Documento.imprimirStatic(this);
            }
            catch (ImprimirException ex)
            {
                throw new ImprimirException("ImprimirInstancia()", ex);
            }
            
        }
    }
}
