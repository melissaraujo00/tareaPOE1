using System;
using System.Linq;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Presionarbutton_Click(object sender, EventArgs e)
        {
            try
            {
                string frases = FrasetextBox.Text.ToLower().Trim();

                if (string.IsNullOrWhiteSpace(frases))
                {
                    throw new ArgumentException("La frase no puede estar vacía. Por favor Ingrese una frase");
                }

                if (!frases.All(char.IsLetter))
                {
                    throw new ArgumentException("La frase solo debe contener letras. Por favor ingrese una frase.");
                }

                string frasesLimpias = ConservarSoloLetras(frases);

                if (SiesPalindromo(frasesLimpias))
                {
                    ResultadoLabel.Text = "La frase es un palíndromo.";
                }
                else
                {
                    ResultadoLabel.Text = "La frase no es un palíndromo.";
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error al Validad", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha Ocurrió un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ConservarSoloLetras(string frases)
        {
            return new string(frases.Where(char.IsLetter).ToArray());
        }

        private bool SiesPalindromo(string frases)
        {
            int longitud = frases.Length;
            for (int i = 0; i < longitud / 2; i++)
            {
                if (frases[i] != frases[longitud - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}