using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlEstacionamiento
{
    public partial class Inicio : Form
    {   
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            inputId.Focus();
            btnLog.Enabled = false;
        }

        private void btnLog_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void controlBotones()
        {
            if (inputId.Text.Trim() != String.Empty && inputId.Text.All(Char.IsNumber) && inputId.Text.Length == 4)
            {
                errorDatos.SetError(inputId, "");
                btnLog.Cursor = Cursors.Hand;
                btnLog.Enabled = true;
            } 
            else
            {
                if (!(inputId.Text.All(Char.IsNumber)))
                {
                    errorDatos.SetError(inputId, "El id solo puede contener numeros");
                }
                else if (inputId.Text.Length != 4)
                {
                    errorDatos.SetError(inputId, "Id inválido");
                }
                btnLog.Cursor = Cursors.No;
                btnLog.Enabled = false;
                inputId.Focus();
            }
        }

        private void inputId_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }
    }
}
