using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using CapaEntidades;

namespace CapaPresentacion
{
    public partial class frmVenta : Form
    {
        string tipoTienda;
        List<Producto> prodsStockMinimo;
        List<Empleado> empleados;

        private List<Familia> familias;
        private List<Producto> productos;
        private List<Producto> productosCarrito = new List<Producto>();
        private int numProdsCarrito = 0;

        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {

            cargarCmbBuscar();
            dgvCarrito.Hide();
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cargarStockMinimo();
            cargarListaTrabajadores();
            cargarFamilias();
            ocultarGboSubFam();
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        
        private void cargarStockMinimo()
        {
            prodsStockMinimo = Modulo.miNegocio.getProdsStockMinimo();
            int num;
            if (prodsStockMinimo == null)
            {
                num = 0;
            }
            else
            {
                num = prodsStockMinimo.Count();
            }
            if (num > 0)
            {
                btnStock.BackColor = Color.Red;
                btnStock.Text = num.ToString();
            }
            else
            {
                btnStock.BackColor = Color.Lime;
                btnStock.Text = "0";
            }
        }

        private void cargarListaTrabajadores()
        {
            this.cmbEmpleado.SelectedIndexChanged -= new EventHandler(cmbEmpleado_SelectedIndexChanged);
            cmbEmpleado.DataSource = Modulo.empleados;
            this.cmbEmpleado.SelectedIndexChanged += new EventHandler(cmbEmpleado_SelectedIndexChanged);
            cmbEmpleado.DisplayMember = "nombre";
            cmbEmpleado.SelectedItem = Modulo.empleadoActual;
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpleado.SelectedItem != null)
            {
                Modulo.empleadoActual = (Empleado)cmbEmpleado.SelectedItem;
                lblNombreEmpleado.Text = ((Empleado)cmbEmpleado.SelectedItem).Nombre;
                if (System.IO.File.Exists(((Empleado)cmbEmpleado.SelectedItem).Foto))
                {
                    imgEmpleado.Image = new System.Drawing.Bitmap(((Empleado)cmbEmpleado.SelectedItem).Foto);
                }
                else
                {
                    imgEmpleado.Image = CapaPresentacion.Properties.Resources.newsle_empty_icon;
                }
            }
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proceso = new System.Diagnostics.Process();
            proceso.StartInfo.FileName = "calc.exe";
            proceso.StartInfo.Arguments = "";
            proceso.Start();
        }

        private void cargarCmbBuscar()
        {
            cmbBuscar.Items.Add("Código de barras");
            cmbBuscar.Items.Add("Código de artículo");
            cmbBuscar.Items.Add("Descripción");
            cmbBuscar.SelectedIndex = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
                switch (cmbBuscar.SelectedItem.ToString())
                {
                    case "Código de barras":
                    if (txtBuscar.Text.Length > 13) { }
                    else
                    {
                        productos = Modulo.miNegocio.getProdsPorCodigoArticulo(txtBuscar.Text);
                        dgvProductos.DataSource = productos;
                    }
                        break;
                    case "Código de ártículo":
                        productos = Modulo.miNegocio.getProdsPorCodigoArticulo(txtBuscar.Text);
                        dgvProductos.DataSource = productos;
                        break;
                    case "Descripción":
                        productos = Modulo.miNegocio.getProdsPorDescripcion(txtBuscar.Text);
                        dgvProductos.DataSource = productos;
                        break;
                    default:
                        break;
                }
            
        }



        private void btnCarrito_Click(object sender, EventArgs e)
        {
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = (from p in productosCarrito
                                     select new{CodigoArticulo = p.CodigoArticulo, Descripcion = p.Descripcion, Coste = p.Coste, Unidades = p.Unidades }).ToList();
            dgvCarrito.Refresh();
            dgvCarrito.Show();
        }

        private void dgvCarrito_MouseLeave(object sender, EventArgs e)
        {
            dgvCarrito.Hide();
        }

        private void loadTipoTienda()
        {
            string line;
            try
            {
                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                System.IO.StreamReader file = new System.IO.StreamReader(mydocpath + @"\.config.txt");
                System.Console.WriteLine(tipoTienda);
                while ((line = file.ReadLine()) != null)
                {
                    if (line.StartsWith("ShopMode="))
                    {
                        tipoTienda = line.Split('=')[1];
                    }
                }
                file.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar el archivo de configuración! " + "" + "Se cargara la configuración por defecto.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tipoTienda = "food";
            }
        }

        private void cargarFamilias()
        {
            ponerFamiliasEnBlanco();
            familias = Modulo.miNegocio.getFamiliasSubfamilias();
            
            for(int i = gboFamilia.Controls.Count - 1, j = 0; i >= 0 ; i--, j++)
            {
                if(j <= familias.Count -1)
                {
                    Familia f = familias[j];
                    gboFamilia.Controls[i].Tag = f;
                    gboFamilia.Controls[i].BackgroundImage = !f.Imagen.Equals("") && File.Exists(f.Imagen) ? Image.FromFile(f.Imagen) : null;
                    gboFamilia.Controls[i].Text = f.CodFamilia;
                    gboFamilia.Controls[i].Click += new EventHandler(loadSubfamilias);

                }
                else
                {
                    gboFamilia.Controls[i].Visible = false;
                }
                
            }
        }

