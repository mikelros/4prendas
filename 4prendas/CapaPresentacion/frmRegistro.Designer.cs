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
            this.gboRegistros = new System.Windows.Forms.GroupBox();
            this.nupCoste = new System.Windows.Forms.NumericUpDown();
            this.lblErrorCoste = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudNumRecogida = new System.Windows.Forms.NumericUpDown();
            this.nudEmpleado = new System.Windows.Forms.NumericUpDown();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.lblErrorNumRecogida = new System.Windows.Forms.Label();
            this.lblErrorEmpleado = new System.Windows.Forms.Label();
            this.lblErrorStock = new System.Windows.Forms.Label();
            this.lblErrorCodArticulo = new System.Windows.Forms.Label();
            this.txtMedida = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtCodArticulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.gboRegistros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCoste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumRecogida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // gboRegistros
            // 
            this.gboRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.gboRegistros.BackColor = System.Drawing.Color.Transparent;
            this.gboRegistros.Controls.Add(this.nupCoste);
            this.gboRegistros.Controls.Add(this.lblErrorCoste);
            this.gboRegistros.Controls.Add(this.label12);
            this.gboRegistros.Controls.Add(this.nudNumRecogida);
            this.gboRegistros.Controls.Add(this.nudEmpleado);
            this.gboRegistros.Controls.Add(this.nudStock);
            this.gboRegistros.Controls.Add(this.btnGenerar);
            this.gboRegistros.Controls.Add(this.lblErrorNumRecogida);
            this.gboRegistros.Controls.Add(this.lblErrorEmpleado);
            this.gboRegistros.Controls.Add(this.lblErrorStock);
            this.gboRegistros.Controls.Add(this.lblErrorCodArticulo);
            this.gboRegistros.Controls.Add(this.txtMedida);
            this.gboRegistros.Controls.Add(this.txtDescripcion);
            this.gboRegistros.Controls.Add(this.txtCodArticulo);
            this.gboRegistros.Controls.Add(this.label6);
            this.gboRegistros.Controls.Add(this.label5);
            this.gboRegistros.Controls.Add(this.label4);
            this.gboRegistros.Controls.Add(this.label3);
            this.gboRegistros.Controls.Add(this.label2);
            this.gboRegistros.Controls.Add(this.label1);
            this.gboRegistros.Location = new System.Drawing.Point(12, 33);
            this.gboRegistros.Name = "gboRegistros";
            this.gboRegistros.Size = new System.Drawing.Size(260, 453);
            this.gboRegistros.TabIndex = 0;
            this.gboRegistros.TabStop = false;
            this.gboRegistros.Text = "Registro de Articulos";
            // 
            // nupCoste
            // 
            this.nupCoste.Location = new System.Drawing.Point(130, 307);
            this.nupCoste.Name = "nupCoste";
            this.nupCoste.Size = new System.Drawing.Size(124, 20);
            this.nupCoste.TabIndex = 24;
            // 
            // lblErrorCoste
            // 
            this.lblErrorCoste.AutoSize = true;
            this.lblErrorCoste.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCoste.Location = new System.Drawing.Point(147, 330);
            this.lblErrorCoste.Name = "lblErrorCoste";
            this.lblErrorCoste.Size = new System.Drawing.Size(91, 13);
            this.lblErrorCoste.TabIndex = 23;
            this.lblErrorCoste.Text = "Campo obligatorio";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "Coste";
            // 
            // nudNumRecogida
            // 
            this.nudNumRecogida.Location = new System.Drawing.Point(130, 255);
            this.nudNumRecogida.Name = "nudNumRecogida";
            this.nudNumRecogida.Size = new System.Drawing.Size(124, 20);
            this.nudNumRecogida.TabIndex = 21;
            this.nudNumRecogida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNums);
            // 
            // nudEmpleado
            // 
            this.nudEmpleado.Location = new System.Drawing.Point(130, 202);
            this.nudEmpleado.Name = "nudEmpleado";
            this.nudEmpleado.Size = new System.Drawing.Size(124, 20);
            this.nudEmpleado.TabIndex = 20;
            this.nudEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNums);
            // 
            // nudStock
            // 
            this.nudStock.Location = new System.Drawing.Point(130, 151);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(124, 20);
            this.nudStock.TabIndex = 19;
            this.nudStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.onlyNums);
            // 
            // btnGenerar
            // 
            this.btnGenerar.BackColor = System.Drawing.Color.White;
            this.btnGenerar.BackgroundImage = global::CapaPresentacion.Properties.Resources.plus;
            this.btnGenerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnGenerar.Location = new System.Drawing.Point(185, 361);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(69, 86);
            this.btnGenerar.TabIndex = 18;
            this.btnGenerar.Text = "Añadir";
            this.btnGenerar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGenerar.UseVisualStyleBackColor = false;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // lblErrorNumRecogida
            // 
            this.lblErrorNumRecogida.AutoSize = true;
            this.lblErrorNumRecogida.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNumRecogida.Location = new System.Drawing.Point(147, 278);
            this.lblErrorNumRecogida.Name = "lblErrorNumRecogida";
            this.lblErrorNumRecogida.Size = new System.Drawing.Size(91, 13);
            this.lblErrorNumRecogida.TabIndex = 17;
            this.lblErrorNumRecogida.Text = "Campo obligatorio";
            // 
            // lblErrorEmpleado
            // 
            this.lblErrorEmpleado.AutoSize = true;
            this.lblErrorEmpleado.ForeColor = System.Drawing.Color.Red;
            this.lblErrorEmpleado.Location = new System.Drawing.Point(147, 225);
            this.lblErrorEmpleado.Name = "lblErrorEmpleado";
            this.lblErrorEmpleado.Size = new System.Drawing.Size(91, 13);
            this.lblErrorEmpleado.TabIndex = 16;
            this.lblErrorEmpleado.Text = "Campo obligatorio";
            // 
            // lblErrorStock
            // 
            this.lblErrorStock.AutoSize = true;
            this.lblErrorStock.ForeColor = System.Drawing.Color.Red;
            this.lblErrorStock.Location = new System.Drawing.Point(147, 174);
            this.lblErrorStock.Name = "lblErrorStock";
            this.lblErrorStock.Size = new System.Drawing.Size(91, 13);
            this.lblErrorStock.TabIndex = 15;
            this.lblErrorStock.Text = "Campo obligatorio";
            // 
            // lblErrorCodArticulo
            // 
            this.lblErrorCodArticulo.AutoSize = true;
            this.lblErrorCodArticulo.ForeColor = System.Drawing.Color.Red;
            this.lblErrorCodArticulo.Location = new System.Drawing.Point(147, 42);
            this.lblErrorCodArticulo.Name = "lblErrorCodArticulo";
            this.lblErrorCodArticulo.Size = new System.Drawing.Size(91, 13);
            this.lblErrorCodArticulo.TabIndex = 14;
            this.lblErrorCodArticulo.Text = "Campo obligatorio";
            // 
            // txtMedida
            // 
            this.txtMedida.Location = new System.Drawing.Point(130, 110);
            this.txtMedida.Name = "txtMedida";
            this.txtMedida.Size = new System.Drawing.Size(124, 20);
            this.txtMedida.TabIndex = 9;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(130, 68);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(124, 20);
            this.txtDescripcion.TabIndex = 8;
            // 
            // txtCodArticulo
            // 
            this.txtCodArticulo.Location = new System.Drawing.Point(130, 19);
            this.txtCodArticulo.Name = "txtCodArticulo";
            this.txtCodArticulo.Size = new System.Drawing.Size(124, 20);
            this.txtCodArticulo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nº Recogida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Descripción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Medida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Stock";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código Artículo";
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(325, 33);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.Size = new System.Drawing.Size(864, 581);
            this.dgvRegistros.TabIndex = 19;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1033, 620);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 116);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "&Salir";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(952, 620);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 116);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Añadir";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.BackgroundImage = global::CapaPresentacion.Properties.Resources.exit;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1114, 623);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 113);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "A&trás";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1273, 790);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvRegistros);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gboRegistros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistro";
            this.Text = "frmRegistro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRegistro_Load);
            this.gboRegistros.ResumeLayout(false);
            this.gboRegistros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupCoste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumRecogida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboRegistros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMedida;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtCodArticulo;
        private System.Windows.Forms.Label lblErrorNumRecogida;
        private System.Windows.Forms.Label lblErrorEmpleado;
        private System.Windows.Forms.Label lblErrorStock;
        private System.Windows.Forms.Label lblErrorCodArticulo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.NumericUpDown nudNumRecogida;
        private System.Windows.Forms.NumericUpDown nudEmpleado;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.NumericUpDown nupCoste;
        private System.Windows.Forms.Label lblErrorCoste;
        private System.Windows.Forms.Label label12;
    }
}