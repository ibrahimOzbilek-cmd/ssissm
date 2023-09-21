using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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
using System.Windows.Threading;
using Opc.UaFx;
using Opc.UaFx.Client;
using Org.BouncyCastle.Crypto.Tls;
using DevExpress.Xpf.Core;  

namespace WpfApp8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public OpcClient client = new OpcClient("opc.tcp://192.168.1.10:4840/");//opc.tcp://OSISTEK-EFE:48010    //opc.tcp://192.168.0.10:4840/
       
        public MainWindow()
        {
            InitializeComponent();
            //   client.Security.UserIdentity = new OpcClientIdentity("eifel4125", "8445");
            client.Connect();

        }


        public void ss(object sender, RoutedEventArgs e)
        {
            //client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.PLC_PRG.efs", true);
            var pages = new manual();
            pages.Show();
            this.Close();
            //manual_sf mss = new manual_sf();
            //this.Content = mss;
        }

        public void cnt(object sender, EventArgs e)
        {

            //client.Connect();


        }


    }
}
