using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Agencia.src.model;
namespace Agencia
{
    public partial class Agencia : Form
    {
        private Dictionary<string, Form> formularios;
        private string fActive;
        private Usuario usuario;
        private Tiquete tiquete;
        private Cliente cliente;

        public Agencia()
        {
            InitializeComponent();
            formularios = new Dictionary<string, Form>();
            Factura fFactura = new Factura();
            formularios.Add("factura", fFactura);
            registrarCliente("1090505", "Juan David", "Sanchez Mancilla", "12345678", "AV 1 Calle 2", "correo@cun.com", "Arauca");
            tiquete = new Tiquete();            
            usuario = new Usuario();
            Login fLogin = new Login();
            Registro fRegistro = new Registro();            
            ClienteForm fCliente = new ClienteForm();            
            formularios.Add("login", fLogin);
            formularios.Add("registro", fRegistro);            
            formularios.Add("cliente", fCliente);
            cambiarContenedor("login");
            btnFactura.Visible = false;
            btnCliente.Visible = false;
            this.btnCerrarSesion.Visible = false;
            lblFactura.Visible = false;
            lblClientee.Visible = false;
            
        }



        private void cambiarContenedor(string formulario)
        {
            Form form = formularios[formulario];
            if (formulario == "registro")
            {
                ((Registro)form).cambioPestaña(usuario.Contrasenia);
            }           
            if (fActive != "factura" && formulario == "factura")
            {
                this.Width = this.Width + 300;
            }
            if (fActive == "factura" && formulario != "factura")
            {
                this.Width = this.Width - 300;
            }
            
            if (fActive != null)
            {
                Form active = formularios[fActive];
                active.Visible = false;
                this.panel4.Controls.Remove(active);
            }
            form.TopLevel = false;
            fActive = formulario;
            this.panel4.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.TopMost = true;
            form.Show();
            if (formulario == "cliente")
            {
                ((ClienteForm)form).iniciar();
            }
            if(fActive == "factura")
            {
                ((Factura)form).limpiar();
            }
            if(fActive == "login")
            {
                ((Login)form).limpiar();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.lblRegistro.Visible = false;
            this.lblLogin.Visible = true;
            cambiarContenedor("login");
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {

            this.lblRegistro.Visible = true;
            this.lblLogin.Visible = false;
            cambiarContenedor("registro");

        }


        public void registro(string idUsuario, string nombreUsuario, string contrasenia, int rolUsuario)
        {
            usuario.Registro(idUsuario, nombreUsuario, contrasenia, rolUsuario);            
        }
        public void nuevo()
        {
            usuario = new Usuario();
        }

        public void login(string usuario, string contrasena)
        {
            string nombre = this.usuario.login(usuario, contrasena);
            if (nombre != null)
            {
                MessageBox.Show($"Bienvenido {nombre}");
                this.lblRegistro.Visible = false;
                this.lblLogin.Visible = false;
                this.lblFactura.Visible = true;                
                this.btnLogin.Enabled = false;
                this.btnRegistro.Enabled = false;
                this.btnCerrarSesion.Visible = true;
                this.btnCliente.Visible = true;                
                this.btnFactura.Visible = true;
                this.btnCerrarSesion.TabIndex = btnCliente.TabIndex + 1;
                cambiarContenedor("factura");
            }

        }

        public Object ingresarTarifas(string ciudad)
        {
            this.tiquete.Ciudad = ciudad;
            this.tiquete.reserva();
            return getClonTiquete();
        }
        public Object liquidar()
        {
            this.tiquete.Liquidar(tiquete.Ciudad,tiquete.DiasHospedaje,tiquete.NroTiquete);
            return getClonTiquete();
        }
        private Tiquete getClonTiquete()
        {
            Tiquete clon = new Tiquete();
            clon.CostoComida = tiquete.CostoComida;
            clon.CostoPersona = tiquete.CostoPersona;
            clon.DiasHospedaje = tiquete.DiasHospedaje;
            clon.CostoAlojamiento = tiquete.CostoAlojamiento;
            clon.NroTiquete = tiquete.NroTiquete;
            clon.TotalPago = tiquete.TotalPago;
            clon.Subtotal = tiquete.Subtotal;
            clon.Descuentos = tiquete.Descuentos;
            return clon;
        }

        public Object buscarCliente(string cedula)
        {
            if( cliente != null && cedula == cliente.Cedula)
            {
                Cliente clon = new Cliente();
                clon.Cedula = cliente.Cedula;
                clon.Nombres = cliente.Nombres;
                clon.Apellidos = cliente.Apellidos;
                clon.Ciudad = cliente.Ciudad;
                clon.Email = cliente.Email;
                clon.Telefono = cliente.Telefono;
                clon.Direccion = cliente.Direccion;
                return clon;
            }
            return null;
        }

        public Object Cliente()
        {
            if (cliente != null )
            {
                Cliente clon = new Cliente();
                clon.Cedula = cliente.Cedula;
                clon.Nombres = cliente.Nombres;
                clon.Apellidos = cliente.Apellidos;
                clon.Ciudad = cliente.Ciudad;
                clon.Email = cliente.Email;
                clon.Telefono = cliente.Telefono;
                clon.Direccion = cliente.Direccion;
                return clon;
            }
            return null;
        }
        
        public Object ingresarCantidadPersonas(int cantidad)
        {
            this.tiquete.NroTiquete = cantidad;
            return getClonTiquete();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ingresarFormaPago(string forma)
        {
            this.tiquete.Pago = forma;
        }

        public void registrarCliente(string cedula, string nombres, string apellidos, string telefono, string direccion, string email, string ciudad)
        {
            cliente = new Cliente();
            cliente.Registro(cedula, nombres, apellidos, telefono, direccion, email, ciudad);
           
        }
        public void actualizarCliente(string cedula, string nombres, string apellidos, string telefono, string direccion, string email, string ciudad)
        {            
            cliente.Actualizar(cedula, nombres, apellidos, telefono, direccion, email, ciudad);
            
        }
        
        public void eliminarCliente()
        {
            cliente.Eliminar();
            
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.lblClientee.Visible = true;
            this.lblFactura.Visible = false;
            lblClientee.BringToFront();
            
            cambiarContenedor("cliente");
        }

        private void btnFactura_Click(object sender, EventArgs e)
        {
            this.lblFactura.Visible = true;
            this.lblClientee.Visible = false;
            cambiarContenedor("factura");
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Se ha cerrado la sesión.");            
            this.lblLogin.Visible = true;
            this.lblFactura.Visible = false;
            this.lblClientee.Visible = false;
            this.btnLogin.Enabled = true;
            this.btnRegistro.Enabled = true;
            this.btnCliente.Visible = false;
            this.btnFactura.Visible = false;
            this.btnCerrarSesion.Visible = false;
            cambiarContenedor("login");
        }

        public void ActualizarContra(string contrasena)
        {
            this.usuario.ActualizarContra(contrasena);
        }
    }
}
