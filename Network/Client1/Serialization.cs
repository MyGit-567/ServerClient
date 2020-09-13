/*
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Client1
{
    public class Serialization
    {
        public string ImageToString(string path)
        {
            if (path == null)

                throw new ArgumentNullException("@SendFile/?path=:");

            Image im = Image.FromFile(path);

            MemoryStream ms = new MemoryStream();

            im.Save(ms, im.RawFormat);

            byte[] array = ms.ToArray();

            return Convert.ToBase64String(array);

        }

        public Image StringToImage(string imageString)
        {

            if (imageString == null)

                throw new ArgumentNullException("imageString");

            byte[] array = Convert.FromBase64String(imageString);

            Image image = Image.FromStream(new MemoryStream(array));

            return image;
        }
    }
}
*/