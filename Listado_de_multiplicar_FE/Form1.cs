using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listado_de_multiplicar_FE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtpr2_TextChanged(object sender, EventArgs e)
        {

        }
        private void bt_agregar_Click(object sender, EventArgs e)
        {
            double Num1, Num2, Resultado;

            if (double.TryParse(txtpr1.Text, out Num1)
                && double.TryParse(txtpr2.Text, out Num2))
            {
                Resultado = Num1 * Num2;
                txtres.Text = Resultado.ToString();

                ListaResultados.Items.Add($"{Num1} x {Num2} = {Resultado}");
            }
            else
            {
                MessageBox.Show("Por favor, ingrese números válidos");
            }
        }

        private void bt_borrar_Click(object sender, EventArgs e)
        {
            txtpr1.Clear();
            txtpr2.Clear();
            txtres.Clear();
            ListaResultados.Items.Clear();


        }

        private void ListaResultados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtpr1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

    

