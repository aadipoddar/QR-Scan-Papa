using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace QR_Retrieve
{
    public partial class QR_Generate : Form
    {
        public QR_Generate()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            string textToBeConverted = textBoxConvert.Text;
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap bitmap = encoder.Encode(textToBeConverted);
            pictureBoxQRCode.Image = bitmap;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "Generated Image";
            saveFileDialog.Filter = "BMP Image Only(*.bmp)|*.bmp";
            saveFileDialog.AddExtension = true;

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    pictureBoxQRCode.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void textBoxConvert_TextChanged(object sender, EventArgs e)
        {
            btnConvert_Click(sender, e);
        }

        private void textBoxConvert_TextChanged_1(object sender, EventArgs e)
        {
            btnConvert_Click(sender, e);
        }
    }
}
