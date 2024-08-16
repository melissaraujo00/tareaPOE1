using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PentagonoLibreria;

namespace ejercicio5UI
{
    public partial class PentagonoForm : Form
    {
        //Calculadora de área y perímetro de un Pentagono
        public PentagonoForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            try
            {
                //validaciones 
                if (string.IsNullOrWhiteSpace(apotemaTextBox.Text) || string.IsNullOrWhiteSpace(longitudLadoTextBox.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!decimal.TryParse(apotemaTextBox.Text, out decimal apotemaPentagono) ||
                    !decimal.TryParse(longitudLadoTextBox.Text, out decimal longitudLado))
                {
                    MessageBox.Show("Ingrese valores numéricos válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (apotemaPentagono < 0 || longitudLado < 0)
                {
                    MessageBox.Show("Los valores deben ser mayores que cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                //Creación de la instancia del objeto y utilización de los métodos

                Pentagono miPentagono = new Pentagono(longitudLado, apotemaPentagono);
                decimal areaPentagono = miPentagono.CalcularArea();
                decimal perimetroPentagono = miPentagono.CalcularPerimetro();

                MessageBox.Show($"El pentágono tiene un área de {areaPentagono} cm² y un perímetro de {perimetroPentagono} cm.", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
