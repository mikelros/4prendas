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
    public partial class frmLoginAdmin : Form
    {
        public frmLoginAdmin()
        {
            InitializeComponent();
        }

        private void frmLoginAdmin_Load(object sender, EventArgs e)
        {
            txtUsuario.Focus();
            lblClaveError.Hide();
            lblUsuarioError.Hide();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (Modulo.miNegocio.getAdministrador(txtUsuario.Text, txtPass.Text) != null)
                {
                    (new frmConfig()).Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            (new frmMenu()).Show();
            this.Close();
        }
    }
}
