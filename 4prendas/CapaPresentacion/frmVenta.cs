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
using System.Drawing.Printing;

namespace CapaPresentacion
{
    public partial class frmVenta : Form
    {
        string tipoTienda;
        List<Producto> prodsStockMinimo;
        bool estaCargado = false;

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
            estaCargado = false;
            cargarCmbBuscar();
            dgvCarrito.Hide();
            dgvCarrito.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cargarStockMinimo();
            cargarListaTrabajadores();
            estaCargado = true;
            cargarFamilias();
            ocultarGboSubFam();
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void cargarStockMinimo()
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cargarListaTrabajadores()
        {
            this.cmbEmpleado.SelectedIndexChanged -= new EventHandler(cmbEmpleado_SelectedIndexChanged);
            cmbEmpleado.DataSource = Modulo.empleados;
            this.cmbEmpleado.SelectedIndexChanged += new EventHandler(cmbEmpleado_SelectedIndexChanged);
            cmbEmpleado.DisplayMember = "nombre";
            cmbEmpleado.SelectedItem = Modulo.empleadoActual;
            imgEmpleado.Image = Modulo.empleadoActual != null && File.Exists(Modulo.empleadoActual.Foto) ? Image.FromFile(Modulo.empleadoActual.Foto) : Properties.Resources.newsle_empty_icon;
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpleado.SelectedItem != null && estaCargado)
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
            try
            {
                switch (cmbBuscar.SelectedItem.ToString())
                {
                    case "Código de barras":
                        long parse = 0;
                        if (long.TryParse(txtBuscar.Text, out parse))
                        {
                            if (txtBuscar.Text.Length < 13)
                            {
                                productos = Modulo.miNegocio.getProdsCodigoBarras(parse);
                                dgvProductos.DataSource = productos;
                                dgvCarrito.Refresh();
                            }
                        }
                        break;
                    case "Código de artículo":
                        productos = Modulo.miNegocio.getProdsPorCodigoArticulo(txtBuscar.Text);

                        dgvProductos.DataSource = productos;
                        dgvCarrito.Refresh();
                        break;
                    case "Descripción":
                        productos = Modulo.miNegocio.getProdsPorDescripcion(txtBuscar.Text);

                        dgvProductos.DataSource = productos;
                        dgvCarrito.Refresh();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnCarrito_Click(object sender, EventArgs e)
        {
            dgvCarrito.DataSource = null;
            dgvCarrito.DataSource = (from p in productosCarrito
                                     select new { CodigoArticulo = p.CodigoArticulo, Descripcion = p.Descripcion, Coste = p.Coste, Unidades = p.Unidades }).ToList();
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
            try
            {
                ponerFamiliasEnBlanco();
                familias = Modulo.miNegocio.getFamiliasSubfamilias();

                for (int i = gboFamilia.Controls.Count - 1, j = 0; i >= 0; i--, j++)
                {
                    if (j <= familias.Count - 1)
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
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadSubfamilias(object sender, EventArgs e)
        {
            try
            {
                ponerFamiliasEnBlanco();
                ponerSubfamiliasEnBlanco();
                Button b = (Button)sender;
                b.BackColor = Color.LightBlue;
                Familia f = (Familia)b.Tag;
                productos = Modulo.miNegocio.getProductosFamilia(f.CodFamilia);
                dgvProductos.DataSource = productos;

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
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadProductosSubfam(object sender, EventArgs e)
        {
            try
            {
                ponerSubfamiliasEnBlanco();
                Button b = (Button)sender;
                b.BackColor = Color.LightBlue;
                SubFamilia s = (SubFamilia)b.Tag;

                productos = Modulo.miNegocio.getProductos(s.CodFamilia, s.CodSubFamilia);
                if (productos != null)
                {
                    dgvProductos.DataSource = productos;
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (e.RowIndex == -1)
            {
                return;
            }
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
            }
            else
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

            PrintDocument pd = new PrintDocument();
            pd.PrinterSettings.PrinterName = "Brother QL-700";
            pd.DefaultPageSettings.Landscape = false;
            var sizes = pd.PrinterSettings.PaperSizes;
            PaperSize ps = null;
            foreach (PaperSize s in sizes)
            {
                if (s.PaperName.Equals("62mm"))
                {
                    ps = s;
                    break;
                }
            }
            pd.DefaultPageSettings.PaperSize = ps;


            pd.PrintPage += (s, args) =>
            {
                float yPos = 0;
                int cont = 0;
                float margenIzq = 7;
                float total = 0;
                Font printFont = new Font(FontFamily.GenericSansSerif, 7.0F, FontStyle.Bold);
                args.Graphics.DrawString("PRODUCTO - CANT - PRECIO - TOTAL", printFont, Brushes.Black, margenIzq, yPos, new StringFormat());

                printFont = new Font(FontFamily.GenericSansSerif, 10.0F, FontStyle.Bold);
                yPos = yPos + 5;
                for (int i = 0; i < productosCarrito.Count; i++)
                {
                    yPos = yPos + 15;
                    args.Graphics.DrawString(productosCarrito[i].ToString(), printFont, Brushes.Black, margenIzq, yPos, new StringFormat());
                    cont++;
                    total = total + (productosCarrito[i].Coste * productosCarrito[i].Unidades);
                }
                yPos = yPos + 20;
                args.Graphics.DrawString("Total: " + total.ToString() + "€", printFont, Brushes.Black, margenIzq, yPos, new StringFormat());
                args.Graphics.DrawString(" ", printFont, Brushes.Black, margenIzq, yPos, new StringFormat());

                printFont = new Font(FontFamily.GenericSansSerif, 7.0F, FontStyle.Bold);
                args.Graphics.DrawString("Le ha atendido: " + Modulo.empleadoActual.Nombre, printFont, Brushes.Black, margenIzq, yPos, new StringFormat());
                args.Graphics.DrawString(" ", printFont, Brushes.Black, margenIzq, yPos, new StringFormat());
                args.Graphics.DrawString("Cuatrovientos Centro Integrado", printFont, Brushes.Black, margenIzq, yPos, new StringFormat());
                args.Graphics.DrawString("Av. San Jorge 2, Pamplona", printFont, Brushes.Black, margenIzq, yPos, new StringFormat());
                args.Graphics.DrawString("Tel: 948 124 129", printFont, Brushes.Black, margenIzq, yPos, new StringFormat());

            };
            PrintDialog pdi = new PrintDialog();
            pdi.Document = pd;
            if (pdi.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
            try
            {
                Modulo.miNegocio.insertVenta(productosCarrito, Modulo.empleadoActual.EmpleadoId);
                numProdsCarrito = 0;
                btnCarrito.Text = "0";
                productosCarrito.Clear();
                dgvCarrito.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            try
            {
                productos = Modulo.miNegocio.getTodosProductos();
                dgvProductos.DataSource = Modulo.miNegocio.getTodosProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToCsV(DataGridView dGV)
        {
            string filename = @"Productos.doc";
            string stOutput = "";
            string sHeaders = "";
            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf8 = Encoding.UTF8;
            byte[] output = utf8.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length);
            bw.Flush();
            bw.Close();
            fs.Close();
        }
    }
}