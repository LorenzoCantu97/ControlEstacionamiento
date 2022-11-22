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
        Admin Admin;
        Usuario Usuario;
        public Inicio()
        {
            InitializeComponent();       
        }

        //Inhabilita botón de login
        private void Inicio_Load(object sender, EventArgs e)
        {            
            inputId.Focus();
            btnLog.Enabled = false;
        }

        //Función para iniciar sesión
        private void btnLog_Click(object sender, EventArgs e)
        {
            string idAdmin = "1001";
            string pass = "1001";
            if (inputId.Text == idAdmin && inputPwd.Text == pass)
            {
                //Entra a sig pantalla de Admin
                Admin = new Admin(inputId.Text);
                Admin.Show();
                this.Hide();
            }
            else
            {
                //Entra a sig pantalla de Usuario
                Usuario = new Usuario(inputId.Text);
                Usuario.Show();
                this.Hide();
            }
        }

        //Cierra el programa
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Si todo es correcto, habilita el botón login
        private void controlBotones()
        {
            if (inputId.Text.All(Char.IsNumber) && inputId.Text.Length == 4)
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
                else if (inputId.Text.Trim() != String.Empty && inputId.Text.Length != 4)
                {
                    errorDatos.SetError(inputId, "Id inválido");
                }
                btnLog.Cursor = Cursors.No;
                btnLog.Enabled = false;
                inputId.Focus();
            }
        }

        //Evento que manda a llamar "controlBotones()" cada que cambia el texto del id
        private void inputId_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        //Se manda a llamar al cerrar sesión para volver a ventana Inicio
        public void showInicio()
        {
            inputId.Text = "";
            inputPwd.Text = "";
            this.Show();
        }
    }
}
