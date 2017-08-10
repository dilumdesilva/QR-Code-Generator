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
using System.Drawing.Imaging;
using ClassLibrary1;

namespace QR_Generator_V1._0
{
    public partial class frmQR_Generator : Form
    {
        private string UserSelectedQRPath;
        private string FileName;

        public frmQR_Generator()
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

            //try
            //{
            //    Generating_Methods obj = new Generating_Methods();
            //    string textBarCode = txtBarCode.Text;
            //    picBoxBAR.Image = obj.generateBarCode(textBarCode);
            //    //code by Dilum De Silva
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
            
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
            //try
            //{
            //    frmAbout obj = new frmAbout();
            //    obj.Show();
            //}
            //catch (Exception ex)
            //{

            //    throw ex;
            //}
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

        //this is the method for reset text boxes and other form feilds. code by Dilum
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
                SaveQrCode();
                ResetFeilds();
                picBoxQR.Image = null;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }


        //This method will get name and path of the file
        private void SaveQrCode()
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
                UserSelectedQRPath = FBD.SelectedPath;
            }

            else
            {
                MessageBox.Show("Please set a file directory to save");
            }

            if (FileName != string.Empty && UserSelectedQRPath != string.Empty)
            {

                if (picBoxQR.Image != null)
                {
                    //this set the width and the height of the generated qr image  
                    using (var bmp = new Bitmap(picBoxQR.Image.Width, picBoxQR.Image.Height))
                    {
                        string path = UserSelectedQRPath;

                        picBoxQR.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));

                        path = System.IO.Path.Combine(path, FileName + ".png");
                        bmp.Save(path);
                        bmp.Dispose();

                        MessageBox.Show("Your QR code has been saved");
                    }
                }

            }
            

            
            
        }
    }
}

//Developer - Dilum De Silva.