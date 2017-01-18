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
            this.btnTestNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTestNext
            // 
            this.btnTestNext.BackColor = System.Drawing.Color.Coral;
            this.btnTestNext.Location = new System.Drawing.Point(514, 571);
            this.btnTestNext.Name = "btnTestNext";
            this.btnTestNext.Size = new System.Drawing.Size(89, 19);
            this.btnTestNext.TabIndex = 11;
            this.btnTestNext.Text = "FormPalante";
            this.btnTestNext.UseVisualStyleBackColor = false;
            this.btnTestNext.Click += new System.EventHandler(this.btnTestNext_Click);
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 602);
            this.Controls.Add(this.btnTestNext);
            this.Name = "frmInicio";
            this.Text = "4Tiendas";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTestNext;
    }
}