        private void loadSubfamilias(object sender, EventArgs e)
        {
            ponerFamiliasEnBlanco();
            ponerSubfamiliasEnBlanco();
            Button b = (Button)sender;
            b.BackColor = Color.LightBlue;
            Familia f = (Familia)b.Tag;

            for (int i = gboSubfamilia.Controls.Count - 1, j = 0; i >= 0; i--, j++)
            {
                gboSubfamilia.Controls[i].Visible = false;
                if (j <= f.SubFamilias.Count - 1)
                {
                    SubFamilia s = f.SubFamilias[j];
                    gboSubfamilia.Controls[i].Tag = s;
                    gboSubfamilia.Controls[i].BackgroundImage = !s.Imagen.Equals("") && File.Exists(s.Imagen) ? Image.FromFile(s.Imagen) : null;
                    gboSubfamilia.Controls[i].Text = s.CodSubFamilia;
                    gboSubfamilia.Controls[i].Click += new EventHandler(loadProductosSubfam);
                    gboSubfamilia.Controls[i].Visible = true;

                }

            }

        }

        private void loadProductosSubfam(object sender, EventArgs e)
        {
            ponerSubfamiliasEnBlanco();
            Button b = (Button)sender;
            b.BackColor = Color.LightBlue;
            SubFamilia s = (SubFamilia)b.Tag;
            
            productos = Modulo.miNegocio.getProductos(s.CodFamilia, s.CodSubFamilia);
            if (productos != null)
            {
                dgvProductos.DataSource = productos;
            } else
            {
                //TODO CONTROLAR ERROR
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void dgvProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Chequea que no se haya hecho click fuera de las columnas con datos.
            if (e.RowIndex == -1)
            {
                return;
            }

            //TODO pasar a la lista de productos para comprar
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            cargarStockMinimo();
            productos = prodsStockMinimo;
            dgvProductos.DataSource = prodsStockMinimo;
            dgvProductos.Refresh();
        }

        private void ocultarGboSubFam()
        {
            foreach (Control c in gboSubfamilia.Controls)
            {
                c.Visible = false;
            }
        }

        private void dgvProducts_DataSourceChanged(object sender, EventArgs e)
        {
            this.dgvProductos.Columns["StockMinimo"].Visible = false;
            this.dgvProductos.Columns["EmpleadoId"].Visible = false;
            this.dgvProductos.Columns["RecogidaId"].Visible = false;
            this.dgvProductos.Columns["FechaEntrada"].Visible = false;
        }

      
        private void dgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            Producto producto = productos.ElementAt(e.RowIndex);

            dgvCarrito.DataSource = null;

            if (!productosCarrito.Contains(producto))
            {
                productosCarrito.Add(productos.ElementAt(e.RowIndex));
            }
            productosCarrito.Where((p) => p.Equals(producto)).SingleOrDefault().Unidades++;

            dgvCarrito.DataSource = (from p in productosCarrito
                                     select new { CodigoArticulo = p.CodigoArticulo, Descripcion = p.Descripcion, Coste = p.Coste, Unidades = p.Unidades }).ToList();

            dgvCarrito.Refresh();
            numProdsCarrito += 1;
            btnCarrito.Text = numProdsCarrito.ToString();
        }

        private void dgvCarrito_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                return;
            }

            Producto producto = productosCarrito.ElementAt(e.RowIndex);

            dgvCarrito.DataSource = null;

            if (productosCarrito.Where((p) => p.Equals(producto)).SingleOrDefault().Unidades == 1)
            {
                productosCarrito.Remove(producto);
            } else
            {
                productosCarrito.Where((p) => p.Equals(producto)).SingleOrDefault().Unidades--;
            }


            dgvCarrito.DataSource = (from p in productosCarrito
                                     select new { CodigoArticulo = p.CodigoArticulo, Descripcion = p.Descripcion, Coste = p.Coste, Unidades = p.Unidades }).ToList();
            dgvCarrito.Refresh();
            numProdsCarrito -= 1;
            btnCarrito.Text = numProdsCarrito.ToString();
        }

        private void ponerFamiliasEnBlanco()
        {
            for (int i = gboFamilia.Controls.Count - 1; i >= 0; i--)
            {
                if (gboFamilia.Controls[i].Visible)
                {
                    gboFamilia.Controls[i].BackColor = Color.White;
                }
            }
        }

        private void ponerSubfamiliasEnBlanco()
        {
            for (int i = gboSubfamilia.Controls.Count - 1; i >= 0; i--)
            {
                if (gboSubfamilia.Controls[i].Visible)
                {
                    gboSubfamilia.Controls[i].BackColor = Color.White;
                }
            }
        }

        private void btnFinVenta_Click(object sender, EventArgs e)
        {
            Modulo.miNegocio.insertVenta(productosCarrito, Modulo.empleadoActual.EmpleadoId);
        }
    }
}
