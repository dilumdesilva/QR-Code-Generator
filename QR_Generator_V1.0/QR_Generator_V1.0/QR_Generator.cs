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
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            picBox.Image = barcode.Draw(txtBarCode.Text, 50);

        }

        private void btnQrGenerate_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            picBox.Image = qrcode.Draw(txtQrCode.Text, 50); 
        }
    }
}
