using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InteresSimpleLibrary; 

namespace InteresSimpleUI
{
    public partial class IteresSimpleForms : Form
    {
        public IteresSimpleForms()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            try
            {
                double capital = Convert.ToDouble(capitalTextBox.Text);
                double TasaInteres = Convert.ToDouble(tasaInteresTextBox.Text);
                double tiempo = Convert.ToDouble(tiempoTextBox.Text);

                InteresSimple _interesSimple = new InteresSimple(capital, TasaInteres, tiempo);

                double resultado = _interesSimple.CalcularInteresSimple();

                resultadoLabel.Text = $"El interes simple generado es de ${resultado}";


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IteresSimpleForms_Load(object sender, EventArgs e)
        {
            string[] items = {
                "Meses",
                "Años"
            };


            tiempoComboBox.Items.AddRange(items);
        }

        private void capitalTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(capitalTextBox.Text))
            {
                e.Cancel = true;
                provedorError.SetError(capitalTextBox, "El capital no debe estar vacio");
                capitalErrorLabel.Text = "El capital no debe estar vacio";
                capitalTextBox.Focus();
            }
            else if (!double.TryParse(capitalTextBox.Text, out double capital)) 
            {
                e.Cancel = true;
                provedorError.SetError(capitalTextBox, "El capital debe ser un numero ");
                capitalTextBox.Text = "El capital debe ser un numero ";
                capitalTextBox.Focus();
            }
            else
            {
                e.Cancel = false;
                provedorError.SetError(capitalTextBox, "");
                capitalErrorLabel.Text = string.Empty;
            }
        }

        private void tasaInteresTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tasaInteresTextBox.Text))
            {
                e.Cancel = true;
                provedorError.SetError(tasaInteresTextBox, "La tasa de interes no debe de estar vacio");
                tasaInteresErrorLabel.Text = "La tasa de interes no debe de estar vacio";
                tasaInteresTextBox.Focus();
            }
            else if (!double.TryParse(tasaInteresTextBox.Text, out double tasaInteres)) 
            {
                e.Cancel = true;
                provedorError.SetError(tasaInteresTextBox, "La tasa de interes debe de ser un numero");
                tasaInteresErrorLabel,Text = "La tasa de interes debe ser un numero";
                tasaInteresTextBox.Focus();
            }
            else
            {
                e.Cancel = false;
                provedorError.SetError(tasaInteresTextBox, "");
                tasaInteresErrorLabel.Text = string.Empty;
            }
        }

        private void tiempoTextBox_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
