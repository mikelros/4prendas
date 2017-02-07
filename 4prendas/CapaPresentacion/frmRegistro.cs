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
        private List<Producto> productos = new List<Producto>();

        public frmRegistro()
        {
            InitializeComponent();
            dgvRegistros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            refreshDgv();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            //confirmar salida?
            //comprobar si se han añadido para la recogida tantos productos como hubiese en la recogida

            if (MessageBox.Show("¿Seguro que deseas salir?", "Salir",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmRegistro_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();
            producto.CodigoArticulo = txtCodArticulo.Text;
            //producto.Coste = COSA QUE NO ESTA
            producto.Descripcion = txtDescripcion.Text;
            producto.Medida = txtMedida.Text;
            producto.Stock = int.Parse(nudStock.Text);
            producto.EmpleadoId = int.Parse(nudEmpleado.Text);
            //fecha de entrada es la de ahora o la de la recogida..?
            producto.RecogidaId = int.Parse(nudNumRecogida.Text);
            productos.Add(producto);
            refreshDgv();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Modulo.miNegocio.InsertarProductos(productos);
            productos.Clear();
            refreshDgv();

            //lblLOQUESEA.text = "insertado correctamente" ??
        }

        private void refreshDgv()
        {
            dgvRegistros.DataSource = productos.Select(p => new { p.CodigoArticulo, p.Descripcion, p.Medida, p.Stock, p.EmpleadoId, p.RecogidaId }).ToList();
            dgvRegistros.Refresh();
        }

        private void onlyNums(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

    }
}
