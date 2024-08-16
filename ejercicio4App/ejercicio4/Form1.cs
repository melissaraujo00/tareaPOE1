namespace ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void compararButton_Click(object sender, EventArgs e)
        {
            try
            {
                string primeraCadena = primeraCadenaTextBox.Text?.Trim().ToLower() ?? string.Empty;
                string segundaCadena = segundaCadenaTextBox.Text?.Trim().ToLower() ?? string.Empty;

                //Validaciones

                if (primeraCadena.Length < 3 || segundaCadena.Length < 3)
                {
                    resultLabel.Text = "Cada cadena debe tener al menos 3 caracteres.";
                    return;
                }

                if (!primeraCadena.All(char.IsLetter) || !segundaCadena.All(char.IsLetter))
                {
                    resultLabel.Text = "Las cadenas solo deben contener letras.";
                    return;
                }


                //Comparación de las cadenas
                if (string.IsNullOrEmpty(primeraCadena) || string.IsNullOrEmpty(segundaCadena))
                {
                    resultLabel.Text = "Uno o ambos campos están vacíos";
                }
 
                else if (primeraCadena == segundaCadena)
                {
                    resultLabel.Text = "Los strings son iguales";
                }
                else
                {
                    resultLabel.Text = "Los strings son distintos";
                }
            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("Ocurrió un error al intentar acceder al contenido de los TextBoxes. Por favor, verifique que los campos no estén nulos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
  
    }
}
