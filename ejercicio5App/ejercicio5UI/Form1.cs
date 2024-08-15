using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using ClassLibrary;

namespace ejercicio5UI
{
    public partial class Form1 : Form
    {
        private Pentagono miPentagono;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CalcularButton_Click(object sender, EventArgs e)

        {
            decimal longitudLado = Convert.ToDecimal(ladoPentagonoTextBox.Text);
            decimal apotema = Convert.ToDecimal(apotemaPentagonoTextBox.Text);
            miPentagono = new Pentagono(longitudLado, apotema);
        }
    }
}
