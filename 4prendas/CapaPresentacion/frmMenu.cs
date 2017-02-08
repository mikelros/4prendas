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
            btnRecogida.Location = new Point((this.Size.Width / 5) - btnRecogida.Width / 2, medioY - (btnRecogida.Height / 2));
            btnRegistro.Location = new Point((this.Size.Width * 2 / 5) - btnRegistro.Width / 2, medioY - (btnRegistro.Height / 2));
            btnVenta.Location = new Point((this.Size.Width * 3 / 5) - btnVenta.Width / 2, medioY - (btnVenta.Height / 2));
            btnAlmacenamiento.Location = new Point((this.Size.Width  * 4 / 5) - btnAlmacenamiento.Width / 2, medioY - (btnAlmacenamiento.Height / 2));

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfig_Click_1(object sender, EventArgs e)
        {
            Form frmLoginAdmin = new frmLoginAdmin();
            frmLoginAdmin.Show();
            this.Close();
        }

        private void btnRecogida_Click(object sender, EventArgs e)
        {
            Form frmRecogida = new frmRecogida();
            frmRecogida.Show();
            this.Close();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            Form frmRegistro = new frmRegistro();
            frmRegistro.Show();
            this.Close();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            Form frmVenta = new frmVenta();
            frmVenta.Show();
            this.Close();
        }

        private void btnAlmacenamiento_Click(object sender, EventArgs e)
        {
            Form frmAlmacenamiento = new frmAlmacenamiento();
            frmAlmacenamiento.Show();
            this.Close();
        }
    }
}
