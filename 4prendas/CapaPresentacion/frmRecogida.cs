using CapaEntidades;
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
        string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        Empleado employee;
        Negocio negocio = new Negocio();
        public frmRecogida()
        {
            InitializeComponent();

        }

        private void frmRecogida_Load(object sender, EventArgs e)
        {
            lblEmployeePassError.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtGivingPerson.Text = "";
            pboEmployee.BackgroundImage = null;
            lblEmployeePassError.Hide();
            employee = null;
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {

            //Recogida recogida = new Recogida(new DateTime(), nudEmployee.Value, nudQuantity.Value, txtGivingPerson.Text);
            //negocio.realizarRecogida(recogida);


        }

        private void txtEmployer_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {                
                e.Handled = true;
                return;
            }
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                chargeEmployer();
            }
        }

        private void chargeEmployer()
        {
            int employerNum;
                if (!int.TryParse(nudEmployee.Text, out employerNum))
                {
                    lblEmployeePassError.Show();
                    return;
                }
                else
                {
                    lblEmployeePassError.Hide();
                }
            employee = negocio.getEmployee(int.Parse(nudEmployee.Value.ToString()));
                if (employee.Nombre == null)
            {
                lblEmployeePassError.Text = "Empleado no encontrado!!";
                lblEmployeePassError.Show();
                return;
            }
            else
            {
                lblEmployeePassError.Hide();
                if (System.IO.File.Exists(mydocpath + employee.Foto))
                {
                    pboEmployee.Image = new System.Drawing.Bitmap(mydocpath + employee.Foto);
                }
            }

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

        private void chargeEmployer(object sender, EventArgs e)
        {
            chargeEmployer();
        }
    }
}
