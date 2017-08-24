//bibaoke.com

using System.Text;
using System;

namespace NChardet
{
    public static class ByteExtensions
    {
        /// <summary>
        /// 根据自动检测到的编码获取字符串
        /// </summary>
        /// <param name="byteArray"></param>
        /// <returns></returns>
        /// <exception cref="NullReferenceException">字节数组不能为 null</exception>
        /// <exception cref="ArgumentException">不支持的编码</exception>
        /// <exception cref="DecoderFallbackException">
        /// 发生回退（请参见了解编码以获得完整的解释） 
        /// - 并且 - 
        /// System.Text.Encoding.DecoderFallback 被设置为 System.Text.DecoderExceptionFallback
        /// </exception>
        public static string GetString(this byte[] byteArray)
        {
            return byteArray.GetEncoding().GetString(byteArray);
        }

        /// <summary>
        /// 自动检测编码
        /// </summary>
        /// <param name="byteArray"></param>
        /// <returns></returns>
        /// <exception cref="NullReferenceException">字节数组不能为 null</exception>
        /// <exception cref="ArgumentException">不支持的编码</exception>
        public static Encoding GetEncoding(this byte[] byteArray)
        {
            MyCharsetDetectionObserver cdo = new MyCharsetDetectionObserver();

            Detector detector = new Detector();

            detector.Init(cdo);

            detector.DoIt(byteArray, byteArray.Length, false);

            detector.Done();

            if (cdo.Charset == null)
            {
                throw new DetectingException();
            }

            return Encoding.GetEncoding(cdo.Charset);
        }
    }
}
