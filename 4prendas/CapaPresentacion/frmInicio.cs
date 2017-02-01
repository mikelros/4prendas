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
    public partial class frmInicio : Form
    {
        string searchBy;
        public frmInicio()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
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

        private void cmbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //searchBy = selectedIndex
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            switch (searchBy)
            {
                case "Barcode":
                    //dgvProducts.datasource = searchByBarcode(txtSearch.text)
                    break;
                case "Family":
                    //dgvProducts.datasource = searchByFamily(txtSearch.text)
                    break;
                case "SubFamily":
                    //dgvProducts.datasource = searchBySubFamily(txtSearch.text)
                    break;
                default:
                    break;
            }
        }
    }
}
