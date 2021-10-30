using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

using Microsoft.WindowsAPICodePack.Dialogs;

namespace QR_Retrieve
{
    public partial class QR_Scan : Form
    {
        public QR_Scan()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                textBoxOpenFile.Text = ofd.FileName;
                pictureBoxQRToConvert.Image = Image.FromFile(textBoxOpenFile.Text);
            }

            btnDecode_Click(sender, e);
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            QRCodeDecoder qRCodeDecoder = new QRCodeDecoder();
            textBoxQRConvertedText.Text = qRCodeDecoder.Decode(new QRCodeBitmapImage(pictureBoxQRToConvert.Image as Bitmap));
        }

        private void QR_Scan_Load(object sender, EventArgs e)
        {
            btnOpen_Click(sender, e);
        }

        private void btnSaveTextConverted_Click(object sender, EventArgs e)
        {
            ChoosePath();
        }

        void ChoosePath()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.FileName = "Ouput From QR";
            saveFileDialog.Filter = "TXT Only(*.txt)|*.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, textBoxQRConvertedText.Text);
            }

            else
            {
                File.WriteAllText("D:", textBoxQRConvertedText.Text);
            }
        }
    }
}
