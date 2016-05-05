using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaGit
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        bool secuencia = true, punto = true;
        string operacion, borrado;
        double num1, num2, resultado;


        private void button1_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "1";
                secuencia = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "2";
                secuencia = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "3";
                secuencia = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "4";
                secuencia = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "5";
                secuencia = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "6";
                secuencia = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "7";
                secuencia = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "8";
                secuencia = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                txtPantalla.Text = "";
                txtPantalla.Text = "9";
                secuencia = false;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0")
            {
                return;
            }
            else
            {
                txtPantalla.Text = txtPantalla.Text + "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            operacion = "+";
            num1 = double.Parse(txtPantalla.Text);
            secuencia = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            operacion = "-";
            num1 = double.Parse(txtPantalla.Text);
            secuencia = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            operacion = "×";
            num1 = double.Parse(txtPantalla.Text);
            secuencia = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            operacion = "÷";
            num1 = double.Parse(txtPantalla.Text);
            secuencia = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtPantalla.Text);
            if (operacion == "+")
            {
                resultado = num1 + num2;
                txtPantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "-")
            {
                resultado = num1 - num2;
                txtPantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "×")
            {
                resultado = num1 * num2;
                txtPantalla.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "÷")
            {
                resultado = num1 / num2;
                txtPantalla.Text = resultado.ToString();
                secuencia = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrado = txtPantalla.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            txtPantalla.Text = borrado;

            if (txtPantalla.Text == "")
            {
                txtPantalla.Text = "0";
                secuencia = true;
            }
            if (txtPantalla.Text == "-")
            {
                txtPantalla.Text = "0";
                secuencia = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (punto == true)
            {
                txtPantalla.Text = txtPantalla.Text + ".";
                punto = false;
            }
            else
            {
                return;
            }
        }


    }
}
