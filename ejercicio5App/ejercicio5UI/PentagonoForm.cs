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
        public PentagonoForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            decimal apotemaPentagono = Convert.ToDecimal(apotemaTextBox.Text);
            decimal longitudLado = Convert.ToDecimal(longitudLadoTextBox.Text);

            Pentagono miPentagono = new Pentagono(longitudLado, apotemaPentagono);

            decimal areaPentagono = miPentagono.CalcularArea();
            decimal perimetroPentagono = miPentagono.CalcularPerimetro();

            MessageBox.Show($"El pentagono tiene una area: {areaPentagono} cm y un perimetro de {perimetroPentagono} cm");

        }
    }
}
