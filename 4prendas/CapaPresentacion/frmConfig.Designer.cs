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
            this.bntCreateCancel = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPhoto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grbType.SuspendLayout();
            this.grbNewEmployer.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(265, 348);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(127, 348);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 9;
            this.btnApply.Text = "&Aplicar";
            this.btnApply.UseVisualStyleBackColor = true;
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
            this.grbType.Controls.Add(this.rbtnFood);
            this.grbType.Controls.Add(this.rbtnClothes);
            this.grbType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbType.Location = new System.Drawing.Point(12, 12);
            this.grbType.Name = "grbType";
            this.grbType.Size = new System.Drawing.Size(117, 85);
            this.grbType.TabIndex = 12;
            this.grbType.TabStop = false;
            this.grbType.Text = "Tipo Tienda";
            // 
            // grbNewEmployer
            // 
            this.grbNewEmployer.Controls.Add(this.bntCreateCancel);
            this.grbNewEmployer.Controls.Add(this.btnCreate);
            this.grbNewEmployer.Controls.Add(this.btnBrowse);
            this.grbNewEmployer.Controls.Add(this.txtPhoto);
            this.grbNewEmployer.Controls.Add(this.label3);
            this.grbNewEmployer.Controls.Add(this.txtNumber);
            this.grbNewEmployer.Controls.Add(this.label2);
            this.grbNewEmployer.Controls.Add(this.txtName);
            this.grbNewEmployer.Controls.Add(this.label1);
            this.grbNewEmployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbNewEmployer.Location = new System.Drawing.Point(147, 12);
            this.grbNewEmployer.Name = "grbNewEmployer";
            this.grbNewEmployer.Size = new System.Drawing.Size(193, 238);
            this.grbNewEmployer.TabIndex = 13;
            this.grbNewEmployer.TabStop = false;
            this.grbNewEmployer.Text = "Nuevo Empleado";
            // 
            // bntCreateCancel
            // 
            this.bntCreateCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCreateCancel.Location = new System.Drawing.Point(108, 194);
            this.bntCreateCancel.Name = "bntCreateCancel";
            this.bntCreateCancel.Size = new System.Drawing.Size(79, 23);
            this.bntCreateCancel.TabIndex = 12;
            this.bntCreateCancel.Text = "C&ancelar";
            this.bntCreateCancel.UseVisualStyleBackColor = true;
            this.bntCreateCancel.Click += new System.EventHandler(this.bntCreateCancel_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(9, 194);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 11;
            this.btnCreate.Text = "&Crear";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(108, 153);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(79, 23);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "&Examinar";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPhoto
            // 
            this.txtPhoto.Location = new System.Drawing.Point(6, 155);
            this.txtPhoto.Name = "txtPhoto";
            this.txtPhoto.Size = new System.Drawing.Size(96, 21);
            this.txtPhoto.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Foto:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(6, 104);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(153, 21);
            this.txtNumber.TabIndex = 7;
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
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(6, 53);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(153, 21);
            this.txtName.TabIndex = 5;
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
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.btnDeleteCancel);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(356, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 238);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Eliminar Empleado";
            // 
            // btnDeleteCancel
            // 
            this.btnDeleteCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCancel.Location = new System.Drawing.Point(108, 194);
            this.btnDeleteCancel.Name = "btnDeleteCancel";
            this.btnDeleteCancel.Size = new System.Drawing.Size(79, 23);
            this.btnDeleteCancel.TabIndex = 12;
            this.btnDeleteCancel.Text = "C&ancelar";
            this.btnDeleteCancel.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(9, 194);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "E&liminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 53);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(129, 21);
            this.textBox2.TabIndex = 7;
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
            this.label6.Location = new System.Drawing.Point(6, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nombre:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(35, 108);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 18);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "nombre";
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
            // 
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 483);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbNewEmployer);
            this.Controls.Add(this.grbType);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnExit);
            this.Name = "frmConfig";
            this.Text = "Configuración";
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
        private System.Windows.Forms.TextBox txtPhoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntCreateCancel;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnDeleteCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}