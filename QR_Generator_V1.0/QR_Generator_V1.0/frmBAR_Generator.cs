using sharedLibrary;
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
    public partial class frmBAR_Generator : Form
    {
        public frmBAR_Generator()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
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
