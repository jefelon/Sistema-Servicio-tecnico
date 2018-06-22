namespace Sistema_de_ventas_2018.Presentacion
{
    partial class FrmProducto_Vista
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
            this.dgvDatosProducto = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDatosProducto
            // 
            this.dgvDatosProducto.AllowUserToAddRows = false;
            this.dgvDatosProducto.AllowUserToDeleteRows = false;
            this.dgvDatosProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatosProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosProducto.Location = new System.Drawing.Point(12, 42);
            this.dgvDatosProducto.Name = "dgvDatosProducto";
            this.dgvDatosProducto.ReadOnly = true;
            this.dgvDatosProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatosProducto.Size = new System.Drawing.Size(1173, 309);
            this.dgvDatosProducto.TabIndex = 15;
            this.dgvDatosProducto.DoubleClick += new System.EventHandler(this.dgvDatos_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "LISTADO DE PRODUCTOS:";
            // 
            // FrmProducto_Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDatosProducto);
            this.Name = "FrmProducto_Vista";
            this.Text = "FrmProducto_Vista";
            this.Load += new System.EventHandler(this.FrmProducto_Vista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDatosProducto;
        private System.Windows.Forms.Label label1;
    }
}