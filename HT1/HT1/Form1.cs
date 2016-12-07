using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1, n2, n3;

            n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            n3 = int.Parse(textBox3.Text);

            int contador = 2;
            int mcd = 1;

            while (contador <= n1 && contador <= n2 && contador <= n3) { 
                while(n1%contador==0 && n2%contador==0 && n3 % contador==0){
                mcd=mcd*contador;
                    n1=n1/contador;
                    n2=n2/contador;
                    n3=n3/contador;
                }
                contador=contador+1;
            }
            textBox4.Text=mcd.ToString() ;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label5.Text = "Ingrese 6 numeros para Ordenarlos en Forma Ascendente";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "Ingrese 3 Numeros para calcular el MCD";
        }
    }
}
