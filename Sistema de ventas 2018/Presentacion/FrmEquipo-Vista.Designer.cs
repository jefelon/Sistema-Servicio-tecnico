namespace Sistema_de_ventas_2018.Presentacion
{
    partial class FrmEquipo_Vista
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
            this.dgvListaEquipo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEquipo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaEquipo
            // 
            this.dgvListaEquipo.AllowUserToAddRows = false;
            this.dgvListaEquipo.AllowUserToDeleteRows = false;
            this.dgvListaEquipo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListaEquipo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaEquipo.Location = new System.Drawing.Point(12, 72);
            this.dgvListaEquipo.Name = "dgvListaEquipo";
            this.dgvListaEquipo.ReadOnly = true;
            this.dgvListaEquipo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaEquipo.Size = new System.Drawing.Size(634, 207);
            this.dgvListaEquipo.TabIndex = 14;
            this.dgvListaEquipo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellContentClick);
            this.dgvListaEquipo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaEquipo_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(31, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "LISTADO DE EQUIPO:";
            // 
            // FrmEquipo_Vista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 297);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListaEquipo);
            this.Name = "FrmEquipo_Vista";
            this.Text = "FrmEquipo_Vista";
            this.Load += new System.EventHandler(this.FrmEquipo_Vista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaEquipo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaEquipo;
        private System.Windows.Forms.Label label1;
    }
}