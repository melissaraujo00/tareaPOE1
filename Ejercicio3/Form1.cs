using System;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CalculartextBox.Text, out int numero) && numero > 0)
            {
                int CantidadCifras = CalcularNumerodeCifras(numero);

                Resultadolabel.Text = $"El número {numero} tiene una cantidad de {CantidadCifras} cifras.";
            }
            else
            {
                Resultadolabel.Text = "Datos no validos. Por Favor, vuelva a ingresar numeros enteros positivos.";
            }
        }
        private int CalcularNumerodeCifras(int numero) 
        {
            string CadenadeNumeros = numero.ToString();
            return CadenadeNumeros.Length;
        }
    }
}
