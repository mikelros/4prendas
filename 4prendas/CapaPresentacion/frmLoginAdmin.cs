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
            lblPassError.Hide();
            lblUserError.Hide();

        }

        private void btnTestNext_Click(object sender, EventArgs e)
        {
            (new frmConfig()).Show();
        }
    }
}
