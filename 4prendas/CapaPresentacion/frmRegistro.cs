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
        private List<Recogida> recogidas;

        public frmRegistro()
        {
            InitializeComponent();
            recogidas = Modulo.miNegocio.getRecogidasSinRegistros();
            cboRecogida.DataSource = recogidas;
            cboRecogida.DisplayMember = "IdRecogida";
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            if(hayErrores())
            {
                MessageBox.Show("Los campos obligatorios deben ser introducidos.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Producto producto = new Producto();
            Lugar lugar = new Lugar(txtEstanteria.Text, int.Parse(nudEstante.Value.ToString()), int.Parse(nudAltura.Value.ToString()));
            
            producto.CodigoArticulo = txtCodArticulo.Text;
            if (!String.IsNullOrWhiteSpace(nupCoste.Text))
            {
                producto.Coste = int.Parse(nupCoste.Text);
            }
            producto.Descripcion = txtDescripcion.Text;
            producto.Medida = txtMedida.Text;
            producto.Stock = int.Parse(nudStock.Text);
            producto.EmpleadoId = int.Parse(nudEmpleado.Text);
            producto.FechaEntrada = DateTime.Now;
            producto.RecogidaId = ((Recogida)cboRecogida.SelectedItem).IdRecogida;
            string codfamilia = producto.CodigoArticulo.Substring(8, 10);
            producto.CodFamilia = codfamilia;
            string codsubfamilia = producto.CodigoArticulo.Substring(10, 12);
            producto.CodSubFamilia = codsubfamilia;
            //producto.LugarId = Modulo.miNegocio.comprobarLugar(lugar);
            productos.Add(producto);
            refreshDgv();
        }

        private bool hayErrores()
        {
            if (String.IsNullOrWhiteSpace(txtCodArticulo.Text))
            {
                txtCodArticulo.Text = "";
                txtCodArticulo.Focus();
                return true;
            }

            if(cboRecogida.SelectedItem == null)
            {
                cboRecogida.Focus();
                return true;
            }

            return false;
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
            dgvRegistros.DataSource = productos.Select(p => new { p.CodigoArticulo, p.Descripcion, p.Medida, p.Stock, p.EmpleadoId, p.RecogidaId, p.FechaEntrada, p.Coste }).ToList();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }
    }
}
