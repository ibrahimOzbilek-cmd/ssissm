using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
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

namespace WpfApp8
{
    /// <summary>
    /// INPUT_OUTPUT.xaml etkileşim mantığı
    /// </summary>
    public partial class INPUT_OUTPUT : Page
    {

        public double old = 0.0;

        public void ioMethod()
        {
            while (true)
            {
                double newTime = DateTime.Now.Ticks;
                while (newTime >= old + 99999)
                {
                    old = newTime;

                }
            }
        }
        public INPUT_OUTPUT()
        {
            InitializeComponent();
            Image im = new Image();
            im.PreviewMouseDown += Im_PreviewMouseDown;
            for (int girisler = 0; girisler < 62; girisler++)
            {
                im.Name = "X0."+girisler.ToString();
                im.Width = 12;
                im.Height = 12;
            }
            

            Thread i_o = new Thread(ioMethod);
        }

        private void Im_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            
        }
    }
}
