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
    public partial class Usuario : Form
    {
        string idUsuario;
        public Usuario(string id)
        {
            InitializeComponent();
            idUsuario = id;
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            saludo.Text += idUsuario;
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Program.Inicio.showInicio();
            this.Close();
        }
    }
}
