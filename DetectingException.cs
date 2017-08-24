using System;

namespace NChardet
{
    public class DetectingException : Exception
    {
        public DetectingException() : base("检测不到编码")
        {
            //
        }
    }
}
