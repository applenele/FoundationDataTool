using FoundationDataTool.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoundationDataTool.Forms
{
    public partial class QrCodeForm : BaseForm
    {
        public QrCodeForm()
        {
            base.Title = "二维码";
            InitializeComponent();
        }

        private void QrCode_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerateQrCode_Click(object sender, EventArgs e)
        {
            string text = txtInfo.Text;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show(text);
            }
            Image image = QRCodeHelper.GetQRCode(text);
            picQrCode.Image = image;
            picQrCode.Height = image.Height;
            picQrCode.Width = image.Width;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "图片格式|*.*";
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string picpath = openFileDialog1.FileName;
                var ext = Path.GetExtension(picpath);
                string path = Application.StartupPath + "\\UploadImage\\" + DateHelper.GetTimeStamp() + ext;
                File.Copy(openFileDialog1.FileName, path);
                Image image = Image.FromFile(path);
                picQrCode.Image = image;
                picQrCode.Height = image.Height;
                picQrCode.Width = image.Width;
                Recognize(image);
            }
        }

        public void Recognize(Image image)
        {
            var result = QRCodeHelper.RecognizeQrCode(image);
            txtInfo.Text = result;
        }
    }
}
