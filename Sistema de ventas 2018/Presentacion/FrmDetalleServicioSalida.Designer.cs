namespace Sistema_de_ventas_2018.Presentacion
{
    partial class FrmDetalleServicioSalida
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
            this.txtSalidaId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtServicioId = new System.Windows.Forms.TextBox();
            this.btnCargarServicio = new System.Windows.Forms.Button();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.txtDetalleServicioId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSalidaId
            // 
            this.txtSalidaId.Enabled = false;
            this.txtSalidaId.Location = new System.Drawing.Point(372, 9);
            this.txtSalidaId.Name = "txtSalidaId";
            this.txtSalidaId.Size = new System.Drawing.Size(65, 20);
            this.txtSalidaId.TabIndex = 33;
            this.txtSalidaId.Text = "IdSalida";
            this.txtSalidaId.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtServicioId);
            this.groupBox2.Controls.Add(this.btnCargarServicio);
            this.groupBox2.Controls.Add(this.txtServicio);
            this.groupBox2.Controls.Add(this.txtCantidad);
            this.groupBox2.Controls.Add(this.txtPrecio);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 56);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SERVICIO";
            // 
            // txtServicioId
            // 
            this.txtServicioId.Enabled = false;
            this.txtServicioId.Location = new System.Drawing.Point(6, 19);
            this.txtServicioId.Name = "txtServicioId";
            this.txtServicioId.Size = new System.Drawing.Size(41, 20);
            this.txtServicioId.TabIndex = 32;
            this.txtServicioId.Visible = false;
            // 
            // btnCargarServicio
            // 
            this.btnCargarServicio.Location = new System.Drawing.Point(570, 13);
            this.btnCargarServicio.Name = "btnCargarServicio";
            this.btnCargarServicio.Size = new System.Drawing.Size(57, 30);
            this.btnCargarServicio.TabIndex = 5;
            this.btnCargarServicio.Text = "........";
            this.btnCargarServicio.UseVisualStyleBackColor = true;
            this.btnCargarServicio.Click += new System.EventHandler(this.btnCargarServicio_Click);
            // 
            // txtServicio
            // 
            this.txtServicio.Location = new System.Drawing.Point(309, 19);
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(255, 20);
            this.txtServicio.TabIndex = 30;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(108, 19);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(52, 20);
            this.txtCantidad.TabIndex = 35;
            this.txtCantidad.Text = "1";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(232, 19);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(58, 20);
            this.txtPrecio.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "CANT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "PRECIO:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Location = new System.Drawing.Point(12, 101);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 56);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acciones";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(204, 14);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(109, 36);
            this.btnEditar.TabIndex = 39;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(454, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 36);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(330, 14);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(107, 36);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(91, 14);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(95, 36);
            this.btnNuevo.TabIndex = 0;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(12, 163);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(634, 207);
            this.dgvDatos.TabIndex = 36;
            this.dgvDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            this.dgvDatos.SelectionChanged += new System.EventHandler(this.dgvDatos_SelectionChanged);
            // 
            // txtDetalleServicioId
            // 
            this.txtDetalleServicioId.Enabled = false;
            this.txtDetalleServicioId.Location = new System.Drawing.Point(79, 13);
            this.txtDetalleServicioId.Name = "txtDetalleServicioId";
            this.txtDetalleServicioId.Size = new System.Drawing.Size(62, 20);
            this.txtDetalleServicioId.TabIndex = 34;
            this.txtDetalleServicioId.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "ID:";
            this.label1.Visible = false;
            // 
            // FrmDetalleServicioSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 382);
            this.Controls.Add(this.txtSalidaId);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtDetalleServicioId);
            this.Controls.Add(this.label1);
            this.Name = "FrmDetalleServicioSalida";
            this.Text = "FrmDetalleServicioSalida";
            this.Load += new System.EventHandler(this.FrmDetalleServicioSalida_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox txtSalidaId;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox txtServicioId;
        private System.Windows.Forms.Button btnCargarServicio;
        public System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox txtDetalleServicioId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnEditar;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
    }
}