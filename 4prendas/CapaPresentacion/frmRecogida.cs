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
        //Employer employer;
        public frmRecogida()
        {
            InitializeComponent();

        }

        private void frmRecogida_Load(object sender, EventArgs e)
        {
            lblCollectionNumError.Hide();
            lblEmployerPassError.Hide();
            lblQuantityError.Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtEmployer.Text = "";
            txtCollectionNum.Text = "";
            txtQuantity.Text = "";
            txtGivingPerson.Text = "";
            pboEmployer.BackgroundImage = null;
            //employer = null;
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            int quantity;
            int collectionNum;
            if (!int.TryParse(txtCollectionNum.Text, out collectionNum))
            {
                lblCollectionNumError.Show();
                return;
            }
            else
            {
                lblCollectionNumError.Hide();
            }
            if (!int.TryParse(txtQuantity.Text, out quantity))
            {
                lblQuantityError.Show();
                return;
            }
            else
            {
                lblQuantityError.Hide();
            }

            //datos.realizarRecogida(employer,collectionNum, quantity, txtGivingPerson.Text)


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
                if (!int.TryParse(txtEmployer.Text, out employerNum))
                {
                    lblEmployerPassError.Show();
                    return;
                }
                else
                {
                    lblEmployerPassError.Hide();
                }
                //employer = datos.getEmployer(numEmployer)
                //if (employer = null)
                //{
                //    lblEmployerPassError.Show();
                //    return;
                //}else
                //{
                //    lblEmployerPassError.Hide();
                //    pboEmployer.BackgroundImage = employer.image;
                //}
            
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
