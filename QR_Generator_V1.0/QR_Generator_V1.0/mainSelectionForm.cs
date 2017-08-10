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
    public partial class mainSelectionForm : Form
    {
        public mainSelectionForm()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                frmAbout obj = new frmAbout();
                obj.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //bar generating form will load with the btn click
        private void btnBarPath_Click(object sender, EventArgs e)
        {
            try
            {
                frmBAR_Generator obj = new frmBAR_Generator();
                obj.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //qr generating form will load with the btn click
        private void btnQrPath_Click(object sender, EventArgs e)
        {
            try
            {
                frmQR_Generator obj = new frmQR_Generator();
                obj.Show();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
