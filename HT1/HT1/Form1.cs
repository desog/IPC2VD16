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

            while (contador <= n1 && contador <= n2 && contador <= n3)
            {
                while (n1 % contador == 0 && n2 % contador == 0 && n3 % contador == 0)
                {
                    mcd = mcd * contador;
                    n1 = n1 / contador;
                    n2 = n2 / contador;
                    n3 = n3 / contador;
                }
                contador = contador + 1;
            }
            textBox4.Text = mcd.ToString();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label5.Text = "Ingrese 6 numeros para Ordenarlos en Forma Ascendente";
            textBox5.Show();
            textBox6.Show();
            textBox7.Show();
            textBox8.Hide();
            textBox9.Hide();
            textBox10.Hide();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            button4.Show();
            button5.Hide();
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            label5.Text = "Ingrese 3 Numeros para calcular el MCD";
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            textBox10.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            button2.Show();
            button4.Hide();
            button5.Hide(); 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox5.Hide();
            textBox6.Hide();
            textBox7.Hide();
            textBox8.Hide();
            textBox9.Hide();
            textBox10.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            label9.Hide();
            label10.Hide();
            label11.Hide();
            button4.Hide();
            button5.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int n = 0,m=0;
            int[] num;
            string resultado;
            resultado = "";
            num = new int[6];

            num[0] = int.Parse(textBox1.Text);
            num[1] = int.Parse(textBox2.Text);
            num[2] = int.Parse(textBox3.Text);
            num[3] = int.Parse(textBox5.Text);
            num[4] = int.Parse(textBox6.Text);
            num[5] = int.Parse(textBox7.Text);

            for (int i = 1; i < 6; i++) {
                for (int y = 0; y < 6 - 1; y++) {
                    if (num[i] < num[y]) {
                        m = num[i];
                        num[i] = num[y];
                        num[y] = m;
                    }
                }
            }

            for (int r = 0; r < 6; r++) {
                resultado = resultado+ Convert.ToString(num[r])+",";
            }

            textBox4.Text = resultado;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label5.Text = "Ingrese los numeros necesarios para calcular el Determinante de una matriz de 3x3";
            button5.Show();
            button4.Hide();
            button2.Hide();
            textBox5.Show();
            textBox6.Show();
            textBox7.Show();
            textBox8.Show();
            textBox9.Show();
            textBox10.Show();
            label6.Show();
            label7.Show();
            label8.Show();
            label9.Show();
            label10.Show();
            label11.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int determinante;
            int[,] matriztmp;
            matriztmp = new int[3, 3];

            matriztmp[0, 0] = int.Parse(textBox1.Text);
            matriztmp[0, 1] = int.Parse(textBox2.Text);
            matriztmp[0, 2] = int.Parse(textBox3.Text);
            matriztmp[1, 0] = int.Parse(textBox5.Text);
            matriztmp[1, 1] = int.Parse(textBox6.Text);
            matriztmp[1, 2] = int.Parse(textBox7.Text);
            matriztmp[2, 0] = int.Parse(textBox8.Text);
            matriztmp[2, 1] = int.Parse(textBox9.Text);
            matriztmp[2, 2] = int.Parse(textBox10.Text);

            determinante = (matriztmp[0, 0] * matriztmp[1, 1] * matriztmp[2, 2]) + (matriztmp[0, 1] * matriztmp[1, 2] * matriztmp[2, 0]) + (matriztmp[0, 2] * matriztmp[1, 0] * matriztmp[2, 1]) - (matriztmp[0, 2] * matriztmp[1, 1] * matriztmp[2, 0]) - (matriztmp[0, 1] * matriztmp[1, 0] * matriztmp[2, 2]) - (matriztmp[0, 0] * matriztmp[1, 2] * matriztmp[2, 1]);
            textBox4.Text = determinante.ToString();
        }
    }
}
