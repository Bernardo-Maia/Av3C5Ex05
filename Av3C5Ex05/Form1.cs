using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Av3C5Ex05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int mes = int.Parse(txtmes.Text);
            
            if(mes > 0 && mes < 13)
            {
                if(mes == 1)
                {
                    MessageBox.Show("Janeiro");
                }
                if (mes == 2)
                {
                    MessageBox.Show("Fevereiro");
                }
                if (mes == 3)
                {
                    MessageBox.Show("Março");
                }
                if (mes == 4)
                {
                    MessageBox.Show("Abril");
                }
                if (mes == 5)
                {
                    MessageBox.Show("Maio");
                }
                if (mes == 6)
                {
                    MessageBox.Show("Junho");
                }
                if (mes == 7)
                {
                    MessageBox.Show("Julho");
                }
                if (mes == 8)
                {
                    MessageBox.Show("Agosto");
                }
                if (mes == 9)
                {
                    MessageBox.Show("Setembro");
                }
                if (mes == 10)
                {
                    MessageBox.Show("Outubro");
                }
                if (mes == 11)
                {
                    MessageBox.Show("Novembro");
                }
                if (mes == 12)
                {
                    MessageBox.Show("Dezembro");
                }
            }
            else{ MessageBox.Show("digite o número de um mês valido");}
            txtmes.Text = "";
        }
    }
}
