using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sharedLibrary;


namespace QR_Generator_V1._0
{
    public partial class QR_Generator : Form
    {
        public QR_Generator()
        {
            InitializeComponent();
        }

        private void QR_Generator_Load(object sender, EventArgs e)
        {

        }

        private void lblMESSAGE_Click(object sender, EventArgs e)
        {

        }

        private void btnBarGenerate_Click(object sender, EventArgs e)
        {

            try
            {
                Generating_Methods obj = new Generating_Methods();
                string textBarCode = txtBarCode.Text;
                picBoxBAR.Image = obj.generateBarCode(textBarCode);
                //code by Dilum De Silva
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnQrGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                Generating_Methods obj = new Generating_Methods();
                string textQrCode = txtQrCode.Text;
                picBoxQR.Image = obj.generatQrCode(textQrCode);
                //code by Dilum De Silva
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnAbout_Click(object sender, EventArgs e)
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                ResetFeilds();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void ResetFeilds()
        {
            try
            {
                Action<Control.ControlCollection> func = null;

                func = (controls) =>
                {
                    foreach (Control ctrl in controls)
                        if (ctrl is TextBox)
                        {
                            (ctrl as TextBox).Clear();
                        }

                        else if (ctrl is ComboBox)
                        {
                            (ctrl as ComboBox).SelectedValue = -1;
                        }
                        else
                            func(ctrl.Controls);
                };

                func(Controls);
            }
            catch (Exception ex)
            {

                throw ex;
            }
    }

    }
}

//Developer - Dilum De Silva.