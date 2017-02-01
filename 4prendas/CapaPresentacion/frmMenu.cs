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
    public partial class frmMenu : Form
    {

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            int medioY = this.Size.Height / 2;
            pboRecogida.Location = new Point((this.Size.Width / 5) - pboRecogida.Width / 2, medioY - (pboRecogida.Height / 2));
            pboRegistro.Location = new Point((this.Size.Width * 2 / 5) - pboRegistro.Width / 2, medioY - (pboRegistro.Height / 2));
            pboVenta.Location = new Point((this.Size.Width * 3 / 5) - pboVenta.Width / 2, medioY - (pboVenta.Height / 2));
            pboAlmacenamiento.Location = new Point((this.Size.Width  * 4 / 5) - pboAlmacenamiento.Width / 2, medioY - (pboAlmacenamiento.Height / 2));

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pboRecogida_Click(object sender, EventArgs e)
        {
            Form frmRecogida = new frmRecogida();
            frmRecogida.Show();
            this.Close();
        }

        private void pboVenta_Click(object sender, EventArgs e)
        {
            Form frmVenta = new frmVenta();
            frmVenta.Show();
            this.Close();
        }

        private void pboAlmacenamiento_Click(object sender, EventArgs e)
        {
            //Form frmRecogida = new frmAlmacenamiento();
            //frmRecogida.Show();
            //this.Close();
        }

        private void pboRegistro_Click(object sender, EventArgs e)
        {
            Form frmRegistro = new frmRegistro();
            frmRegistro.Show();
            this.Close();
        }
    }
}
