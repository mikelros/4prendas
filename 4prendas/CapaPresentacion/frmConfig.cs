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
        //Employer employer;

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
            if (txtCreateName.Text.Equals("") || txtCreateNumEmployer.Text.Equals("") || txtCreatePhoto.Text.Equals(""))
            {
                lblCreateError.Show();
                return;
            }else
            {
                lblCreateError.Hide();
            }
            if (!File.Exists(txtCreatePhoto.Text))
            {
                lblCreateFileNoExistError.Show();
            }else
            {
                lblCreateFileNoExistError.Hide();
                string NombreArchivo;
                NombreArchivo = System.IO.Path.GetFileNameWithoutExtension(txtCreatePhoto.Text);
                Bitmap Picture = new Bitmap(txtCreatePhoto.Text);
                Picture.Save(mydocpath + @NombreArchivo + ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg);

            }
            //string msg = datos.crearEmpleado(txtName.text, txtNumber.text, txtPhoto.text);
            //if (msg == "")
            //{
            //    MessageBox.Show("El empleado " + txtName.Text + " se ha creado correctamente");
            //}else
            //{
            //    MessageBox.Show(msg);
            //}

        }
        
        private void bntCreateCancel_Click(object sender, EventArgs e)
        {
            txtCreateName.Text = "";
            txtCreateNumEmployer.Text = "";
            txtCreatePhoto.Text = "";
            lblCreateIntParseError.Hide();
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
            //if (employer = null)
            //{

            //}
            //else
            //{
            //    //datos.eliminarEmpleado(employer.number);
            //}
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            lblEmployerNoExistError.Hide();

            lblCreateFileNoExistError.Hide();

            lblDeleteIntParseError.Hide();
            lblCreateIntParseError.Hide();

            lblDeleteError.Hide();
            lblCreateError.Hide();

            lblCreateExistingNumberError.Hide();

            loadShopMode();

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
            txtDeleteNumEmployer.Text = "";
            lblDeleteName.Text = "";
            lblEmployerNoExistError.Hide();
            lblCreateIntParseError.Hide();
            lblDeleteIntParseError.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            int i;
            if (int.TryParse(txtDeleteNumEmployer.Text, out i))
            {
                lblDeleteIntParseError.Hide();
                //employer = datos.buscarEmpleado(i);
                //if (employer == null)
                //{
                //    lblEmployerError.show();
                //}else
                //{
                //    lblEmployerError.Hide();
                //    lblDeleteName.Text = employer.name;
                //}
            }
            else
            {
                lblDeleteIntParseError.Show();
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            //datos.deleteEmployer(employer);
        }

        private void btnDeleteCancel_Click_1(object sender, EventArgs e)
        {
            lblDeleteName.Text = "";
            txtDeleteNumEmployer.Text = "";
            txtDeleteNumEmployer.Focus();
            lblDeleteIntParseError.Hide();
            lblEmployerNoExistError.Hide();
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

        private void btnApply_Click(object sender, EventArgs e)
        {
            saveShopMode();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
