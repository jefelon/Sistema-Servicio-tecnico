namespace Sistema_de_ventas_2018.Presentacion
{
    partial class FrmServicio_Vista
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
            this.dgvServicioLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicioLista)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(31, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 18);
            this.label1.TabIndex = 17;
            this.label1.Text = "LISTADO DE SERVICIOS:";
            // 
            // dgvServicioLista
            // 
            this.dgvServicioLista.AllowUserToAddRows = false;
            this.dgvServicioLista.AllowUserToDeleteRows = false;
            this.dgvServicioLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicioLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicioLista.Location = new System.Drawing.Point(12, 46);
            this.dgvServicioLista.Name = "dgvServicioLista";
            this.dgvServicioLista.ReadOnly = true;
            this.dgvServicioLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicioLista.Size = new System.Drawing.Size(634, 207);
            this.dgvServicioLista.TabIndex = 16;
            this.dgvServicioLista.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicioLista_CellContentClick);
           
            this.dgvServicioLista.DoubleClick += new System.EventHandler(this.dgvServicioLista_DoubleClick);
            // 
            // FrmServicio_Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 269);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvServicioLista);
            this.Name = "FrmServicio_Vista";
            this.Text = "FrmServicio_Vista";
            this.Load += new System.EventHandler(this.FrmServicio_Vista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicioLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvServicioLista;
    }
}