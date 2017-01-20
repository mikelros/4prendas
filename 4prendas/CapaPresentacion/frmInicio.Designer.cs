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
            this.SuspendLayout();
            // 
            // btnIRAREGISTRO
            // 
            this.btnIRAREGISTRO.BackColor = System.Drawing.Color.Coral;
            this.btnIRAREGISTRO.Location = new System.Drawing.Point(12, 136);
            this.btnIRAREGISTRO.Name = "btnIRAREGISTRO";
            this.btnIRAREGISTRO.Size = new System.Drawing.Size(75, 19);
            this.btnIRAREGISTRO.TabIndex = 12;
            this.btnIRAREGISTRO.Text = "Registro";
            this.btnIRAREGISTRO.UseVisualStyleBackColor = false;
            this.btnIRAREGISTRO.Click += new System.EventHandler(this.btnIRAREGISTRO_Click);
            // 
            // btnIRARECOGIDA
            // 
            this.btnIRARECOGIDA.BackColor = System.Drawing.Color.Coral;
            this.btnIRARECOGIDA.Location = new System.Drawing.Point(12, 98);
            this.btnIRARECOGIDA.Name = "btnIRARECOGIDA";
            this.btnIRARECOGIDA.Size = new System.Drawing.Size(75, 19);
            this.btnIRARECOGIDA.TabIndex = 13;
            this.btnIRARECOGIDA.Text = "Recogida";
            this.btnIRARECOGIDA.UseVisualStyleBackColor = false;
            this.btnIRARECOGIDA.Click += new System.EventHandler(this.btnIRARECOGIDA_Click);
            // 
            // btnIRACONFIG
            // 
            this.btnIRACONFIG.BackColor = System.Drawing.Color.Coral;
            this.btnIRACONFIG.Location = new System.Drawing.Point(12, 48);
            this.btnIRACONFIG.Name = "btnIRACONFIG";
            this.btnIRACONFIG.Size = new System.Drawing.Size(75, 19);
            this.btnIRACONFIG.TabIndex = 14;
            this.btnIRACONFIG.Text = "Config";
            this.btnIRACONFIG.UseVisualStyleBackColor = false;
            this.btnIRACONFIG.Click += new System.EventHandler(this.btnIRACONFIG_Click);
            // 
            // btnIRALOGINADMIN
            // 
            this.btnIRALOGINADMIN.BackColor = System.Drawing.Color.Coral;
            this.btnIRALOGINADMIN.Location = new System.Drawing.Point(12, 12);
            this.btnIRALOGINADMIN.Name = "btnIRALOGINADMIN";
            this.btnIRALOGINADMIN.Size = new System.Drawing.Size(75, 19);
            this.btnIRALOGINADMIN.TabIndex = 15;
            this.btnIRALOGINADMIN.Text = "LoginAdmin";
            this.btnIRALOGINADMIN.UseVisualStyleBackColor = false;
            this.btnIRALOGINADMIN.Click += new System.EventHandler(this.btnIRALOGINADMIN_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 400);
            this.Controls.Add(this.btnIRALOGINADMIN);
            this.Controls.Add(this.btnIRACONFIG);
            this.Controls.Add(this.btnIRARECOGIDA);
            this.Controls.Add(this.btnIRAREGISTRO);
            this.Name = "frmInicio";
            this.Text = "4Tiendas";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIRAREGISTRO;
        private System.Windows.Forms.Button btnIRARECOGIDA;
        private System.Windows.Forms.Button btnIRACONFIG;
        private System.Windows.Forms.Button btnIRALOGINADMIN;
    }
}

