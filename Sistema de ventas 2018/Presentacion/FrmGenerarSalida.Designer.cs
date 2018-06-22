namespace Sistema_de_ventas_2018.Presentacion
{
    partial class FrmGenerarSalida
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
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNumeroSalida = new System.Windows.Forms.Label();
            this.lblIdSalida = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(42, 104);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 27);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblNumeroSalida
            // 
            this.lblNumeroSalida.AutoSize = true;
            this.lblNumeroSalida.Location = new System.Drawing.Point(117, 33);
            this.lblNumeroSalida.Name = "lblNumeroSalida";
            this.lblNumeroSalida.Size = new System.Drawing.Size(35, 13);
            this.lblNumeroSalida.TabIndex = 1;
            this.lblNumeroSalida.Text = "label1";
            this.lblNumeroSalida.Visible = false;
            // 
            // lblIdSalida
            // 
            this.lblIdSalida.AutoSize = true;
            this.lblIdSalida.Location = new System.Drawing.Point(26, 33);
            this.lblIdSalida.Name = "lblIdSalida";
            this.lblIdSalida.Size = new System.Drawing.Size(35, 13);
            this.lblIdSalida.TabIndex = 2;
            this.lblIdSalida.Text = "label1";
            this.lblIdSalida.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(161, 104);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 27);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Generando Item de salida...";
            // 
            // FrmGenerarSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 143);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblIdSalida);
            this.Controls.Add(this.lblNumeroSalida);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Name = "FrmGenerarSalida";
            this.Text = "FrmGenerarSalida";
            this.Load += new System.EventHandler(this.FrmGenerarSalida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNumeroSalida;
        private System.Windows.Forms.Label lblIdSalida;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
    }
}