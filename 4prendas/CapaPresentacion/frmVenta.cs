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

namespace CapaPresentacion
{
    public partial class frmVenta : Form
    {
        string shopMode;
        string searchBy;
        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            loadCmbSearch();
            dgvCarrito.Hide();
            checkStockMinimo();
            loadWorkersList();
            //Cargar botones familia();
        }

        //Al seleccionar familia, cargar subfamilia

        //Al seleccionar subfamilia, cagar dgv

        private void checkStockMinimo()
        {
            int num = 1;//negocio.prodsStockMinimo();
            if (num > 0){
                btnStock.BackColor = Color.Red;
                btnStock.Text = num.ToString();
            } else {
                btnStock.BackColor = Color.Lime;
                btnStock.Text = "0";
            }
        }

        private void loadWorkersList()
        {
            //cmbEmpleado.DataSource = listWorkersID();
        }

        private void btnTestNext_Click(object sender, EventArgs e)
        {
            (new frmLoginAdmin()).Show();
        }

        private void btnIRALOGINADMIN_Click(object sender, EventArgs e)
        {
            Form frm = new frmLoginAdmin();
            frm.Show();
        }

        private void btnIRACONFIG_Click(object sender, EventArgs e)
        {
            Form frm = new frmConfig();
            frm.Show();
        }
        private void btnIRARECOGIDA_Click(object sender, EventArgs e)
        {
            Form frm = new frmRecogida();
            frm.Show();
        }
        private void btnIRAREGISTRO_Click(object sender, EventArgs e)
        {
            Form frm = new frmRegistro();
            frm.Show();
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lblWorkerName = Negocio.getWorkerName();
            //imgWorker.Image = Negocio.getWorkerImage();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proceso = new System.Diagnostics.Process();
            proceso.StartInfo.FileName = "calc.exe";
            proceso.StartInfo.Arguments = "";
            proceso.Start();
        }
        
        private void loadCmbSearch()
        {
            cmbSearch.Items.Add("Codigo de barras");
            cmbSearch.Items.Add("Familia");
            cmbSearch.Items.Add("Subfamilia");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            switch (cmbSearch.SelectedText)
            {
                case "Código de barras":
                    //dgvProducts.datasource = searchByBarcode(txtSearch.text)
                    break;
                case "Familia":
                    //dgvProducts.datasource = searchByFamily(txtSearch.text)
                    break;
                case "Subfamilia":
                    //dgvProducts.datasource = searchBySubFamily(txtSearch.text)
                    break;
                default:
                    break;
            }
        }



        private void btnCarrito_Click(object sender, EventArgs e)
        {
            dgvCarrito.Show();
        }

        private void dgvCarrito_MouseLeave(object sender, EventArgs e)
        {
            dgvCarrito.Hide();
        }

        private void loadShopMode()
        {
            string line;
            try
            {
                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); 
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
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void dgvProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Chequea que no se haya hecho click fuera de las columnas con datos.
            if (e.RowIndex == -1)
            {
                return;
            }

            //TODO pasar a la lista de productos para comprar
        }
    }
}
