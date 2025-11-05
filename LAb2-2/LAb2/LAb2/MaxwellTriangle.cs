using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAb2
{
 class MaxwellTriangle
    {
        private int width;
        public Bitmap Bitmap { get; private set; }
       
        public MaxwellTriangle(int width)
        {
            this.width = width;
        }
        /// <summary>
        /// Построение треугольника. Результат заносится в <see cref="MaxwellTriangle.Bitmap"/>
        /// </summary>
        ImageWrapper wr2;
        public Bitmap Build()
        {
            var dx = 2d / (width - 1);
            var h = width * Math.Sqrt(3) / 2d;
            var dy = 1d / (h - 1);
            Bitmap = new Bitmap(width, (int)h);
            using (var wr = new ImageWrapper(Bitmap))
            {
                wr.DefaultColor = Color.Pink;
                for (int i = 0; i < width; i++)
                    for (int j = 0; j < h; j++)
                    {
                        var x = -1d + i * dx;
                        var y = j * dy;
                        //Значения цветов нормированы
                        //Зелёный
                        var g = y;
                        //Красный
                        var b = (x + 1 - g) / 2d;
                        //Синий
                        var r = 1d - g - b;
                        //Если точка находится внутри треугольника, то заносим её в Bitmap
                        if (r >= 0 && r <= 1d && g >= 0 && g <= 1d && b >= 0 && b <= 1d)
                        {
                            var pt = new Point(i, (int)h - j);
                            //Bitmap.SetPixel(i, j, Color.FromArgb((int)r, (int)g, (int)b));
                            wr.SetPixel(pt, r * 255, g * 255, b * 255);
                        }
                    }
            }
            return Bitmap;
        }
        /*public string[] ColorInf(MaxwellTriangle tr, int x,int y)
        {
            string[] strClr = new string[3];
            Color pixelColor = wr2.GetEnumerator;

            strClr[1] = "Red: " + pixelColor.R.ToString();
            strClr[2] = "Green: " + pixelColor.G.ToString();
            strClr[2] = "Blue: " + pixelColor.B.ToString();
            return strClr;
        }*/
    }
}
