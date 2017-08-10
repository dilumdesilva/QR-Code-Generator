namespace QR_Generator_V1._0
{
    partial class frmBAR_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBAR_Generator));
            this.picBoxlogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxBAR = new System.Windows.Forms.PictureBox();
            this.btnBarGenerate = new System.Windows.Forms.Button();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDownload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBAR)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxlogo
            // 
            this.picBoxlogo.BackColor = System.Drawing.Color.Transparent;
            this.picBoxlogo.Image = ((System.Drawing.Image)(resources.GetObject("picBoxlogo.Image")));
            this.picBoxlogo.Location = new System.Drawing.Point(178, 37);
            this.picBoxlogo.Name = "picBoxlogo";
            this.picBoxlogo.Size = new System.Drawing.Size(328, 52);
            this.picBoxlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxlogo.TabIndex = 0;
            this.picBoxlogo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Aachen BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(361, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Please enter your URL here";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // picBoxBAR
            // 
            this.picBoxBAR.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.picBoxBAR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxBAR.Location = new System.Drawing.Point(45, 153);
            this.picBoxBAR.Name = "picBoxBAR";
            this.picBoxBAR.Size = new System.Drawing.Size(281, 191);
            this.picBoxBAR.TabIndex = 17;
            this.picBoxBAR.TabStop = false;
            // 
            // btnBarGenerate
            // 
            this.btnBarGenerate.Location = new System.Drawing.Point(363, 275);
            this.btnBarGenerate.Name = "btnBarGenerate";
            this.btnBarGenerate.Size = new System.Drawing.Size(128, 27);
            this.btnBarGenerate.TabIndex = 16;
            this.btnBarGenerate.Text = "Generate BAR Code";
            this.btnBarGenerate.UseVisualStyleBackColor = true;
            this.btnBarGenerate.Click += new System.EventHandler(this.btnBarGenerate_Click);
            // 
            // txtBarCode
            // 
            this.txtBarCode.Location = new System.Drawing.Point(363, 181);
            this.txtBarCode.Multiline = true;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(281, 55);
            this.txtBarCode.TabIndex = 15;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(363, 317);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 27);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(45, 376);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(100, 27);
            this.btnDownload.TabIndex = 21;
            this.btnDownload.Text = "Download BAR";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // frmBAR_Generator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(689, 443);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxBAR);
            this.Controls.Add(this.btnBarGenerate);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.picBoxlogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBAR_Generator";
            this.Text = "BAR Generator";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxlogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBoxBAR;
        private System.Windows.Forms.Button btnBarGenerate;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDownload;
    }
}