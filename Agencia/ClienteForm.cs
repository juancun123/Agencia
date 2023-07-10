using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Agencia.src.model;
namespace Agencia
{
    public partial class ClienteForm : Form
    {
        public ClienteForm()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombres.Text;
            string apellido = txtApellidos.Text;
            string cedula = txtCedula.Text;
            string telefono = txtTelefono.Text;
            string correo = txtEmail.Text;
            string direccion = txtDireccion.Text;
            string ciudad = txtCiudad.Text;

            if (validar(cedula, nombre, apellido, telefono, direccion, correo, ciudad))
            {
                ((Agencia)Parent.Parent).registrarCliente(cedula, nombre, apellido, telefono, direccion, correo, ciudad);
                MessageBox.Show(text: "Cliente registrado con exito.", caption: "Exito!", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
                btnRegistrar.Enabled = false;
                btnActualizar.Enabled = true;
                btnEliminar.Enabled = true;
            }            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = txtNombres.Text;
            string apellido = txtApellidos.Text;
            string cedula = txtCedula.Text;
            string telefono = txtTelefono.Text;
            string correo = txtEmail.Text;
            string direccion = txtDireccion.Text;
            string ciudad = txtCiudad.Text;
            if (validar(cedula, nombre, apellido, telefono, direccion, correo, ciudad))
            {
                ((Agencia)Parent.Parent).actualizarCliente(cedula, nombre, apellido, telefono, direccion, correo, ciudad);
                MessageBox.Show(text: "Cliente actualizado con exito.", caption: "Exito!", MessageBoxButtons.OK, icon: MessageBoxIcon.Information);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ((Agencia)Parent.Parent).eliminarCliente();
            btnEliminar.Enabled = false;
            btnActualizar.Enabled = false;
            btnRegistrar.Enabled = true;
            iniciar();
        }

        private bool validar(string cedula, string nombre, string apellido,string telefono, string direccion, string correo, string ciudad)
        {
            if (nombre== null || nombre.Trim() == "")
            {
                MessageBox.Show(text: "Debe ingresar el campo nombre", caption: "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            if (apellido == null || apellido.Trim() == "")
            {
                MessageBox.Show(text: "Debe ingresar el campo apellido", caption: "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            if (cedula == null || cedula.Trim() == "")
            {
                MessageBox.Show(text: "Debe ingresar el campo cedula", caption: "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            if (telefono == null || telefono.Trim() == "")
            {
                MessageBox.Show(text: "Debe ingresar el campo telefono", caption: "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            if (correo == null || correo.Trim() == "")
            {
                MessageBox.Show(text: "Debe ingresar el campo correo", caption: "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            if (direccion == null || direccion.Trim() == "")
            {
                MessageBox.Show(text: "Debe ingresar el campo direccion", caption: "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            if (ciudad == null || ciudad.Trim() == "")
            {
                MessageBox.Show(text: "Debe ingresar el campo ciudad", caption: "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public void iniciar()
        {
            Cliente cliente = ((Cliente)((Agencia)Parent.Parent).Cliente());
            if (cliente != null)
            {
                txtCedula.Text = cliente.Cedula;
                txtApellidos.Text = cliente.Apellidos;
                txtNombres.Text = cliente.Nombres;
                txtEmail.Text = cliente.Email;
                txtDireccion.Text = cliente.Direccion;
                txtCiudad.Text = cliente.Ciudad;
                txtTelefono.Text = cliente.Telefono;
            }
        }
    }
}
