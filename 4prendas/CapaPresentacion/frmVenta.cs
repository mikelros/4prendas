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
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class frmVenta : Form
    {
        string shopMode;
        List<Producto> ProdsStockMinimo;
        List<Empleado> Empleados;
        private List<Familia> familias;
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
            loadFamilias();
            //Cargar botones familia(); 
        }

        //Al seleccionar familia, cargar subfamilia

        //Al seleccionar subfamilia, cagar dgv

        private void checkStockMinimo()
        {
            ProdsStockMinimo = Modulo.miNegocio.getProdsStockMinimo();
            int num;
            if (Modulo.miNegocio.getProdsStockMinimo() == null)
            {
                num = 0;
            } else {
            num = ProdsStockMinimo.Count();
            }
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
            Empleados = Modulo.miNegocio.getEmpleados();
            cmbEmpleado.DataSource = Empleados;
            cmbEmpleado.DisplayMember = "empleadoId";
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
            cmbSearch.Items.Add("Descripcion");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            switch (cmbSearch.SelectedText)
            {
                case "Código de barras":
                    dgvProducts.DataSource = Modulo.miNegocio.getProdsPorCodigoArticulo(txtSearch.Text);
                    break;
                case "Descripcion":
                    dgvProducts.DataSource = Modulo.miNegocio.getProdsPorDescripcion(txtSearch.Text);
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

        private void loadFamilias()
        {
            familias = Modulo.miNegocio.getFamiliasSubfamilias();
            int cont = 0;
            foreach (Familia f in familias)
            {
                gboFamilia.Controls[cont].Tag = f;
                gboFamilia.Controls[cont].BackgroundImage = Image.FromFile(f.Imagen); //creo QUE PUEDE FALLAR
                gboFamilia.Controls[cont].Click += new EventHandler(loadSubfamilias); ;
                cont++;
            }
        }

        private void loadSubfamilias(object sender, EventArgs e)
        {
            Familia f = (Familia) sender;
            int cont = 0;
            foreach (SubFamilia s in f.SubFamilias)
            {
                gboFamilia.Controls[cont].Tag = s;
                gboFamilia.Controls[cont].BackgroundImage = Image.FromFile(s.Imagen); //creo QUE PUEDE FALLAR
                gboFamilia.Controls[cont].Click += new EventHandler(loadProductosSubfam);
                cont++;
            }
        }

        private void loadProductosSubfam(object sender, EventArgs e)
        {
            //SubFamilia s = (SubFamilia) sender;
            //List<Producto> productos = Modulo.miNegocio.getProductos(s.CodFamilia, s.CodSubFamilia); //por los cambios de bdd de LArris habrá que hacer algo con esto
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

        private void btnStock_Click(object sender, EventArgs e)
        {
            checkStockMinimo();
            dgvProducts.DataSource = ProdsStockMinimo;
            dgvProducts.Refresh();
        }
    }
}
