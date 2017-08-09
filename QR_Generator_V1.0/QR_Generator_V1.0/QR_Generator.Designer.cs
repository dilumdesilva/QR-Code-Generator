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
        //code by Dilum De Silva
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QR_Generator));
            this.txtQrCode = new System.Windows.Forms.TextBox();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.btnQrGenerate = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBarGenerate = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lblMESSAGE = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQrCode
            // 
            this.txtQrCode.Location = new System.Drawing.Point(114, 354);
            this.txtQrCode.Multiline = true;
            this.txtQrCode.Name = "txtQrCode";
            this.txtQrCode.Size = new System.Drawing.Size(284, 29);
            this.txtQrCode.TabIndex = 1;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(114, 404);
            this.txtBarCode.Multiline = true;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(284, 29);
            this.txtBarCode.TabIndex = 2;
            // 
            // btnQrGenerate
            // 
            this.btnQrGenerate.Location = new System.Drawing.Point(467, 356);
            this.btnQrGenerate.Name = "btnQrGenerate";
            this.btnQrGenerate.Size = new System.Drawing.Size(128, 27);
            this.btnQrGenerate.TabIndex = 4;
            this.btnQrGenerate.Text = "Generate QR";
            this.btnQrGenerate.UseVisualStyleBackColor = true;
            this.btnQrGenerate.Click += new System.EventHandler(this.btnQrGenerate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(223, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnBarGenerate
            // 
            this.btnBarGenerate.Location = new System.Drawing.Point(467, 404);
            this.btnBarGenerate.Name = "btnBarGenerate";
            this.btnBarGenerate.Size = new System.Drawing.Size(128, 27);
            this.btnBarGenerate.TabIndex = 6;
            this.btnBarGenerate.Text = "Generate BAR Code";
            this.btnBarGenerate.UseVisualStyleBackColor = true;
            this.btnBarGenerate.Click += new System.EventHandler(this.btnBarGenerate_Click);
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBox.Location = new System.Drawing.Point(65, 97);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(590, 191);
            this.picBox.TabIndex = 7;
            this.picBox.TabStop = false;
            // 
            // lblMESSAGE
            // 
            this.lblMESSAGE.AutoSize = true;
            this.lblMESSAGE.BackColor = System.Drawing.Color.Transparent;
            this.lblMESSAGE.Font = new System.Drawing.Font("Aachen BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMESSAGE.ForeColor = System.Drawing.Color.Red;
            this.lblMESSAGE.Location = new System.Drawing.Point(111, 326);
            this.lblMESSAGE.Name = "lblMESSAGE";
            this.lblMESSAGE.Size = new System.Drawing.Size(172, 16);
            this.lblMESSAGE.TabIndex = 8;
            this.lblMESSAGE.Text = "Please enter your URL here";
            this.lblMESSAGE.Click += new System.EventHandler(this.lblMESSAGE_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(373, 471);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(77, 24);
            this.btnAbout.TabIndex = 12;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(273, 471);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(73, 24);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
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
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.btnBarGenerate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnQrGenerate);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.txtQrCode);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QR_Generator";
            this.Text = "QR Generator V1.0";
            this.Load += new System.EventHandler(this.QR_Generator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQrCode;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Button btnQrGenerate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBarGenerate;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Label lblMESSAGE;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnReset;
    }
}

