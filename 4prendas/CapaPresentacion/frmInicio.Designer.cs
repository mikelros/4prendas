namespace CapaPresentacion
{
    partial class frmInicio
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
            this.btnIRAREGISTRO = new System.Windows.Forms.Button();
            this.btnIRARECOGIDA = new System.Windows.Forms.Button();
            this.btnIRACONFIG = new System.Windows.Forms.Button();
            this.btnIRALOGINADMIN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCalculator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIRAREGISTRO
            // 
            this.btnIRAREGISTRO.BackColor = System.Drawing.Color.Coral;
            this.btnIRAREGISTRO.Location = new System.Drawing.Point(3, 305);
            this.btnIRAREGISTRO.Name = "btnIRAREGISTRO";
            this.btnIRAREGISTRO.Size = new System.Drawing.Size(92, 29);
            this.btnIRAREGISTRO.TabIndex = 12;
            this.btnIRAREGISTRO.Text = "Registro";
            this.btnIRAREGISTRO.UseVisualStyleBackColor = false;
            this.btnIRAREGISTRO.Click += new System.EventHandler(this.btnIRAREGISTRO_Click);
            // 
            // btnIRARECOGIDA
            // 
            this.btnIRARECOGIDA.BackColor = System.Drawing.Color.Coral;
            this.btnIRARECOGIDA.Location = new System.Drawing.Point(3, 267);
            this.btnIRARECOGIDA.Name = "btnIRARECOGIDA";
            this.btnIRARECOGIDA.Size = new System.Drawing.Size(92, 32);
            this.btnIRARECOGIDA.TabIndex = 13;
            this.btnIRARECOGIDA.Text = "Recogida";
            this.btnIRARECOGIDA.UseVisualStyleBackColor = false;
            this.btnIRARECOGIDA.Click += new System.EventHandler(this.btnIRARECOGIDA_Click);
            // 
            // btnIRACONFIG
            // 
            this.btnIRACONFIG.BackColor = System.Drawing.Color.Coral;
            this.btnIRACONFIG.Location = new System.Drawing.Point(3, 217);
            this.btnIRACONFIG.Name = "btnIRACONFIG";
            this.btnIRACONFIG.Size = new System.Drawing.Size(92, 30);
            this.btnIRACONFIG.TabIndex = 14;
            this.btnIRACONFIG.Text = "Config";
            this.btnIRACONFIG.UseVisualStyleBackColor = false;
            this.btnIRACONFIG.Click += new System.EventHandler(this.btnIRACONFIG_Click);
            // 
            // btnIRALOGINADMIN
            // 
            this.btnIRALOGINADMIN.BackColor = System.Drawing.Color.Coral;
            this.btnIRALOGINADMIN.Location = new System.Drawing.Point(3, 181);
            this.btnIRALOGINADMIN.Name = "btnIRALOGINADMIN";
            this.btnIRALOGINADMIN.Size = new System.Drawing.Size(92, 30);
            this.btnIRALOGINADMIN.TabIndex = 15;
            this.btnIRALOGINADMIN.Text = "LoginAdmin";
            this.btnIRALOGINADMIN.UseVisualStyleBackColor = false;
            this.btnIRALOGINADMIN.Click += new System.EventHandler(this.btnIRALOGINADMIN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(799, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "Empleado:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(802, 112);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(799, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nombre Empleado";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::CapaPresentacion.Properties.Resources._4Prendas;
            this.pictureBox3.Location = new System.Drawing.Point(143, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(650, 140);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 55;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CapaPresentacion.Properties.Resources.newsle_empty_icon;
            this.pictureBox2.Location = new System.Drawing.Point(802, 157);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 54;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.Logo4V;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(137, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // btnCalculator
            // 
            this.btnCalculator.BackgroundImage = global::CapaPresentacion.Properties.Resources.Calculator;
            this.btnCalculator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCalculator.Location = new System.Drawing.Point(3, 356);
            this.btnCalculator.Name = "btnCalculator";
            this.btnCalculator.Size = new System.Drawing.Size(92, 101);
            this.btnCalculator.TabIndex = 56;
            this.btnCalculator.UseVisualStyleBackColor = true;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 626);
            this.Controls.Add(this.btnCalculator);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnIRALOGINADMIN);
            this.Controls.Add(this.btnIRACONFIG);
            this.Controls.Add(this.btnIRARECOGIDA);
            this.Controls.Add(this.btnIRAREGISTRO);
            this.Name = "frmInicio";
            this.Text = "4Tiendas";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIRAREGISTRO;
        private System.Windows.Forms.Button btnIRARECOGIDA;
        private System.Windows.Forms.Button btnIRACONFIG;
        private System.Windows.Forms.Button btnIRALOGINADMIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnCalculator;
    }
}

