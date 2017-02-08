namespace CapaPresentacion
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pbo4prendas = new System.Windows.Forms.PictureBox();
            this.pboCuatrovientos = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnVenta = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnRecogida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbo4prendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboCuatrovientos)).BeginInit();
            this.SuspendLayout();
            // 
            // pbo4prendas
            // 
            this.pbo4prendas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbo4prendas.Image = global::CapaPresentacion.Properties.Resources._4Prendas;
            this.pbo4prendas.Location = new System.Drawing.Point(333, 12);
            this.pbo4prendas.Name = "pbo4prendas";
            this.pbo4prendas.Size = new System.Drawing.Size(650, 140);
            this.pbo4prendas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbo4prendas.TabIndex = 57;
            this.pbo4prendas.TabStop = false;
            // 
            // pboCuatrovientos
            // 
            this.pboCuatrovientos.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.pboCuatrovientos.Image = global::CapaPresentacion.Properties.Resources.Logo4V;
            this.pboCuatrovientos.Location = new System.Drawing.Point(24, 12);
            this.pboCuatrovientos.Name = "pboCuatrovientos";
            this.pboCuatrovientos.Size = new System.Drawing.Size(137, 140);
            this.pboCuatrovientos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboCuatrovientos.TabIndex = 56;
            this.pboCuatrovientos.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1207, 655);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(93, 113);
            this.btnExit.TabIndex = 79;
            this.btnExit.Text = "&Salir";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.BackColor = System.Drawing.Color.White;
            this.btnConfig.BackgroundImage = global::CapaPresentacion.Properties.Resources.admin;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.Location = new System.Drawing.Point(1108, 655);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(93, 113);
            this.btnConfig.TabIndex = 81;
            this.btnConfig.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnConfig.UseVisualStyleBackColor = false;
            this.btnConfig.Click += new System.EventHandler(this.btnConfig_Click_1);
            // 
            // btnVenta
            // 
            this.btnVenta.BackgroundImage = global::CapaPresentacion.Properties.Resources.cesta;
            this.btnVenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVenta.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVenta.FlatAppearance.BorderSize = 0;
            this.btnVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenta.Location = new System.Drawing.Point(896, 343);
            this.btnVenta.Name = "btnVenta";
            this.btnVenta.Size = new System.Drawing.Size(165, 186);
            this.btnVenta.TabIndex = 83;
            this.btnVenta.UseVisualStyleBackColor = true;
            this.btnVenta.Click += new System.EventHandler(this.btnVenta_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.BackgroundImage = global::CapaPresentacion.Properties.Resources.registro;
            this.btnRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegistro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegistro.FlatAppearance.BorderSize = 0;
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Location = new System.Drawing.Point(590, 343);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(165, 186);
            this.btnRegistro.TabIndex = 84;
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnRecogida
            // 
            this.btnRecogida.BackgroundImage = global::CapaPresentacion.Properties.Resources.bolsa;
            this.btnRecogida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRecogida.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRecogida.FlatAppearance.BorderSize = 0;
            this.btnRecogida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecogida.Location = new System.Drawing.Point(285, 343);
            this.btnRecogida.Name = "btnRecogida";
            this.btnRecogida.Size = new System.Drawing.Size(165, 186);
            this.btnRecogida.TabIndex = 85;
            this.btnRecogida.UseVisualStyleBackColor = true;
            this.btnRecogida.Click += new System.EventHandler(this.btnRecogida_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 780);
            this.Controls.Add(this.btnRecogida);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnVenta);
            this.Controls.Add(this.btnConfig);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pbo4prendas);
            this.Controls.Add(this.pboCuatrovientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbo4prendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboCuatrovientos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbo4prendas;
        private System.Windows.Forms.PictureBox pboCuatrovientos;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnVenta;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnRecogida;
    }
}