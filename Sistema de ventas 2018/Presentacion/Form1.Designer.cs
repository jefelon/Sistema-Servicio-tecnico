namespace Sistema_de_ventas_2018
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
            this.components = new System.ComponentModel.Container();
            this.btnTpv = new System.Windows.Forms.Button();
            this.btnproveedores = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.lblHora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tablasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDocumentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unidadMedidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salidaEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasGeneralesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clasificaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kardexDeProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposPendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equiposReparadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTpv
            // 
            this.btnTpv.Image = global::Sistema_de_ventas_2018.Properties.Resources.registrator_box;
            this.btnTpv.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTpv.Location = new System.Drawing.Point(21, 244);
            this.btnTpv.Name = "btnTpv";
            this.btnTpv.Size = new System.Drawing.Size(103, 67);
            this.btnTpv.TabIndex = 0;
            this.btnTpv.Text = "TPV";
            this.btnTpv.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTpv.UseVisualStyleBackColor = true;
            this.btnTpv.Click += new System.EventHandler(this.btnTpv_Click);
            // 
            // btnproveedores
            // 
            this.btnproveedores.Image = global::Sistema_de_ventas_2018.Properties.Resources.proveedores;
            this.btnproveedores.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnproveedores.Location = new System.Drawing.Point(21, 327);
            this.btnproveedores.Name = "btnproveedores";
            this.btnproveedores.Size = new System.Drawing.Size(103, 67);
            this.btnproveedores.TabIndex = 0;
            this.btnproveedores.Text = "PROVEEDORES";
            this.btnproveedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnproveedores.UseVisualStyleBackColor = true;
            this.btnproveedores.Click += new System.EventHandler(this.btnproveedores_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.Image = global::Sistema_de_ventas_2018.Properties.Resources.partner;
            this.btnClientes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClientes.Location = new System.Drawing.Point(21, 159);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(103, 67);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Image = global::Sistema_de_ventas_2018.Properties.Resources.truck;
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompras.Location = new System.Drawing.Point(21, 75);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(103, 67);
            this.btnCompras.TabIndex = 0;
            this.btnCompras.Text = "COMPRAS";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.Black;
            this.lblHora.Location = new System.Drawing.Point(0, 630);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(120, 31);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "08:34:30";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Juan Peres - Administrador";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Sistema_de_ventas_2018.Properties.Resources.cerrar_sesion;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(974, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 45);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Cerrar Sesión");
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1004, 69);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Sistema_de_ventas_2018.Properties.Resources.online_user;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(12, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Conectado");
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablasToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.ventasToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.vistaVentaToolStripMenuItem,
            this.comprasGeneralesToolStripMenuItem,
            this.clasificaciónToolStripMenuItem,
            this.pendientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1004, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tablasToolStripMenuItem
            // 
            this.tablasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriasToolStripMenuItem,
            this.equiposToolStripMenuItem,
            this.tipoDocumentosToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.modeloToolStripMenuItem,
            this.productoToolStripMenuItem,
            this.serviciosToolStripMenuItem,
            this.unidadMedidaToolStripMenuItem,
            this.salidaToolStripMenuItem,
            this.ingresoEquiposToolStripMenuItem,
            this.salidaEquiposToolStripMenuItem,
            this.stockToolStripMenuItem,
            this.usuarioToolStripMenuItem});
            this.tablasToolStripMenuItem.Name = "tablasToolStripMenuItem";
            this.tablasToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.tablasToolStripMenuItem.Text = "Tablas";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // equiposToolStripMenuItem
            // 
            this.equiposToolStripMenuItem.Name = "equiposToolStripMenuItem";
            this.equiposToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.equiposToolStripMenuItem.Text = "Equipos";
            this.equiposToolStripMenuItem.Click += new System.EventHandler(this.equiposToolStripMenuItem_Click);
            // 
            // tipoDocumentosToolStripMenuItem
            // 
            this.tipoDocumentosToolStripMenuItem.Name = "tipoDocumentosToolStripMenuItem";
            this.tipoDocumentosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.tipoDocumentosToolStripMenuItem.Text = "Tipo Documentos";
            this.tipoDocumentosToolStripMenuItem.Click += new System.EventHandler(this.tipoDocumentosToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // modeloToolStripMenuItem
            // 
            this.modeloToolStripMenuItem.Name = "modeloToolStripMenuItem";
            this.modeloToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.modeloToolStripMenuItem.Text = "Modelo";
            this.modeloToolStripMenuItem.Click += new System.EventHandler(this.modeloToolStripMenuItem_Click);
            // 
            // productoToolStripMenuItem
            // 
            this.productoToolStripMenuItem.Name = "productoToolStripMenuItem";
            this.productoToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.productoToolStripMenuItem.Text = "Producto";
            this.productoToolStripMenuItem.Click += new System.EventHandler(this.productoToolStripMenuItem_Click);
            // 
            // serviciosToolStripMenuItem
            // 
            this.serviciosToolStripMenuItem.Name = "serviciosToolStripMenuItem";
            this.serviciosToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.serviciosToolStripMenuItem.Text = "Servicios";
            this.serviciosToolStripMenuItem.Click += new System.EventHandler(this.serviciosToolStripMenuItem_Click);
            // 
            // unidadMedidaToolStripMenuItem
            // 
            this.unidadMedidaToolStripMenuItem.Name = "unidadMedidaToolStripMenuItem";
            this.unidadMedidaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.unidadMedidaToolStripMenuItem.Text = "Unidad Medida";
            this.unidadMedidaToolStripMenuItem.Click += new System.EventHandler(this.unidadMedidaToolStripMenuItem_Click);
            // 
            // salidaToolStripMenuItem
            // 
            this.salidaToolStripMenuItem.Name = "salidaToolStripMenuItem";
            this.salidaToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.salidaToolStripMenuItem.Text = "Salida";
            this.salidaToolStripMenuItem.Click += new System.EventHandler(this.salidaToolStripMenuItem_Click);
            // 
            // ingresoEquiposToolStripMenuItem
            // 
            this.ingresoEquiposToolStripMenuItem.Name = "ingresoEquiposToolStripMenuItem";
            this.ingresoEquiposToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ingresoEquiposToolStripMenuItem.Text = "Ingreso Equipos";
            this.ingresoEquiposToolStripMenuItem.Click += new System.EventHandler(this.ingresoEquiposToolStripMenuItem_Click);
            // 
            // salidaEquiposToolStripMenuItem
            // 
            this.salidaEquiposToolStripMenuItem.Name = "salidaEquiposToolStripMenuItem";
            this.salidaEquiposToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.salidaEquiposToolStripMenuItem.Text = "Salida Equipos";
            this.salidaEquiposToolStripMenuItem.Click += new System.EventHandler(this.salidaEquiposToolStripMenuItem_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.stockToolStripMenuItem.Text = "Stock";
            this.stockToolStripMenuItem.Click += new System.EventHandler(this.stockToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            this.proveedoresToolStripMenuItem.Click += new System.EventHandler(this.proveedoresToolStripMenuItem_Click_1);
            // 
            // ventasToolStripMenuItem
            // 
            this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ventasToolStripMenuItem.Text = "Ventas";
            this.ventasToolStripMenuItem.Click += new System.EventHandler(this.ventasToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            this.comprasToolStripMenuItem.Click += new System.EventHandler(this.comprasToolStripMenuItem_Click);
            // 
            // vistaVentaToolStripMenuItem
            // 
            this.vistaVentaToolStripMenuItem.Name = "vistaVentaToolStripMenuItem";
            this.vistaVentaToolStripMenuItem.Size = new System.Drawing.Size(107, 20);
            this.vistaVentaToolStripMenuItem.Text = "Ventas Generales";
            this.vistaVentaToolStripMenuItem.Click += new System.EventHandler(this.vistaVentaToolStripMenuItem_Click_1);
            // 
            // comprasGeneralesToolStripMenuItem
            // 
            this.comprasGeneralesToolStripMenuItem.Name = "comprasGeneralesToolStripMenuItem";
            this.comprasGeneralesToolStripMenuItem.Size = new System.Drawing.Size(121, 20);
            this.comprasGeneralesToolStripMenuItem.Text = "Compras Generales";
            this.comprasGeneralesToolStripMenuItem.Click += new System.EventHandler(this.comprasGeneralesToolStripMenuItem_Click);
            // 
            // clasificaciónToolStripMenuItem
            // 
            this.clasificaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.reporteVentasToolStripMenuItem,
            this.reporteComprasToolStripMenuItem,
            this.kardexDeProductosToolStripMenuItem});
            this.clasificaciónToolStripMenuItem.Name = "clasificaciónToolStripMenuItem";
            this.clasificaciónToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.clasificaciónToolStripMenuItem.Text = "Reporte Listados";
            this.clasificaciónToolStripMenuItem.Click += new System.EventHandler(this.clasificaciónToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.productosToolStripMenuItem.Text = "Reporte Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // reporteVentasToolStripMenuItem
            // 
            this.reporteVentasToolStripMenuItem.Name = "reporteVentasToolStripMenuItem";
            this.reporteVentasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.reporteVentasToolStripMenuItem.Text = "Reporte Ventas";
            this.reporteVentasToolStripMenuItem.Click += new System.EventHandler(this.reporteVentasToolStripMenuItem_Click);
            // 
            // reporteComprasToolStripMenuItem
            // 
            this.reporteComprasToolStripMenuItem.Name = "reporteComprasToolStripMenuItem";
            this.reporteComprasToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.reporteComprasToolStripMenuItem.Text = "Reporte Compras";
            this.reporteComprasToolStripMenuItem.Click += new System.EventHandler(this.reporteComprasToolStripMenuItem_Click);
            // 
            // kardexDeProductosToolStripMenuItem
            // 
            this.kardexDeProductosToolStripMenuItem.Name = "kardexDeProductosToolStripMenuItem";
            this.kardexDeProductosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.kardexDeProductosToolStripMenuItem.Text = "Kardex de productos";
            this.kardexDeProductosToolStripMenuItem.Click += new System.EventHandler(this.kardexDeProductosToolStripMenuItem_Click);
            // 
            // pendientesToolStripMenuItem
            // 
            this.pendientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.equiposPendientesToolStripMenuItem,
            this.equiposReparadosToolStripMenuItem});
            this.pendientesToolStripMenuItem.Name = "pendientesToolStripMenuItem";
            this.pendientesToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.pendientesToolStripMenuItem.Text = "Reporte Servicios";
            this.pendientesToolStripMenuItem.Click += new System.EventHandler(this.pendientesToolStripMenuItem_Click);
            // 
            // equiposPendientesToolStripMenuItem
            // 
            this.equiposPendientesToolStripMenuItem.Name = "equiposPendientesToolStripMenuItem";
            this.equiposPendientesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.equiposPendientesToolStripMenuItem.Text = "Equipos pendientes";
            this.equiposPendientesToolStripMenuItem.Click += new System.EventHandler(this.equiposPendientesToolStripMenuItem_Click);
            // 
            // equiposReparadosToolStripMenuItem
            // 
            this.equiposReparadosToolStripMenuItem.Name = "equiposReparadosToolStripMenuItem";
            this.equiposReparadosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.equiposReparadosToolStripMenuItem.Text = "Equipos estados";
            this.equiposReparadosToolStripMenuItem.Click += new System.EventHandler(this.equiposReparadosToolStripMenuItem_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // btnIngreso
            // 
            this.btnIngreso.Image = global::Sistema_de_ventas_2018.Properties.Resources.closed_purse;
            this.btnIngreso.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnIngreso.Location = new System.Drawing.Point(445, 178);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(103, 80);
            this.btnIngreso.TabIndex = 0;
            this.btnIngreso.Text = "INGRESO EQUIPOS";
            this.btnIngreso.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIngreso.UseVisualStyleBackColor = true;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.Image = global::Sistema_de_ventas_2018.Properties.Resources.closed_purse;
            this.btnSalida.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSalida.Location = new System.Drawing.Point(445, 286);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(103, 81);
            this.btnSalida.TabIndex = 0;
            this.btnSalida.Text = "SALIDA EQUIPOS";
            this.btnSalida.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSalida.UseVisualStyleBackColor = true;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_de_ventas_2018.Properties.Resources._303206;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1004, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.btnTpv);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.btnproveedores);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnCompras);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnTpv;
        private System.Windows.Forms.Button btnproveedores;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tablasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.ToolStripMenuItem equiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tipoDocumentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unidadMedidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salidaEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vistaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasGeneralesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clasificaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposPendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equiposReparadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kardexDeProductosToolStripMenuItem;
    }
}

