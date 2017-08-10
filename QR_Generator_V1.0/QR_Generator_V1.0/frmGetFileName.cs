
using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_Generator_V1._0
{
    public partial class frmGetFileName : Form
    {
        public frmGetFileName()
        {
            InitializeComponent();
        }

        private void frmGetFileName_Load(object sender, EventArgs e)
        {
           
        }

        private void btnGetFileName_Click(object sender, EventArgs e)
        {
            FileDetails obj = new FileDetails();
            obj.FileName = txtGetFileName.Text;
        }
    }
}
