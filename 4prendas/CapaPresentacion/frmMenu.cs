using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class frmMenu : Form
    {
        string tipoTienda;
        string rutaAMisDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        bool estaCargado = false;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            estaCargado = false;
            int medioY = this.Size.Height / 2;
            btnRecogida.Location = new Point((this.Size.Width / 4) - btnRecogida.Width / 2, medioY - (btnRecogida.Height / 2));
            btnRegistro.Location = new Point((this.Size.Width * 2 / 4) - btnRegistro.Width / 2, medioY - (btnRegistro.Height / 2));
            btnVenta.Location = new Point((this.Size.Width * 3 / 4) - btnVenta.Width / 2, medioY - (btnVenta.Height / 2));
            cargarTipoTienda();
            cargarListaEmpleados();
            estaCargado = true;
        }

        private void cargarListaEmpleados()
        {
            try
            {
                this.cmbEmpleado.SelectedIndexChanged -= new EventHandler(cmbEmpleado_SelectedIndexChanged);
                cmbEmpleado.DataSource = Modulo.empleados;
                this.cmbEmpleado.SelectedIndexChanged += new EventHandler(cmbEmpleado_SelectedIndexChanged);
                cmbEmpleado.DisplayMember = "nombre";
                cmbEmpleado.SelectedItem = Modulo.empleadoActual;
                imgEmpleado.Image = Modulo.empleadoActual != null && File.Exists(Modulo.empleadoActual.Foto) ? Image.FromFile(Modulo.empleadoActual.Foto) : Properties.Resources.newsle_empty_icon;
            } catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpleado.SelectedItem != null && estaCargado)
            {
                Modulo.empleadoActual = (Empleado)cmbEmpleado.SelectedItem;
                lblNombreEmpleado.Text = ((Empleado)cmbEmpleado.SelectedItem).Nombre;
                if (System.IO.File.Exists(((Empleado)cmbEmpleado.SelectedItem).Foto))
                {
                    imgEmpleado.Image = new System.Drawing.Bitmap(((Empleado)cmbEmpleado.SelectedItem).Foto);
                }
                else
                {
                    imgEmpleado.Image = CapaPresentacion.Properties.Resources.newsle_empty_icon;
                }
            }
        }

        private void cargarTipoTienda()
        {
            string line;
            try
            {

                System.IO.StreamReader file = new System.IO.StreamReader(rutaAMisDocumentos + @"\.config.txt");

                System.Console.WriteLine(tipoTienda);
                while ((line = file.ReadLine()) != null)
                {
                    if (line.StartsWith("ShopMode="))
                    {
                        tipoTienda = line.Split('=')[1];
                    }
                }

                file.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar el archivo de configuración!!! " + "" + "Se cargara la configuración por defecto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tipoTienda = "food";
                guardarTipoTienda();
            }
            
        }
        private void guardarTipoTienda()
        {
            try
            {

                using (StreamWriter outputFile = new StreamWriter(rutaAMisDocumentos + @"\.config.txt"))
                {
                    outputFile.WriteLine("ShopMode=" + tipoTienda);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfig_Click_1(object sender, EventArgs e)
        {
            Form frmLoginAdmin = new frmLoginAdmin();
            frmLoginAdmin.Show();
            this.Hide();
        }

        private void btnRecogida_Click(object sender, EventArgs e)
        {
            Form frmRecogida = new frmRecogida();
            frmRecogida.Show();
            this.Hide();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Form frmRegistro = new frmRegistro();
            frmRegistro.Show();
            this.Hide();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            Form frmVenta = new frmVenta();
            frmVenta.Show();
            this.Hide();
        }

    }
}
