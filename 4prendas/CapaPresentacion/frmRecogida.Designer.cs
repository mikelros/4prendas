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
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pboEmpleado = new System.Windows.Forms.PictureBox();
            this.dtpFechaRecogida = new System.Windows.Forms.DateTimePicker();
            this.lblEmployer = new System.Windows.Forms.Label();
            this.lblCollectionDate = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblErrorPaseEmpleado = new System.Windows.Forms.Label();
            this.nudEmpleado = new System.Windows.Forms.NumericUpDown();
            this.gbRecogida = new System.Windows.Forms.GroupBox();
            this.lblNRecogida = new System.Windows.Forms.Label();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.txtDonante = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleado)).BeginInit();
            this.gbRecogida.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(49, 36);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(89, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 54;
            this.label4.Text = "Cantidad artículos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(136, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 18);
            this.label6.TabIndex = 51;
            this.label6.Text = "NºRecogida";
            // 
            // pboEmpleado
            // 
            this.pboEmpleado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboEmpleado.Location = new System.Drawing.Point(413, 100);
            this.pboEmpleado.Name = "pboEmpleado";
            this.pboEmpleado.Size = new System.Drawing.Size(71, 88);
            this.pboEmpleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboEmpleado.TabIndex = 50;
            this.pboEmpleado.TabStop = false;
            // 
            // dtpFechaRecogida
            // 
            this.dtpFechaRecogida.Location = new System.Drawing.Point(239, 74);
            this.dtpFechaRecogida.Name = "dtpFechaRecogida";
            this.dtpFechaRecogida.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRecogida.TabIndex = 49;
            // 
            // lblEmployer
            // 
            this.lblEmployer.AutoSize = true;
            this.lblEmployer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployer.Location = new System.Drawing.Point(150, 135);
            this.lblEmployer.Name = "lblEmployer";
            this.lblEmployer.Size = new System.Drawing.Size(83, 18);
            this.lblEmployer.TabIndex = 47;
            this.lblEmployer.Text = "Empleado";
            // 
            // lblCollectionDate
            // 
            this.lblCollectionDate.AutoSize = true;
            this.lblCollectionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCollectionDate.Location = new System.Drawing.Point(86, 74);
            this.lblCollectionDate.Name = "lblCollectionDate";
            this.lblCollectionDate.Size = new System.Drawing.Size(147, 18);
            this.lblCollectionDate.TabIndex = 46;
            this.lblCollectionDate.Text = "Fecha de recogida";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackgroundImage = global::CapaPresentacion.Properties.Resources.back_arrow;
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
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(239, 256);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(152, 20);
            this.nudCantidad.TabIndex = 64;
            // 
            // lblErrorPaseEmpleado
            // 
            this.lblErrorPaseEmpleado.AutoSize = true;
            this.lblErrorPaseEmpleado.ForeColor = System.Drawing.Color.Red;
            this.lblErrorPaseEmpleado.Location = new System.Drawing.Point(248, 157);
            this.lblErrorPaseEmpleado.Name = "lblErrorPaseEmpleado";
            this.lblErrorPaseEmpleado.Size = new System.Drawing.Size(32, 13);
            this.lblErrorPaseEmpleado.TabIndex = 48;
            this.lblErrorPaseEmpleado.Text = "Error!";
            // 
            // nudEmpleado
            // 
            this.nudEmpleado.Location = new System.Drawing.Point(240, 137);
            this.nudEmpleado.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudEmpleado.Name = "nudEmpleado";
            this.nudEmpleado.Size = new System.Drawing.Size(58, 20);
            this.nudEmpleado.TabIndex = 64;
            this.nudEmpleado.Leave += new System.EventHandler(this.nudEmployee_Leave);
            // 
            // gbRecogida
            // 
            this.gbRecogida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gbRecogida.Controls.Add(this.lblNRecogida);
            this.gbRecogida.Controls.Add(this.lblNombreEmpleado);
            this.gbRecogida.Controls.Add(this.nudEmpleado);
            this.gbRecogida.Controls.Add(this.nudCantidad);
            this.gbRecogida.Controls.Add(this.lblTitle);
            this.gbRecogida.Controls.Add(this.txtDonante);
            this.gbRecogida.Controls.Add(this.label7);
            this.gbRecogida.Controls.Add(this.label4);
            this.gbRecogida.Controls.Add(this.label6);
            this.gbRecogida.Controls.Add(this.pboEmpleado);
            this.gbRecogida.Controls.Add(this.dtpFechaRecogida);
            this.gbRecogida.Controls.Add(this.lblErrorPaseEmpleado);
            this.gbRecogida.Controls.Add(this.lblEmployer);
            this.gbRecogida.Controls.Add(this.lblCollectionDate);
            this.gbRecogida.Location = new System.Drawing.Point(191, 77);
            this.gbRecogida.Name = "gbRecogida";
            this.gbRecogida.Size = new System.Drawing.Size(532, 381);
            this.gbRecogida.TabIndex = 65;
            this.gbRecogida.TabStop = false;
            // 
            // lblNRecogida
            // 
            this.lblNRecogida.AutoSize = true;
            this.lblNRecogida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNRecogida.Location = new System.Drawing.Point(248, 198);
            this.lblNRecogida.Name = "lblNRecogida";
            this.lblNRecogida.Size = new System.Drawing.Size(0, 18);
            this.lblNRecogida.TabIndex = 66;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.Location = new System.Drawing.Point(304, 139);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(0, 18);
            this.lblNombreEmpleado.TabIndex = 65;
            // 
            // txtDonante
            // 
            this.txtDonante.Location = new System.Drawing.Point(239, 313);
            this.txtDonante.Name = "txtDonante";
            this.txtDonante.Size = new System.Drawing.Size(153, 20);
            this.txtDonante.TabIndex = 59;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(69, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 18);
            this.label7.TabIndex = 58;
            this.label7.Text = "Persona que entrega";
            // 
            // frmRecogida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(921, 678);
            this.Controls.Add(this.gbRecogida);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnInsert);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRecogida";
            this.Text = "frmRecogida";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRecogida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleado)).EndInit();
            this.gbRecogida.ResumeLayout(false);
            this.gbRecogida.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pboEmpleado;
        private System.Windows.Forms.DateTimePicker dtpFechaRecogida;
        private System.Windows.Forms.Label lblEmployer;
        private System.Windows.Forms.Label lblCollectionDate;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblErrorPaseEmpleado;
        private System.Windows.Forms.NumericUpDown nudEmpleado;
        private System.Windows.Forms.GroupBox gbRecogida;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.TextBox txtDonante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblNRecogida;
    }
}