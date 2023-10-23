using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto.View
{
    public partial class TelaForm : Form
    {
        public TelaForm()
        {
            InitializeComponent();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {

            String resultado;
            int num = Convert.ToInt32(tb_primeirovalor.Text);
            int num2 = Convert.ToInt32(tb_segundovalor.Text);
            int num3 = Convert.ToInt32(tb_terceirovalor.Text);
            int maior;


            if (num >= num2 && num >= num3)
            {
                maior = num;
            }
            else if (num2 >= num && num2 >= num3)
            {
                maior = num2;
            }
            else
            {
                maior = num3;
            }

            Console.WriteLine("O maior número é: " + maior);



            lbl_resultado.Text = "Primeiro Valor: " + num + "\nSegundo Valor:" + num2 + "\nTerceiro Valor: " + num3 + "\nO maior valor é : " + maior;




        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = " ";
        }
    }
}
