using Less.Windows;
using System;
using System.Text;
using Less.Text;
using NChardet;

namespace MyTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string html = Application.SetupDir.CombinePath("bolishijing.com.html").ReadString(Encoding.UTF8);

            byte[] data1 = html.ToByteArray(Encoding.UTF8);

            byte[] data2 = html.ToByteArray(MyEncoding.GB2312);

            Console.WriteLine(data1.Detect());

            Console.WriteLine(data2.Detect());

            Console.ReadLine();
        }
    }
}
