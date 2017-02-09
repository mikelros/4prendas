namespace CapaPresentacion
{
    partial class frmRecogida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecogida));
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtGivingPerson = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmployer = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantityError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCollectionNum = new System.Windows.Forms.TextBox();
            this.lblCollectionNumError = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pboEmployer = new System.Windows.Forms.PictureBox();
            this.dtpCollectionDate = new System.Windows.Forms.DateTimePicker();
            this.lblEmployerPassError = new System.Windows.Forms.Label();
            this.lblEmployer = new System.Windows.Forms.Label();
            this.lblCollectionDate = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pboEmployer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(223, 123);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(141, 18);
            this.lblTitle.TabIndex = 62;
            this.lblTitle.Text = "Recogida de ropa";
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCancel.BackgroundImage")));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(491, 487);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 110);
            this.btnCancel.TabIndex = 61;
            this.btnCancel.Text = "&Cancelar";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.BackColor = System.Drawing.Color.White;
            this.btnInsert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsert.BackgroundImage")));
            this.btnInsert.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(352, 487);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 110);
            this.btnInsert.TabIndex = 60;
            this.btnInsert.Text = "&Insertar";
            this.btnInsert.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtGivingPerson
            // 
            this.txtGivingPerson.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtGivingPerson.Location = new System.Drawing.Point(413, 400);
            this.txtGivingPerson.Name = "txtGivingPerson";
            this.txtGivingPerson.Size = new System.Drawing.Size(153, 20);
            this.txtGivingPerson.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 18);
            this.label7.TabIndex = 58;
            this.label7.Text = "Persona que entrega";
            // 
            // txtEmployer
            // 
            this.txtEmployer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEmployer.Location = new System.Drawing.Point(413, 223);
            this.txtEmployer.Name = "txtEmployer";
            this.txtEmployer.Size = new System.Drawing.Size(153, 20);
            this.txtEmployer.TabIndex = 57;
            this.txtEmployer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmployer_KeyPress);
            this.txtEmployer.Leave += new System.EventHandler(this.chargeEmployer);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtQuantity.Location = new System.Drawing.Point(413, 342);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(153, 20);
            this.txtQuantity.TabIndex = 56;
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblQuantityError
            // 
            this.lblQuantityError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblQuantityError.AutoSize = true;
            this.lblQuantityError.ForeColor = System.Drawing.Color.Red;
            this.lblQuantityError.Location = new System.Drawing.Point(419, 365);
            this.lblQuantityError.Name = "lblQuantityError";
            this.lblQuantityError.Size = new System.Drawing.Size(32, 13);
            this.lblQuantityError.TabIndex = 55;
            this.lblQuantityError.Text = "Error!";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(263, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Cantidad artículos";
            // 
            // txtCollectionNum
            // 
            this.txtCollectionNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCollectionNum.Location = new System.Drawing.Point(413, 286);
            this.txtCollectionNum.Name = "txtCollectionNum";
            this.txtCollectionNum.Size = new System.Drawing.Size(153, 20);
            this.txtCollectionNum.TabIndex = 53;
            this.txtCollectionNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantity_KeyPress);
            // 
            // lblCollectionNumError
            // 
            this.lblCollectionNumError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCollectionNumError.AutoSize = true;
            this.lblCollectionNumError.ForeColor = System.Drawing.Color.Red;
            this.lblCollectionNumError.Location = new System.Drawing.Point(419, 309);
            this.lblCollectionNumError.Name = "lblCollectionNumError";
            this.lblCollectionNumError.Size = new System.Drawing.Size(32, 13);
            this.lblCollectionNumError.TabIndex = 52;
            this.lblCollectionNumError.Text = "Error!";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(310, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 51;
            this.label6.Text = "NºRecogida";
            // 
            // pboEmployer
            // 
            this.pboEmployer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pboEmployer.Location = new System.Drawing.Point(588, 187);
            this.pboEmployer.Name = "pboEmployer";
            this.pboEmployer.Size = new System.Drawing.Size(71, 88);
            this.pboEmployer.TabIndex = 50;
            this.pboEmployer.TabStop = false;
            // 
            // dtpCollectionDate
            // 
            this.dtpCollectionDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtpCollectionDate.Location = new System.Drawing.Point(413, 161);
            this.dtpCollectionDate.Name = "dtpCollectionDate";
            this.dtpCollectionDate.Size = new System.Drawing.Size(200, 20);
            this.dtpCollectionDate.TabIndex = 49;
            // 
            // lblEmployerPassError
            // 
            this.lblEmployerPassError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblEmployerPassError.AutoSize = true;
            this.lblEmployerPassError.ForeColor = System.Drawing.Color.Red;
            this.lblEmployerPassError.Location = new System.Drawing.Point(422, 244);
            this.lblEmployerPassError.Name = "lblEmployerPassError";
            this.lblEmployerPassError.Size = new System.Drawing.Size(32, 13);
            this.lblEmployerPassError.TabIndex = 48;
            this.lblEmployerPassError.Text = "Error!";
            // 
            // lblEmployer
            // 
            this.lblEmployer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblEmployer.AutoSize = true;
            this.lblEmployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployer.Location = new System.Drawing.Point(324, 222);
            this.lblEmployer.Name = "lblEmployer";
            this.lblEmployer.Size = new System.Drawing.Size(83, 18);
            this.lblEmployer.TabIndex = 47;
            this.lblEmployer.Text = "Empleado";
            // 
            // lblCollectionDate
            // 
            this.lblCollectionDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCollectionDate.AutoSize = true;
            this.lblCollectionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollectionDate.Location = new System.Drawing.Point(260, 161);
            this.lblCollectionDate.Name = "lblCollectionDate";
            this.lblCollectionDate.Size = new System.Drawing.Size(147, 18);
            this.lblCollectionDate.TabIndex = 46;
            this.lblCollectionDate.Text = "Fecha de recogida";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackgroundImage = global::CapaPresentacion.Properties.Resources.exit;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(632, 487);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 110);
            this.btnBack.TabIndex = 63;
            this.btnBack.Text = "A&trás";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmRecogida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 678);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtGivingPerson);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmployer);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantityError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCollectionNum);
            this.Controls.Add(this.lblCollectionNumError);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pboEmployer);
            this.Controls.Add(this.dtpCollectionDate);
            this.Controls.Add(this.lblEmployerPassError);
            this.Controls.Add(this.lblEmployer);
            this.Controls.Add(this.lblCollectionDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecogida";
            this.Text = "frmRecogida";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRecogida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboEmployer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtGivingPerson;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmployer;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantityError;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCollectionNum;
        private System.Windows.Forms.Label lblCollectionNumError;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pboEmployer;
        private System.Windows.Forms.DateTimePicker dtpCollectionDate;
        private System.Windows.Forms.Label lblEmployerPassError;
        private System.Windows.Forms.Label lblEmployer;
        private System.Windows.Forms.Label lblCollectionDate;
        private System.Windows.Forms.Button btnBack;
    }
}