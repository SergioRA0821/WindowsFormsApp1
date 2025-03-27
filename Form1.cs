using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void btnSuma_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txbNumero1.Text);
            int num2 = Convert.ToInt32(txbNumero2.Text);
            MessageBox.Show($"El resultado es: {num1 + num2}");
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txbNumero1.Text);
            int num2 = Convert.ToInt32(txbNumero2.Text);
            MessageBox.Show($"El resultado es: {num1 - num2}");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txbNumero1.Text);
            int num2 = Convert.ToInt32(txbNumero2.Text);
            MessageBox.Show($"El resultado es: {num1 * num2}");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txbNumero1.Text);
            double num2 = Convert.ToDouble(txbNumero2.Text);
            MessageBox.Show($"El resultado es: {num1 / num2}");
        }

        private void btnResiduo_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(txbNumero1.Text);
            int num2 = Convert.ToInt32(txbNumero2.Text);
            MessageBox.Show($"El resultado es: {num1 % num2}");
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txbNumero1.Text = "";
            txbNumero2.Text = "";
        }
    }
}
