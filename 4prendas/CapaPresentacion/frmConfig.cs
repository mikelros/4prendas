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
    public partial class frmConfig : Form
    {
        public frmConfig()
        {
            InitializeComponent();
        }

        private void btnTestPrev_Click(object sender, EventArgs e)
        {
            
            
        }

        private void rbtnFood_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnClothes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
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
            txtName.Text = "";
            txtNumber.Text = "";
            txtPhoto.Text = "";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //datos.eliminarEmpleado(txtNumbre.text);
        }
    }
}
