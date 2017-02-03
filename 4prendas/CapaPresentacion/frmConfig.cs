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
            int empNum;
            if (!int.TryParse(txtCreateNumEmployer.Text, out empNum))
            {
                lblCreateIntParseError.Show();
                return;
            }else
            {
                lblCreateIntParseError.Hide();
            }
            //employer = datos.buscarEmpleado(empNum);
            //if(!employer = null)
            //{
            //    lblCreateExistingNumberError.Show();
            //    return;
            //}
            //else
            //{
            //    lblCreateExistingNumberError.Hide();
            //}
            //string msg = datos.crearEmpleado(txtName.text, txtNumber.text, txtPhoto.text);
            //if (msg == "")
            //{
                //MessageBox.Show("El empleado " + txtCreateName.Text + " se ha creado correctamente","",MessageBoxButtons.OK,MessageBoxIcon.Information);
            //}else
            //{
            //    MessageBox.Show(msg,"",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            //}
            //employer = null;
        }

        private void bntCreateCancel_Click(object sender, EventArgs e)
        {
            createCancel();
        }
        private void createCancel()
        {
            txtCreateName.Text = "";
            txtCreateNumEmployer.Text = "";
            txtCreatePhoto.Text = "";
            lblCreateIntParseError.Hide();
            //employer = null;
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
            //lblDeleteError.Show();
            //}
            //else
            //{
            //lblDeleteError.Hide();
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

            //employer = null;

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

        private void deleteCancel()
        {
            txtDeleteNumEmployer.Text = "";
            lblDeleteName.Text = "";
            lblEmployerNoExistError.Hide();
            lblCreateIntParseError.Hide();
            lblDeleteIntParseError.Hide();
            //employer = null;
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
    }
}
