using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sharedLibrary
{
    public class Generating_Methods
    {
        //code by Dilum De Silva
        public System.Drawing.Image generateBarCode(string textBarCode)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            return barcode.Draw(textBarCode, 50);
        }

        //this method will receive text input from the user as a string input
        //and it will pass to ZenBarcode CodeQrBarcodeDraw class to generate the  QR code
        //then method will return an image after BarcodeDrawFactory has drawn the image
        public Image generatQrCode(string textQrCode)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            return qrcode.Draw(textQrCode, 50); 
        }
    }
}
