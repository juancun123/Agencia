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
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();            
            limpiar();


        }

        private void comboCiudad_SelectedValueChanged(object sender, EventArgs e)
        {
            if (null != this.Parent)
            {
                actualizarPrecioUnitario();
                actualizarCantidad();
            }
        }

        private void actualizarPrecioUnitario()
        {
            string ciudad = comboCiudad.Text;
            
            Tiquete tiquete = ((Tiquete)((Agencia)Parent.Parent).ingresarTarifas(ciudad));
            txtDiasAlojamiento.Text = tiquete.DiasHospedaje.ToString();
            txtValorAlojamiento.Text = tiquete.CostoAlojamiento.ToString();
            txtValorTiquete.Text = tiquete.CostoPersona.ToString();
            txtValorComida.Text = tiquete.CostoComida.ToString();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            actualizarCantidad();

        }

        private void actualizarCantidad()
        {
            string cantidadTxt = txtCantidadPersonas.Text;
            int cantidad = 0;
            if (cantidadTxt != null && cantidadTxt.Trim() != "")
            {
                cantidad = int.Parse(cantidadTxt);
            }
            Tiquete tiquete = ((Tiquete)((Agencia)Parent.Parent).ingresarCantidadPersonas(cantidad));
            float[] resultados = tiquete.Liquidar(tiquete.Ciudad,tiquete.DiasHospedaje,tiquete.NroTiquete);
            float totalTiquete = resultados[1];
            float totalComida = resultados[2];
            float totalAlojamiento = resultados[0];

            txtTotalComida.Text = totalComida.ToString();
            txtTotalTiquete.Text = totalTiquete.ToString();
            txtTotalAlojamiento.Text = totalAlojamiento.ToString();

        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            Tiquete tiquete = ((Tiquete)((Agencia)Parent.Parent).liquidar());
            txtSubtotal.Text = tiquete.Subtotal.ToString();
            txtPagoTotal.Text = tiquete.TotalPago.ToString();
            txtDescuentos.Text = tiquete.Descuentos.ToString();            
        }
        private bool validar()
        {
            if (txtCedula == null || txtCedula.Text.Trim() == "")
            {
                MessageBox.Show(this, text: "Para reservar debes seleccionar un cliente.", caption: "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show(this, text: "Para reservar debes seleccionar un metodo de pago.", caption: "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            if (txtCantidadPersonas.Text == null || txtCantidadPersonas.Text.Trim() == "" || int.Parse(txtCantidadPersonas.Text) == 0)
            {
                MessageBox.Show(this, text: "Para reservar debes seleccionar por lo menos 1 persona.", caption: "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            if (comboCiudad.SelectedIndex == 0 || comboCiudad.Text == "Seleccione")
            {
                MessageBox.Show(this, text: "Para reservar debes seleccionar una ciudad.", caption: "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void radioButton1_Click(object sender, EventArgs e)
        {
            ((Agencia)Parent.Parent).ingresarFormaPago(radioButton1.Text);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ((Agencia)Parent.Parent).ingresarFormaPago(radioButton2.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cedula = txtBuscarCedula.Text;
            Cliente cliente = (Cliente)((Agencia)Parent.Parent).buscarCliente(cedula);
            if(cliente == null)
            {
                MessageBox.Show(this,text: "No se ha encontrado cliente asociado a la cedula ingresada.", caption: "Error", MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return;
            }            
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

        public void limpiar()
        {
            txtCantidadPersonas.Text = "";
            comboCiudad.SelectedIndex = 0;
            txtSubtotal.Text ="0";
            txtPagoTotal.Text = "0";
            txtDescuentos.Text = "0";
            txtCedula.Text = "";
            txtApellidos.Text = "";
            txtNombres.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtTelefono.Text = "";
            txtBuscarCedula.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtCantidadPersonas.Enabled = true;
            comboCiudad.Enabled = true;
            txtBuscarCedula.Enabled = true;
            btnBuscar.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            btnLiquidar.Enabled = false;
            btnActualizar.Enabled = false;            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!validar())
            {
                return;
            }
            txtCantidadPersonas.Enabled = false;
            comboCiudad.Enabled = false;
            txtBuscarCedula.Enabled = false;
            btnBuscar.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            btnLiquidar.Enabled = true;
            btnActualizar.Enabled = true;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            txtCantidadPersonas.Enabled = true;
            comboCiudad.Enabled = true;
            txtBuscarCedula.Enabled = true;
            btnBuscar.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            btnLiquidar.Enabled = false;
            btnActualizar.Enabled = false;
            txtSubtotal.Text = "0";
            txtPagoTotal.Text = "0";
            txtDescuentos.Text = "0";
        }
    }
}
