/*
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Client1
{
    class Program
    {
        private static byte[] GetBytes(Bitmap image)
        {
            using (var output = new MemoryStream())
            {
                image.Save(output, ImageFormat.Bmp);

                return output.ToArray();
            };
        }

        private static Bitmap GetImage(byte[] data)
        {
            //Do not dispose of the stream!!
            return new Bitmap(new MemoryStream(data));
        }
        static void Main(string[] args)
        {
            Bitmap bitmap = new Bitmap(@"D:\test.png");
            var b1 = GetBytes(bitmap);
            var m = GetImage(b1);
            var b2 = GetBytes(m);
            var v = b1.SequenceEqual(b2);
            if (v)
            {
                Console.WriteLine("success");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadLine();

        }
    }
}
*/