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
            Modulo.empleadoActual = null;
            lblEmployeeName.Text = "";
            pboEmployee.BackgroundImage = null;
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            int id = Modulo.miNegocio.comprobarPersona(txtGivingPerson.Text);
            DateTime dtm = new DateTime(dtpCollectionDate.Value.Year, dtpCollectionDate.Value.Month, dtpCollectionDate.Value.Day, dtpCollectionDate.Value.Hour, dtpCollectionDate.Value.Minute, dtpCollectionDate.Value.Second);
            Recogida recogida = new Recogida(dtm, Convert.ToInt32(Math.Round(nudEmployee.Value, 0)), Convert.ToInt32(Math.Round(nudQuantity.Value, 0)), id);
            Modulo.miNegocio.realizarRecogida(recogida);
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

        private void nudEmployee_Leave(object sender, EventArgs e)
        {

            Empleado empleado = Modulo.empleados.Where((em) => em.EmpleadoId == Convert.ToInt32(Math.Round(nudEmployee.Value, 0))).SingleOrDefault();
            if (empleado == null)
            {
                pboEmployee.BackgroundImage = null;
                lblEmployeeName.Text = "";
                return;

            }

            Modulo.empleadoActual = empleado;
            lblEmployeeName.Text = empleado.Nombre;
            if (System.IO.File.Exists(empleado.Foto))
            {
                //preguntar a María donde van a estar las fotos de los empleados? cambiar desde config?
                pboEmployee.BackgroundImage = Image.FromFile(empleado.Foto);
                pboEmployee.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pboEmployee.BackgroundImage = null;
            }
        }

    }
}
