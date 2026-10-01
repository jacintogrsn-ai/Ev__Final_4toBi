using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ev__Final_4toBi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            int Var1 = int.Parse(TextVar1.Text);
            int Var2 = int.Parse(TextVar2.Text);
            int Producto = Var1 * Var2;
            MessageBox.Show("El resultado del Producto es" + Producto);
        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            int Var1 = int.Parse(TextVar1.Text);
            int Var2 = int.Parse(TextVar2.Text);
            int Suma = Var1 + Var2;
            MessageBox.Show("El resultado del Producto es" + Suma);
        }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(TextVar1.Text);
            int num2 = int.Parse(TextVar2.Text);
            int num3 = 1;
            int potencia = 1;
            while (num3 != num2)

            {
                potencia = potencia * num1;
                num3 = num3 + 1;
            }
            MessageBox.Show("El resultado de la potencia es " + potencia);

        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            float Var1 = float.Parse(TextVar1.Text);
            float Var2 = float.Parse(TextVar2.Text);

            if (Var2 > 0)
            {
                float Division = Var1 / Var2;
                MessageBox.Show("El resultado de la Division es " + Division);
            }
            else
            {
                MessageBox.Show("La Division es indefinida");
            }
        }


    }
}
 
