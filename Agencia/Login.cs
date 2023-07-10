using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agencia
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtContrasena.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text.Trim();
            string contrasena = txtContrasena.Text.Trim();
            if(usuario == null || usuario == "")
            {
                MessageBox.Show(text:"Debes ingresar usuario.", caption: "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return;
            }
            if (contrasena == null || contrasena == "")
            {
                MessageBox.Show(text: "Debes ingresar contraseña.", caption: "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return;
            }
            try
            {
                ((Agencia)this.Parent.Parent).login(usuario, contrasena);
            }
            catch(Exception exception)
            {
                MessageBox.Show(text: exception.Message,caption:"Error",MessageBoxButtons.OK,icon: MessageBoxIcon.Error);
            }
        }
    }
}
