namespace Sistema_de_ventas_2018.Presentacion
{
    partial class FrmSalida_Vista
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListaSalida = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(31, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "LISTA DE SALIDA:";
            // 
            // dgvListaSalida
            // 
            this.dgvListaSalida.AllowUserToAddRows = false;
            this.dgvListaSalida.AllowUserToDeleteRows = false;
            this.dgvListaSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaSalida.Location = new System.Drawing.Point(12, 50);
            this.dgvListaSalida.Name = "dgvListaSalida";
            this.dgvListaSalida.ReadOnly = true;
            this.dgvListaSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaSalida.Size = new System.Drawing.Size(634, 207);
            this.dgvListaSalida.TabIndex = 16;
            this.dgvListaSalida.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaSalida_CellContentClick);
            this.dgvListaSalida.DoubleClick += new System.EventHandler(this.dgvListaSalida_DoubleClick);
            // 
            // FrmSalida_Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 271);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaSalida);
            this.Name = "FrmSalida_Vista";
            this.Text = "FrmSalida_Vista";
            this.Load += new System.EventHandler(this.FrmSalida_Vista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListaSalida;
    }
}