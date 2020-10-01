namespace JH_CST117_InClassAssignment3
{
    partial class YourWeightOnMars
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
            this.EarthWeightLabel = new System.Windows.Forms.Label();
            this.MarsWeightLabel = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.txtEarthWeight = new System.Windows.Forms.TextBox();
            this.txtMarsWeight = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EarthWeightLabel
            // 
            this.EarthWeightLabel.AutoSize = true;
            this.EarthWeightLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EarthWeightLabel.Location = new System.Drawing.Point(74, 54);
            this.EarthWeightLabel.Name = "EarthWeightLabel";
            this.EarthWeightLabel.Size = new System.Drawing.Size(274, 33);
            this.EarthWeightLabel.TabIndex = 0;
            this.EarthWeightLabel.Text = "Enter Weight on Earth: ";
            this.EarthWeightLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // MarsWeightLabel
            // 
            this.MarsWeightLabel.AutoSize = true;
            this.MarsWeightLabel.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MarsWeightLabel.Location = new System.Drawing.Point(84, 126);
            this.MarsWeightLabel.Name = "MarsWeightLabel";
            this.MarsWeightLabel.Size = new System.Drawing.Size(264, 33);
            this.MarsWeightLabel.TabIndex = 1;
            this.MarsWeightLabel.Text = "Your Weight on Mars: ";
            // 
            // btnConvert
            // 
            this.btnConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnConvert.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvert.Location = new System.Drawing.Point(188, 198);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(200, 62);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = false;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // txtEarthWeight
            // 
            this.txtEarthWeight.Location = new System.Drawing.Point(385, 66);
            this.txtEarthWeight.Name = "txtEarthWeight";
            this.txtEarthWeight.Size = new System.Drawing.Size(124, 20);
            this.txtEarthWeight.TabIndex = 3;
            // 
            // txtMarsWeight
            // 
            this.txtMarsWeight.Location = new System.Drawing.Point(385, 138);
            this.txtMarsWeight.Name = "txtMarsWeight";
            this.txtMarsWeight.Size = new System.Drawing.Size(124, 20);
            this.txtMarsWeight.TabIndex = 4;
            // 
            // YourWeightOnMars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 317);
            this.Controls.Add(this.txtMarsWeight);
            this.Controls.Add(this.txtEarthWeight);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.MarsWeightLabel);
            this.Controls.Add(this.EarthWeightLabel);
            this.Name = "YourWeightOnMars";
            this.Text = "Your Weight On Mars";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EarthWeightLabel;
        private System.Windows.Forms.Label MarsWeightLabel;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox txtEarthWeight;
        private System.Windows.Forms.TextBox txtMarsWeight;
    }
}

