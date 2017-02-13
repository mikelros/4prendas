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
        Empleado employee;
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
            lblEmployeeName.Text = "";
            pboEmployee.BackgroundImage = null;
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {

            //Recogida recogida = new Recogida(new DateTime(), Convert.ToInt32(Math.Round(nudEmployee.Value, 0)), Convert.ToInt32(Math.Round(nudQuantity.Value, 0)), txtGivingPerson.Text);
            //Modulo.miNegocio.realizarRecogida(recogida);


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
                chargeEmployee();
            }
        }

        private void chargeEmployee()
        {
            int employerNum;
                if (!int.TryParse(nudEmployee.Text, out employerNum))
                {
                    lblEmployeePassError.Show();
                lblEmployeeName.Text = "";
                pboEmployee.BackgroundImage = null;
                return;
                }
                else
                {
                    lblEmployeePassError.Hide();
                }
            employee = Modulo.miNegocio.getEmployee(int.Parse(nudEmployee.Value.ToString()));
                if (employee.Nombre == null)
            {
                lblEmployeePassError.Text = "Empleado no encontrado!!";
                lblEmployeePassError.Show();
                lblEmployeeName.Text = "";
                pboEmployee.BackgroundImage = null;
                return;
            }
            else
            {
                lblEmployeePassError.Hide();
                lblEmployeeName.Text = employee.Nombre;
                if (System.IO.File.Exists(employee.Foto))
                {
                    pboEmployee.BackgroundImage = new System.Drawing.Bitmap(employee.Foto);
                    pboEmployee.BackgroundImageLayout = ImageLayout.Stretch;
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
            chargeEmployee();
        }

        private void ifEnterSearchEmployee(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                chargeEmployee();
            }
        }
    }
}
