namespace CapaPresentacion
{
    partial class frmRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            this.gboRegistro = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.chb = new System.Windows.Forms.CheckBox();
            this.lblCodArticulo = new System.Windows.Forms.Label();
            this.lblCodArticuloLabel = new System.Windows.Forms.Label();
            this.cboRecogida = new System.Windows.Forms.ComboBox();
            this.nudCoste = new System.Windows.Forms.NumericUpDown();
            this.lblCoste = new System.Windows.Forms.Label();
            this.nudAltura = new System.Windows.Forms.NumericUpDown();
            this.nudEstante = new System.Windows.Forms.NumericUpDown();
            this.nudUnidades = new System.Windows.Forms.NumericUpDown();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblErrorNumRecogida = new System.Windows.Forms.Label();
            this.lblErrorStock = new System.Windows.Forms.Label();
            this.txtEstanteria = new System.Windows.Forms.TextBox();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblRecogida = new System.Windows.Forms.Label();
            this.lblEstanteria = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblEstante = new System.Windows.Forms.Label();
            this.lblMedida = new System.Windows.Forms.Label();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.gboSubfamilia = new System.Windows.Forms.GroupBox();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.gboFamilia = new System.Windows.Forms.GroupBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.imgEmpleado = new System.Windows.Forms.PictureBox();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.gboRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnidades)).BeginInit();
            this.gboSubfamilia.SuspendLayout();
            this.gboFamilia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gboRegistro
            // 
            this.gboRegistro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gboRegistro.BackColor = System.Drawing.Color.Transparent;
            this.gboRegistro.Controls.Add(this.btnImprimir);
            this.gboRegistro.Controls.Add(this.chb);
            this.gboRegistro.Controls.Add(this.lblCodArticulo);
            this.gboRegistro.Controls.Add(this.lblCodArticuloLabel);
            this.gboRegistro.Controls.Add(this.cboRecogida);
            this.gboRegistro.Controls.Add(this.nudCoste);
            this.gboRegistro.Controls.Add(this.lblCoste);
            this.gboRegistro.Controls.Add(this.nudAltura);
            this.gboRegistro.Controls.Add(this.nudEstante);
            this.gboRegistro.Controls.Add(this.nudUnidades);
            this.gboRegistro.Controls.Add(this.btnGenerar);
            this.gboRegistro.Controls.Add(this.lblErrorNumRecogida);
            this.gboRegistro.Controls.Add(this.lblErrorStock);
            this.gboRegistro.Controls.Add(this.txtEstanteria);
            this.gboRegistro.Controls.Add(this.txtMedida);
            this.gboRegistro.Controls.Add(this.txtDescripcion);
            this.gboRegistro.Controls.Add(this.lblAltura);
            this.gboRegistro.Controls.Add(this.lblRecogida);
            this.gboRegistro.Controls.Add(this.lblEstanteria);
            this.gboRegistro.Controls.Add(this.lblDescripcion);
            this.gboRegistro.Controls.Add(this.lblEstante);
            this.gboRegistro.Controls.Add(this.lblMedida);
            this.gboRegistro.Controls.Add(this.lblUnidades);
            this.gboRegistro.Location = new System.Drawing.Point(12, 57);
            this.gboRegistro.Name = "gboRegistro";
            this.gboRegistro.Size = new System.Drawing.Size(281, 511);
            this.gboRegistro.TabIndex = 0;
            this.gboRegistro.TabStop = false;
            this.gboRegistro.Text = "Registro de Articulos";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.White;
            this.btnImprimir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnImprimir.BackgroundImage")));
            this.btnImprimir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(126, 408);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(70, 86);
            this.btnImprimir.TabIndex = 28;
            this.btnImprimir.Text = "C. Barras";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // chb
            // 
            this.chb.AutoSize = true;
            this.chb.Location = new System.Drawing.Point(6, 488);
            this.chb.Name = "chb";
            this.chb.Size = new System.Drawing.Size(114, 17);
            this.chb.TabIndex = 8;
            this.chb.Text = "Producto existente";
            this.chb.UseVisualStyleBackColor = true;
            this.chb.CheckedChanged += new System.EventHandler(this.chb_CheckedChanged);
            // 
            // lblCodArticulo
            // 
            this.lblCodArticulo.AutoSize = true;
            this.lblCodArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodArticulo.Location = new System.Drawing.Point(144, 23);
            this.lblCodArticulo.Name = "lblCodArticulo";
            this.lblCodArticulo.Size = new System.Drawing.Size(0, 16);
            this.lblCodArticulo.TabIndex = 27;
            // 
            // lblCodArticuloLabel
            // 
            this.lblCodArticuloLabel.AutoSize = true;
            this.lblCodArticuloLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodArticuloLabel.Location = new System.Drawing.Point(6, 21);
            this.lblCodArticuloLabel.Name = "lblCodArticuloLabel";
            this.lblCodArticuloLabel.Size = new System.Drawing.Size(105, 18);
            this.lblCodArticuloLabel.TabIndex = 26;
            this.lblCodArticuloLabel.Text = "Cód. artículo";
            // 
            // cboRecogida
            // 
            this.cboRecogida.BackColor = System.Drawing.SystemColors.Window;
            this.cboRecogida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRecogida.FormattingEnabled = true;
            this.cboRecogida.Location = new System.Drawing.Point(147, 191);
            this.cboRecogida.Name = "cboRecogida";
            this.cboRecogida.Size = new System.Drawing.Size(121, 21);
            this.cboRecogida.TabIndex = 3;
            // 
            // nudCoste
            // 
            this.nudCoste.Location = new System.Drawing.Point(147, 241);
            this.nudCoste.Name = "nudCoste";
            this.nudCoste.Size = new System.Drawing.Size(124, 20);
            this.nudCoste.TabIndex = 4;
            // 
            // lblCoste
            // 
            this.lblCoste.AutoSize = true;
            this.lblCoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoste.Location = new System.Drawing.Point(6, 249);
            this.lblCoste.Name = "lblCoste";
            this.lblCoste.Size = new System.Drawing.Size(53, 18);
            this.lblCoste.TabIndex = 22;
            this.lblCoste.Text = "Coste";
            // 
            // nudAltura
            // 
            this.nudAltura.Location = new System.Drawing.Point(147, 360);
            this.nudAltura.Name = "nudAltura";
            this.nudAltura.Size = new System.Drawing.Size(124, 20);
            this.nudAltura.TabIndex = 7;
            this.nudAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros);
            // 
            // nudEstante
            // 
            this.nudEstante.Location = new System.Drawing.Point(147, 321);
            this.nudEstante.Name = "nudEstante";
            this.nudEstante.Size = new System.Drawing.Size(124, 20);
            this.nudEstante.TabIndex = 6;
            this.nudEstante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros);
            // 
            // nudUnidades
            // 
            this.nudUnidades.Location = new System.Drawing.Point(147, 141);
            this.nudUnidades.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudUnidades.Name = "nudUnidades";
            this.nudUnidades.Size = new System.Drawing.Size(124, 20);
            this.nudUnidades.TabIndex = 2;
            this.nudUnidades.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.White;
            this.btnGenerar.BackgroundImage = global::CapaPresentacion.Properties.Resources.plus;
            this.btnGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.Location = new System.Drawing.Point(202, 408);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(69, 86);
            this.btnGenerar.TabIndex = 9;
            this.btnGenerar.Text = "Añadir";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblErrorNumRecogida
            // 
            this.lblErrorNumRecogida.AutoSize = true;
            this.lblErrorNumRecogida.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNumRecogida.Location = new System.Drawing.Point(164, 215);
            this.lblErrorNumRecogida.Name = "lblErrorNumRecogida";
            this.lblErrorNumRecogida.Size = new System.Drawing.Size(91, 13);
            this.lblErrorNumRecogida.TabIndex = 17;
            this.lblErrorNumRecogida.Text = "Campo obligatorio";
            // 
            // lblErrorStock
            // 
            this.lblErrorStock.AutoSize = true;
            this.lblErrorStock.ForeColor = System.Drawing.Color.Red;
            this.lblErrorStock.Location = new System.Drawing.Point(164, 164);
            this.lblErrorStock.Name = "lblErrorStock";
            this.lblErrorStock.Size = new System.Drawing.Size(91, 13);
            this.lblErrorStock.TabIndex = 15;
            this.lblErrorStock.Text = "Campo obligatorio";
            // 
            // txtEstanteria
            // 
            this.txtEstanteria.Location = new System.Drawing.Point(147, 280);
            this.txtEstanteria.Name = "txtEstanteria";
            this.txtEstanteria.Size = new System.Drawing.Size(124, 20);
            this.txtEstanteria.TabIndex = 5;
            // 
            // txtMedida
            // 
            this.txtMedida.Location = new System.Drawing.Point(147, 100);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(124, 20);
            this.txtMedida.TabIndex = 1;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(147, 58);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(124, 20);
            this.txtDescripcion.TabIndex = 0;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(6, 358);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(51, 18);
            this.lblAltura.TabIndex = 6;
            this.lblAltura.Text = "Altura";
            // 
            // lblRecogida
            // 
            this.lblRecogida.AutoSize = true;
            this.lblRecogida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecogida.Location = new System.Drawing.Point(6, 190);
            this.lblRecogida.Name = "lblRecogida";
            this.lblRecogida.Size = new System.Drawing.Size(102, 18);
            this.lblRecogida.TabIndex = 7;
            this.lblRecogida.Text = "Nº Recogida";
            // 
            // lblEstanteria
            // 
            this.lblEstanteria.AutoSize = true;
            this.lblEstanteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstanteria.Location = new System.Drawing.Point(6, 279);
            this.lblEstanteria.Name = "lblEstanteria";
            this.lblEstanteria.Size = new System.Drawing.Size(84, 18);
            this.lblEstanteria.TabIndex = 4;
            this.lblEstanteria.Text = "Estantería";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(6, 57);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(98, 18);
            this.lblDescripcion.TabIndex = 5;
            this.lblDescripcion.Text = "Descripción";
            // 
            // lblEstante
            // 
            this.lblEstante.AutoSize = true;
            this.lblEstante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstante.Location = new System.Drawing.Point(6, 319);
            this.lblEstante.Name = "lblEstante";
            this.lblEstante.Size = new System.Drawing.Size(65, 18);
            this.lblEstante.TabIndex = 3;
            this.lblEstante.Text = "Estante";
            // 
            // lblMedida
            // 
            this.lblMedida.AutoSize = true;
            this.lblMedida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedida.Location = new System.Drawing.Point(6, 109);
            this.lblMedida.Name = "lblMedida";
            this.lblMedida.Size = new System.Drawing.Size(62, 18);
            this.lblMedida.TabIndex = 4;
            this.lblMedida.Text = "Medida";
            // 
            // lblUnidades
            // 
            this.lblUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnidades.Location = new System.Drawing.Point(6, 139);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(102, 38);
            this.lblUnidades.TabIndex = 3;
            this.lblUnidades.Text = "Unidades a introducir";
            // 
            // btnAtras
            // 
            this.btnAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtras.BackColor = System.Drawing.Color.White;
            this.btnAtras.BackgroundImage = global::CapaPresentacion.Properties.Resources.exit;
            this.btnAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(1186, 655);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 113);
            this.btnAtras.TabIndex = 20;
            this.btnAtras.Text = "A&trás";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // gboSubfamilia
            // 
            this.gboSubfamilia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gboSubfamilia.Controls.Add(this.button11);
            this.gboSubfamilia.Controls.Add(this.button12);
            this.gboSubfamilia.Controls.Add(this.button13);
            this.gboSubfamilia.Controls.Add(this.button14);
            this.gboSubfamilia.Controls.Add(this.button15);
            this.gboSubfamilia.Controls.Add(this.button16);
            this.gboSubfamilia.Controls.Add(this.button17);
            this.gboSubfamilia.Controls.Add(this.button18);
            this.gboSubfamilia.Controls.Add(this.button19);
            this.gboSubfamilia.Controls.Add(this.button20);
            this.gboSubfamilia.Location = new System.Drawing.Point(331, 335);
            this.gboSubfamilia.Name = "gboSubfamilia";
            this.gboSubfamilia.Size = new System.Drawing.Size(456, 256);
            this.gboSubfamilia.TabIndex = 11;
            this.gboSubfamilia.TabStop = false;
            this.gboSubfamilia.Text = "Subfamilia";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Location = new System.Drawing.Point(6, 19);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(84, 112);
            this.button11.TabIndex = 67;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Location = new System.Drawing.Point(96, 19);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(84, 112);
            this.button12.TabIndex = 66;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button13.Location = new System.Drawing.Point(186, 19);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(84, 112);
            this.button13.TabIndex = 65;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.Location = new System.Drawing.Point(276, 19);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(84, 112);
            this.button14.TabIndex = 64;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button15.Location = new System.Drawing.Point(366, 19);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(84, 112);
            this.button15.TabIndex = 63;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.White;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button16.Location = new System.Drawing.Point(6, 137);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(84, 112);
            this.button16.TabIndex = 62;
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.White;
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button17.Location = new System.Drawing.Point(96, 137);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(84, 112);
            this.button17.TabIndex = 61;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.White;
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button18.Location = new System.Drawing.Point(186, 137);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(84, 112);
            this.button18.TabIndex = 60;
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.White;
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button19.Location = new System.Drawing.Point(276, 137);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(84, 112);
            this.button19.TabIndex = 59;
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.White;
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button20.Location = new System.Drawing.Point(366, 137);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(84, 112);
            this.button20.TabIndex = 58;
            this.button20.UseVisualStyleBackColor = false;
            // 
            // gboFamilia
            // 
            this.gboFamilia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gboFamilia.Controls.Add(this.button10);
            this.gboFamilia.Controls.Add(this.button9);
            this.gboFamilia.Controls.Add(this.button7);
            this.gboFamilia.Controls.Add(this.button8);
            this.gboFamilia.Controls.Add(this.button5);
            this.gboFamilia.Controls.Add(this.button6);
            this.gboFamilia.Controls.Add(this.button3);
            this.gboFamilia.Controls.Add(this.button4);
            this.gboFamilia.Controls.Add(this.button2);
            this.gboFamilia.Controls.Add(this.button1);
            this.gboFamilia.Location = new System.Drawing.Point(331, 33);
            this.gboFamilia.Name = "gboFamilia";
            this.gboFamilia.Size = new System.Drawing.Size(456, 256);
            this.gboFamilia.TabIndex = 10;
            this.gboFamilia.TabStop = false;
            this.gboFamilia.Text = "Familia";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Location = new System.Drawing.Point(366, 136);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 112);
            this.button10.TabIndex = 67;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Location = new System.Drawing.Point(276, 136);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 112);
            this.button9.TabIndex = 66;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(186, 135);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 112);
            this.button7.TabIndex = 65;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Location = new System.Drawing.Point(96, 136);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 112);
            this.button8.TabIndex = 64;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(6, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 112);
            this.button5.TabIndex = 63;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(366, 18);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 112);
            this.button6.TabIndex = 62;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(276, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 112);
            this.button3.TabIndex = 61;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(186, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 112);
            this.button4.TabIndex = 60;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(96, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 112);
            this.button2.TabIndex = 59;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(6, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 112);
            this.button1.TabIndex = 58;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // imgEmpleado
            // 
            this.imgEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgEmpleado.Image = global::CapaPresentacion.Properties.Resources.newsle_empty_icon;
            this.imgEmpleado.Location = new System.Drawing.Point(1114, 78);
            this.imgEmpleado.Name = "imgEmpleado";
            this.imgEmpleado.Size = new System.Drawing.Size(100, 129);
            this.imgEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgEmpleado.TabIndex = 74;
            this.imgEmpleado.TabStop = false;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.Location = new System.Drawing.Point(1111, 57);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(148, 18);
            this.lblNombreEmpleado.TabIndex = 73;
            this.lblNombreEmpleado.Text = "Nombre Empleado";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEmpleado.BackColor = System.Drawing.Color.White;
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(1114, 33);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpleado.TabIndex = 13;
            this.cmbEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleado_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1111, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 71;
            this.label1.Text = "Empleado:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(12, 606);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.Size = new System.Drawing.Size(775, 231);
            this.dgvProductos.TabIndex = 12;
            this.dgvProductos.Visible = false;
            this.dgvProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellClick);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1273, 780);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.imgEmpleado);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gboSubfamilia);
            this.Controls.Add(this.gboFamilia);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gboRegistro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistro";
            this.Text = "frmRegistro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gboRegistro.ResumeLayout(false);
            this.gboRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAltura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEstante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnidades)).EndInit();
            this.gboSubfamilia.ResumeLayout(false);
            this.gboFamilia.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboRegistro;
        private System.Windows.Forms.Label lblRecogida;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblMedida;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblErrorNumRecogida;
        private System.Windows.Forms.Label lblErrorStock;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.NumericUpDown nudUnidades;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.NumericUpDown nudCoste;
        private System.Windows.Forms.Label lblCoste;
        private System.Windows.Forms.NumericUpDown nudAltura;
        private System.Windows.Forms.NumericUpDown nudEstante;
        private System.Windows.Forms.TextBox txtEstanteria;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblEstanteria;
        private System.Windows.Forms.Label lblEstante;
        private System.Windows.Forms.ComboBox cboRecogida;
        private System.Windows.Forms.GroupBox gboSubfamilia;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.GroupBox gboFamilia;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox imgEmpleado;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodArticulo;
        private System.Windows.Forms.Label lblCodArticuloLabel;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.CheckBox chb;
        private System.Windows.Forms.Button btnImprimir;
    }
}