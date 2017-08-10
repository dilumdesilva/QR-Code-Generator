using ClassLibrary1;
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
        private string UserSelectedBARPath;
        private string FileName;

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

        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                SaveBarCode();
                ResetFeilds();
                picBoxBAR.Image = null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        //This method will get name and path of the file
        private void SaveBarCode()
        {
            frmGetFileName objGetFileNameForm = new frmGetFileName();
            objGetFileNameForm.ShowDialog();



            FileDetails objFileDetails = new FileDetails();
            if (objGetFileNameForm.obj.FileName != string.Empty)
            {
                FileName = objGetFileNameForm.obj.FileName;
            }
            else
            {
                MessageBox.Show("Please enter a file name before save");
            }

            FolderBrowserDialog FBD = new FolderBrowserDialog();
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                objFileDetails.FilePath = FBD.SelectedPath;
                UserSelectedBARPath = FBD.SelectedPath;
            }

            else
            {
                MessageBox.Show("Please set a file directory to save");
            }

            if (FileName != string.Empty && UserSelectedBARPath != string.Empty)
            {

                if (picBoxBAR.Image != null)
                {
                    //this set the width and the height of the generated qr image  
                    using (var bmp = new Bitmap(picBoxBAR.Image.Width, picBoxBAR.Image.Height))
                    {
                        string path = UserSelectedBARPath;

                        picBoxBAR.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

                        path = System.IO.Path.Combine(path, FileName + ".png");
                        bmp.Save(path);
                        bmp.Dispose();

                        MessageBox.Show("Your BAR code has been saved");
                    }
                }

            }
        }
    }
}
