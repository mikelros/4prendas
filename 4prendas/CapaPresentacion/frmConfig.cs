using CapaEntidades;
using CapaNegocio;
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

namespace CapaPresentacion
{
    public partial class frmConfig : Form
    {
        Empleado empleadoBorrar;
        List<Empleado> empleados;
        List<Empleado> empleadosCreados = new List<Empleado>();
        List<Empleado> empleadosBorrados = new List<Empleado>();
        Producto producto;
        string tipoTiendaAnterior;

        string rutaMisDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string tipoTienda;
        bool cambios;

        public frmConfig()
        {
            InitializeComponent();
        }


        private void rbtnFood_CheckedChanged(object sender, EventArgs e)
        {
            tipoTienda = "food";
            cambios = true;
            if (tipoTienda == tipoTiendaAnterior)
            {
                cambios = false;
            }

        }

        private void rbtnClothes_CheckedChanged(object sender, EventArgs e)
        {
            tipoTienda = "clothes";
            cambios = true;
            if (tipoTienda == tipoTiendaAnterior)
            {
                cambios = false;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            string rutaFoto = "";
            string nombreArchivo ="";
            if (txtCrearNombre.Text.Equals("") )
            {
                lblCrearError.Show();
                return;
            }else
            {
                lblCrearError.Hide();
            }
            if (!txtCrearFoto.Text.Equals(""))
            {
                if (!File.Exists(txtCrearFoto.Text))
                {
                    lblNoExisteArchivoCrearError.Show();
                    return;
                }
                else
                {
                    lblNoExisteArchivoCrearError.Hide();
                    nombreArchivo = System.IO.Path.GetFileNameWithoutExtension(txtCrearFoto.Text);
                    Bitmap imagen = new Bitmap(txtCrearFoto.Text);
                    rutaFoto = rutaMisDocumentos + "/" + nombreArchivo + ".jpeg";
                    imagen.Save(rutaFoto, System.Drawing.Imaging.ImageFormat.Jpeg);

                }
            }
            Empleado emp = new Empleado(txtCrearNombre.Text, rutaFoto);
            empleados.Add(emp);
            empleadosCreados.Add(emp);
            cambios = true;
            rutaFoto = "";
            cancelarCrear();
        }

        private void bntCreateCancel_Click(object sender, EventArgs e)
        {
            cancelarCrear();
        }
        private void cancelarCrear()
        {
            txtCrearNombre.Text = "";
            txtCrearFoto.Text = "";
        }
        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog abrirFileDialog1 = new OpenFileDialog();

            abrirFileDialog1.InitialDirectory = "c:\\";
            abrirFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
            abrirFileDialog1.FilterIndex = 2;
            abrirFileDialog1.RestoreDirectory = true;

            if (abrirFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = abrirFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            lblNoExisteArchivoCrearError.Hide();
                            txtCrearFoto.Text = abrirFileDialog1.FileName;
                            Bitmap imagen = new Bitmap(txtCrearFoto.Text);
                            pboFotoEmpleado.BackgroundImage = imagen;
                            pboFotoEmpleado.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e) //Probar
        {
            if (empleadoBorrar.Nombre == null)
            {
                lblBorrarError.Show();
            }
            else
            {
                lblBorrarError.Hide();
                empleados.Remove(empleadoBorrar);
                if (!empleadosCreados.Contains(empleadoBorrar))
                {
                empleadosBorrados.Add(empleadoBorrar);
                    borrarFotoEmpleado(empleadoBorrar.Foto);
                }
                cambios = true;
                
            }
        }

        private void borrarFotoEmpleado(string photo)
        {
            if (System.IO.File.Exists(photo))
            {
                try
                {
                    System.IO.File.Delete(photo);
                }
                catch (System.IO.IOException e)
                {
                    Console.WriteLine(e.Message);
                    return;
                }
            }
        }

        private void frmConfig_Load(object sender, EventArgs e)
        {
            
            lblEmpleadoNoExisteError.Hide();

            gboDeleteEmployer.Hide();

            lblNoExisteArchivoCrearError.Hide();
            

            lblBorrarError.Hide();
            lblCrearError.Hide();
            lblEmpleadoNoExisteError.Hide();
            


            nudEditarProductoStock.Maximum  = int.MaxValue;
            nudEditarProductoMinStock.Maximum = int.MaxValue;
            nudEditarProductoCoste.Maximum = int.MaxValue;
            nudEditarProductoIdEmpleado.Maximum = int.MaxValue; 
            nudEditarProductoLugarId.Maximum = int.MaxValue;
            nudEditarProductoIdRecogida.Maximum = int.MaxValue; 

            rbtnEditarProducto.Select();

            cargarEmpleados();

            cargarShopMode();

            empleadoBorrar = null;

        }
        private void cargarEmpleados()
        {
            try
            {
            empleados = Modulo.miNegocio.getEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cargarShopMode()
        {
            string line;
            try
            {

                System.IO.StreamReader file = new System.IO.StreamReader(rutaMisDocumentos + @"\.config.txt");

                System.Console.WriteLine(tipoTienda);
                while ((line = file.ReadLine()) != null)
                {
                    if (line.StartsWith("ShopMode="))
                    {
                        tipoTienda = line.Split('=')[1];
                        tipoTiendaAnterior = tipoTienda;
                    }
                }

                file.Close();
            }
            catch
            {
                MessageBox.Show("¡Error al cargar el archivo de configuración! " + "" + "Se cargará la configuración por defecto.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tipoTienda = "food";
                guardarTipoTienda();
            }
            if (tipoTienda == "food")
            {
                rbtnAlimentos.Checked = true;
            }
            else
            {
                rbtnPrendas.Checked = true;
            }
        }

        private void btnDeleteCancel_Click(object sender, EventArgs e)
        {
            cancelarBorrado();
        }

        

        

        private void cancelarBorrado()
        {
            nudBorrarNumEmpleado.Text = "";
            lblBorrarNombre.Text = "";
            lblEmpleadoNoExisteError.Hide();
            empleadoBorrar = null;
        }

        private void guardarTipoTienda()
        {
            try
            {

                using (StreamWriter outputFile = new StreamWriter(rutaMisDocumentos + @"\.config.txt"))
                {
                    outputFile.WriteLine("ShopMode=" + tipoTienda);
                }
            }
            catch
            {

            }
            finally
            {

            }
            cancelarBorrado();
            cancelarCrear();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            guardarTipoTienda();
            guardarCambiosEmpleado();
            cambios = false;
        }
        private void guardarCambiosEmpleado()
        {
            try
            {

                foreach (Empleado crtEmp in empleadosCreados)
                {
                    Modulo.miNegocio.crearEmpleado(crtEmp.Nombre, crtEmp.Foto);
                    Modulo.empleados = Modulo.miNegocio.getEmpleados();
                }
                foreach (Empleado dltEmp in empleadosBorrados)
                {
                    Modulo.miNegocio.eliminarEmpleado(dltEmp.EmpleadoId);
                    borrarFotoEmpleado(dltEmp.Foto);
                }

                Modulo.empleados = Modulo.miNegocio.getEmpleados();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (cambios)
            {
                DialogResult result = MessageBox.Show("Ha realizado cambios." + "\n" + "¿Desea guardar los cambios?", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    guardarTipoTienda();
                }else if(result == DialogResult.Cancel)
                {
                    return;
                }
            }
            Form frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            string archivoCopiar;
            SaveFileDialog nuevaCopia = new SaveFileDialog();
            nuevaCopia.Filter = "Base de datos|*.accdb";
            nuevaCopia.ShowDialog();
            archivoCopiar = "4Prendas.accdb";
            
            if (System.IO.File.Exists(archivoCopiar))
            {
                if (!nuevaCopia.FileName.Equals(""))
                {
                    System.IO.File.Copy(archivoCopiar, nuevaCopia.FileName);
                    MessageBox.Show("File Copied");
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

        private void btnUpdatePorduct_Click(object sender, EventArgs e)
        {
            
            
                producto.Stock = int.Parse(nudEditarProductoStock.Value.ToString());

             
                producto.StockMinimo = int.Parse(nudEditarProductoMinStock.Value.ToString());

            

                producto.Coste = float.Parse(nudEditarProductoCoste.Value.ToString());


            producto.EmpleadoId = int.Parse(nudEditarProductoIdEmpleado.Value.ToString()) ;
        
             
                producto.Descripcion = txtEditarProductoDescripcion.Text;

             
                producto.CodFamilia = txtEditarProductoCodigoFamilia.Text;

            
                producto.LugarId = int.Parse(nudEditarProductoLugarId.Value.ToString());

             
                producto.RecogidaId = int.Parse(nudEditarProductoIdRecogida.Value.ToString());

           
                producto.Medida = txtEditarTallaProducto.Text;
            try { 
            Modulo.miNegocio.actualizarProducto(producto);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUpdateCancel_Click(object sender, EventArgs e)
        {
            txtEditarProductoCodigo.Text = "";
            nudEditarProductoStock.Value = 0;
            nudEditarProductoMinStock.Value = 0;
            nudEditarProductoCoste.Value = 0;
            nudEditarProductoIdEmpleado.Value = 0;
            txtEditarProductoDescripcion.Text = "";
            txtEditarProductoCodigoFamilia.Text = "";
            nudEditarProductoLugarId.Text = "";
            nudEditarProductoIdRecogida.Text = "";
            txtEditarTallaProducto.Text = "";
            producto = null;

        }

       
        private void buscarProducto()
        {
            try { 
            producto = Modulo.miNegocio.getProdsPorCodigoArticulo(txtEditarProductoCodigo.Text).First<Producto>();
            if (producto == null)
            {
                lblCodigoNoEncontradoStockMinimoError.Show();
            }
            else
            {
                lblCodigoNoEncontradoStockMinimoError.Hide();
                nudEditarProductoStock.Value = producto.Stock;
                nudEditarProductoMinStock.Value = producto.StockMinimo;
                nudEditarProductoCoste.Value = int.Parse(producto.Coste.ToString());
                nudEditarProductoIdEmpleado.Value = producto.EmpleadoId;
                txtEditarProductoDescripcion.Text = producto.Descripcion;
                txtEditarProductoCodigoFamilia.Text = producto.CodFamilia;
                nudEditarProductoLugarId.Value = producto.LugarId;
                nudEditarProductoIdRecogida.Value = producto.RecogidaId;
                txtEditarTallaProducto.Text = producto.Medida;
                txtEditarProductoSubFamiliaCodigo.Text = producto.CodSubFamilia;

            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEditProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtEditarProductoCodigo.TextLength == 9)
            {
                buscarProducto();
            }
        }

        private void chargeEmpleado(object sender, EventArgs e)
        {
            foreach (Empleado emplead in empleados)
            {
                if (emplead.EmpleadoId == nudBorrarNumEmpleado.Value)
                {
                    lblBorrarNombre.Text = emplead.Nombre;
                    empleadoBorrar = emplead;
                    return;
                }else
                {
                    lblBorrarNombre.Text = "";
                }
            }
        }

        private void txtEditProductCode_TextChanged(object sender, EventArgs e)
        {
            if (txtEditarProductoCodigo.TextLength == 9)
            {
                buscarProducto();
            }
        }

        private void btnCreateSearchPhoto_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txtCrearFoto.Text))
            {
                lblNoExisteArchivoCrearError.Show();
                return;
            }else
            {
                lblNoExisteArchivoCrearError.Hide();
                Bitmap Picture = new Bitmap(txtCrearFoto.Text);
                pboFotoEmpleado.BackgroundImage = Picture;
                pboFotoEmpleado.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void btnRestoreDataBase_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog(); 

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "Acces Data Base Files|*.accdb|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            DialogResult result = MessageBox.Show("¿ESTÁ SEGURO DE QUERER SOBRESCRIBIR LA BASE DE DATOS ACTUAL POR EL ARCHIVO SELECCIONADO? RECUERDE QUE ESTE CAMBIO NO SE PODRÁ DESHACER.", "", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                            if (result == DialogResult.Yes)
                            {
                            File.Copy(openFileDialog1.FileName, "4Prendas.accdb", true);
                            }
                                return;
                            

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void rbtnEditarProducto_CheckedChanged(object sender, EventArgs e)
        {
            gboEditProduct.Show();
            gboAnadirFamilia.Hide();
            gboAñadirSubFamilia.Hide();
        }

        private void btnAñadirSubFamilia_Click(object sender, EventArgs e)
        {
            try { 
            SubFamilia subFam = new SubFamilia(txtCodFamiliaParaSub.Text, txtCodigoSubFamilia.Text, txtNombreSubFamila.Text, txtImagenSubFamilia.Text, int.Parse(txtIVASub.Text), int.Parse(txtNumSub.Text));
            Modulo.miNegocio.InsertarSubFamilia(subFam);
            MessageBox.Show("Familia insertada correctamente");
            btnCancelarSubFamilia_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAnadirFamilia_Click(object sender, EventArgs e)
        {
            try { 
            Familia fam = new Familia(txtCodigoFamilia.Text, txtNombreFamilia.Text, txtImagenFamilia.Text, int.Parse(txtNumCodFam.Text));
            Modulo.miNegocio.InsertarFamilia(fam);
            MessageBox.Show("SubFamilia insertada correctamente");
            btnCancelarAnadirFamilia_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelarAnadirFamilia_Click(object sender, EventArgs e)
        {
            txtCodigoFamilia.Text = "";
            txtNombreFamilia.Text = "";
            txtImagenFamilia.Text = "";
            txtNumCodFam.Text = "";

        }

        private void btnCancelarSubFamilia_Click(object sender, EventArgs e)
        {
            txtCodigoSubFamilia.Text = "";
            txtCodFamiliaParaSub.Text = "";
            txtNombreSubFamila.Text = "";
            txtImagenSubFamilia.Text = "";
            txtIVASub.Text = "";
            txtNumSub.Text = "";
        }

        private void rbtnAnadirFamilia_CheckedChanged(object sender, EventArgs e)
        {

            gboEditProduct.Hide();
            gboAnadirFamilia.Show();
            gboAñadirSubFamilia.Hide();
        }

        private void rbtnAñadirSubFamilia_CheckedChanged(object sender, EventArgs e)
        {
            gboAñadirSubFamilia.Show();
            gboEditProduct.Hide();
            gboAnadirFamilia.Hide();
        }
    }
}
