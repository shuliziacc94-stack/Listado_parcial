using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listado_de_multiplicar_V4
{
    public class Operacion
    {
        public DataTable DTresultados { get; set; } = new DataTable();

        public Operacion()
        {
            DTresultados.TableName = "ListaResultados";
            DTresultados.Columns.Add("num1", typeof(int));
            DTresultados.Columns.Add("num2", typeof(int));
            DTresultados.Columns.Add("resultado", typeof(int));
            LeerArchivo();
        }

        public void LeerArchivo()
        {
           if(System.IO.File.Exists("operaciones"))
           { 
                DTresultados.ReadXml("operaciones");
           }


        }
        public void GuardarOperacion(int num1, int num2, int resultado)
        {
            DTresultados.Rows.Add(num1, num2, resultado);
            List<string> lineas = new List<string>();
            foreach (DataRow row in DTresultados.Rows)
            {
                string linea = $"{row["Num1"]},{row["Num2"]},{row["Resultado"]}";
                lineas.Add(linea);
            }
            System.IO.File.WriteAllLines("operaciones.xml", lineas);
        }
        private int Calcular(int num1, int num2)
        {
            return num1 * num2;
        }
        private int NuevaOperacion(int num1, int num2)
        {
            int resultado = Calcular(num1, num2);
            GuardarOperacion(num1, num2, resultado);
            return resultado;
        }

    }
}
