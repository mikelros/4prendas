namespace CapaPresentacion
{
    partial class frmVenta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.lblWorkerName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStock = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dgvCarrito = new System.Windows.Forms.DataGridView();
            this.btnCarrito = new System.Windows.Forms.Button();
            this.btnCalculator = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.imgWorker = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFinVenta = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWorker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1059, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "Empleado:";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbEmpleado.BackColor = System.Drawing.Color.White;
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(1062, 112);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cmbEmpleado.TabIndex = 52;
            this.cmbEmpleado.SelectedIndexChanged += new System.EventHandler(this.cmbEmpleado_SelectedIndexChanged);
            // 
            // lblWorkerName
            // 
            this.lblWorkerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWorkerName.AutoSize = true;
            this.lblWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorkerName.Location = new System.Drawing.Point(1059, 136);
            this.lblWorkerName.Name = "lblWorkerName";
            this.lblWorkerName.Size = new System.Drawing.Size(148, 18);
            this.lblWorkerName.TabIndex = 53;
            this.lblWorkerName.Text = "Nombre Empleado";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button10);
            this.groupBox1.Controls.Add(this.button9);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.button8);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(12, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 602);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Familia";
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.button10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button10.Location = new System.Drawing.Point(96, 480);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(84, 112);
            this.button10.TabIndex = 67;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.White;
            this.button9.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Location = new System.Drawing.Point(6, 482);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(84, 112);
            this.button9.TabIndex = 66;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.Location = new System.Drawing.Point(96, 364);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 112);
            this.button7.TabIndex = 65;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.White;
            this.button8.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button8.Location = new System.Drawing.Point(6, 364);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(84, 112);
            this.button8.TabIndex = 64;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(96, 248);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(84, 112);
            this.button5.TabIndex = 63;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Location = new System.Drawing.Point(6, 248);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 112);
            this.button6.TabIndex = 62;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(96, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 112);
            this.button3.TabIndex = 61;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(6, 133);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 112);
            this.button4.TabIndex = 60;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
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
            this.button1.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(6, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 112);
            this.button1.TabIndex = 58;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dgvProducts
            // 
            this.dgvProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(398, 202);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.Size = new System.Drawing.Size(649, 549);
            this.dgvProducts.TabIndex = 69;
            this.dgvProducts.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProducts_CellMouseClick);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(977, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 18);
            this.label2.TabIndex = 70;
            this.label2.Text = "Alerta de stock:";
            // 
            // btnStock
            // 
            this.btnStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStock.BackColor = System.Drawing.Color.Lime;
            this.btnStock.Location = new System.Drawing.Point(1100, 22);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(47, 23);
            this.btnStock.TabIndex = 71;
            this.btnStock.Text = "0";
            this.btnStock.UseVisualStyleBackColor = false;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button11);
            this.groupBox2.Controls.Add(this.button12);
            this.groupBox2.Controls.Add(this.button13);
            this.groupBox2.Controls.Add(this.button14);
            this.groupBox2.Controls.Add(this.button15);
            this.groupBox2.Controls.Add(this.button16);
            this.groupBox2.Controls.Add(this.button17);
            this.groupBox2.Controls.Add(this.button18);
            this.groupBox2.Controls.Add(this.button19);
            this.groupBox2.Controls.Add(this.button20);
            this.groupBox2.Location = new System.Drawing.Point(205, 157);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(187, 602);
            this.groupBox2.TabIndex = 68;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Subfamilia";
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button11.Location = new System.Drawing.Point(96, 480);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(84, 112);
            this.button11.TabIndex = 67;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Location = new System.Drawing.Point(6, 482);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(84, 112);
            this.button12.TabIndex = 66;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button13.Location = new System.Drawing.Point(96, 364);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(84, 112);
            this.button13.TabIndex = 65;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.White;
            this.button14.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.button14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button14.Location = new System.Drawing.Point(6, 364);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(84, 112);
            this.button14.TabIndex = 64;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.White;
            this.button15.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.button15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button15.Location = new System.Drawing.Point(96, 248);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(84, 112);
            this.button15.TabIndex = 63;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.White;
            this.button16.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.button16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button16.Location = new System.Drawing.Point(6, 248);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(84, 112);
            this.button16.TabIndex = 62;
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.White;
            this.button17.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.button17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button17.Location = new System.Drawing.Point(96, 133);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(84, 112);
            this.button17.TabIndex = 61;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.White;
            this.button18.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.button18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button18.Location = new System.Drawing.Point(6, 133);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(84, 112);
            this.button18.TabIndex = 60;
            this.button18.UseVisualStyleBackColor = false;
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.White;
            this.button19.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button19.Location = new System.Drawing.Point(96, 17);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(84, 112);
            this.button19.TabIndex = 59;
            this.button19.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.White;
            this.button20.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button20.Location = new System.Drawing.Point(6, 17);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(84, 112);
            this.button20.TabIndex = 58;
            this.button20.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(683, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 72;
            this.label1.Text = "Buscar:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(880, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 18);
            this.label4.TabIndex = 73;
            this.label4.Text = "por";
            // 
            // cmbSearch
            // 
            this.cmbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSearch.BackColor = System.Drawing.Color.White;
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(919, 174);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(128, 21);
            this.cmbSearch.TabIndex = 74;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(745, 174);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(129, 20);
            this.txtSearch.TabIndex = 75;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvCarrito
            // 
            this.dgvCarrito.AllowUserToAddRows = false;
            this.dgvCarrito.AllowUserToDeleteRows = false;
            this.dgvCarrito.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvCarrito.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCarrito.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCarrito.Location = new System.Drawing.Point(402, 172);
            this.dgvCarrito.Margin = new System.Windows.Forms.Padding(2);
            this.dgvCarrito.Name = "dgvCarrito";
            this.dgvCarrito.ReadOnly = true;
            this.dgvCarrito.RowTemplate.Height = 24;
            this.dgvCarrito.Size = new System.Drawing.Size(134, 284);
            this.dgvCarrito.TabIndex = 77;
            this.dgvCarrito.MouseLeave += new System.EventHandler(this.dgvCarrito_MouseLeave);
            // 
            // btnCarrito
            // 
            this.btnCarrito.BackColor = System.Drawing.Color.White;
            this.btnCarrito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarrito.Image = global::CapaPresentacion.Properties.Resources.addcarrito;
            this.btnCarrito.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarrito.Location = new System.Drawing.Point(398, 168);
            this.btnCarrito.Margin = new System.Windows.Forms.Padding(2);
            this.btnCarrito.Name = "btnCarrito";
            this.btnCarrito.Size = new System.Drawing.Size(56, 29);
            this.btnCarrito.TabIndex = 76;
            this.btnCarrito.Text = "0";
            this.btnCarrito.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCarrito.UseVisualStyleBackColor = false;
            this.btnCarrito.Click += new System.EventHandler(this.btnCarrito_Click);
            // 
            // btnCalculator
            // 
            this.btnCalculator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculator.BackColor = System.Drawing.Color.White;
            this.btnCalculator.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.btnCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalculator.Location = new System.Drawing.Point(1062, 296);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(92, 101);
            this.btnCalculator.TabIndex = 56;
            this.btnCalculator.UseVisualStyleBackColor = false;
            this.btnCalculator.Click += new System.EventHandler(this.btnCalculator_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources._4Prendas;
            this.pictureBox3.Location = new System.Drawing.Point(247, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(650, 140);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            // 
            // imgWorker
            // 
            this.imgWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imgWorker.Image = global::CapaPresentacion.Properties.Resources.newsle_empty_icon;
            this.imgWorker.Location = new System.Drawing.Point(1062, 157);
            this.imgWorker.Name = "imgWorker";
            this.imgWorker.Size = new System.Drawing.Size(100, 129);
            this.imgWorker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgWorker.TabIndex = 54;
            this.imgWorker.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Logo4V;
            this.pictureBox1.Location = new System.Drawing.Point(14, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1134, 636);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 113);
            this.btnExit.TabIndex = 78;
            this.btnExit.Text = "&Atrás";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFinVenta
            // 
            this.btnFinVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFinVenta.BackColor = System.Drawing.Color.White;
            this.btnFinVenta.BackgroundImage = global::CapaPresentacion.Properties.Resources.cesta;
            this.btnFinVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFinVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinVenta.Location = new System.Drawing.Point(1053, 636);
            this.btnFinVenta.Name = "btnFinVenta";
            this.btnFinVenta.Size = new System.Drawing.Size(75, 113);
            this.btnFinVenta.TabIndex = 79;
            this.btnFinVenta.Text = "&Fin venta";
            this.btnFinVenta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFinVenta.UseVisualStyleBackColor = false;
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 771);
            this.Controls.Add(this.btnFinVenta);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvCarrito);
            this.Controls.Add(this.btnCarrito);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnStock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.imgWorker);
            this.Controls.Add(this.lblWorkerName);
            this.Controls.Add(this.cmbEmpleado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVenta";
            this.Text = "4Tiendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCarrito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgWorker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label lblWorkerName;
        private System.Windows.Forms.PictureBox imgWorker;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnCalculator;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.TextBox txtSearch;
        internal System.Windows.Forms.Button btnCarrito;
        internal System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnFinVenta;
    }
}

