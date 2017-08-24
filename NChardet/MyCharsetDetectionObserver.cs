//bibaoke.com

namespace NChardet
{
    internal class MyCharsetDetectionObserver : ICharsetDetectionObserver
    {
        internal string Charset = null;

        public void Notify(string charset)
        {
            Charset = charset;
        }
    }
}
