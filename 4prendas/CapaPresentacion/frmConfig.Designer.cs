namespace CapaPresentacion
{
    partial class frmConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfig));
            this.rbtnAlimentos = new System.Windows.Forms.RadioButton();
            this.rbtnPrendas = new System.Windows.Forms.RadioButton();
            this.grbType = new System.Windows.Forms.GroupBox();
            this.grbNewEmployer = new System.Windows.Forms.GroupBox();
            this.pboFotoEmpleado = new System.Windows.Forms.PictureBox();
            this.lblNoExisteArchivoCrearError = new System.Windows.Forms.Label();
            this.lblCrearError = new System.Windows.Forms.Label();
            this.bntCreateCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtCrearFoto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCrearNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDeleteEmployer = new System.Windows.Forms.GroupBox();
            this.nudBorrarNumEmpleado = new System.Windows.Forms.NumericUpDown();
            this.lblBorrarError = new System.Windows.Forms.Label();
            this.lblEmpleadoNoExisteError = new System.Windows.Forms.Label();
            this.lblBorrarNombre = new System.Windows.Forms.Label();
            this.btnDeleteCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grbEditProduct = new System.Windows.Forms.GroupBox();
            this.nudEditarProductoLugarId = new System.Windows.Forms.NumericUpDown();
            this.nudEditarProductoCollectionId = new System.Windows.Forms.NumericUpDown();
            this.nudEditarProductoCoste = new System.Windows.Forms.NumericUpDown();
            this.nudEditarProductoStock = new System.Windows.Forms.NumericUpDown();
            this.nudEditarProductoMinStock = new System.Windows.Forms.NumericUpDown();
            this.nudEditarProductoEmployerId = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblCoste = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEditarProductoSubFamiliaCodigo = new System.Windows.Forms.TextBox();
            this.txtEditarProductoDescripcion = new System.Windows.Forms.TextBox();
            this.txtEditarProductoCodigoFamilia = new System.Windows.Forms.TextBox();
            this.Medida = new System.Windows.Forms.Label();
            this.txtEditarTallaProducto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCodigoNoEncontradoStockMinimoError = new System.Windows.Forms.Label();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.btnUpdatePorduct = new System.Windows.Forms.Button();
            this.txtEditarProductoCodigo = new System.Windows.Forms.TextBox();
            this.btnRestoreDataBase = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbType.SuspendLayout();
            this.grbNewEmployer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFotoEmpleado)).BeginInit();
            this.grbDeleteEmployer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorrarNumEmpleado)).BeginInit();
            this.grbEditProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditarProductoLugarId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditarProductoCollectionId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditarProductoCoste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditarProductoStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditarProductoMinStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditarProductoEmployerId)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnFood
            // 
            this.rbtnAlimentos.AutoSize = true;
            this.rbtnAlimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnAlimentos.Location = new System.Drawing.Point(6, 24);
            this.rbtnAlimentos.Name = "rbtnFood";
            this.rbtnAlimentos.Size = new System.Drawing.Size(84, 22);
            this.rbtnAlimentos.TabIndex = 10;
            this.rbtnAlimentos.TabStop = true;
            this.rbtnAlimentos.Text = "Comida";
            this.rbtnAlimentos.UseVisualStyleBackColor = true;
            this.rbtnAlimentos.CheckedChanged += new System.EventHandler(this.rbtnFood_CheckedChanged);
            // 
            // rbtnClothes
            // 
            this.rbtnPrendas.AutoSize = true;
            this.rbtnPrendas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPrendas.Location = new System.Drawing.Point(6, 52);
            this.rbtnPrendas.Name = "rbtnClothes";
            this.rbtnPrendas.Size = new System.Drawing.Size(66, 22);
            this.rbtnPrendas.TabIndex = 11;
            this.rbtnPrendas.TabStop = true;
            this.rbtnPrendas.Text = "Ropa";
            this.rbtnPrendas.UseVisualStyleBackColor = true;
            this.rbtnPrendas.CheckedChanged += new System.EventHandler(this.rbtnClothes_CheckedChanged);
            // 
            // grbType
            // 
            this.grbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grbType.Controls.Add(this.rbtnAlimentos);
            this.grbType.Controls.Add(this.rbtnPrendas);
            this.grbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbType.Location = new System.Drawing.Point(12, 106);
            this.grbType.Name = "grbType";
            this.grbType.Size = new System.Drawing.Size(108, 242);
            this.grbType.TabIndex = 12;
            this.grbType.TabStop = false;
            this.grbType.Text = "Tipo Tienda";
            // 
            // grbNewEmployer
            // 
            this.grbNewEmployer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grbNewEmployer.Controls.Add(this.pboFotoEmpleado);
            this.grbNewEmployer.Controls.Add(this.lblNoExisteArchivoCrearError);
            this.grbNewEmployer.Controls.Add(this.lblCrearError);
            this.grbNewEmployer.Controls.Add(this.bntCreateCancel);
            this.grbNewEmployer.Controls.Add(this.btnCreate);
            this.grbNewEmployer.Controls.Add(this.btnBrowse);
            this.grbNewEmployer.Controls.Add(this.txtCrearFoto);
            this.grbNewEmployer.Controls.Add(this.label3);
            this.grbNewEmployer.Controls.Add(this.txtCrearNombre);
            this.grbNewEmployer.Controls.Add(this.label1);
            this.grbNewEmployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNewEmployer.Location = new System.Drawing.Point(126, 106);
            this.grbNewEmployer.Name = "grbNewEmployer";
            this.grbNewEmployer.Size = new System.Drawing.Size(413, 363);
            this.grbNewEmployer.TabIndex = 13;
            this.grbNewEmployer.TabStop = false;
            this.grbNewEmployer.Text = "Nuevo Empleado";
            // 
            // pboEmployeePhoto
            // 
            this.pboFotoEmpleado.Location = new System.Drawing.Point(311, 131);
            this.pboFotoEmpleado.Name = "pboEmployeePhoto";
            this.pboFotoEmpleado.Size = new System.Drawing.Size(96, 139);
            this.pboFotoEmpleado.TabIndex = 20;
            this.pboFotoEmpleado.TabStop = false;
            // 
            // lblCreateFileNoExistError
            // 
            this.lblNoExisteArchivoCrearError.AutoSize = true;
            this.lblNoExisteArchivoCrearError.ForeColor = System.Drawing.Color.Red;
            this.lblNoExisteArchivoCrearError.Location = new System.Drawing.Point(19, 128);
            this.lblNoExisteArchivoCrearError.Name = "lblCreateFileNoExistError";
            this.lblNoExisteArchivoCrearError.Size = new System.Drawing.Size(140, 15);
            this.lblNoExisteArchivoCrearError.TabIndex = 19;
            this.lblNoExisteArchivoCrearError.Text = "El archivo no existe!!";
            this.lblNoExisteArchivoCrearError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCreateError
            // 
            this.lblCrearError.AutoSize = true;
            this.lblCrearError.ForeColor = System.Drawing.Color.Red;
            this.lblCrearError.Location = new System.Drawing.Point(6, 334);
            this.lblCrearError.Name = "lblCreateError";
            this.lblCrearError.Size = new System.Drawing.Size(170, 15);
            this.lblCrearError.TabIndex = 18;
            this.lblCrearError.Text = "Debes poner un nombre!!";
            // 
            // bntCreateCancel
            // 
            this.bntCreateCancel.BackColor = System.Drawing.Color.White;
            this.bntCreateCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntCreateCancel.BackgroundImage")));
            this.bntCreateCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bntCreateCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCreateCancel.Location = new System.Drawing.Point(108, 218);
            this.bntCreateCancel.Name = "bntCreateCancel";
            this.bntCreateCancel.Size = new System.Drawing.Size(79, 113);
            this.bntCreateCancel.TabIndex = 12;
            this.bntCreateCancel.Text = "C&ancelar";
            this.bntCreateCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntCreateCancel.UseVisualStyleBackColor = false;
            this.bntCreateCancel.Click += new System.EventHandler(this.bntCreateCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.White;
            this.btnCreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreate.BackgroundImage")));
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(9, 218);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 113);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "&Crear";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.White;
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(6, 143);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(79, 23);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "&Examinar";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtCreatePhoto
            // 
            this.txtCrearFoto.Enabled = false;
            this.txtCrearFoto.Location = new System.Drawing.Point(6, 104);
            this.txtCrearFoto.Name = "txtCreatePhoto";
            this.txtCrearFoto.Size = new System.Drawing.Size(401, 21);
            this.txtCrearFoto.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Foto:";
            // 
            // txtCreateName
            // 
            this.txtCrearNombre.Location = new System.Drawing.Point(6, 53);
            this.txtCrearNombre.Name = "txtCreateName";
            this.txtCrearNombre.Size = new System.Drawing.Size(153, 21);
            this.txtCrearNombre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // grbDeleteEmployer
            // 
            this.grbDeleteEmployer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grbDeleteEmployer.Controls.Add(this.nudBorrarNumEmpleado);
            this.grbDeleteEmployer.Controls.Add(this.lblBorrarError);
            this.grbDeleteEmployer.Controls.Add(this.lblEmpleadoNoExisteError);
            this.grbDeleteEmployer.Controls.Add(this.lblBorrarNombre);
            this.grbDeleteEmployer.Controls.Add(this.btnDeleteCancel);
            this.grbDeleteEmployer.Controls.Add(this.btnDelete);
            this.grbDeleteEmployer.Controls.Add(this.label5);
            this.grbDeleteEmployer.Controls.Add(this.label6);
            this.grbDeleteEmployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDeleteEmployer.Location = new System.Drawing.Point(545, 106);
            this.grbDeleteEmployer.Name = "grbDeleteEmployer";
            this.grbDeleteEmployer.Size = new System.Drawing.Size(207, 363);
            this.grbDeleteEmployer.TabIndex = 16;
            this.grbDeleteEmployer.TabStop = false;
            this.grbDeleteEmployer.Text = "Eliminar Empleado";
            // 
            // nudDeleteNumEmployee
            // 
            this.nudBorrarNumEmpleado.Location = new System.Drawing.Point(9, 53);
            this.nudBorrarNumEmpleado.Name = "nudDeleteNumEmployee";
            this.nudBorrarNumEmpleado.Size = new System.Drawing.Size(161, 21);
            this.nudBorrarNumEmpleado.TabIndex = 20;
            this.nudBorrarNumEmpleado.ValueChanged += new System.EventHandler(this.chargeEmpleado);
            this.nudBorrarNumEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros);
            // 
            // lblDeleteError
            // 
            this.lblBorrarError.AutoSize = true;
            this.lblBorrarError.ForeColor = System.Drawing.Color.Red;
            this.lblBorrarError.Location = new System.Drawing.Point(6, 334);
            this.lblBorrarError.Name = "lblDeleteError";
            this.lblBorrarError.Size = new System.Drawing.Size(167, 15);
            this.lblBorrarError.TabIndex = 17;
            this.lblBorrarError.Text = "Seleciona un empleado!!";
            // 
            // lblEmployeeNoExistError
            // 
            this.lblEmpleadoNoExisteError.AutoSize = true;
            this.lblEmpleadoNoExisteError.ForeColor = System.Drawing.Color.Red;
            this.lblEmpleadoNoExisteError.Location = new System.Drawing.Point(20, 77);
            this.lblEmpleadoNoExisteError.Name = "lblEmployeeNoExistError";
            this.lblEmpleadoNoExisteError.Size = new System.Drawing.Size(150, 15);
            this.lblEmpleadoNoExisteError.TabIndex = 15;
            this.lblEmpleadoNoExisteError.Text = "Empleado inexistente!";
            // 
            // lblDeleteName
            // 
            this.lblBorrarNombre.AutoSize = true;
            this.lblBorrarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBorrarNombre.Location = new System.Drawing.Point(35, 122);
            this.lblBorrarNombre.Name = "lblDeleteName";
            this.lblBorrarNombre.Size = new System.Drawing.Size(65, 18);
            this.lblBorrarNombre.TabIndex = 13;
            this.lblBorrarNombre.Text = "nombre";
            // 
            // btnDeleteCancel
            // 
            this.btnDeleteCancel.BackColor = System.Drawing.Color.White;
            this.btnDeleteCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteCancel.BackgroundImage")));
            this.btnDeleteCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCancel.Location = new System.Drawing.Point(108, 218);
            this.btnDeleteCancel.Name = "btnDeleteCancel";
            this.btnDeleteCancel.Size = new System.Drawing.Size(79, 113);
            this.btnDeleteCancel.TabIndex = 12;
            this.btnDeleteCancel.Text = "C&ancelar";
            this.btnDeleteCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteCancel.UseVisualStyleBackColor = false;
            this.btnDeleteCancel.Click += new System.EventHandler(this.btnDeleteCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(9, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 113);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "E&liminar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "nº de empleado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre:";
            // 
            // grbEditProduct
            // 
            this.grbEditProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grbEditProduct.Controls.Add(this.nudEditarProductoLugarId);
            this.grbEditProduct.Controls.Add(this.nudEditarProductoCollectionId);
            this.grbEditProduct.Controls.Add(this.nudEditarProductoCoste);
            this.grbEditProduct.Controls.Add(this.nudEditarProductoStock);
            this.grbEditProduct.Controls.Add(this.nudEditarProductoMinStock);
            this.grbEditProduct.Controls.Add(this.nudEditarProductoEmployerId);
            this.grbEditProduct.Controls.Add(this.dateTimePicker1);
            this.grbEditProduct.Controls.Add(this.lblCoste);
            this.grbEditProduct.Controls.Add(this.label8);
            this.grbEditProduct.Controls.Add(this.label11);
            this.grbEditProduct.Controls.Add(this.label9);
            this.grbEditProduct.Controls.Add(this.label4);
            this.grbEditProduct.Controls.Add(this.label14);
            this.grbEditProduct.Controls.Add(this.label7);
            this.grbEditProduct.Controls.Add(this.label2);
            this.grbEditProduct.Controls.Add(this.label10);
            this.grbEditProduct.Controls.Add(this.txtEditarProductoSubFamiliaCodigo);
            this.grbEditProduct.Controls.Add(this.txtEditarProductoDescripcion);
            this.grbEditProduct.Controls.Add(this.txtEditarProductoCodigoFamilia);
            this.grbEditProduct.Controls.Add(this.Medida);
            this.grbEditProduct.Controls.Add(this.txtEditarTallaProducto);
            this.grbEditProduct.Controls.Add(this.label13);
            this.grbEditProduct.Controls.Add(this.label12);
            this.grbEditProduct.Controls.Add(this.lblCodigoNoEncontradoStockMinimoError);
            this.grbEditProduct.Controls.Add(this.btnUpdateCancel);
            this.grbEditProduct.Controls.Add(this.btnUpdatePorduct);
            this.grbEditProduct.Controls.Add(this.txtEditarProductoCodigo);
            this.grbEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditProduct.Location = new System.Drawing.Point(758, 106);
            this.grbEditProduct.Name = "grbEditProduct";
            this.grbEditProduct.Size = new System.Drawing.Size(356, 363);
            this.grbEditProduct.TabIndex = 18;
            this.grbEditProduct.TabStop = false;
            this.grbEditProduct.Text = "Editar Producto";
            // 
            // nudEditProductPlaceId
            // 
            this.nudEditarProductoLugarId.Location = new System.Drawing.Point(238, 143);
            this.nudEditarProductoLugarId.Name = "nudEditProductPlaceId";
            this.nudEditarProductoLugarId.Size = new System.Drawing.Size(98, 21);
            this.nudEditarProductoLugarId.TabIndex = 29;
            // 
            // nudEditProductCollectionId
            // 
            this.nudEditarProductoCollectionId.Location = new System.Drawing.Point(212, 188);
            this.nudEditarProductoCollectionId.Name = "nudEditProductCollectionId";
            this.nudEditarProductoCollectionId.Size = new System.Drawing.Size(98, 21);
            this.nudEditarProductoCollectionId.TabIndex = 28;
            // 
            // nudEditProductCost
            // 
            this.nudEditarProductoCoste.Location = new System.Drawing.Point(268, 38);
            this.nudEditarProductoCoste.Name = "nudEditProductCost";
            this.nudEditarProductoCoste.Size = new System.Drawing.Size(73, 21);
            this.nudEditarProductoCoste.TabIndex = 26;
            this.nudEditarProductoCoste.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros);
            // 
            // nudEditProductStock
            // 
            this.nudEditarProductoStock.Location = new System.Drawing.Point(189, 38);
            this.nudEditarProductoStock.Name = "nudEditProductStock";
            this.nudEditarProductoStock.Size = new System.Drawing.Size(73, 21);
            this.nudEditarProductoStock.TabIndex = 26;
            this.nudEditarProductoStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros);
            // 
            // nudEditProductMinStock
            // 
            this.nudEditarProductoMinStock.Location = new System.Drawing.Point(110, 38);
            this.nudEditarProductoMinStock.Name = "nudEditProductMinStock";
            this.nudEditarProductoMinStock.Size = new System.Drawing.Size(73, 21);
            this.nudEditarProductoMinStock.TabIndex = 26;
            this.nudEditarProductoMinStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros);
            // 
            // nudEditProductEmployerId
            // 
            this.nudEditarProductoEmployerId.Location = new System.Drawing.Point(134, 143);
            this.nudEditarProductoEmployerId.Name = "nudEditProductEmployerId";
            this.nudEditarProductoEmployerId.Size = new System.Drawing.Size(98, 21);
            this.nudEditarProductoEmployerId.TabIndex = 26;
            this.nudEditarProductoEmployerId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.soloNumeros);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(214, 98);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 21);
            this.dateTimePicker1.TabIndex = 25;
            // 
            // lblCoste
            // 
            this.lblCoste.AutoSize = true;
            this.lblCoste.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoste.Location = new System.Drawing.Point(278, 17);
            this.lblCoste.Name = "lblCoste";
            this.lblCoste.Size = new System.Drawing.Size(53, 18);
            this.lblCoste.TabIndex = 24;
            this.lblCoste.Text = "Coste";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(235, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 18);
            this.label8.TabIndex = 24;
            this.label8.Text = "Id Lugar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(212, 167);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Id Recogida";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(131, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 18);
            this.label9.TabIndex = 22;
            this.label9.Text = "Id Empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(187, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Stock";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(214, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 18);
            this.label14.TabIndex = 20;
            this.label14.Text = "Fecha Entrada";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cod.Sub.Familia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Cod.Familia";
            // 
            // txtEditProductSubFamilyCode
            // 
            this.txtEditarProductoSubFamiliaCodigo.Location = new System.Drawing.Point(8, 188);
            this.txtEditarProductoSubFamiliaCodigo.Name = "txtEditProductSubFamilyCode";
            this.txtEditarProductoSubFamiliaCodigo.Size = new System.Drawing.Size(130, 21);
            this.txtEditarProductoSubFamiliaCodigo.TabIndex = 19;
            // 
            // txtEditProductDescription
            // 
            this.txtEditarProductoDescripcion.Location = new System.Drawing.Point(8, 98);
            this.txtEditarProductoDescripcion.Name = "txtEditProductDescription";
            this.txtEditarProductoDescripcion.Size = new System.Drawing.Size(199, 21);
            this.txtEditarProductoDescripcion.TabIndex = 19;
            // 
            // txtEditProductFamilyCode
            // 
            this.txtEditarProductoCodigoFamilia.Location = new System.Drawing.Point(8, 143);
            this.txtEditarProductoCodigoFamilia.Name = "txtEditProductFamilyCode";
            this.txtEditarProductoCodigoFamilia.Size = new System.Drawing.Size(119, 21);
            this.txtEditarProductoCodigoFamilia.TabIndex = 19;
            // 
            // Medida
            // 
            this.Medida.AutoSize = true;
            this.Medida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medida.Location = new System.Drawing.Point(144, 167);
            this.Medida.Name = "Medida";
            this.Medida.Size = new System.Drawing.Size(62, 18);
            this.Medida.TabIndex = 20;
            this.Medida.Text = "Medida";
            // 
            // txtEditProductSize
            // 
            this.txtEditarTallaProducto.Location = new System.Drawing.Point(146, 188);
            this.txtEditarTallaProducto.Name = "txtEditProductSize";
            this.txtEditarTallaProducto.Size = new System.Drawing.Size(60, 21);
            this.txtEditarTallaProducto.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(105, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 18);
            this.label13.TabIndex = 20;
            this.label13.Text = "Stock Min";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 18);
            this.label12.TabIndex = 18;
            this.label12.Text = "Código";
            // 
            // lblCodeNotFoundMinStockError
            // 
            this.lblCodigoNoEncontradoStockMinimoError.AutoSize = true;
            this.lblCodigoNoEncontradoStockMinimoError.ForeColor = System.Drawing.Color.Red;
            this.lblCodigoNoEncontradoStockMinimoError.Location = new System.Drawing.Point(3, 60);
            this.lblCodigoNoEncontradoStockMinimoError.Name = "lblCodeNotFoundMinStockError";
            this.lblCodigoNoEncontradoStockMinimoError.Size = new System.Drawing.Size(152, 15);
            this.lblCodigoNoEncontradoStockMinimoError.TabIndex = 15;
            this.lblCodigoNoEncontradoStockMinimoError.Text = "Codigo no encontrado!";
            // 
            // btnUpdateCancel
            // 
            this.btnUpdateCancel.BackColor = System.Drawing.Color.White;
            this.btnUpdateCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdateCancel.BackgroundImage")));
            this.btnUpdateCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdateCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateCancel.Location = new System.Drawing.Point(252, 218);
            this.btnUpdateCancel.Name = "btnUpdateCancel";
            this.btnUpdateCancel.Size = new System.Drawing.Size(79, 113);
            this.btnUpdateCancel.TabIndex = 12;
            this.btnUpdateCancel.Text = "C&ancelar";
            this.btnUpdateCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdateCancel.UseVisualStyleBackColor = false;
            this.btnUpdateCancel.Click += new System.EventHandler(this.btnUpdateCancel_Click);
            // 
            // btnUpdatePorduct
            // 
            this.btnUpdatePorduct.BackColor = System.Drawing.Color.White;
            this.btnUpdatePorduct.BackgroundImage = global::CapaPresentacion.Properties.Resources.refresh_arrows;
            this.btnUpdatePorduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUpdatePorduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatePorduct.Location = new System.Drawing.Point(153, 218);
            this.btnUpdatePorduct.Name = "btnUpdatePorduct";
            this.btnUpdatePorduct.Size = new System.Drawing.Size(79, 113);
            this.btnUpdatePorduct.TabIndex = 11;
            this.btnUpdatePorduct.Text = "Act&ualizar";
            this.btnUpdatePorduct.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUpdatePorduct.UseVisualStyleBackColor = false;
            this.btnUpdatePorduct.Click += new System.EventHandler(this.btnUpdatePorduct_Click);
            // 
            // txtEditProductCode
            // 
            this.txtEditarProductoCodigo.Location = new System.Drawing.Point(9, 38);
            this.txtEditarProductoCodigo.Name = "txtEditProductCode";
            this.txtEditarProductoCodigo.Size = new System.Drawing.Size(97, 21);
            this.txtEditarProductoCodigo.TabIndex = 7;
            this.txtEditarProductoCodigo.TextChanged += new System.EventHandler(this.txtEditProductCode_TextChanged);
            this.txtEditarProductoCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditProductCode_KeyPress);
            // 
            // btnRestoreDataBase
            // 
            this.btnRestoreDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestoreDataBase.BackColor = System.Drawing.Color.White;
            this.btnRestoreDataBase.BackgroundImage = global::CapaPresentacion.Properties.Resources.backup;
            this.btnRestoreDataBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRestoreDataBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestoreDataBase.Location = new System.Drawing.Point(779, 511);
            this.btnRestoreDataBase.Name = "btnRestoreDataBase";
            this.btnRestoreDataBase.Size = new System.Drawing.Size(85, 117);
            this.btnRestoreDataBase.TabIndex = 17;
            this.btnRestoreDataBase.Text = "&RestaurarBD";
            this.btnRestoreDataBase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRestoreDataBase.UseVisualStyleBackColor = false;
            this.btnRestoreDataBase.Click += new System.EventHandler(this.btnRestoreDataBase_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.BackColor = System.Drawing.Color.White;
            this.btnCopy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopy.BackgroundImage")));
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(867, 511);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(85, 117);
            this.btnCopy.TabIndex = 17;
            this.btnCopy.Text = "&CopiarBD";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.BackColor = System.Drawing.Color.White;
            this.btnApply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApply.BackgroundImage")));
            this.btnApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(958, 511);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 117);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "&Aplicar";
            this.btnApply.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImage = global::CapaPresentacion.Properties.Resources.back_arrow;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1039, 511);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 117);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "A&trás";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 640);
            this.Controls.Add(this.grbEditProduct);
            this.Controls.Add(this.btnRestoreDataBase);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.grbDeleteEmployer);
            this.Controls.Add(this.grbNewEmployer);
            this.Controls.Add(this.grbType);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConfig";
            this.Text = "Configuración";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConfig_Load);
            this.grbType.ResumeLayout(false);
            this.grbType.PerformLayout();
            this.grbNewEmployer.ResumeLayout(false);
            this.grbNewEmployer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboFotoEmpleado)).EndInit();
            this.grbDeleteEmployer.ResumeLayout(false);
            this.grbDeleteEmployer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBorrarNumEmpleado)).EndInit();
            this.grbEditProduct.ResumeLayout(false);
            this.grbEditProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditarProductoLugarId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditarProductoCollectionId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditarProductoCoste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditarProductoStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditarProductoMinStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditarProductoEmployerId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.RadioButton rbtnAlimentos;
        private System.Windows.Forms.RadioButton rbtnPrendas;
        private System.Windows.Forms.GroupBox grbType;
        private System.Windows.Forms.GroupBox grbNewEmployer;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtCrearFoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCrearNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntCreateCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox grbDeleteEmployer;
        private System.Windows.Forms.Label lblEmpleadoNoExisteError;
        private System.Windows.Forms.Label lblBorrarNombre;
        private System.Windows.Forms.Button btnDeleteCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCrearError;
        private System.Windows.Forms.Label lblBorrarError;
        private System.Windows.Forms.Label lblNoExisteArchivoCrearError;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.GroupBox grbEditProduct;
        private System.Windows.Forms.Label lblCodigoNoEncontradoStockMinimoError;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Button btnUpdatePorduct;
        private System.Windows.Forms.TextBox txtEditarProductoCodigo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEditarProductoDescripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Medida;
        private System.Windows.Forms.TextBox txtEditarTallaProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCoste;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEditarProductoCodigoFamilia;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown nudBorrarNumEmpleado;
        private System.Windows.Forms.NumericUpDown nudEditarProductoCoste;
        private System.Windows.Forms.NumericUpDown nudEditarProductoStock;
        private System.Windows.Forms.NumericUpDown nudEditarProductoMinStock;
        private System.Windows.Forms.NumericUpDown nudEditarProductoEmployerId;
        private System.Windows.Forms.NumericUpDown nudEditarProductoLugarId;
        private System.Windows.Forms.NumericUpDown nudEditarProductoCollectionId;
        private System.Windows.Forms.PictureBox pboFotoEmpleado;
        private System.Windows.Forms.Button btnRestoreDataBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEditarProductoSubFamiliaCodigo;
    }
}