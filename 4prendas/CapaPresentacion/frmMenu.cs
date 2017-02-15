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
        string shopMode;
        string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            int medioY = this.Size.Height / 2;
            btnRecogida.Location = new Point((this.Size.Width / 4) - btnRecogida.Width / 2, medioY - (btnRecogida.Height / 2));
            btnRegistro.Location = new Point((this.Size.Width * 2 / 4) - btnRegistro.Width / 2, medioY - (btnRegistro.Height / 2));
            btnVenta.Location = new Point((this.Size.Width * 3 / 4) - btnVenta.Width / 2, medioY - (btnVenta.Height / 2));
            loadShopMode();

        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Modulo.empleadoActual = (Empleado)cmbEmpleado.SelectedItem;
            lblWorkerName.Text = ((Empleado)cmbEmpleado.SelectedItem).Nombre;
            if (System.IO.File.Exists(((Empleado)cmbEmpleado.SelectedItem).Foto))
            {
                imgWorker.Image = new System.Drawing.Bitmap(((Empleado)cmbEmpleado.SelectedItem).Foto);
            }
            else
            {
                imgWorker.Image = CapaPresentacion.Properties.Resources.newsle_empty_icon;
            }
        }

        private void loadShopMode()
        {
            string line;
            try
            {

                System.IO.StreamReader file = new System.IO.StreamReader(mydocpath + @"\.config.txt");

                System.Console.WriteLine(shopMode);
                while ((line = file.ReadLine()) != null)
                {
                    if (line.StartsWith("ShopMode="))
                    {
                        shopMode = line.Split('=')[1];
                    }
                }

                file.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar el archivo de configuración!!! " + "" + "Se cargara la configuración por defecto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                shopMode = "food";
                saveShopMode();
            }
            if (shopMode == "food")
            {
               // rbtnFood.Checked = true;
            }
            else
            {
               // rbtnClothes.Checked = true;
            }
        }
        private void saveShopMode()
        {
            try
            {

                using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\.config.txt"))
                {
                    outputFile.WriteLine("ShopMode=" + shopMode);
                }
            }
            catch
            {

            }
            finally
            {

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
            this.Close();
        }

        private void btnRecogida_Click(object sender, EventArgs e)
        {
            Form frmRecogida = new frmRecogida();
            frmRecogida.Show();
            this.Close();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Form frmRegistro = new frmRegistro();
            frmRegistro.Show();
            this.Close();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            Form frmVenta = new frmVenta();
            frmVenta.Show();
            this.Close();
        }

    }
}
