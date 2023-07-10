using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Agencia
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            txtContrasena.PasswordChar = '*';
            comboRol.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string idUsuario = txtCodigo.Text;
            string nombreUsuario= txtUsuario.Text;
            string contrasenia = txtContrasena.Text;
            string rol = comboRol.Text;
            if (!validar(idUsuario,nombreUsuario,contrasenia,rol))
            {
                return;
            }
            int rolUsuario = rol == "Administrador" ? 1:0;            
            ((Agencia)this.Parent.Parent).registro(idUsuario, nombreUsuario, contrasenia, rolUsuario);
            MessageBox.Show("Se ha realizado registro exitoso");
            bloquear();
        }
        private bool validar(string idUsuario, string nombreUsuario, string contrasenia, string rol)
        {
            if (idUsuario == null || idUsuario.Trim() == "")
            {
                MessageBox.Show(text: "Debe ingresar el campo codigo", caption: "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            if (nombreUsuario == null || nombreUsuario.Trim() == "")
            {
                MessageBox.Show(text: "Debe ingresar el campo usuario", caption: "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            if (contrasenia == null || contrasenia.Trim() == "")
            {
                MessageBox.Show(text: "Debe ingresar el campo contraseña", caption: "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            if (rol == null || rol.Trim() == "" || rol == "Seleccione")
            {
                MessageBox.Show(text: "Debe seleccioanar un rol", caption: "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            
            return true;
        }


        private void bloquear()
        {
            txtCodigo.Enabled = false;
            txtUsuario.Enabled = false;
            comboRol.Enabled = false;
            btnRegistro.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ((Agencia)this.Parent.Parent).nuevo();
            desbloquear();
        }

        private void desbloquear()
        {
            txtCodigo.Enabled = true;
            txtUsuario.Enabled = true;
            comboRol.Enabled = true;
            txtCodigo.Text = "";
            txtUsuario.Text = "";
            comboRol.SelectedIndex = 0;
            txtContrasena.Text = "";
            btnRegistro.Enabled = true;
        }

        public void cambioPestaña(String contrasena)
        {
            txtContrasena.Text = contrasena;
        }
    }
}
