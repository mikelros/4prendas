﻿using CapaEntidades;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmRecogida : Form
    {
        public frmRecogida()
        {
            InitializeComponent();

        }

        private void frmRecogida_Load(object sender, EventArgs e)
        {
            lblErrorPaseEmpleado.Hide();
            lblNRecogida.Text = "" + (Modulo.miNegocio.getLastNRecogida() + 1);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtDonante.Text = "";
            pboEmpleado.BackgroundImage = null;
            lblErrorPaseEmpleado.Hide(); //No sé si he acertado mucho con este nombre
            Modulo.empleadoActual = null;
            lblNombreEmpleado.Text = "";
            pboEmpleado.BackgroundImage = null;
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            int id = Modulo.miNegocio.comprobarPersona(txtDonante.Text);
            DateTime dtm = new DateTime(dtpFechaRecogida.Value.Year, dtpFechaRecogida.Value.Month, dtpFechaRecogida.Value.Day, dtpFechaRecogida.Value.Hour, dtpFechaRecogida.Value.Minute, dtpFechaRecogida.Value.Second);
            Recogida recogida = new Recogida(dtm, Convert.ToInt32(Math.Round(nudEmpleado.Value, 0)), Convert.ToInt32(Math.Round(nudCantidad.Value, 0)), id);
            Modulo.miNegocio.realizarRecogida(recogida);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void nudEmployee_Leave(object sender, EventArgs e)
        {

            Empleado empleado = Modulo.empleados.Where((em) => em.EmpleadoId == Convert.ToInt32(Math.Round(nudEmpleado.Value, 0))).SingleOrDefault();
            if (empleado == null)
            {
                pboEmpleado.BackgroundImage = null;
                lblNombreEmpleado.Text = "";
                return;

            }

            Modulo.empleadoActual = empleado;
            lblNombreEmpleado.Text = empleado.Nombre;
            if (System.IO.File.Exists(empleado.Foto))
            {
                //preguntar a María donde van a estar las fotos de los empleados? cambiar desde config?
                pboEmpleado.BackgroundImage = Image.FromFile(empleado.Foto);
                pboEmpleado.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pboEmpleado.BackgroundImage = null;
            }
        }

    }
}
