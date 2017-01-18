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
            this.btnExit = new System.Windows.Forms.Button();
            this.btnApply = new System.Windows.Forms.Button();
            this.rbtnFood = new System.Windows.Forms.RadioButton();
            this.rbtnClothes = new System.Windows.Forms.RadioButton();
            this.grbType = new System.Windows.Forms.GroupBox();
            this.grbType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(215, 229);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "&Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.Location = new System.Drawing.Point(77, 229);
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
            // frmConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 276);
            this.Controls.Add(this.grbType);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.btnExit);
            this.Name = "frmConfig";
            this.Text = "frmConfig";
            this.grbType.ResumeLayout(false);
            this.grbType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.RadioButton rbtnFood;
        private System.Windows.Forms.RadioButton rbtnClothes;
        private System.Windows.Forms.GroupBox grbType;
    }
}