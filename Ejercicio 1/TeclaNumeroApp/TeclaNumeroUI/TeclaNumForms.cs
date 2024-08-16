using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeclaNumeroUI
{
    public partial class TeclaNumForms : Form
    {
        public TeclaNumForms()
        {
            InitializeComponent();
        }

        private void teclaNumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsDigit(e.KeyChar))
                {
                    respuestaLabel.Text = $"Se presionó el número: {e.KeyChar}";
                }
                else
                {
                    respuestaLabel.Text = "";
                }
            }
            catch (Exception ex)
            {
                respuestaLabel.Text = "Se ha producido un error: " + ex.Message;
            }
        }
    }
}
