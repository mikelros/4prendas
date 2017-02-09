using CapaEntidades;
using CapaNegocio;
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
    public partial class frmConfig : Form
    {
        Empleado employee;
        Negocio negocio = new Negocio();
        Producto product;

        string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string shopMode;

        public frmConfig()
        {
            InitializeComponent();
        }


        private void rbtnFood_CheckedChanged(object sender, EventArgs e)
        {
            shopMode = "food";
        }

        private void rbtnClothes_CheckedChanged(object sender, EventArgs e)
        {
            shopMode = "clothes";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtCreateName.Text.Equals("") || nudCreateNumEmployee.Text.Equals("") || txtCreatePhoto.Text.Equals(""))
            {
                lblCreateError.Show();
                return;
            }else
            {
                lblCreateError.Hide();
            }
            if (!txtCreatePhoto.Equals(""))
            {
                if (!File.Exists(txtCreatePhoto.Text))
                {
                    lblCreateFileNoExistError.Show();
                    return;
                }
                else
                {
                    lblCreateFileNoExistError.Hide();
                    string NombreArchivo;
                    NombreArchivo = System.IO.Path.GetFileNameWithoutExtension(txtCreatePhoto.Text);
                    Bitmap Picture = new Bitmap(txtCreatePhoto.Text);
                    Picture.Save(mydocpath + @NombreArchivo + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

                }
            }
            //employee = negocio.getEmpleado(nudCreateNumEmployee);
            if (employee == null)
            {
                lblCreateExistingNumberError.Show();
                return;
            }
            else
            {
                lblCreateExistingNumberError.Hide();
            }
            //string msg = negocio.createEmployee(txtCreateName.Text, nudCreateNumEmployee, txtCreatePhoto.Text);
            //if (msg == "")
            //{
            //    MessageBox.Show("El empleado " + txtCreateName.Text + " se ha creado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //else
            //{
            //    MessageBox.Show(msg, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
            employee = null;
        }

        private void bntCreateCancel_Click(object sender, EventArgs e)
        {
            createCancel();
        }
        private void createCancel()
        {
            txtCreateName.Text = "";
            txtCreatePhoto.Text = "";
            employee = null;
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            txtCreatePhoto.Text = myStream.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (employee == null)
            {
                lblDeleteError.Show();
            }
            else
            {
                lblDeleteError.Hide();
                //negocio.deleteEmployee(employee.Id);
            }
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            lblEmployeeNoExistError.Hide();

            lblCreateFileNoExistError.Hide();
            

            lblDeleteError.Hide();
            lblCreateError.Hide();

            lblCreateExistingNumberError.Hide();

            loadShopMode();

            employee = null;

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
            }
            if (shopMode == "food")
            {
                rbtnFood.Checked = true;
            }
            else
            {
                rbtnClothes.Checked = true;
            }
        }

        private void btnDeleteCancel_Click(object sender, EventArgs e)
        {
            deleteCancel();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {


            //employee = negocio.getEmpleado(nudDeleteNumEmployee);
            if (employee == null)
            {
                lblEmployeeNoExistError.Show();
            }
            else
            {
                lblEmployeeNoExistError.Hide();
                lblDeleteName.Text = employee.Nombre;
            }

        }

        

        private void deleteCancel()
        {
            nudDeleteNumEmployee.Text = "";
            lblDeleteName.Text = "";
            lblEmployeeNoExistError.Hide();
            employee = null;
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
            deleteCancel();
            createCancel();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            saveShopMode();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string FileToCopy;
            SaveFileDialog NewCopy = new SaveFileDialog();
            NewCopy.Filter = "Base de datos|*.accdb";
            NewCopy.ShowDialog();
            FileToCopy = "CUASHOP_MODA.accdb";
            
            if (System.IO.File.Exists(FileToCopy))
            {
                if (!NewCopy.FileName.Equals(""))
                {
                    System.IO.File.Copy(FileToCopy, NewCopy.FileName);
                    MessageBox.Show("File Copied");
                }
            }


        }

        private void onlyNums(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void btnUpdatePorduct_Click(object sender, EventArgs e)
        {
            
            
                product.Stock = int.Parse(nudEditProductStock.Value.ToString());

             
                product.StockMinimo = int.Parse(nudEditProductMinStock.Value.ToString());

            

                product.Coste = float.Parse(nudEditProductCost.Value.ToString());


            product.EmpleadoId = int.Parse(nudEditProductEmployerId.Value.ToString()) ;
        
             
                product.Descripcion = txtEditProductDescription.Text;

             
                product.CodFamilia = txtEditProductFamilyCode.Text;

            
                product.LugarId = int.Parse(nudEditProductPlaceId.Value.ToString());

             
                product.RecogidaId = int.Parse(nudEditProductCollectionId.Value.ToString());

           
                product.Medida = txtEditProductSize.Text;
            //negocio.updateProduct(product);

        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            txtEditProductCode.Text = "";
            nudEditProductStock.Value = 0;
            nudEditProductMinStock.Value = 0;
            nudEditProductCost.Value = 0;
            nudEditProductEmployerId.Value = 0;
            txtEditProductDescription.Text = "";
            txtEditProductFamilyCode.Text = "";
            nudEditProductPlaceId.Text = "";
            nudEditProductCollectionId.Text = "";
            txtEditProductSize.Text = "";
            product = null;

        }

        private void searchProduct(object sender, EventArgs e)
        {
            searchProduct();
        }
        private void searchProduct()
        {

            product = negocio.getProdsPorCodigoArticulo(txtEditProductCode.Text).First<Producto>();
            if (product == null)
            {
                lblCodeNotFoundMinStockError.Show();
            }
            else
            {
                lblCodeNotFoundMinStockError.Hide();
                nudEditProductStock.Value = product.Stock;
                nudEditProductMinStock.Value = product.StockMinimo;
                nudEditProductCost.Value = int.Parse(product.Coste.ToString());
                nudEditProductEmployerId.Value = product.EmpleadoId;
                txtEditProductDescription.Text = product.Descripcion;
                txtEditProductFamilyCode.Text = product.CodFamilia;
                nudEditProductPlaceId.Value = product.LugarId;
                nudEditProductCollectionId.Value = product.RecogidaId;
                txtEditProductSize.Text = product.Medida;

            }
        }

        private void txtEditProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                searchProduct();
            }
        }
    }
}
