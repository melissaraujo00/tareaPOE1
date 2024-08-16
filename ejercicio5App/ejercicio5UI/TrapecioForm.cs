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
        public TrapecioForm()
        {
            InitializeComponent();
        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            decimal baseMayor = Convert.ToDecimal(baseMayorTextBox.Text);
            decimal baseMenor = Convert.ToDecimal(baseMenorTextBox.Text);
            decimal ladosParalelos = Convert.ToDecimal(ladosParalelosTextBox.Text);
            decimal altura = Convert.ToDecimal(alturaTrapecioTextBox.Text);

            Trapecio miTrapecio = new Trapecio(baseMayor, baseMenor, ladosParalelos, altura);

            decimal areaTrapecio = miTrapecio.CalcularArea();
            decimal perimetroTrapecio = miTrapecio.CalcularPerimetro();

            MessageBox.Show($"El Trapecio tiene una área de {areaTrapecio} y un perimetro de {perimetroTrapecio}");

        }
    }
}
