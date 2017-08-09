namespace QR_Generator_V1._0
{
    partial class QR_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QR_Generator));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnQrGenerate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBarGenerate = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.lblMESSAGE = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(117, 364);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 29);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(117, 414);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(284, 29);
            this.textBox2.TabIndex = 2;
            // 
            // btnQrGenerate
            // 
            this.btnQrGenerate.Location = new System.Drawing.Point(470, 366);
            this.btnQrGenerate.Name = "btnQrGenerate";
            this.btnQrGenerate.Size = new System.Drawing.Size(128, 27);
            this.btnQrGenerate.TabIndex = 4;
            this.btnQrGenerate.Text = "Generate QR";
            this.btnQrGenerate.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnBarGenerate
            // 
            this.btnBarGenerate.Location = new System.Drawing.Point(470, 414);
            this.btnBarGenerate.Name = "btnBarGenerate";
            this.btnBarGenerate.Size = new System.Drawing.Size(128, 27);
            this.btnBarGenerate.TabIndex = 6;
            this.btnBarGenerate.Text = "Generate BAR Code";
            this.btnBarGenerate.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox.Location = new System.Drawing.Point(68, 107);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(590, 197);
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // lblMESSAGE
            // 
            this.lblMESSAGE.AutoSize = true;
            this.lblMESSAGE.BackColor = System.Drawing.Color.Transparent;
            this.lblMESSAGE.Font = new System.Drawing.Font("Aachen BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMESSAGE.ForeColor = System.Drawing.Color.Red;
            this.lblMESSAGE.Location = new System.Drawing.Point(114, 336);
            this.lblMESSAGE.Name = "lblMESSAGE";
            this.lblMESSAGE.Size = new System.Drawing.Size(172, 16);
            this.lblMESSAGE.TabIndex = 8;
            this.lblMESSAGE.Text = "Please enter your URL here";
            this.lblMESSAGE.Click += new System.EventHandler(this.lblMESSAGE_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(381, 475);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(90, 27);
            this.btnAbout.TabIndex = 12;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(271, 475);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(86, 27);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // QR_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(721, 523);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblMESSAGE);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.btnBarGenerate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQrGenerate);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QR_Generator";
            this.Text = "QR Generator V1.0";
            this.Load += new System.EventHandler(this.QR_Generator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnQrGenerate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBarGenerate;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label lblMESSAGE;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnReset;
    }
}

