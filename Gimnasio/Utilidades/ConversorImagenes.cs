using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gimnasio
{
    static class ConversorImagenes
    {
        public static byte[] ConvertirImagenBytes(Image Foto)
        {
            MemoryStream ms = new MemoryStream();
            Foto.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }

        public static Image ConvertirBytesImagen(byte[] Bytes)
        {
            MemoryStream ms = new MemoryStream(Bytes);
            return Image.FromStream(ms);
        }
    }
}
