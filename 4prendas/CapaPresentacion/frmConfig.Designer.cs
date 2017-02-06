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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.rbtnFood = new System.Windows.Forms.RadioButton();
            this.rbtnClothes = new System.Windows.Forms.RadioButton();
            this.grbType = new System.Windows.Forms.GroupBox();
            this.grbNewEmployer = new System.Windows.Forms.GroupBox();
            this.lblCreateFileNoExistError = new System.Windows.Forms.Label();
            this.lblCreateError = new System.Windows.Forms.Label();
            this.lblCreateExistingNumberError = new System.Windows.Forms.Label();
            this.lblCreateIntParseError = new System.Windows.Forms.Label();
            this.bntCreateCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtCreatePhoto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCreateNumEmployer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCreateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDeleteError = new System.Windows.Forms.Label();
            this.lblDeleteIntParseError = new System.Windows.Forms.Label();
            this.lblEmployerNoExistError = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblDeleteName = new System.Windows.Forms.Label();
            this.btnDeleteCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDeleteNumEmployer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCopy = new System.Windows.Forms.Button();
            this.grbType.SuspendLayout();
            this.grbNewEmployer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackgroundImage = global::CapaPresentacion.Properties.Resources.exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(746, 515);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 113);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "A&trás";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnApply.BackgroundImage")));
            this.btnApply.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(665, 515);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 113);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "&Aplicar";
            this.btnApply.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
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
            this.grbType.Location = new System.Drawing.Point(123, 133);
            this.grbType.Name = "grbType";
            this.grbType.Size = new System.Drawing.Size(117, 242);
            this.grbType.TabIndex = 12;
            this.grbType.TabStop = false;
            this.grbType.Text = "Tipo Tienda";
            // 
            // grbNewEmployer
            // 
            this.grbNewEmployer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.grbNewEmployer.Controls.Add(this.lblCreateFileNoExistError);
            this.grbNewEmployer.Controls.Add(this.lblCreateError);
            this.grbNewEmployer.Controls.Add(this.lblCreateExistingNumberError);
            this.grbNewEmployer.Controls.Add(this.lblCreateIntParseError);
            this.grbNewEmployer.Controls.Add(this.bntCreateCancel);
            this.grbNewEmployer.Controls.Add(this.btnCreate);
            this.grbNewEmployer.Controls.Add(this.btnBrowse);
            this.grbNewEmployer.Controls.Add(this.txtCreatePhoto);
            this.grbNewEmployer.Controls.Add(this.label3);
            this.grbNewEmployer.Controls.Add(this.txtCreateNumEmployer);
            this.grbNewEmployer.Controls.Add(this.label2);
            this.grbNewEmployer.Controls.Add(this.txtCreateName);
            this.grbNewEmployer.Controls.Add(this.label1);
            this.grbNewEmployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNewEmployer.Location = new System.Drawing.Point(258, 118);
            this.grbNewEmployer.Name = "grbNewEmployer";
            this.grbNewEmployer.Size = new System.Drawing.Size(193, 363);
            this.grbNewEmployer.TabIndex = 13;
            this.grbNewEmployer.TabStop = false;
            this.grbNewEmployer.Text = "Nuevo Empleado";
            // 
            // lblCreateFileNoExistError
            // 
            this.lblCreateFileNoExistError.AutoSize = true;
            this.lblCreateFileNoExistError.ForeColor = System.Drawing.Color.Red;
            this.lblCreateFileNoExistError.Location = new System.Drawing.Point(26, 198);
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
            this.lblCreateError.Size = new System.Drawing.Size(181, 15);
            this.lblCreateError.TabIndex = 18;
            this.lblCreateError.Text = "Rellena todos los campos!!";
            // 
            // lblCreateExistingNumberError
            // 
            this.lblCreateExistingNumberError.AutoSize = true;
            this.lblCreateExistingNumberError.ForeColor = System.Drawing.Color.Red;
            this.lblCreateExistingNumberError.Location = new System.Drawing.Point(26, 132);
            this.lblCreateExistingNumberError.Name = "lblCreateExistingNumberError";
            this.lblCreateExistingNumberError.Size = new System.Drawing.Size(153, 15);
            this.lblCreateExistingNumberError.TabIndex = 17;
            this.lblCreateExistingNumberError.Text = "Número ya registrado!!";
            // 
            // lblCreateIntParseError
            // 
            this.lblCreateIntParseError.AutoSize = true;
            this.lblCreateIntParseError.ForeColor = System.Drawing.Color.Red;
            this.lblCreateIntParseError.Location = new System.Drawing.Point(26, 128);
            this.lblCreateIntParseError.Name = "lblCreateIntParseError";
            this.lblCreateIntParseError.Size = new System.Drawing.Size(144, 15);
            this.lblCreateIntParseError.TabIndex = 16;
            this.lblCreateIntParseError.Text = "Introduce un número!";
            // 
            // bntCreateCancel
            // 
            this.bntCreateCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bntCreateCancel.BackgroundImage")));
            this.bntCreateCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bntCreateCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCreateCancel.Location = new System.Drawing.Point(108, 218);
            this.bntCreateCancel.Name = "bntCreateCancel";
            this.bntCreateCancel.Size = new System.Drawing.Size(79, 113);
            this.bntCreateCancel.TabIndex = 12;
            this.bntCreateCancel.Text = "C&ancelar";
            this.bntCreateCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bntCreateCancel.UseVisualStyleBackColor = true;
            this.bntCreateCancel.Click += new System.EventHandler(this.bntCreateCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCreate.BackgroundImage")));
            this.btnCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(9, 218);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 113);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "&Crear";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(108, 172);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(79, 23);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "&Examinar";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtCreatePhoto
            // 
            this.txtCreatePhoto.Location = new System.Drawing.Point(6, 174);
            this.txtCreatePhoto.Name = "txtCreatePhoto";
            this.txtCreatePhoto.Size = new System.Drawing.Size(96, 21);
            this.txtCreatePhoto.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Foto:";
            // 
            // txtCreateNumEmployer
            // 
            this.txtCreateNumEmployer.Location = new System.Drawing.Point(6, 104);
            this.txtCreateNumEmployer.Name = "txtCreateNumEmployer";
            this.txtCreateNumEmployer.Size = new System.Drawing.Size(153, 21);
            this.txtCreateNumEmployer.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "nº de empleado:";
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.groupBox1.Controls.Add(this.lblDeleteError);
            this.groupBox1.Controls.Add(this.lblDeleteIntParseError);
            this.groupBox1.Controls.Add(this.lblEmployerNoExistError);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblDeleteName);
            this.groupBox1.Controls.Add(this.btnDeleteCancel);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.txtDeleteNumEmployer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(466, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 363);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar Empleado";
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
            // lblDeleteIntParseError
            // 
            this.lblDeleteIntParseError.AutoSize = true;
            this.lblDeleteIntParseError.ForeColor = System.Drawing.Color.Red;
            this.lblDeleteIntParseError.Location = new System.Drawing.Point(26, 77);
            this.lblDeleteIntParseError.Name = "lblDeleteIntParseError";
            this.lblDeleteIntParseError.Size = new System.Drawing.Size(144, 15);
            this.lblDeleteIntParseError.TabIndex = 15;
            this.lblDeleteIntParseError.Text = "Introduce un número!";
            // 
            // lblEmployerNoExistError
            // 
            this.lblEmployerNoExistError.AutoSize = true;
            this.lblEmployerNoExistError.ForeColor = System.Drawing.Color.Red;
            this.lblEmployerNoExistError.Location = new System.Drawing.Point(20, 77);
            this.lblEmployerNoExistError.Name = "lblEmployerNoExistError";
            this.lblEmployerNoExistError.Size = new System.Drawing.Size(150, 15);
            this.lblEmployerNoExistError.TabIndex = 15;
            this.lblEmployerNoExistError.Text = "Empleado inexistente!";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearch.BackgroundImage")));
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(141, 33);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(46, 41);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
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
            this.btnDeleteCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteCancel.BackgroundImage")));
            this.btnDeleteCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCancel.Location = new System.Drawing.Point(108, 218);
            this.btnDeleteCancel.Name = "btnDeleteCancel";
            this.btnDeleteCancel.Size = new System.Drawing.Size(79, 113);
            this.btnDeleteCancel.TabIndex = 12;
            this.btnDeleteCancel.Text = "C&ancelar";
            this.btnDeleteCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDeleteCancel.UseVisualStyleBackColor = true;
            this.btnDeleteCancel.Click += new System.EventHandler(this.btnDeleteCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(9, 218);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 113);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "E&liminar";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDeleteNumEmployer
            // 
            this.txtDeleteNumEmployer.Location = new System.Drawing.Point(6, 53);
            this.txtDeleteNumEmployer.Name = "txtDeleteNumEmployer";
            this.txtDeleteNumEmployer.Size = new System.Drawing.Size(129, 21);
            this.txtDeleteNumEmployer.TabIndex = 7;
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
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCopy.BackgroundImage")));
            this.btnCopy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopy.Location = new System.Drawing.Point(574, 515);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(85, 113);
            this.btnCopy.TabIndex = 17;
            this.btnCopy.Text = "&CopiarBD";
            this.btnCopy.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 640);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtCreateNumEmployer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCreateName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntCreateCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEmployerNoExistError;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblDeleteName;
        private System.Windows.Forms.Button btnDeleteCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDeleteNumEmployer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCreateIntParseError;
        private System.Windows.Forms.Label lblDeleteIntParseError;
        private System.Windows.Forms.Label lblCreateExistingNumberError;
        private System.Windows.Forms.Label lblCreateError;
        private System.Windows.Forms.Label lblDeleteError;
        private System.Windows.Forms.Label lblCreateFileNoExistError;
        private System.Windows.Forms.Button btnCopy;
    }
}