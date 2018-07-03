﻿using Sistema_de_ventas_2018.Datos;
using Sistema_de_ventas_2018.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_ventas_2018.Presentacion
{
    public partial class FrmTipoDocumento : Form
    {
        public FrmTipoDocumento()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string sResultado = validarDatos();
                if (sResultado == "")
                {
                    if (txtId.Text =="")
                    {
                        if (txtNombre.Text !="" && txtDescripcion.Text != "")
                        {
                            TipoDocumento tipodocumento = new TipoDocumento();
                            tipodocumento.Nombre=txtNombre.Text;
                            tipodocumento.Descripcion = txtDescripcion.Text;
                            int returId = FTipoDocumento.Insertar(tipodocumento);
                            if(returId > 0)
                            {
                                FrmTipoDocumento_Load(null, null);
                                habilitarBotones(false);
                            }
                        }
                    }
                    else
                    {
                        TipoDocumento tipodocumento = new TipoDocumento();
                        tipodocumento.Id = Convert.ToInt32(txtId.Text);
                        tipodocumento.Nombre = txtNombre.Text;
                        tipodocumento.Descripcion = txtDescripcion.Text;
                        int returnId = FTipoDocumento.Actualizar(tipodocumento);
                        if(returnId > 0)
                        {
                            FrmTipoDocumento_Load(null, null);
                            habilitarBotones(false);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Error + \n" + sResultado);
                    FrmTipoDocumento_Load(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        public string validarDatos()
        {
            string resultado = "";
            if (txtDescripcion.Text == "")
            {
                resultado = "El campo esta vacio";
                txtDescripcion.Focus();
            }
            if (txtNombre.Text == "")
            {
                resultado = "El campo esta vacio";
                txtNombre.Focus();
            }
            return resultado;
        }
        private static DataTable dt = new DataTable();

        private void FrmTipoDocumento_Load(object sender, EventArgs e)
        {
            mostrarOcultar(false);
            try
            {
                DataSet ds = FTipoDocumento.GetAll();
                dt=ds.Tables[0];
                dgvDatos.DataSource = dt;
                dgvDatos.Columns["Id"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void mostrarOcultar(bool b)
        {
            txtDescripcion.Enabled=b;
            txtNombre.Enabled = b;
        }
        private void habilitarBotones(bool b)
        {
            btnNuevo.Enabled = !b;
            btnEditar.Enabled = !b;
            btnGuardar.Enabled = b;
            btnEliminar.Enabled = !b;
            btnCancelar.Enabled = b;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            habilitarBotones(true);
            mostrarOcultar(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            habilitarBotones(false);
            FrmTipoDocumento_Load(null, null);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            habilitarBotones(true);
            mostrarOcultar(true);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                TipoDocumento tipodocumento = new TipoDocumento();
                tipodocumento.Id = Convert.ToInt32(dgvDatos.CurrentRow.Cells["Id"].Value.ToString());
                if(FTipoDocumento.Eliminar(tipodocumento) > 0)
                {
                    FrmTipoDocumento_Load(null, null);
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar, talvez no hay tipo de documento registrados", "No se puede eliminar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

       
        private void dgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            asignarDatos();
        }

        private void dgvDatos_SelectionChanged_1(object sender, EventArgs e)
        {
            asignarDatos();
        }

        private void asignarDatos()
        {
            if (dgvDatos.CurrentRow != null)
            {
                txtId.Text = dgvDatos.CurrentRow.Cells["Id"].Value.ToString();
                txtNombre.Text = dgvDatos.CurrentRow.Cells["Nombre"].Value.ToString();
                txtDescripcion.Text = dgvDatos.CurrentRow.Cells["Descripcion"].Value.ToString();
            }
        }
    }
}
