
namespace Quiz
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.ImgBanco = new System.Windows.Forms.PictureBox();
            this.LblTitulo = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblDocumento = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtDocumento = new System.Windows.Forms.TextBox();
            this.LblFecha = new System.Windows.Forms.Label();
            this.DtpFecha = new System.Windows.Forms.DateTimePicker();
            this.CkbMasculino = new System.Windows.Forms.CheckBox();
            this.CkbFemenino = new System.Windows.Forms.CheckBox();
            this.LblGenero = new System.Windows.Forms.Label();
            this.LblServicios = new System.Windows.Forms.Label();
            this.CkLServicios = new System.Windows.Forms.CheckedListBox();
            this.CbCiudad = new System.Windows.Forms.ComboBox();
            this.LblCiudad = new System.Windows.Forms.Label();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.RtxtResultados = new System.Windows.Forms.RichTextBox();
            this.TxtBGuardado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgBanco)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgBanco
            // 
            this.ImgBanco.BackColor = System.Drawing.Color.Transparent;
            this.ImgBanco.Image = ((System.Drawing.Image)(resources.GetObject("ImgBanco.Image")));
            this.ImgBanco.Location = new System.Drawing.Point(-1, -2);
            this.ImgBanco.Name = "ImgBanco";
            this.ImgBanco.Size = new System.Drawing.Size(122, 131);
            this.ImgBanco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ImgBanco.TabIndex = 0;
            this.ImgBanco.TabStop = false;
            // 
            // LblTitulo
            // 
            this.LblTitulo.AutoSize = true;
            this.LblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LblTitulo.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitulo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LblTitulo.Location = new System.Drawing.Point(162, 9);
            this.LblTitulo.Name = "LblTitulo";
            this.LblTitulo.Size = new System.Drawing.Size(757, 41);
            this.LblTitulo.TabIndex = 3;
            this.LblTitulo.Text = "FORMULARIO - REGISTRO NUEVO USUARIO";
            this.LblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.Color.Transparent;
            this.LblNombre.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(363, 154);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(101, 24);
            this.LblNombre.TabIndex = 4;
            this.LblNombre.Text = "NOMBRE";
            // 
            // LblDocumento
            // 
            this.LblDocumento.AutoSize = true;
            this.LblDocumento.BackColor = System.Drawing.Color.Transparent;
            this.LblDocumento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDocumento.Location = new System.Drawing.Point(341, 194);
            this.LblDocumento.Name = "LblDocumento";
            this.LblDocumento.Size = new System.Drawing.Size(144, 24);
            this.LblDocumento.TabIndex = 5;
            this.LblDocumento.Text = "DOCUMENTO";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(491, 154);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(301, 22);
            this.TxtNombre.TabIndex = 6;
            // 
            // TxtDocumento
            // 
            this.TxtDocumento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocumento.Location = new System.Drawing.Point(491, 194);
            this.TxtDocumento.Name = "TxtDocumento";
            this.TxtDocumento.Size = new System.Drawing.Size(301, 22);
            this.TxtDocumento.TabIndex = 7;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.Transparent;
            this.LblFecha.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.Location = new System.Drawing.Point(364, 64);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(229, 24);
            this.LblFecha.TabIndex = 8;
            this.LblFecha.Text = "FECHA DE REGISTRO";
            // 
            // DtpFecha
            // 
            this.DtpFecha.CalendarFont = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFecha.Location = new System.Drawing.Point(327, 91);
            this.DtpFecha.Name = "DtpFecha";
            this.DtpFecha.Size = new System.Drawing.Size(301, 26);
            this.DtpFecha.TabIndex = 9;
            // 
            // CkbMasculino
            // 
            this.CkbMasculino.AutoSize = true;
            this.CkbMasculino.BackColor = System.Drawing.Color.Transparent;
            this.CkbMasculino.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbMasculino.Location = new System.Drawing.Point(490, 232);
            this.CkbMasculino.Name = "CkbMasculino";
            this.CkbMasculino.Size = new System.Drawing.Size(103, 20);
            this.CkbMasculino.TabIndex = 10;
            this.CkbMasculino.Text = "MASCULINO";
            this.CkbMasculino.UseVisualStyleBackColor = false;
            // 
            // CkbFemenino
            // 
            this.CkbFemenino.AutoSize = true;
            this.CkbFemenino.BackColor = System.Drawing.Color.Transparent;
            this.CkbFemenino.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkbFemenino.Location = new System.Drawing.Point(604, 232);
            this.CkbFemenino.Name = "CkbFemenino";
            this.CkbFemenino.Size = new System.Drawing.Size(95, 20);
            this.CkbFemenino.TabIndex = 11;
            this.CkbFemenino.Text = "FEMENINO";
            this.CkbFemenino.UseVisualStyleBackColor = false;
            // 
            // LblGenero
            // 
            this.LblGenero.AutoSize = true;
            this.LblGenero.BackColor = System.Drawing.Color.Transparent;
            this.LblGenero.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenero.Location = new System.Drawing.Point(363, 232);
            this.LblGenero.Name = "LblGenero";
            this.LblGenero.Size = new System.Drawing.Size(99, 24);
            this.LblGenero.TabIndex = 12;
            this.LblGenero.Text = "GENERO";
            // 
            // LblServicios
            // 
            this.LblServicios.AutoSize = true;
            this.LblServicios.BackColor = System.Drawing.Color.Transparent;
            this.LblServicios.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblServicios.Location = new System.Drawing.Point(578, 302);
            this.LblServicios.Name = "LblServicios";
            this.LblServicios.Size = new System.Drawing.Size(121, 24);
            this.LblServicios.TabIndex = 13;
            this.LblServicios.Text = "SERVICIOS";
            // 
            // CkLServicios
            // 
            this.CkLServicios.BackColor = System.Drawing.Color.AliceBlue;
            this.CkLServicios.CheckOnClick = true;
            this.CkLServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkLServicios.FormattingEnabled = true;
            this.CkLServicios.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.CkLServicios.Items.AddRange(new object[] {
            "CREAR CUENTA DE AHORROS",
            "CREAR CUENTA DE CREDITO",
            "SOLICITAR PRESTAMO",
            "SOLICITAR ASESORIA",
            "APOYO A EMPRENDIMIENTOS"});
            this.CkLServicios.Location = new System.Drawing.Point(524, 329);
            this.CkLServicios.Name = "CkLServicios";
            this.CkLServicios.Size = new System.Drawing.Size(227, 89);
            this.CkLServicios.TabIndex = 14;
            // 
            // CbCiudad
            // 
            this.CbCiudad.AutoCompleteCustomSource.AddRange(new string[] {
            "BUCARAMANGA",
            "GIRON",
            "PIEDECUESTA",
            "FLORIDABLANCA",
            "SAN GIL",
            "CUCUTA",
            "BARRANCABERMEJA",
            "MEDELLIN ",
            "CALI"});
            this.CbCiudad.FormattingEnabled = true;
            this.CbCiudad.Items.AddRange(new object[] {
            "BUCARAMANGA",
            "FLORIDABLANCA",
            "PIEDECUESTA",
            "GIRON",
            "SAN GIL",
            "CUCUTA",
            "BARRANCABERMEJA",
            "MEDELLIN",
            "CALI"});
            this.CbCiudad.Location = new System.Drawing.Point(681, 96);
            this.CbCiudad.Name = "CbCiudad";
            this.CbCiudad.Size = new System.Drawing.Size(215, 21);
            this.CbCiudad.TabIndex = 15;
            // 
            // LblCiudad
            // 
            this.LblCiudad.AutoSize = true;
            this.LblCiudad.BackColor = System.Drawing.Color.Transparent;
            this.LblCiudad.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCiudad.Location = new System.Drawing.Point(673, 64);
            this.LblCiudad.Name = "LblCiudad";
            this.LblCiudad.Size = new System.Drawing.Size(238, 24);
            this.LblCiudad.TabIndex = 16;
            this.LblCiudad.Text = "CIUDAD DE REGISTRO";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(471, 465);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(157, 38);
            this.BtnGuardar.TabIndex = 17;
            this.BtnGuardar.Text = "GUARDAR";
            this.BtnGuardar.UseVisualStyleBackColor = false;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnReporte
            // 
            this.BtnReporte.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtnReporte.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReporte.Location = new System.Drawing.Point(681, 465);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(157, 38);
            this.BtnReporte.TabIndex = 18;
            this.BtnReporte.Text = "REPORTE";
            this.BtnReporte.UseVisualStyleBackColor = false;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // RtxtResultados
            // 
            this.RtxtResultados.BackColor = System.Drawing.Color.AliceBlue;
            this.RtxtResultados.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RtxtResultados.Location = new System.Drawing.Point(-1, 146);
            this.RtxtResultados.Name = "RtxtResultados";
            this.RtxtResultados.Size = new System.Drawing.Size(322, 484);
            this.RtxtResultados.TabIndex = 19;
            this.RtxtResultados.Text = "";
            // 
            // TxtBGuardado
            // 
            this.TxtBGuardado.Location = new System.Drawing.Point(127, 120);
            this.TxtBGuardado.Name = "TxtBGuardado";
            this.TxtBGuardado.Size = new System.Drawing.Size(100, 20);
            this.TxtBGuardado.TabIndex = 20;
            this.TxtBGuardado.Visible = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(968, 642);
            this.Controls.Add(this.TxtBGuardado);
            this.Controls.Add(this.RtxtResultados);
            this.Controls.Add(this.BtnReporte);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.LblCiudad);
            this.Controls.Add(this.CbCiudad);
            this.Controls.Add(this.CkLServicios);
            this.Controls.Add(this.LblServicios);
            this.Controls.Add(this.LblGenero);
            this.Controls.Add(this.CkbFemenino);
            this.Controls.Add(this.CkbMasculino);
            this.Controls.Add(this.DtpFecha);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.TxtDocumento);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblDocumento);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.LblTitulo);
            this.Controls.Add(this.ImgBanco);
            this.Name = "Home";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.ImgBanco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgBanco;
        private System.Windows.Forms.Label LblTitulo;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblDocumento;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtDocumento;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.DateTimePicker DtpFecha;
        private System.Windows.Forms.CheckBox CkbMasculino;
        private System.Windows.Forms.CheckBox CkbFemenino;
        private System.Windows.Forms.Label LblGenero;
        private System.Windows.Forms.Label LblServicios;
        private System.Windows.Forms.CheckedListBox CkLServicios;
        private System.Windows.Forms.ComboBox CbCiudad;
        private System.Windows.Forms.Label LblCiudad;
        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnReporte;
        private System.Windows.Forms.TextBox TxtBGuardado;
        public System.Windows.Forms.RichTextBox RtxtResultados;
    }
}