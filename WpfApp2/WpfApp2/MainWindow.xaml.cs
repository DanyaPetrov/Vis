using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class WPF_Custom_Control:Control
    {

    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
      Button buttonExit = new Button();
       Random random = new Random();
        private void button_prim_Click(object sender, RoutedEventArgs e)
        {
            buttonExit.Height = 50;
            buttonExit.Width = 100;
            int x1 = 500;
            int y1 = 100;
            int x = random.Next(0, x1);
            int y = random.Next(0, y1);

            Canvas.SetLeft(buttonExit, x);
            Canvas.SetTop(buttonExit, y);
        }
    }
}
