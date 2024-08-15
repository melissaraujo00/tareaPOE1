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
            string frase = FrasetextBox.Text.ToLower();
            string fraseLimpia = RemoverCaracteresNoAlfanumericos(frase);

            if (EsPalindromo(fraseLimpia))
            {
                ResultadoLabel.Text = "La frase es un palíndromo.";
            }
            else
            {
                ResultadoLabel.Text = "La frase no es un palíndromo.";
            }
        }

        private string RemoverCaracteresNoAlfanumericos(string frase)
        {
            char[] arr = frase.ToCharArray();
            arr = Array.FindAll(arr, c => char.IsLetterOrDigit(c));
            return new string(arr);
        }

        private bool EsPalindromo(string frase)
        {
            int longitud = frase.Length;
            for (int i = 0; i < longitud / 2; i++)
            {
                if (frase[i] != frase[longitud - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}