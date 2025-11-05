using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Configuration;
using System.Security.Cryptography;

namespace LAb2
{
    public partial class UserControl1: UserControl
    {
        List<Point> points = new List<Point>();
        Point startPoint = new Point();

        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            Bitmap bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            Graphics g = Graphics.FromImage(bitmap);
            /* Pen n = new Pen(Color.Black);
             float[] x = { 10, pictureBox.Width/2, pictureBox.Width-10 };
             float[] y = { 200f, 0, 200f };

             PointF[] p = new PointF[x.Length];

             for (int i = 0; i < x.Length; i++)
                 p[i] = new PointF(x[i], y[i]);

             g.DrawPolygon(n,p);
            */
            Draw(500);
           /*foreach (var point in points)
            {
                bitmap.SetPixel(point.X, point.Y, point.Color);
            }*/
           


           /* for (int i = 0; i < x.Length; i++)
            {
                brush = new SolidBrush(points[i].Color);
                g.FillPolygon(brush, new PointF[] { p[i], p[(i + 1) % p.Length], p[(i + 2) % p.Length] });
            }*/
            pictureBox.Image = bitmap;
        }
        public void Draw(int width)
        {
            int hight = (int)((width / 2) * Math.Sqrt(3));
            double xright = width;
            double xleft = 0;

            for (int i = hight; i > 0; i--)
            {
                for (int j = (int)xleft; j < xright; j++)
                {
                    points.Add(new Point(j, i, startPoint.ColorPoint(j, i, hight, xleft, xright)));
                }

                double temp = (i * 2) / Math.Sqrt(3.0);
                double tmp = width - temp;

                xright = width - (tmp / 2);
                xleft = tmp / 2;
            }
        }
        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
    internal class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }

        public Point() { }

        public Point(int x, int y, Color color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public Color ColorPoint(int x, int y, int height, double xleft, double xright)
        {

            double green = height - y;
            double red = (x - xleft) * Math.Sqrt(3.0) / 2;
            double blue = (xright - x) * Math.Sqrt(3.0) / 2;

            double R = 255.0 / height;
            double G = 255.0 / height;
            double B = 255.0 / height;

            return Color.FromArgb((int)(R * red), (int)(G * green), (int)(B * blue));
        }
    }
}


 