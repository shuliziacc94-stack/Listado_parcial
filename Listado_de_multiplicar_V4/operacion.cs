using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listado_de_multiplicar_V4
{
    internal class Operacioness
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }
        public int Resultado { get; set; }

        public void
               Agregar(int anum1,
                                int anum2,
                                int aresultado)

        {
            Num1 = anum1;
            Num2 = anum2;
            Resultado = aresultado;
        }
    }



}
   
