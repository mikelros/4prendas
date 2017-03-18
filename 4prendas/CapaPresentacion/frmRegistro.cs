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
using System.IO;
using Spire.Barcode;
using System.Drawing.Printing;

namespace CapaPresentacion
{
    public partial class frmRegistro : Form
    {
        private List<Familia> familias;
        private List<Recogida> recogidas;
        private List<Producto> productos;
        private Producto productoExistenteSeleccionado;
        private String codBarrasProductoSeleccionado;
        bool estaCargado = false;
        public frmRegistro()
        {
            InitializeComponent();
            estaCargado = false;

            productoExistenteSeleccionado = null;

            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            hacerGboSubFamInvisible();
            try
            {
                cargarRecogidas();
                cargarEmpleados();
                estaCargado = true;
                cargarFamilias();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void hacerGboSubFamInvisible()
        {
            foreach (Control c in gboSubfamilia.Controls)
            {
                c.Hide();
            }
        }

        private void cargarRecogidas()
        {
            recogidas = Modulo.miNegocio.getRecogidasSinTodosRegistros();
            cboRecogida.DataSource = recogidas;
            cboRecogida.DisplayMember = "idRecogida";
        }

        private void cargarEmpleados()
        {
            this.cmbEmpleado.SelectedIndexChanged -= new EventHandler(cmbEmpleado_SelectedIndexChanged);
            cmbEmpleado.DataSource = Modulo.empleados;
            this.cmbEmpleado.SelectedIndexChanged += new EventHandler(cmbEmpleado_SelectedIndexChanged);
            cmbEmpleado.DisplayMember = "nombre";
            cmbEmpleado.SelectedItem = Modulo.empleadoActual;
            imgEmpleado.Image = Modulo.empleadoActual != null && File.Exists(Modulo.empleadoActual.Foto) ? Image.FromFile(Modulo.empleadoActual.Foto) : Properties.Resources.newsle_empty_icon;
        }

        private void cargarFamilias()
        {
            familias = Modulo.miNegocio.getFamiliasSubfamilias();

            for (int i = gboFamilia.Controls.Count - 1, j = 0; i >= 0; i--, j++)
            {
                if (j <= familias.Count - 1)
                {
                    Familia f = familias[j];
                    gboFamilia.Controls[i].Tag = f;
                    gboFamilia.Controls[i].BackgroundImage = !f.Imagen.Equals("") && File.Exists(f.Imagen) ? Image.FromFile(f.Imagen) : null;
                    gboFamilia.Controls[i].Text = f.Nombre;
                    gboFamilia.Controls[i].Click += new EventHandler(cargarSubfamilias);

                }
                else
                {
                    gboFamilia.Controls[i].Hide();
                }

            }
        }

        private void cargarSubfamilias(object sender, EventArgs e)
        {
            ponerFamiliasEnBlanco();

            Button b = (Button)sender;
            b.BackColor = Color.LightBlue;

            Familia f = (Familia)b.Tag;

            for (int i = 0, j = 0; i < gboSubfamilia.Controls.Count; i++, j++)
            {
                gboSubfamilia.Controls[i].BackColor = Color.White;

                if (j < f.SubFamilias.Count)
                {
                    gboSubfamilia.Controls[i].Show();
                    SubFamilia s = f.SubFamilias[j];
                    gboSubfamilia.Controls[i].Tag = s;
                    gboSubfamilia.Controls[i].BackgroundImage = !s.Imagen.Equals("") && File.Exists(s.Imagen) ? Image.FromFile(s.Imagen) : null;
                    gboSubfamilia.Controls[i].Text = s.Nombre;
                    gboSubfamilia.Controls[i].Click += new EventHandler(cargarProductosSubfam);
                }
                else
                {
                    gboSubfamilia.Controls[i].Hide();
                }

            }

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

        private void cargarProductosSubfam(object sender, EventArgs e)
        {
            ponerSubfamiliasEnBlanco();

            Button b = (Button)sender;
            b.BackColor = Color.LightBlue;
            SubFamilia s = (SubFamilia)b.Tag;

            Familia f = familias.Where((fam) => fam.CodFamilia.ToLower().Equals(s.CodFamilia.ToLower())).SingleOrDefault();
            
            if (chb.Checked)
            {
                cargarProductos(s);
            }
            else
            {
                if (!chb.Checked)
                {
                    try
                    {
                        string id = Modulo.miNegocio.getSiguienteID(s.CodFamilia, s.CodSubFamilia);
                        codBarrasProductoSeleccionado = "2231014" + f.NumCodigo.ToString() + s.NumeroCodigo.ToString() + id;
                        lblCodArticulo.Text = s.CodFamilia.ToString() + s.CodSubFamilia.ToString() + id;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            if (hayErrores())
            {
                MessageBox.Show("Los campos obligatorios deben ser introducidos.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (chb.Checked)
            {
                try
                {
                    productoExistenteSeleccionado.Stock += int.Parse(nudUnidades.Value.ToString());
                    Modulo.miNegocio.actualizarProducto(productoExistenteSeleccionado);
                    limpiarControles();
                    MessageBox.Show("Actualizado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                try
                {
                    Producto producto = new Producto();
                    Lugar lugar = new Lugar(txtEstanteria.Text, int.Parse(nudEstante.Value.ToString()), int.Parse(nudAltura.Value.ToString()));

                    producto.CodigoArticulo = "2231014" + lblCodArticulo.Text;
                    producto.Coste = int.Parse(nudCoste.Text);
                    producto.Descripcion = txtDescripcion.Text;
                    producto.Medida = txtMedida.Text;
                    producto.Stock = int.Parse(nudUnidades.Text);
                    producto.EmpleadoId = ((Empleado)cmbEmpleado.SelectedItem).EmpleadoId;
                    producto.FechaEntrada = Util.GetDateWithoutMilliseconds(DateTime.Now);
                    producto.RecogidaId = ((Recogida)cboRecogida.SelectedItem).IdRecogida;
                    string codfamilia = producto.CodigoArticulo.Substring(0, 2);
                    producto.CodFamilia = codfamilia;
                    string codsubfamilia = producto.CodigoArticulo.Substring(2, 2);
                    producto.CodSubFamilia = codsubfamilia;

                    Lugar lugarFinal = Modulo.miNegocio.getLugar(lugar);
                    if (lugarFinal == null)
                    {
                        MessageBox.Show("Lugar ocupado, debe elegir otro.");
                        return;
                    }
                    producto.LugarId = lugarFinal.Id;

                    List<Producto> productos = new List<Producto>();
                    productos.Add(producto);
                    Modulo.miNegocio.InsertarProductos(productos);
                    limpiarControles();
                    MessageBox.Show("Insertado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }


        }

        private bool hayErrores()
        {
            if (lblCodArticulo.Text.Length != 7)
            {
                return true;
            }

            if (!chb.Checked && cboRecogida.SelectedItem == null)
            {
                cboRecogida.Focus();
                return true;
            }

            if (cmbEmpleado.SelectedItem == null)
            {
                cmbEmpleado.Focus();
                return true;
            }

            return false;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (chb.Checked || cboRecogida.SelectedItem == null)
            {
                cerrarFormulario();
            }
            else
            {
                try
                {
                    Recogida recogida = (Recogida)cboRecogida.SelectedItem;
                    bool recogidaCompleta = Modulo.miNegocio.estaRecogidaCompleta(recogida.IdRecogida);

                    if (!recogidaCompleta)
                    {
                        if (MessageBox.Show("¿Seguro que deseas salir sin introducir todos los productos para esta recogida?", "Salir",
                               MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            cerrarFormulario();
                        }
                    }
                    else
                    {
                        cerrarFormulario();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cerrarFormulario();
                }

            }


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

        private void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void chb_CheckedChanged(object sender, EventArgs e)
        {
            dgvProductos.Visible = !dgvProductos.Visible;

            habilitarControlesInsercion(!dgvProductos.Visible);
            
            codBarrasProductoSeleccionado = "2231014";
            ponerFamiliasEnBlanco();
            ponerSubfamiliasEnBlanco();

        }

        private void habilitarControlesInsercion(bool opcion)
        {
            lblDescripcion.Enabled = opcion;
            txtDescripcion.Enabled = opcion;
            lblMedida.Enabled = opcion;
            txtMedida.Enabled = opcion;
            lblCoste.Enabled = opcion;
            nudCoste.Enabled = opcion;
            lblEstanteria.Enabled = opcion;
            txtEstanteria.Enabled = opcion;
            lblEstante.Enabled = opcion;
            nudEstante.Enabled = opcion;
            lblAltura.Enabled = opcion;
            nudAltura.Enabled = opcion;
            lblRecogida.Enabled = opcion;
            cboRecogida.SelectedItem = null;
            cboRecogida.Enabled = opcion;
        }

        private void cargarProductos(SubFamilia s)
        {
            try
            {
                productos = Modulo.miNegocio.getProductos(s.CodFamilia, s.CodSubFamilia);
                if (productos != null)
                {
                    dgvProductos.DataSource = productos.Select((p) => new { CodigoArticulo = p.CodigoArticulo, Descripcion = p.Descripcion, Coste = p.Coste, Unidades = p.Stock }).ToList();
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void limpiarControles()
        {
            lblCodArticulo.Text = "";
            txtDescripcion.Text = "";
            txtMedida.Text = "";
            nudUnidades.Value = 0;
            nudCoste.Value = 0;
            txtEstanteria.Text = "";
            nudEstante.Value = 0;
            nudAltura.Value = 0;
            chb.Checked = false;
            dgvProductos.DataSource = null;
            dgvProductos.Hide();
            ponerFamiliasEnBlanco();
            ponerSubfamiliasEnBlanco();
            hacerGboSubFamInvisible();
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1)
                {
                    return;
                }

                productoExistenteSeleccionado = productos.ElementAt(e.RowIndex);
                lblCodArticulo.Text = productoExistenteSeleccionado.CodigoArticulo.Substring(7, 7);
                codBarrasProductoSeleccionado = Modulo.miNegocio.getCodigoBarras(productoExistenteSeleccionado.CodigoArticulo);
            } catch(Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cerrarFormulario()
        {
            Form frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (codBarrasProductoSeleccionado.Length != 12)
            {
                MessageBox.Show("Debe seleccionarse un producto antes de poder imprimir su código de barras.", "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String codigoBarras = codBarrasProductoSeleccionado + Util.SacarControl(ulong.Parse(codBarrasProductoSeleccionado));
                BarcodeSettings settings = new BarcodeSettings();
                settings.Type = BarCodeType.EAN13;
                settings.Data = codigoBarras.ToString();

                settings.ResolutionType = ResolutionType.Graphics;
                BarCodeGenerator generator = new BarCodeGenerator(settings);
                Image image = generator.GenerateImage();

                image.RotateFlip(RotateFlipType.Rotate180FlipX);
                Bitmap b = Util.CropImage(image, new Rectangle(0, 0, image.Width, image.Height - 30));
                b.RotateFlip(RotateFlipType.Rotate180FlipX);

                PrintDocument pd = new PrintDocument();
                pd.PrinterSettings.PrinterName = "Brother QL-700";
                pd.DefaultPageSettings.Landscape = false;
                var sizes = pd.PrinterSettings.PaperSizes;
                PaperSize ps = null;
                foreach (PaperSize s in sizes)
                {
                    if (s.PaperName.Equals("62mm x 29mm"))
                    {
                        ps = s;
                        break;
                    }
                }
                pd.DefaultPageSettings.PaperSize = ps;

                pd.PrintPage += (s, args) =>
                {
                    args.Graphics.DrawString(productoExistenteSeleccionado != null ? productoExistenteSeleccionado.Descripcion : txtDescripcion.Text, new Font("Arial", 8), new SolidBrush(Color.Black), 0, 0);
                    args.Graphics.DrawString(productoExistenteSeleccionado != null ? productoExistenteSeleccionado.Coste.ToString() + "€" : nudCoste.Value.ToString() + "€", new Font("Arial", 8), new SolidBrush(Color.Black), 0, 10);
                    args.Graphics.DrawImage(b, new Rectangle(0, 22, b.Width, b.Height));
                };
                PrintDialog pdi = new PrintDialog();
                pdi.Document = pd;
                if (pdi.ShowDialog() == DialogResult.OK)
                {
                    pd.Print();
                }

            }
        }
    }
}
