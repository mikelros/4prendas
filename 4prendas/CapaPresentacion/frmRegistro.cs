using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class frmRegistro : Form
    {
        private List<Producto> productos = new List<Producto>;

        public frmRegistro()
        {
            InitializeComponent();
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.CodigoArticulo = txtCodArticulo.Text;
            //producto.Coste = COSA QUE NO ESTA
            producto.Descripcion = txtDescripcion.Text;
            producto.Medida = txtMedida.Text;
            producto.Stock = int.Parse(txtStock.Text);
            //TODO MIRAR QUE PASA SI NO ES INT // que no se pueda
            //producto.Empleado
            productos.Add(producto);
        }
    }
}
