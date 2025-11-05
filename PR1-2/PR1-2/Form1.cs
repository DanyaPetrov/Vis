using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PR1_2
{
    public partial class Form1 : Form
    {
        public Button light = new Button();
        public Button air = new Button();
        public Button temp = new Button();
        public Button img = new Button();
        public Button eng1 = new Button();
        public Button eng2 = new Button();
        public Button eng3 = new Button();
        public GroupBox gr1 = new GroupBox();
        public GroupBox gr2 = new GroupBox();
        public GroupBox gr3 = new GroupBox();

        public Button clad = new Button();
        public Button spal1 = new Button();
        public Button ubor = new Button();
        public Button kitch = new Button(); 
        public Button ubor2 = new Button();
        public Button gost = new Button();


        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(555, 255);
           light.Text = "Свет";
            light.Size = new Size(101, 75);
            light.Location = new Point(0, 0);
            this.Controls.Add(light);
           air.Text = "Воздух";
          air.Size = new Size(101, 75);
          air.Location = new Point(0, 70);
            this.Controls.Add(air);
            temp.Text = "Температура";
            temp.Size = new Size(101, 75);
           temp.Location = new Point(0, 140);
            this.Controls.Add(temp);

           img.Text = "Тут должно быть фото";
           img.Size = new Size(327, 145);
           img.Location = new Point(100, 0);
            this.Controls.Add(img);

            eng1.Text = "Расход энергии на первом этаже";
           eng1.Size = new Size(111, 75);
            eng1.Location = new Point(100, 140);
            this.Controls.Add(eng1);

            eng2.Text = "Расход энергии на втором этаже";
            eng2.Size = new Size(111, 75);
            eng2.Location = new Point(210, 140);
            this.Controls.Add(eng2);

            eng3.Text = "Расход энергии на третьем этаже";
            eng3.Size = new Size(111, 75);
            eng3.Location = new Point(315, 140);
            this.Controls.Add(eng3);

            clad.Text = "Кладовая";
            clad.Size = new Size(106, 39);
            clad.Location = new Point(0, 20);
            gr1.Controls.Add(clad);

            gr1.Text = "Третий этаж";
            gr1.Size = new Size(106, 59);
            gr1.Location = new Point(428, 0);
            this.Controls.Add(gr1);


           spal1.Text = "Спальня";
            spal1.Size = new Size(106, 23);
            spal1.Location = new Point(0, 10);
            gr2.Controls.Add(spal1);

            ubor.Text = "Уборная";
            ubor.Size = new Size(106, 23);
            ubor.Location = new Point(0, 32);
            gr2.Controls.Add(ubor);
            gr2.Text = "Второй этаж";
            gr2.Size = new Size(106, 59);
            gr2.Location = new Point(428, 58);
            this.Controls.Add(gr2);

            ubor2.Text = "Уборная";
            ubor2.Size = new Size(106, 23);
            ubor2.Location = new Point(0, 65);
            gr3.Controls.Add(ubor2);
            kitch.Text = "Кухня";
            kitch.Size = new Size(106, 23);
            kitch.Location = new Point(0,20);
            gr3.Controls.Add(kitch);
           gost.Text = "Кухня";
            gost.Size = new Size(106, 23);
            gost.Location = new Point(0, 43);
            gr3.Controls.Add(gost);
            gr3.Text = "Первый этаж";
            gr3.Size = new Size(106, 95);
            gr3.Location = new Point(428, 120);
            this.Controls.Add(gr3);

          


        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
    }
}
