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
            this.picBoxQR = new System.Windows.Forms.PictureBox();
            this.lblMESSAGE = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.picBoxBAR = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBAR)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQrCode
            // 
            this.txtQrCode.Location = new System.Drawing.Point(65, 354);
            this.txtQrCode.Multiline = true;
            this.txtQrCode.Name = "txtQrCode";
            this.txtQrCode.Size = new System.Drawing.Size(281, 29);
            this.txtQrCode.TabIndex = 1;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(395, 354);
            this.txtBarCode.Multiline = true;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(281, 29);
            this.txtBarCode.TabIndex = 2;
            // 
            // btnQrGenerate
            // 
            this.btnQrGenerate.Location = new System.Drawing.Point(136, 404);
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
            this.pictureBox1.Location = new System.Drawing.Point(229, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(274, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnBarGenerate
            // 
            this.btnBarGenerate.Location = new System.Drawing.Point(478, 404);
            this.btnBarGenerate.Name = "btnBarGenerate";
            this.btnBarGenerate.Size = new System.Drawing.Size(128, 27);
            this.btnBarGenerate.TabIndex = 6;
            this.btnBarGenerate.Text = "Generate BAR Code";
            this.btnBarGenerate.UseVisualStyleBackColor = true;
            this.btnBarGenerate.Click += new System.EventHandler(this.btnBarGenerate_Click);
            // 
            // picBoxQR
            // 
            this.picBoxQR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picBoxQR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxQR.Location = new System.Drawing.Point(65, 97);
            this.picBoxQR.Name = "picBoxQR";
            this.picBoxQR.Size = new System.Drawing.Size(281, 191);
            this.picBoxQR.TabIndex = 7;
            this.picBoxQR.TabStop = false;
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
            this.btnAbout.Location = new System.Drawing.Point(324, 490);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(91, 24);
            this.btnAbout.TabIndex = 12;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(324, 450);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 24);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // picBoxBAR
            // 
            this.picBoxBAR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picBoxBAR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxBAR.Location = new System.Drawing.Point(395, 97);
            this.picBoxBAR.Name = "picBoxBAR";
            this.picBoxBAR.Size = new System.Drawing.Size(281, 191);
            this.picBoxBAR.TabIndex = 13;
            this.picBoxBAR.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Aachen BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(459, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Please enter your URL here";
            // 
            // QR_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(721, 526);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxBAR);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblMESSAGE);
            this.Controls.Add(this.picBoxQR);
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
            ((System.ComponentModel.ISupportInitialize)(this.picBoxQR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQrCode;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Button btnQrGenerate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnBarGenerate;
        private System.Windows.Forms.PictureBox picBoxQR;
        private System.Windows.Forms.Label lblMESSAGE;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox picBoxBAR;
        private System.Windows.Forms.Label label1;
    }
}

