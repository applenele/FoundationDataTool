/**********************************************
*说明:
*计算机名称：LENNY
*创建日期：2016/8/20 15:41:48
*作者：乐
*电子邮箱：1941973283@qq.com
/**********************************************/

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThoughtWorks.QRCode.Codec;
using ThoughtWorks.QRCode.Codec.Data;

namespace FoundationDataTool.Helper
{
    public class QRCodeHelper
    {
        /// <summary>  
        /// 获取二维码  
        /// </summary>  
        /// <param name="strContent">待编码的字符</param>  
        /// <param name="ms">输出流</param>  
        ///<returns>True if the encoding succeeded, false if the content is empty or too large to fit in a QR code</returns>  
        public static Image GetQRCode(string enCodeString)
        {
            QRCodeEncoder codeEncoder = new QRCodeEncoder();//创建一个编码器
            Image image = codeEncoder.Encode(enCodeString, Encoding.UTF8);//对字符串进行编码，返回

            return image;
        }

        /// <summary>
        /// 识别二维码
        /// </summary>
        /// <param name="image"></param>
        /// <returns></returns>
        public static string RecognizeQrCode(Image image)
        {
            QRCodeDecoder qrDecoder = new QRCodeDecoder();//创建一个解码器
            string msg = qrDecoder.decode(new QRCodeBitmapImage(new Bitmap(image)));

            return msg;
        }
    }
}
