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

                if (tiempo > 0)
                {
                    double resultado = _interesSimple.CalcularInteresSimple();

                    resultadoLabel.Text = $"El interes simple generado es de ${resultado}";
                }

            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Error de formato: {ex.Message}", "Error de formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                capitalErrorLabel.Text = "El capital debe ser un numero ";
                capitalTextBox.Focus();
            }
            else if (capital < 0)
            {
                e.Cancel = true;
                provedorError.SetError(capitalTextBox, "El capital no puede ser un numero negativo");
                capitalErrorLabel.Text = "El capital no puede ser un numero negativo";
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
                tasaInteresErrorLabel.Text = "La tasa de interes debe ser un numero";
                tasaInteresTextBox.Focus();
            }
            else if (tasaInteres > 100)
            {
                e.Cancel= true;
                provedorError.SetError(tasaInteresTextBox, "La tasa de interes no debe ser mayor a 100");
                tasaInteresErrorLabel.Text = "La tasa de interes no debe ser mayor a 100";
                tasaInteresTextBox.Focus();
            }
            else if (tasaInteres < 0)
            {
                e.Cancel = true;
                provedorError.SetError(tasaInteresTextBox, "La tasa de interés no puede ser negativa");
                tasaInteresErrorLabel.Text = "La tasa de interés no puede ser negativa";
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
            if (string.IsNullOrEmpty(tiempoTextBox.Text))
            {
                e.Cancel = true;
                provedorError.SetError(tiempoTextBox, "El tiempo no debe de estar vacio");
                tiempoErrorLabel.Text = "El tiempo no debe de estar vacio";
                tiempoTextBox.Focus();
            }
            else if (!double.TryParse(tiempoTextBox.Text, out double tiempo))
            {
                e.Cancel = true;
                provedorError.SetError(tiempoTextBox, "El tiempo debe de ser un numero");
                tiempoErrorLabel.Text = "El tiempo debe de ser un numero";
                tiempoTextBox.Focus();
            }
            else if(tiempo == 0)
            {
                e.Cancel = true;
                provedorError.SetError(tiempoTextBox, "El tiempo debe ser mayor a 0");
                tiempoErrorLabel.Text = "El tiewpo debe ser mayor a 0";
                tiempoTextBox.Focus();
            }
            else if (tiempo < 0)
            {
                e.Cancel = true;
                provedorError.SetError(tiempoTextBox, "El tiempo no puede ser un numero negativo");
                tiempoErrorLabel.Text = "El tiempo no puede ser un numero negativo";
                tiempoTextBox.Focus();
            }
            else
            {
                e.Cancel = false;
                provedorError.SetError(tiempoTextBox, "");
                tiempoErrorLabel.Text = string.Empty;
            }

        }

        private void IteresSimpleForms_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
