﻿using System;
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
        string shopMode;
        List<Producto> ProdsStockMinimo;
        List<Empleado> Empleados;
        private List<Familia> familias;
        private List<Producto> productos;
        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmInicio_Load(object sender, EventArgs e)
        {
            loadCmbSearch();
            dgvCarrito.Hide();
            checkStockMinimo();
            loadWorkersList();
            loadFamilias();
            makeGboSubFamInvisible();
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        //Al seleccionar familia, cargar subfamilia

        //Al seleccionar subfamilia, cagar dgv

        private void checkStockMinimo()
        {
            ProdsStockMinimo = Modulo.miNegocio.getProdsStockMinimo();
            int num;
            if (Modulo.miNegocio.getProdsStockMinimo() == null)
            {
                num = 0;
            }
            else
            {
                num = ProdsStockMinimo.Count();
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

        private void loadWorkersList()
        {
            Empleados = Modulo.miNegocio.getEmpleados();
            cmbEmpleado.DataSource = Empleados;
            cmbEmpleado.DisplayMember = "empleadoId";
        }

        private void btnTestNext_Click(object sender, EventArgs e)
        {
            (new frmLoginAdmin()).Show();
        }

        private void btnIRALOGINADMIN_Click(object sender, EventArgs e)
        {
            Form frm = new frmLoginAdmin();
            frm.Show();
        }

        private void btnIRACONFIG_Click(object sender, EventArgs e)
        {
            Form frm = new frmConfig();
            frm.Show();
        }
        private void btnIRARECOGIDA_Click(object sender, EventArgs e)
        {
            Form frm = new frmRecogida();
            frm.Show();
        }
        private void btnIRAREGISTRO_Click(object sender, EventArgs e)
        {
            Form frm = new frmRegistro();
            frm.Show();
        }

        private void cmbEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblWorkerName.Text = ((Empleado)cmbEmpleado.SelectedItem).Nombre;
            if (System.IO.File.Exists(((Empleado)cmbEmpleado.SelectedItem).Foto))
            {
                imgWorker.Image = new System.Drawing.Bitmap(((Empleado)cmbEmpleado.SelectedItem).Foto);
            }else
            {
                imgWorker.Image = CapaPresentacion.Properties.Resources.newsle_empty_icon;
            }
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proceso = new System.Diagnostics.Process();
            proceso.StartInfo.FileName = "calc.exe";
            proceso.StartInfo.Arguments = "";
            proceso.Start();
        }

        private void loadCmbSearch()
        {
            cmbSearch.Items.Add("Codigo de barras");
            cmbSearch.Items.Add("Descripcion");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            switch (cmbSearch.SelectedText)
            {
                case "Código de barras":
                    dgvProducts.DataSource = Modulo.miNegocio.getProdsPorCodigoArticulo(txtSearch.Text);
                    break;
                case "Descripcion":
                    dgvProducts.DataSource = Modulo.miNegocio.getProdsPorDescripcion(txtSearch.Text);
                    break;
                default:
                    break;
            }
        }



        private void btnCarrito_Click(object sender, EventArgs e)
        {
            dgvCarrito.Show();
        }

        private void dgvCarrito_MouseLeave(object sender, EventArgs e)
        {
            dgvCarrito.Hide();
        }

        private void loadShopMode()
        {
            string line;
            try
            {
                string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                System.IO.StreamReader file = new System.IO.StreamReader(mydocpath + @"\.config.txt");
                System.Console.WriteLine(shopMode);
                while ((line = file.ReadLine()) != null)
                {
                    if (line.StartsWith("ShopMode="))
                    {
                        shopMode = line.Split('=')[1];
                    }
                }
                file.Close();
            }
            catch
            {
                MessageBox.Show("Error al cargar el archivo de configuración!!! " + "" + "Se cargara la configuración por defecto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                shopMode = "food";
            }
        }

        private void loadFamilias()
        {
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
            Button b = (Button)sender;
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
            Button b = (Button)sender;
            SubFamilia s = (SubFamilia)b.Tag;
            
            productos = Modulo.miNegocio.getProductos(s.CodFamilia, s.CodSubFamilia);
            if (productos != null)
            {
                dgvProducts.DataSource = productos;
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
            checkStockMinimo();
            dgvProducts.DataSource = ProdsStockMinimo;
            dgvProducts.Refresh();
        }

        private void makeGboSubFamInvisible()
        {
            foreach (Control c in gboSubfamilia.Controls)
            {
                c.Visible = false;
            }
        }
    }
}
