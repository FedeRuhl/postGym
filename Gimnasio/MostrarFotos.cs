using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimnasio
{
    public partial class MostrarFotos : Form
    {
        private Image Imagen;
        public MostrarFotos(byte[] foto)
        {
            InitializeComponent();
            Imagen = ConversorImagenes.ConvertirBytesImagen(foto);
        }

        private void Foto_Load(object sender, EventArgs e)
        {
            int anchoPantalla = Screen.PrimaryScreen.WorkingArea.Size.Width;
            int altoPantalla = Screen.PrimaryScreen.WorkingArea.Size.Height;
            int anchoImagen = Imagen.Width;
            int altoImagen = Imagen.Height;

            if (anchoPantalla < anchoImagen && altoPantalla < altoImagen)
                Imagen = FixedSize(Imagen, anchoPantalla, altoPantalla);
            else if (anchoPantalla < anchoImagen)
                Imagen = FixedSize(Imagen, anchoPantalla, Imagen.Size.Height);
                
            else if (altoPantalla < altoImagen)
                Imagen = FixedSize(Imagen, Imagen.Size.Width, altoPantalla);
            
            this.Size = Imagen.Size;
            this.MaximumSize = Imagen.Size;
            pictureBox.Image = Imagen;
            this.Location = new Point(0, 0);
        }

        private static Image FixedSize(Image imgPhoto, int Width, int Height)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            int sourceX = 0;
            int sourceY = 0;
            int destX = 0;
            int destY = 0;

            float nPercentW = Width / (float)sourceWidth;
            float nPercentH = Height / (float)sourceHeight;
            float nPercent;

            if (nPercentH < nPercentW)
            {
                nPercent = nPercentH;
                destX = System.Convert.ToInt16((Width -
                              (sourceWidth * nPercent)) / 2);
            }
            else
            {
                nPercent = nPercentW;
                destY = System.Convert.ToInt16((Height -
                              (sourceHeight * nPercent)) / 2);
            }

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(Width, Height,
                              PixelFormat.Format24bppRgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution,
                             imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.Black);
            grPhoto.InterpolationMode =
                    InterpolationMode.HighQualityBicubic;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(destX, destY, destWidth, destHeight),
                new Rectangle(sourceX, sourceY, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }
    }
}
