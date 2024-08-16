using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace ejercicio5UI
{
    //Calculadora de área y perímetro de una figura
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
  
        }

        private void seleccionarButton_Click(object sender, EventArgs e)
        {
            //Elecciones que abren distintos formularios segun la figura
            try
            {
                string seleccion = seleccionFiguraComboBox.Text;

                if (string.IsNullOrWhiteSpace(seleccion))
                {
                    MessageBox.Show("Por favor, seleccione una figura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                switch (seleccion)
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
                        MessageBox.Show("Opción no válida. Por favor, seleccione una figura válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
