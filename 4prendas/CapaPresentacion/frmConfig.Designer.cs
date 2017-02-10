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
            this.rbtnFood = new System.Windows.Forms.RadioButton();
            this.rbtnClothes = new System.Windows.Forms.RadioButton();
            this.grbType = new System.Windows.Forms.GroupBox();
            this.grbNewEmployer = new System.Windows.Forms.GroupBox();
            this.lblCreateFileNoExistError = new System.Windows.Forms.Label();
            this.lblCreateError = new System.Windows.Forms.Label();
            this.bntCreateCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtCreatePhoto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDeleteEmployer = new System.Windows.Forms.GroupBox();
            this.nudDeleteNumEmployee = new System.Windows.Forms.NumericUpDown();
            this.lblDeleteError = new System.Windows.Forms.Label();
            this.lblEmployeeNoExistError = new System.Windows.Forms.Label();
            this.lblDeleteName = new System.Windows.Forms.Label();
            this.btnDeleteCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grbEditProduct = new System.Windows.Forms.GroupBox();
            this.nudEditProductPlaceId = new System.Windows.Forms.NumericUpDown();
            this.nudEditProductCollectionId = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.nudEditProductCost = new System.Windows.Forms.NumericUpDown();
            this.nudEditProductStock = new System.Windows.Forms.NumericUpDown();
            this.nudEditProductMinStock = new System.Windows.Forms.NumericUpDown();
            this.nudEditProductEmployerId = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblCoste = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEditProductDescription = new System.Windows.Forms.TextBox();
            this.txtEditProductFamilyCode = new System.Windows.Forms.TextBox();
            this.Medida = new System.Windows.Forms.Label();
            this.txtEditProductSize = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCodeNotFoundMinStockError = new System.Windows.Forms.Label();
            this.btnUpdateCancel = new System.Windows.Forms.Button();
            this.btnUpdatePorduct = new System.Windows.Forms.Button();
            this.txtEditProductCode = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grbType.SuspendLayout();
            this.grbNewEmployer.SuspendLayout();
            this.grbDeleteEmployer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeleteNumEmployee)).BeginInit();
            this.grbEditProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditProductPlaceId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditProductCollectionId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditProductCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditProductStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditProductMinStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditProductEmployerId)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnFood
            // 
            this.rbtnFood.AutoSize = true;
            this.rbtnFood.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnFood.Location = new System.Drawing.Point(6, 24);
            this.rbtnFood.Name = "rbtnFood";
            this.rbtnFood.Size = new System.Drawing.Size(84, 22);
            this.rbtnFood.TabIndex = 10;
            this.rbtnFood.TabStop = true;
            this.rbtnFood.Text = "Comida";
            this.rbtnFood.UseVisualStyleBackColor = true;
            this.rbtnFood.CheckedChanged += new System.EventHandler(this.rbtnFood_CheckedChanged);
            // 
            // rbtnClothes
            // 
            this.rbtnClothes.AutoSize = true;
            this.rbtnClothes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnClothes.Location = new System.Drawing.Point(6, 52);
            this.rbtnClothes.Name = "rbtnClothes";
            this.rbtnClothes.Size = new System.Drawing.Size(66, 22);
            this.rbtnClothes.TabIndex = 11;
            this.rbtnClothes.TabStop = true;
            this.rbtnClothes.Text = "Ropa";
            this.rbtnClothes.UseVisualStyleBackColor = true;
            this.rbtnClothes.CheckedChanged += new System.EventHandler(this.rbtnClothes_CheckedChanged);
            // 
            // grbType
            // 
            this.grbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grbType.Controls.Add(this.rbtnFood);
            this.grbType.Controls.Add(this.rbtnClothes);
            this.grbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbType.Location = new System.Drawing.Point(135, 139);
            this.grbType.Name = "grbType";
            this.grbType.Size = new System.Drawing.Size(129, 242);
            this.grbType.TabIndex = 12;
            this.grbType.TabStop = false;
            this.grbType.Text = "Tipo Tienda";
            // 
            // grbNewEmployer
            // 
            this.grbNewEmployer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grbNewEmployer.Controls.Add(this.lblCreateFileNoExistError);
            this.grbNewEmployer.Controls.Add(this.lblCreateError);
            this.grbNewEmployer.Controls.Add(this.bntCreateCancel);
            this.grbNewEmployer.Controls.Add(this.btnCreate);
            this.grbNewEmployer.Controls.Add(this.btnBrowse);
            this.grbNewEmployer.Controls.Add(this.txtCreatePhoto);
            this.grbNewEmployer.Controls.Add(this.label3);
            this.grbNewEmployer.Controls.Add(this.txtCreateName);
            this.grbNewEmployer.Controls.Add(this.label1);
            this.grbNewEmployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNewEmployer.Location = new System.Drawing.Point(270, 124);
            this.grbNewEmployer.Name = "grbNewEmployer";
            this.grbNewEmployer.Size = new System.Drawing.Size(279, 363);
            this.grbNewEmployer.TabIndex = 13;
            this.grbNewEmployer.TabStop = false;
            this.grbNewEmployer.Text = "Nuevo Empleado";
            // 
            // lblCreateFileNoExistError
            // 
            this.lblCreateFileNoExistError.AutoSize = true;
            this.lblCreateFileNoExistError.ForeColor = System.Drawing.Color.Red;
            this.lblCreateFileNoExistError.Location = new System.Drawing.Point(19, 128);
            this.lblCreateFileNoExistError.Name = "lblCreateFileNoExistError";
            this.lblCreateFileNoExistError.Size = new System.Drawing.Size(140, 15);
            this.lblCreateFileNoExistError.TabIndex = 19;
            this.lblCreateFileNoExistError.Text = "El archivo no existe!!";
            this.lblCreateFileNoExistError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCreateError
            // 
            this.lblCreateError.AutoSize = true;
            this.lblCreateError.ForeColor = System.Drawing.Color.Red;
            this.lblCreateError.Location = new System.Drawing.Point(6, 334);
            this.lblCreateError.Name = "lblCreateError";
            this.lblCreateError.Size = new System.Drawing.Size(170, 15);
            this.lblCreateError.TabIndex = 18;
            this.lblCreateError.Text = "Debes poner un nombre!!";
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
            this.txtCreatePhoto.Location = new System.Drawing.Point(6, 104);
            this.txtCreatePhoto.Name = "txtCreatePhoto";
            this.txtCreatePhoto.Size = new System.Drawing.Size(186, 21);
            this.txtCreatePhoto.TabIndex = 9;
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
            this.txtCreateName.Location = new System.Drawing.Point(6, 53);
            this.txtCreateName.Name = "txtCreateName";
            this.txtCreateName.Size = new System.Drawing.Size(153, 21);
            this.txtCreateName.TabIndex = 5;
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
            this.grbDeleteEmployer.Controls.Add(this.nudDeleteNumEmployee);
            this.grbDeleteEmployer.Controls.Add(this.lblDeleteError);
            this.grbDeleteEmployer.Controls.Add(this.lblEmployeeNoExistError);
            this.grbDeleteEmployer.Controls.Add(this.lblDeleteName);
            this.grbDeleteEmployer.Controls.Add(this.btnDeleteCancel);
            this.grbDeleteEmployer.Controls.Add(this.btnDelete);
            this.grbDeleteEmployer.Controls.Add(this.label5);
            this.grbDeleteEmployer.Controls.Add(this.label6);
            this.grbDeleteEmployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbDeleteEmployer.Location = new System.Drawing.Point(478, 124);
            this.grbDeleteEmployer.Name = "grbDeleteEmployer";
            this.grbDeleteEmployer.Size = new System.Drawing.Size(279, 363);
            this.grbDeleteEmployer.TabIndex = 16;
            this.grbDeleteEmployer.TabStop = false;
            this.grbDeleteEmployer.Text = "Eliminar Empleado";
            // 
            // nudDeleteNumEmployee
            // 
            this.nudDeleteNumEmployee.Location = new System.Drawing.Point(9, 53);
            this.nudDeleteNumEmployee.Name = "nudDeleteNumEmployee";
            this.nudDeleteNumEmployee.Size = new System.Drawing.Size(161, 21);
            this.nudDeleteNumEmployee.TabIndex = 20;
            this.nudDeleteNumEmployee.ValueChanged += new System.EventHandler(this.chargeEmployee);
            this.nudDeleteNumEmployee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNums);
            // 
            // lblDeleteError
            // 
            this.lblDeleteError.AutoSize = true;
            this.lblDeleteError.ForeColor = System.Drawing.Color.Red;
            this.lblDeleteError.Location = new System.Drawing.Point(6, 334);
            this.lblDeleteError.Name = "lblDeleteError";
            this.lblDeleteError.Size = new System.Drawing.Size(167, 15);
            this.lblDeleteError.TabIndex = 17;
            this.lblDeleteError.Text = "Seleciona un empleado!!";
            // 
            // lblEmployeeNoExistError
            // 
            this.lblEmployeeNoExistError.AutoSize = true;
            this.lblEmployeeNoExistError.ForeColor = System.Drawing.Color.Red;
            this.lblEmployeeNoExistError.Location = new System.Drawing.Point(20, 77);
            this.lblEmployeeNoExistError.Name = "lblEmployeeNoExistError";
            this.lblEmployeeNoExistError.Size = new System.Drawing.Size(150, 15);
            this.lblEmployeeNoExistError.TabIndex = 15;
            this.lblEmployeeNoExistError.Text = "Empleado inexistente!";
            // 
            // lblDeleteName
            // 
            this.lblDeleteName.AutoSize = true;
            this.lblDeleteName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteName.Location = new System.Drawing.Point(35, 122);
            this.lblDeleteName.Name = "lblDeleteName";
            this.lblDeleteName.Size = new System.Drawing.Size(65, 18);
            this.lblDeleteName.TabIndex = 13;
            this.lblDeleteName.Text = "nombre";
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
            this.grbEditProduct.Controls.Add(this.nudEditProductPlaceId);
            this.grbEditProduct.Controls.Add(this.nudEditProductCollectionId);
            this.grbEditProduct.Controls.Add(this.label15);
            this.grbEditProduct.Controls.Add(this.nudEditProductCost);
            this.grbEditProduct.Controls.Add(this.nudEditProductStock);
            this.grbEditProduct.Controls.Add(this.nudEditProductMinStock);
            this.grbEditProduct.Controls.Add(this.nudEditProductEmployerId);
            this.grbEditProduct.Controls.Add(this.dateTimePicker1);
            this.grbEditProduct.Controls.Add(this.lblCoste);
            this.grbEditProduct.Controls.Add(this.label8);
            this.grbEditProduct.Controls.Add(this.label11);
            this.grbEditProduct.Controls.Add(this.label9);
            this.grbEditProduct.Controls.Add(this.label4);
            this.grbEditProduct.Controls.Add(this.label14);
            this.grbEditProduct.Controls.Add(this.label7);
            this.grbEditProduct.Controls.Add(this.label10);
            this.grbEditProduct.Controls.Add(this.txtEditProductDescription);
            this.grbEditProduct.Controls.Add(this.txtEditProductFamilyCode);
            this.grbEditProduct.Controls.Add(this.Medida);
            this.grbEditProduct.Controls.Add(this.txtEditProductSize);
            this.grbEditProduct.Controls.Add(this.label13);
            this.grbEditProduct.Controls.Add(this.label12);
            this.grbEditProduct.Controls.Add(this.lblCodeNotFoundMinStockError);
            this.grbEditProduct.Controls.Add(this.btnUpdateCancel);
            this.grbEditProduct.Controls.Add(this.btnUpdatePorduct);
            this.grbEditProduct.Controls.Add(this.txtEditProductCode);
            this.grbEditProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditProduct.Location = new System.Drawing.Point(677, 124);
            this.grbEditProduct.Name = "grbEditProduct";
            this.grbEditProduct.Size = new System.Drawing.Size(356, 363);
            this.grbEditProduct.TabIndex = 18;
            this.grbEditProduct.TabStop = false;
            this.grbEditProduct.Text = "Editar Producto";
            // 
            // nudEditProductPlaceId
            // 
            this.nudEditProductPlaceId.Location = new System.Drawing.Point(238, 143);
            this.nudEditProductPlaceId.Name = "nudEditProductPlaceId";
            this.nudEditProductPlaceId.Size = new System.Drawing.Size(98, 21);
            this.nudEditProductPlaceId.TabIndex = 29;
            // 
            // nudEditProductCollectionId
            // 
            this.nudEditProductCollectionId.Location = new System.Drawing.Point(74, 188);
            this.nudEditProductCollectionId.Name = "nudEditProductCollectionId";
            this.nudEditProductCollectionId.Size = new System.Drawing.Size(98, 21);
            this.nudEditProductCollectionId.TabIndex = 28;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(6, 230);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 58);
            this.label15.TabIndex = 27;
            this.label15.Text = "Los campos vacíos no serán modificados";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudEditProductCost
            // 
            this.nudEditProductCost.Location = new System.Drawing.Point(268, 38);
            this.nudEditProductCost.Name = "nudEditProductCost";
            this.nudEditProductCost.Size = new System.Drawing.Size(73, 21);
            this.nudEditProductCost.TabIndex = 26;
            this.nudEditProductCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNums);
            // 
            // nudEditProductStock
            // 
            this.nudEditProductStock.Location = new System.Drawing.Point(189, 38);
            this.nudEditProductStock.Name = "nudEditProductStock";
            this.nudEditProductStock.Size = new System.Drawing.Size(73, 21);
            this.nudEditProductStock.TabIndex = 26;
            this.nudEditProductStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNums);
            // 
            // nudEditProductMinStock
            // 
            this.nudEditProductMinStock.Location = new System.Drawing.Point(110, 38);
            this.nudEditProductMinStock.Name = "nudEditProductMinStock";
            this.nudEditProductMinStock.Size = new System.Drawing.Size(73, 21);
            this.nudEditProductMinStock.TabIndex = 26;
            this.nudEditProductMinStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNums);
            // 
            // nudEditProductEmployerId
            // 
            this.nudEditProductEmployerId.Location = new System.Drawing.Point(134, 143);
            this.nudEditProductEmployerId.Name = "nudEditProductEmployerId";
            this.nudEditProductEmployerId.Size = new System.Drawing.Size(98, 21);
            this.nudEditProductEmployerId.TabIndex = 26;
            this.nudEditProductEmployerId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNums);
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
            this.label11.Location = new System.Drawing.Point(74, 167);
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
            // txtEditProductDescription
            // 
            this.txtEditProductDescription.Location = new System.Drawing.Point(8, 98);
            this.txtEditProductDescription.Name = "txtEditProductDescription";
            this.txtEditProductDescription.Size = new System.Drawing.Size(199, 21);
            this.txtEditProductDescription.TabIndex = 19;
            // 
            // txtEditProductFamilyCode
            // 
            this.txtEditProductFamilyCode.Location = new System.Drawing.Point(8, 143);
            this.txtEditProductFamilyCode.Name = "txtEditProductFamilyCode";
            this.txtEditProductFamilyCode.Size = new System.Drawing.Size(119, 21);
            this.txtEditProductFamilyCode.TabIndex = 19;
            // 
            // Medida
            // 
            this.Medida.AutoSize = true;
            this.Medida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medida.Location = new System.Drawing.Point(6, 167);
            this.Medida.Name = "Medida";
            this.Medida.Size = new System.Drawing.Size(62, 18);
            this.Medida.TabIndex = 20;
            this.Medida.Text = "Medida";
            // 
            // txtEditProductSize
            // 
            this.txtEditProductSize.Location = new System.Drawing.Point(8, 188);
            this.txtEditProductSize.Name = "txtEditProductSize";
            this.txtEditProductSize.Size = new System.Drawing.Size(60, 21);
            this.txtEditProductSize.TabIndex = 19;
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
            this.lblCodeNotFoundMinStockError.AutoSize = true;
            this.lblCodeNotFoundMinStockError.ForeColor = System.Drawing.Color.Red;
            this.lblCodeNotFoundMinStockError.Location = new System.Drawing.Point(3, 60);
            this.lblCodeNotFoundMinStockError.Name = "lblCodeNotFoundMinStockError";
            this.lblCodeNotFoundMinStockError.Size = new System.Drawing.Size(152, 15);
            this.lblCodeNotFoundMinStockError.TabIndex = 15;
            this.lblCodeNotFoundMinStockError.Text = "Codigo no encontrado!";
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
            this.txtEditProductCode.Location = new System.Drawing.Point(9, 38);
            this.txtEditProductCode.Name = "txtEditProductCode";
            this.txtEditProductCode.Size = new System.Drawing.Size(97, 21);
            this.txtEditProductCode.TabIndex = 7;
            this.txtEditProductCode.TextChanged += new System.EventHandler(this.txtEditProductCode_TextChanged);
            this.txtEditProductCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEditProductCode_KeyPress);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.BackColor = System.Drawing.Color.White;
            this.btnCopy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopy.BackgroundImage")));
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(867, 515);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(85, 113);
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
            this.btnApply.Location = new System.Drawing.Point(958, 515);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 113);
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
            this.btnExit.BackgroundImage = global::CapaPresentacion.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1039, 515);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 113);
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
            this.grbDeleteEmployer.ResumeLayout(false);
            this.grbDeleteEmployer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeleteNumEmployee)).EndInit();
            this.grbEditProduct.ResumeLayout(false);
            this.grbEditProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditProductPlaceId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditProductCollectionId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditProductCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditProductStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditProductMinStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEditProductEmployerId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.RadioButton rbtnFood;
        private System.Windows.Forms.RadioButton rbtnClothes;
        private System.Windows.Forms.GroupBox grbType;
        private System.Windows.Forms.GroupBox grbNewEmployer;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtCreatePhoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCreateName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntCreateCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox grbDeleteEmployer;
        private System.Windows.Forms.Label lblEmployeeNoExistError;
        private System.Windows.Forms.Label lblDeleteName;
        private System.Windows.Forms.Button btnDeleteCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCreateError;
        private System.Windows.Forms.Label lblDeleteError;
        private System.Windows.Forms.Label lblCreateFileNoExistError;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.GroupBox grbEditProduct;
        private System.Windows.Forms.Label lblCodeNotFoundMinStockError;
        private System.Windows.Forms.Button btnUpdateCancel;
        private System.Windows.Forms.Button btnUpdatePorduct;
        private System.Windows.Forms.TextBox txtEditProductCode;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEditProductDescription;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Medida;
        private System.Windows.Forms.TextBox txtEditProductSize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCoste;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEditProductFamilyCode;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.NumericUpDown nudDeleteNumEmployee;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudEditProductCost;
        private System.Windows.Forms.NumericUpDown nudEditProductStock;
        private System.Windows.Forms.NumericUpDown nudEditProductMinStock;
        private System.Windows.Forms.NumericUpDown nudEditProductEmployerId;
        private System.Windows.Forms.NumericUpDown nudEditProductPlaceId;
        private System.Windows.Forms.NumericUpDown nudEditProductCollectionId;
    }
}