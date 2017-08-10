namespace QR_Generator_V1._0
{
    partial class mainSelectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainSelectionForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnQrPath = new System.Windows.Forms.Button();
            this.btnBarPath = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(170, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnQrPath
            // 
            this.btnQrPath.BackColor = System.Drawing.SystemColors.Control;
            this.btnQrPath.Location = new System.Drawing.Point(306, 251);
            this.btnQrPath.Name = "btnQrPath";
            this.btnQrPath.Size = new System.Drawing.Size(150, 35);
            this.btnQrPath.TabIndex = 1;
            this.btnQrPath.Text = "Generate QR code";
            this.btnQrPath.UseVisualStyleBackColor = false;
            // 
            // btnBarPath
            // 
            this.btnBarPath.BackColor = System.Drawing.SystemColors.Control;
            this.btnBarPath.Location = new System.Drawing.Point(306, 307);
            this.btnBarPath.Name = "btnBarPath";
            this.btnBarPath.Size = new System.Drawing.Size(150, 35);
            this.btnBarPath.TabIndex = 2;
            this.btnBarPath.Text = "Generate BAR code";
            this.btnBarPath.UseVisualStyleBackColor = false;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.SystemColors.Control;
            this.btnAbout.Location = new System.Drawing.Point(306, 361);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(150, 35);
            this.btnAbout.TabIndex = 4;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.button4_Click);
            // 
            // mainSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(759, 498);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnBarPath);
            this.Controls.Add(this.btnQrPath);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Generator V1.2";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnQrPath;
        private System.Windows.Forms.Button btnBarPath;
        private System.Windows.Forms.Button btnAbout;
    }
}