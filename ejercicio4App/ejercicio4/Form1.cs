namespace ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCompString_MouseClick(object sender, MouseEventArgs e)
        {
            string firstString = firstStringTextBox.Text.Trim().ToLower();
            string secondString = secondStringTextBox.Text.Trim().ToLower();


            if(string.IsNullOrEmpty(firstString) || string.IsNullOrEmpty(secondString))
            {
                resultLabel.Text = "Uno o ambos campos están vacíos";
            }
            else if (firstString == secondString)
            {
                resultLabel.Text = "Los strings son iguales";
            }
            else
            {
                resultLabel.Text = "Los strings son distintos";
            }
        }
    }
}
