
namespace Agencia
{
    partial class Factura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboCiudad = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidadPersonas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorTiquete = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorComida = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtValorAlojamiento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiasAlojamiento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTotalAlojamiento = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTotalComida = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotalTiquete = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txtCiudad = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.txtPagoTotal = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtDescuentos = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.btnLiquidar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarCedula = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnReserva = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboCiudad
            // 
            this.comboCiudad.FormattingEnabled = true;
            this.comboCiudad.ItemHeight = 15;
            this.comboCiudad.Items.AddRange(new object[] {
            "Seleccione",
            "Ciudad A",
            "Ciudad B",
            "Ciudad C",
            "Ciudad D"});
            this.comboCiudad.Location = new System.Drawing.Point(36, 51);
            this.comboCiudad.Name = "comboCiudad";
            this.comboCiudad.Size = new System.Drawing.Size(137, 23);
            this.comboCiudad.TabIndex = 0;
            this.comboCiudad.SelectedValueChanged += new System.EventHandler(this.comboCiudad_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(36, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero Personas";
            // 
            // txtCantidadPersonas
            // 
            this.txtCantidadPersonas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadPersonas.Location = new System.Drawing.Point(36, 108);
            this.txtCantidadPersonas.Name = "txtCantidadPersonas";
            this.txtCantidadPersonas.Size = new System.Drawing.Size(137, 16);
            this.txtCantidadPersonas.TabIndex = 21;
            this.txtCantidadPersonas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCantidadPersonas.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(31, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "_____________________________________________";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(212, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Valor Tiquete / Persona";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(212, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Valor Comida Diario / Persona";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(212, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 15);
            this.label6.TabIndex = 25;
            this.label6.Text = "Valor Alojamiento Diario / Persona";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(212, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Días Alojamiento";
            // 
            // txtValorTiquete
            // 
            this.txtValorTiquete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorTiquete.Enabled = false;
            this.txtValorTiquete.Location = new System.Drawing.Point(418, 40);
            this.txtValorTiquete.Name = "txtValorTiquete";
            this.txtValorTiquete.Size = new System.Drawing.Size(137, 16);
            this.txtValorTiquete.TabIndex = 27;
            this.txtValorTiquete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(413, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "_____________________________________________";
            // 
            // txtValorComida
            // 
            this.txtValorComida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorComida.Enabled = false;
            this.txtValorComida.Location = new System.Drawing.Point(418, 72);
            this.txtValorComida.Name = "txtValorComida";
            this.txtValorComida.Size = new System.Drawing.Size(137, 16);
            this.txtValorComida.TabIndex = 29;
            this.txtValorComida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(413, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 20);
            this.label9.TabIndex = 30;
            this.label9.Text = "_____________________________________________";
            // 
            // txtValorAlojamiento
            // 
            this.txtValorAlojamiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorAlojamiento.Enabled = false;
            this.txtValorAlojamiento.Location = new System.Drawing.Point(418, 104);
            this.txtValorAlojamiento.Name = "txtValorAlojamiento";
            this.txtValorAlojamiento.Size = new System.Drawing.Size(137, 16);
            this.txtValorAlojamiento.TabIndex = 31;
            this.txtValorAlojamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(413, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "_____________________________________________";
            // 
            // txtDiasAlojamiento
            // 
            this.txtDiasAlojamiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiasAlojamiento.Enabled = false;
            this.txtDiasAlojamiento.Location = new System.Drawing.Point(418, 134);
            this.txtDiasAlojamiento.Name = "txtDiasAlojamiento";
            this.txtDiasAlojamiento.Size = new System.Drawing.Size(137, 16);
            this.txtDiasAlojamiento.TabIndex = 33;
            this.txtDiasAlojamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(413, 143);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 20);
            this.label11.TabIndex = 34;
            this.label11.Text = "_____________________________________________";
            // 
            // txtTotalAlojamiento
            // 
            this.txtTotalAlojamiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalAlojamiento.Enabled = false;
            this.txtTotalAlojamiento.Location = new System.Drawing.Point(720, 104);
            this.txtTotalAlojamiento.Name = "txtTotalAlojamiento";
            this.txtTotalAlojamiento.Size = new System.Drawing.Size(137, 16);
            this.txtTotalAlojamiento.TabIndex = 43;
            this.txtTotalAlojamiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(715, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(155, 20);
            this.label13.TabIndex = 44;
            this.label13.Text = "_____________________________________________";
            // 
            // txtTotalComida
            // 
            this.txtTotalComida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalComida.Enabled = false;
            this.txtTotalComida.Location = new System.Drawing.Point(720, 72);
            this.txtTotalComida.Name = "txtTotalComida";
            this.txtTotalComida.Size = new System.Drawing.Size(137, 16);
            this.txtTotalComida.TabIndex = 41;
            this.txtTotalComida.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(715, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(155, 20);
            this.label14.TabIndex = 42;
            this.label14.Text = "_____________________________________________";
            // 
            // txtTotalTiquete
            // 
            this.txtTotalTiquete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalTiquete.Enabled = false;
            this.txtTotalTiquete.Location = new System.Drawing.Point(720, 40);
            this.txtTotalTiquete.Name = "txtTotalTiquete";
            this.txtTotalTiquete.Size = new System.Drawing.Size(137, 16);
            this.txtTotalTiquete.TabIndex = 39;
            this.txtTotalTiquete.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(715, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(155, 20);
            this.label15.TabIndex = 40;
            this.label15.Text = "_____________________________________________";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(598, 111);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 15);
            this.label17.TabIndex = 37;
            this.label17.Text = "Total Alojamiento";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(598, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(78, 15);
            this.label18.TabIndex = 36;
            this.label18.Text = "Total Comida\r\n";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label19.Location = new System.Drawing.Point(598, 54);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 15);
            this.label19.TabIndex = 35;
            this.label19.Text = "Total Tiquete";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(36, 182);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 19);
            this.radioButton1.TabIndex = 45;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Efectivo";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(36, 207);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(101, 19);
            this.radioButton2.TabIndex = 46;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tarjeta Credito";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(370, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 15);
            this.label12.TabIndex = 47;
            this.label12.Text = "Tarifas Plan";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(686, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 15);
            this.label16.TabIndex = 48;
            this.label16.Text = "Liquidación Reserva";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label20.Location = new System.Drawing.Point(51, 9);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(105, 15);
            this.label20.TabIndex = 49;
            this.label20.Text = "Opciones de Viaje";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(31, 164);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(89, 15);
            this.label21.TabIndex = 50;
            this.label21.Text = "Forma de Pago";
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(418, 291);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(137, 16);
            this.txtTelefono.TabIndex = 61;
            // 
            // label22
            // 
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Location = new System.Drawing.Point(413, 300);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(155, 20);
            this.label22.TabIndex = 62;
            this.label22.Text = "_____________________________________________";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Location = new System.Drawing.Point(418, 261);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(137, 16);
            this.txtApellidos.TabIndex = 59;
            // 
            // label23
            // 
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label23.Location = new System.Drawing.Point(413, 270);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(155, 20);
            this.label23.TabIndex = 60;
            this.label23.Text = "_____________________________________________";
            // 
            // txtNombres
            // 
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombres.Enabled = false;
            this.txtNombres.Location = new System.Drawing.Point(418, 229);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(137, 16);
            this.txtNombres.TabIndex = 57;
            // 
            // label24
            // 
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label24.Location = new System.Drawing.Point(413, 238);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(155, 20);
            this.label24.TabIndex = 58;
            this.label24.Text = "_____________________________________________";
            // 
            // txtCedula
            // 
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Enabled = false;
            this.txtCedula.Location = new System.Drawing.Point(418, 197);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(137, 16);
            this.txtCedula.TabIndex = 55;
            // 
            // label25
            // 
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label25.Location = new System.Drawing.Point(413, 206);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(155, 20);
            this.label25.TabIndex = 56;
            this.label25.Text = "_____________________________________________";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label26.Location = new System.Drawing.Point(294, 299);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 15);
            this.label26.TabIndex = 54;
            this.label26.Text = "Telefono";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label27.Location = new System.Drawing.Point(294, 267);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(57, 15);
            this.label27.TabIndex = 53;
            this.label27.Text = "Apellidos";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label28.Location = new System.Drawing.Point(294, 236);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(58, 15);
            this.label28.TabIndex = 52;
            this.label28.Text = "Nombres\r\n";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label29.Location = new System.Drawing.Point(294, 210);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(44, 15);
            this.label29.TabIndex = 51;
            this.label29.Text = "Cedula";
            // 
            // txtCiudad
            // 
            this.txtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCiudad.Enabled = false;
            this.txtCiudad.Location = new System.Drawing.Point(420, 380);
            this.txtCiudad.Name = "txtCiudad";
            this.txtCiudad.Size = new System.Drawing.Size(137, 16);
            this.txtCiudad.TabIndex = 71;
            // 
            // label31
            // 
            this.label31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label31.Location = new System.Drawing.Point(415, 389);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(155, 20);
            this.label31.TabIndex = 72;
            this.label31.Text = "_____________________________________________";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(420, 348);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(137, 16);
            this.txtEmail.TabIndex = 69;
            // 
            // label32
            // 
            this.label32.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label32.Location = new System.Drawing.Point(415, 357);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(155, 20);
            this.label32.TabIndex = 70;
            this.label32.Text = "_____________________________________________";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Location = new System.Drawing.Point(420, 316);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(137, 16);
            this.txtDireccion.TabIndex = 67;
            // 
            // label33
            // 
            this.label33.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label33.Location = new System.Drawing.Point(415, 325);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(155, 20);
            this.label33.TabIndex = 68;
            this.label33.Text = "_____________________________________________";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label35.Location = new System.Drawing.Point(296, 386);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(44, 15);
            this.label35.TabIndex = 65;
            this.label35.Text = "Ciudad";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label36.Location = new System.Drawing.Point(296, 355);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(36, 15);
            this.label36.TabIndex = 64;
            this.label36.Text = "Email";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label37.Location = new System.Drawing.Point(296, 329);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(60, 15);
            this.label37.TabIndex = 63;
            this.label37.Text = "Dirección";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label30.Location = new System.Drawing.Point(387, 178);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(46, 15);
            this.label30.TabIndex = 73;
            this.label30.Text = "Cliente";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label34.Location = new System.Drawing.Point(686, 176);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(99, 15);
            this.label34.TabIndex = 83;
            this.label34.Text = "Datos Pago Total";
            // 
            // txtPagoTotal
            // 
            this.txtPagoTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPagoTotal.Enabled = false;
            this.txtPagoTotal.Location = new System.Drawing.Point(720, 261);
            this.txtPagoTotal.Name = "txtPagoTotal";
            this.txtPagoTotal.Size = new System.Drawing.Size(137, 16);
            this.txtPagoTotal.TabIndex = 81;
            this.txtPagoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label38
            // 
            this.label38.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label38.Location = new System.Drawing.Point(715, 270);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(155, 20);
            this.label38.TabIndex = 82;
            this.label38.Text = "_____________________________________________";
            // 
            // txtDescuentos
            // 
            this.txtDescuentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuentos.Enabled = false;
            this.txtDescuentos.Location = new System.Drawing.Point(720, 229);
            this.txtDescuentos.Name = "txtDescuentos";
            this.txtDescuentos.Size = new System.Drawing.Size(137, 16);
            this.txtDescuentos.TabIndex = 79;
            this.txtDescuentos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label39
            // 
            this.label39.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label39.Location = new System.Drawing.Point(715, 238);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(155, 20);
            this.label39.TabIndex = 80;
            this.label39.Text = "_____________________________________________";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(720, 197);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(137, 16);
            this.txtSubtotal.TabIndex = 77;
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label40
            // 
            this.label40.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label40.Location = new System.Drawing.Point(715, 206);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(155, 20);
            this.label40.TabIndex = 78;
            this.label40.Text = "_____________________________________________";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label41.Location = new System.Drawing.Point(598, 268);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(64, 15);
            this.label41.TabIndex = 76;
            this.label41.Text = "Pago Total";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label42.Location = new System.Drawing.Point(598, 237);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(72, 15);
            this.label42.TabIndex = 75;
            this.label42.Text = "Descuentos";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label43.Location = new System.Drawing.Point(598, 211);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(54, 15);
            this.label43.TabIndex = 74;
            this.label43.Text = "Subtotal";
            // 
            // btnLiquidar
            // 
            this.btnLiquidar.Location = new System.Drawing.Point(603, 316);
            this.btnLiquidar.Name = "btnLiquidar";
            this.btnLiquidar.Size = new System.Drawing.Size(75, 30);
            this.btnLiquidar.TabIndex = 84;
            this.btnLiquidar.Text = "Liquidar";
            this.btnLiquidar.UseVisualStyleBackColor = true;
            this.btnLiquidar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(28, 317);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 30);
            this.btnBuscar.TabIndex = 85;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscarCedula
            // 
            this.txtBuscarCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarCedula.Location = new System.Drawing.Point(31, 274);
            this.txtBuscarCedula.Name = "txtBuscarCedula";
            this.txtBuscarCedula.Size = new System.Drawing.Size(137, 16);
            this.txtBuscarCedula.TabIndex = 86;
            // 
            // label44
            // 
            this.label44.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label44.Location = new System.Drawing.Point(26, 283);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(155, 20);
            this.label44.TabIndex = 87;
            this.label44.Text = "_____________________________________________";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label45.Location = new System.Drawing.Point(28, 256);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(86, 15);
            this.label45.TabIndex = 88;
            this.label45.Text = "Cedula Cliente";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(795, 315);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 30);
            this.btnNuevo.TabIndex = 89;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReserva
            // 
            this.btnReserva.Location = new System.Drawing.Point(700, 315);
            this.btnReserva.Name = "btnReserva";
            this.btnReserva.Size = new System.Drawing.Size(75, 30);
            this.btnReserva.TabIndex = 90;
            this.btnReserva.Text = "Reserva";
            this.btnReserva.UseVisualStyleBackColor = true;
            this.btnReserva.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(603, 366);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 30);
            this.btnActualizar.TabIndex = 91;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(900, 450);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnReserva);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.txtBuscarCedula);
            this.Controls.Add(this.label44);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLiquidar);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.txtPagoTotal);
            this.Controls.Add(this.label38);
            this.Controls.Add(this.txtDescuentos);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.label42);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.txtCiudad);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txtTotalAlojamiento);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTotalComida);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTotalTiquete);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtDiasAlojamiento);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtValorAlojamiento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtValorComida);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtValorTiquete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCantidadPersonas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboCiudad);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label22);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Factura";
            this.Text = "Factura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboCiudad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidadPersonas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorTiquete;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorComida;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtValorAlojamiento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiasAlojamiento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTotalAlojamiento;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTotalComida;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotalTiquete;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtCiudad;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtPagoTotal;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtDescuentos;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button btnLiquidar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscarCedula;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnReserva;
        private System.Windows.Forms.Button btnActualizar;
    }
}