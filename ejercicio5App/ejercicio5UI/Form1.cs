using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace ejercicio5UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
  
        }

        private void selccionarButton_Click(object sender, EventArgs e)
        {
            string seleccion = seleccionFiguraComboBox.Text;
            switch(seleccion)
            {
                case "Trapecio":
                    TrapecioForm trapecioForm = new TrapecioForm();
                    trapecioForm.Show();
                    break;

                case "Pentagono":
                    PentagonoForm pentagonoForm = new PentagonoForm();
                    pentagonoForm.Show(); 
                    break;

                default:
                    MessageBox.Show("Opcion no válida");
                    break;
            }
             


        }
    }
}
