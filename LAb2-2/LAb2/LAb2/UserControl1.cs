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
using System.Drawing.Drawing2D;
using Aspose.Slides;

namespace LAb2
{
    public partial class UserControl1 : UserControl
    {
    
        public UserControl1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
        
        }
        private MaxwellTriangle triangle;
       public  string[] Inf()
        {
            //Пересоздаём треугольник при изменении размера.
            string[] color = new string[3];
            color[0] = labelRed.Text;
            color[1]=labelGreen.Text;
            color[2] =labelBlue.Text;

            return color;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            //Пересоздаём треугольник при изменении размера.
            triangle = new MaxwellTriangle((int)(Math.Min(pictureBox1.Width, pictureBox1.Height) * 0.95));
            pictureBox1.Image =  triangle.Build();
                
               
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
               
            Color pixelColor = ((Bitmap)pictureBox1.Image).GetPixel(e.X,e.Y);
            
            labelRed.Text = "Red: " + pixelColor.R.ToString();
            labelGreen.Text = "Green: " + pixelColor.G.ToString();
            labelBlue.Text = "Blue: " + pixelColor.B.ToString();
        }

        }
    } 

