namespace PFormulario
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtapel = new System.Windows.Forms.TextBox();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.cmbestado = new System.Windows.Forms.ComboBox();
            this.txtmunicipio = new System.Windows.Forms.TextBox();
            this.txtzona = new System.Windows.Forms.TextBox();
            this.txtinfo = new System.Windows.Forms.TextBox();
            this.txttel = new System.Windows.Forms.TextBox();
            this.txtcel = new System.Windows.Forms.TextBox();
            this.txtcalle = new System.Windows.Forms.TextBox();
            this.cmbciudad = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.cmbciudad);
            this.groupBox1.Controls.Add(this.cmbestado);
            this.groupBox1.Controls.Add(this.txtcalle);
            this.groupBox1.Controls.Add(this.txtcel);
            this.groupBox1.Controls.Add(this.txttel);
            this.groupBox1.Controls.Add(this.txtinfo);
            this.groupBox1.Controls.Add(this.txtzona);
            this.groupBox1.Controls.Add(this.txtmunicipio);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.txtapel);
            this.groupBox1.Controls.Add(this.txtnom);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INFORMACIÓN DE ENTREGA";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(6, 67);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(203, 20);
            this.txtcodigo.TabIndex = 5;
            this.txtcodigo.Text = "Código Postal*";
            // 
            // txtapel
            // 
            this.txtapel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtapel.Location = new System.Drawing.Point(236, 26);
            this.txtapel.Name = "txtapel";
            this.txtapel.Size = new System.Drawing.Size(203, 20);
            this.txtapel.TabIndex = 4;
            this.txtapel.Text = "Apellidos*";
            // 
            // txtnom
            // 
            this.txtnom.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnom.Location = new System.Drawing.Point(6, 26);
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(203, 20);
            this.txtnom.TabIndex = 3;
            this.txtnom.Text = "Nombre*";
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(295, 354);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 1;
            this.btnnuevo.Text = "Enviar";
            this.btnnuevo.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(376, 354);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 3;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // cmbestado
            // 
            this.cmbestado.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbestado.FormattingEnabled = true;
            this.cmbestado.Items.AddRange(new object[] {
            "Excelente!!",
            "Buena.",
            "Medio.",
            "Pésimo."});
            this.cmbestado.Location = new System.Drawing.Point(236, 292);
            this.cmbestado.Name = "cmbestado";
            this.cmbestado.Size = new System.Drawing.Size(203, 23);
            this.cmbestado.TabIndex = 4;
            this.cmbestado.Text = "Estado del Producto*";
            // 
            // txtmunicipio
            // 
            this.txtmunicipio.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmunicipio.Location = new System.Drawing.Point(236, 251);
            this.txtmunicipio.Name = "txtmunicipio";
            this.txtmunicipio.Size = new System.Drawing.Size(203, 20);
            this.txtmunicipio.TabIndex = 7;
            this.txtmunicipio.Text = "Municipio*";
            // 
            // txtzona
            // 
            this.txtzona.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtzona.Location = new System.Drawing.Point(6, 251);
            this.txtzona.Name = "txtzona";
            this.txtzona.Size = new System.Drawing.Size(203, 20);
            this.txtzona.TabIndex = 8;
            this.txtzona.Text = "Zona*";
            // 
            // txtinfo
            // 
            this.txtinfo.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinfo.Location = new System.Drawing.Point(6, 206);
            this.txtinfo.Name = "txtinfo";
            this.txtinfo.Size = new System.Drawing.Size(433, 20);
            this.txtinfo.TabIndex = 9;
            this.txtinfo.Text = "Información Adicional*";
            // 
            // txttel
            // 
            this.txttel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttel.Location = new System.Drawing.Point(236, 158);
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(203, 20);
            this.txttel.TabIndex = 10;
            this.txttel.Text = "Número de Teléfono*";
            // 
            // txtcel
            // 
            this.txtcel.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcel.Location = new System.Drawing.Point(6, 158);
            this.txtcel.Name = "txtcel";
            this.txtcel.Size = new System.Drawing.Size(203, 20);
            this.txtcel.TabIndex = 11;
            this.txtcel.Text = "Número de Celular*";
            // 
            // txtcalle
            // 
            this.txtcalle.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcalle.Location = new System.Drawing.Point(6, 111);
            this.txtcalle.Name = "txtcalle";
            this.txtcalle.Size = new System.Drawing.Size(433, 20);
            this.txtcalle.TabIndex = 12;
            this.txtcalle.Text = "Calle*";
            // 
            // cmbciudad
            // 
            this.cmbciudad.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbciudad.FormattingEnabled = true;
            this.cmbciudad.Items.AddRange(new object[] {
            "Sucre.",
            "La Paz.",
            "Cochabamba.",
            "Potosí.",
            "Oruro.",
            "Tarija.",
            "Beni.",
            "Pando.",
            "Santa Cruz."});
            this.cmbciudad.Location = new System.Drawing.Point(6, 292);
            this.cmbciudad.Name = "cmbciudad";
            this.cmbciudad.Size = new System.Drawing.Size(203, 23);
            this.cmbciudad.TabIndex = 13;
            this.cmbciudad.Text = "Ciudad*";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(473, 389);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnsalir);
            this.Name = "Form1";
            this.Text = "Registro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtapel;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.ComboBox cmbciudad;
        private System.Windows.Forms.ComboBox cmbestado;
        private System.Windows.Forms.TextBox txtcalle;
        private System.Windows.Forms.TextBox txtcel;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.TextBox txtinfo;
        private System.Windows.Forms.TextBox txtzona;
        private System.Windows.Forms.TextBox txtmunicipio;
    }
}

