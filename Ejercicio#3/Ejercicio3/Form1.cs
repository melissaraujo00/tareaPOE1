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
            try
            {
                string input = CalculartextBox.Text.Trim();

                if (string.IsNullOrWhiteSpace(input))
                {
                    throw new ArgumentException("El cuadro no puede quedarse vacio, por favor ingrese un numero. :(");
                }

                if (!int.TryParse(input, out int numero))
                {
                    throw new ArgumentException("Por favor. Ingrese un número entero válido. :(");
                }

                if (numero <= 0)
                {
                    throw new ArgumentException("Por favor. Ingrese un número entero positivo. :(");
                }

                int CantidadCifras = CalcularNumerodeCifras(numero);

                Resultadolabel.Text = $"El número {numero} tiene una cantidad de {CantidadCifras} cifras. :)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Resultadolabel.Text = "Se produjo un error. Por favor intente nuevamente. :(";
            }
        }

        private int CalcularNumerodeCifras(int numero)
        {
            return numero.ToString().Length;
        }
    }
}