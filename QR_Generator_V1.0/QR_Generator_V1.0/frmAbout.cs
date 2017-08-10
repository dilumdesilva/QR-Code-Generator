using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Generator_V1._0
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            //Developed by Dilum De Silva
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dResult = new DialogResult();
            dResult = MessageBox.Show("Connecting to the server..." + Environment.NewLine +Environment.NewLine + "Click OK to get updates", "Connecting to the server", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dResult == DialogResult.OK)
            {
                //if user clicks ok for update this will redirect and download the lateset version in my git branch
                dResult = MessageBox.Show("Fetching updates.." + Environment.NewLine + "Updates has found !" + Environment.NewLine + Environment.NewLine + "Do you want to download the latest update?", "Update manager", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dResult == DialogResult.Yes)
                {
                    //this will open the defult browser with following links
                    Process.Start("https://drive.google.com/open?id=0B31SNK7utOq0OWJiX0pVMC1VWWs");
                    Process.Start("https://github.com/dilum1995");

                    MessageBox.Show("Please download setup files of the latest version " + Environment.NewLine + Environment.NewLine + "Thank you!" + Environment.NewLine, "Update manager", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                return;
            }

            //Code by Dilum De Silva
        }
    }
}
