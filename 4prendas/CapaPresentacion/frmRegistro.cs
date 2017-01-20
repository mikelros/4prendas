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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //add product
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            //confirmar salida?

            //comprobar si se han añadido para la recogida tantos productos como hubiese en la recogida
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
                if (MessageBox.Show("¿Seguro que deseas salir?", "Salir",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            
        }
    }
}
