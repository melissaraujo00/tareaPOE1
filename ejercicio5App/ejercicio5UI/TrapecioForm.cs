using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrapecioLibreria;

namespace ejercicio5UI
{
    public partial class TrapecioForm : Form
    {
        //Calculadora de área y Perímetro de un trapecio
        public TrapecioForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {

            try
            {
                //Validaciones
                if (string.IsNullOrWhiteSpace(baseMayorTextBox.Text) || string.IsNullOrWhiteSpace(baseMenorTextBox.Text) ||
                string.IsNullOrWhiteSpace(ladosParalelosTextBox.Text) || string.IsNullOrWhiteSpace(alturaTrapecioTextBox.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(baseMayorTextBox.Text, out decimal baseMayor) || !decimal.TryParse(baseMenorTextBox.Text, out decimal baseMenor) || !decimal.TryParse(ladosParalelosTextBox.Text, out decimal ladosParalelos) || !decimal.TryParse(alturaTrapecioTextBox.Text, out decimal alturaTrapecio))
                {
                    MessageBox.Show("Por favor, Ingrese valores numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (baseMayor < 0 || baseMenor < 0 || ladosParalelos < 0 || alturaTrapecio < 0)
                {
                    MessageBox.Show("Por favor, Ingrese valores positivos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Creación de la instancia de un objeto y utilización de los métodos

                Trapecio miTrapecio = new Trapecio(baseMayor, baseMenor, ladosParalelos, alturaTrapecio);
                decimal areaTrapecio = miTrapecio.CalcularArea();
                decimal perimetroTrapecio = miTrapecio.CalcularPerimetro();

                MessageBox.Show($"El Trapecio tiene una área de {areaTrapecio} cm² y un perimetro de {perimetroTrapecio} cm");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Formato de entrada inválido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"Valor numérico fuera de rango: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Error de referencia nula: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

       
    }
}
