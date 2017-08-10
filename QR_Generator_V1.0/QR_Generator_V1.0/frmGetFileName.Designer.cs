namespace QR_Generator_V1._0
{
    partial class frmGetFileName
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
            this.txtGetFileName = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnGetFileName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtGetFileName
            // 
            this.txtGetFileName.Location = new System.Drawing.Point(56, 47);
            this.txtGetFileName.Name = "txtGetFileName";
            this.txtGetFileName.Size = new System.Drawing.Size(222, 20);
            this.txtGetFileName.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(56, 21);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(122, 13);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.Text = "Please enter a file Name";
            // 
            // btnGetFileName
            // 
            this.btnGetFileName.Location = new System.Drawing.Point(125, 92);
            this.btnGetFileName.Name = "btnGetFileName";
            this.btnGetFileName.Size = new System.Drawing.Size(75, 23);
            this.btnGetFileName.TabIndex = 2;
            this.btnGetFileName.Text = "Save";
            this.btnGetFileName.UseVisualStyleBackColor = true;
            this.btnGetFileName.Click += new System.EventHandler(this.btnGetFileName_Click);
            // 
            // frmGetFileName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 136);
            this.Controls.Add(this.btnGetFileName);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtGetFileName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGetFileName";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.frmGetFileName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGetFileName;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnGetFileName;
    }
}