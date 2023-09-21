using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;
using System.Diagnostics;
using System.IO;
using System.Windows.Navigation;
using System.ComponentModel;
using Opc.UaFx.Client;
using System.Threading;
using WpfApp8;
using DevExpress.Mvvm.Native;
using DevExpress.XtraPrinting.Native;
using DevExpress.SpreadsheetSource.Csv;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;

namespace WpfApp8
{
    /// <summary>
    /// Window1.xaml etkileşim mantığı
    /// </summary>
    public partial class manual : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        // numpad nmp = new numpad();

        public MainWindow ns = new MainWindow();


        public manual()
        {
            InitializeComponent();
            reset_grids();

            mnal.Visibility = Visibility.Visible;
            //keyboard
            Thread thmain = new Thread(mnthread);
            thmain.IsBackground = true;
            thmain.Start();
            acilis();
            MessageBox.Show(Properties.Settings.Default.Xeksen_nominator.ToString());
            cabbar.Text = Properties.Settings.Default.Xeksen_nominator.ToString();


        }
        #region OPC-UA-CONNECT
        private double old = 0;
        public void mnthread()
        {
            //  ns.client.Connect();
            while (true)
            {
                double newtime = DateTime.Now.Ticks;
                while (newtime >= old + 9999)
                {
                    old = newtime;
                    try
                    {
                        //  var lbx = ns.client.ReadNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.variable_change.xpsend");
                        // lb_x_real.Content = lbx.ToString();
                        // System.Diagnostics.Debug.WriteLine(sifirlama_id);
                        if (flsts)
                        {


                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("AZ");
                    }
                }
            }
        }
        #endregion
        #region onstartup
        private void acilis()
        {

            //            Properties.Settings.Default.x_realvalue      opc den gelecek
            lb_x_real.Content = Properties.Settings.Default.x_realvalue.ToString();
            lb_y_real.Content = Properties.Settings.Default.y_realvalue.ToString();
            lb_z_real.Content = Properties.Settings.Default.z_realvalue.ToString();

            lb_bx_real.Content = Properties.Settings.Default.cx_realvalue.ToString();
            lb_by_real.Content = Properties.Settings.Default.cy_realvalue.ToString();
            lb_bz_real.Content = Properties.Settings.Default.cz_realvalue.ToString();

            lb_e9_real.Content = Properties.Settings.Default.e9_realvalue.ToString();

            lb_tr_real.Content = Properties.Settings.Default.tr_realvalue.ToString();
            lb_tz_real.Content = Properties.Settings.Default.tz_realvalue.ToString();

            #region ayarlardegiskeni
            tb_x_enc.Text = Properties.Settings.Default.x_enc.ToString();
            tb_x_kalkis.Text = Properties.Settings.Default.x_kalkis.ToString();
            tb_x_durus.Text = Properties.Settings.Default.x_durus.ToString();
            tb_x_gohome.Text = Properties.Settings.Default.x_go_home.ToString();
            tb_x_backhome.Text = Properties.Settings.Default.x_back_home.ToString();
            tb_x_workspd.Text = Properties.Settings.Default.x_workspeed.ToString();
            tb_x_manspd.Text = Properties.Settings.Default.x_man_speed.ToString();
            tb_x_axislimit.Text = Properties.Settings.Default.x_axis_limit.ToString();
            tb_x_ofset.Text = Properties.Settings.Default.x_ofsett.ToString();

            tb_y_enc.Text = Properties.Settings.Default.y_enc.ToString();
            tb_y_kalkis.Text = Properties.Settings.Default.y_kalkis.ToString();
            tb_y_durus.Text = Properties.Settings.Default.y_durus.ToString();
            tb_y_gohome.Text = Properties.Settings.Default.y_go_home.ToString();
            tb_y_backhome.Text = Properties.Settings.Default.y_back_home.ToString();
            tb_y_workspd.Text = Properties.Settings.Default.y_workspeed.ToString();
            tb_y_manspd.Text = Properties.Settings.Default.y_man_speed.ToString();
            tb_y_axislimit.Text = Properties.Settings.Default.y_axis_limit.ToString();
            tb_y_ofset.Text = Properties.Settings.Default.y_ofsett.ToString();

            tb_z_enc.Text = Properties.Settings.Default.z_enc.ToString();
            tb_z_kalkis.Text = Properties.Settings.Default.z_kalkis.ToString();
            tb_z_durus.Text = Properties.Settings.Default.z_durus.ToString();
            tb_z_gohome.Text = Properties.Settings.Default.z_go_home.ToString();
            tb_z_backhome.Text = Properties.Settings.Default.z_back_home.ToString();
            tb_z_workspd.Text = Properties.Settings.Default.z_workspeed.ToString();
            tb_z_manspd.Text = Properties.Settings.Default.z_man_speed.ToString();
            tb_z_axislimit.Text = Properties.Settings.Default.z_axis_limit.ToString();
            tb_z_ofset.Text = Properties.Settings.Default.z_ofsett.ToString();

            tb_e4_enc.Text = Properties.Settings.Default.e4_enc.ToString();
            tb_e4_kalkis.Text = Properties.Settings.Default.e4_kalkis.ToString();
            tb_e4_durus.Text = Properties.Settings.Default.e4_durus.ToString();
            tb_e4_gohome.Text = Properties.Settings.Default.e4_go_home.ToString();
            tb_e4_backhome.Text = Properties.Settings.Default.e4_back_home.ToString();
            tb_e4_workspd.Text = Properties.Settings.Default.e4_workspeed.ToString();
            tb_e4_manspd.Text = Properties.Settings.Default.e4_man_speed.ToString();
            tb_e4_axislimit.Text = Properties.Settings.Default.e4_axis_limit.ToString();
            tb_e4_ofset.Text = Properties.Settings.Default.e4_ofsett.ToString();

            tb_e5_enc.Text = Properties.Settings.Default.e5_enc.ToString();
            tb_e5_kalkis.Text = Properties.Settings.Default.e5_kalkis.ToString();
            tb_e5_durus.Text = Properties.Settings.Default.e5_durus.ToString();
            tb_e5_gohome.Text = Properties.Settings.Default.e5_go_home.ToString();
            tb_e5_backhome.Text = Properties.Settings.Default.e5_back_home.ToString();
            tb_e5_workspd.Text = Properties.Settings.Default.e5_workspeed.ToString();
            tb_e5_manspd.Text = Properties.Settings.Default.e5_man_speed.ToString();
            tb_e5_axislimit.Text = Properties.Settings.Default.e5_axis_limit.ToString();
            tb_e5_ofset.Text = Properties.Settings.Default.e5_ofsett.ToString();

            tb_e6_enc.Text = Properties.Settings.Default.e6_enc.ToString();
            tb_e6_kalkis.Text = Properties.Settings.Default.e6_kalkis.ToString();
            tb_e6_durus.Text = Properties.Settings.Default.e6_durus.ToString();
            tb_e6_gohome.Text = Properties.Settings.Default.e6_go_home.ToString();
            tb_e6_backhome.Text = Properties.Settings.Default.e6_back_home.ToString();
            tb_e6_workspd.Text = Properties.Settings.Default.e6_workspeed.ToString();
            tb_e6_manspd.Text = Properties.Settings.Default.e6_man_speed.ToString();
            tb_e6_axislimit.Text = Properties.Settings.Default.e6_axis_limit.ToString();
            tb_e6_ofset.Text = Properties.Settings.Default.e6_ofsett.ToString();

            tb_e7_enc.Text = Properties.Settings.Default.e7_enc.ToString();
            tb_e7_kalkis.Text = Properties.Settings.Default.e7_kalkis.ToString();
            tb_e7_durus.Text = Properties.Settings.Default.e7_durus.ToString();
            tb_e7_gohome.Text = Properties.Settings.Default.e7_go_home.ToString();
            tb_e7_backhome.Text = Properties.Settings.Default.e7_back_home.ToString();
            tb_e7_workspd.Text = Properties.Settings.Default.e7_workspeed.ToString();
            tb_e7_manspd.Text = Properties.Settings.Default.e7_man_speed.ToString();
            tb_e7_axislimit.Text = Properties.Settings.Default.e7_axis_limit.ToString();
            tb_e7_ofset.Text = Properties.Settings.Default.e7_ofsett.ToString();

            tb_e8_enc.Text = Properties.Settings.Default.e8_enc.ToString();
            tb_e8_kalkis.Text = Properties.Settings.Default.e8_kalkis.ToString();
            tb_e8_durus.Text = Properties.Settings.Default.e8_durus.ToString();
            tb_e8_gohome.Text = Properties.Settings.Default.e8_go_home.ToString();
            tb_e8_backhome.Text = Properties.Settings.Default.e8_back_home.ToString();
            tb_e8_workspd.Text = Properties.Settings.Default.e8_workspeed.ToString();
            tb_e8_manspd.Text = Properties.Settings.Default.e8_man_speed.ToString();
            tb_e8_axislimit.Text = Properties.Settings.Default.e8_axis_limit.ToString();
            tb_e8_ofset.Text = Properties.Settings.Default.e8_ofsett.ToString();

            tb_e9_enc.Text = Properties.Settings.Default.e9_enc.ToString();
            tb_e9_kalkis.Text = Properties.Settings.Default.e9_kalkis.ToString();
            tb_e9_durus.Text = Properties.Settings.Default.e9_durus.ToString();
            tb_e9_gohome.Text = Properties.Settings.Default.e9_go_home.ToString();
            tb_e9_backhome.Text = Properties.Settings.Default.e9_back_home.ToString();
            tb_e9_workspd.Text = Properties.Settings.Default.e9_workspeed.ToString();
            tb_e9_manspd.Text = Properties.Settings.Default.e9_man_speed.ToString();
            tb_e9_axislimit.Text = Properties.Settings.Default.e9_axis_limit.ToString();
            tb_e9_ofset.Text = Properties.Settings.Default.e9_ofsett.ToString();
            #endregion
        }
        #endregion

        private void fls(object sender, MouseButtonEventArgs e)
        {
            ns.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.variable_change.x_sa", false);
            ns.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.variable_change.x_so", false);
        }




        private void x_acc(object sender, TextCompositionEventArgs e)
        {
            ns.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.variable_change.x_ac", 50);

        }
        #region grid change
        private void otosf(object sender, RoutedEventArgs e)
        {
            reset_grids();
            oto.Visibility = Visibility.Visible;
        }
        private void reset_grids()
        {
            mnal.Visibility = Visibility.Hidden;
            oto.Visibility = Visibility.Hidden;
            sifirlama.Visibility = Visibility.Hidden;
            ayarlar.Visibility = Visibility.Hidden;
            recete.Visibility = Visibility.Hidden;
            // sifirlama_id = 0;
        }

        private void msftp(object sender, RoutedEventArgs e)
        {
            reset_grids();
            mnal.Visibility = Visibility.Visible;
        }
        private void rctsf(object sender, RoutedEventArgs e)
        {
            reset_grids();
            recete.Visibility = Visibility.Visible;
        }
        private void sfrsf(object sender, RoutedEventArgs e)
        {
            reset_grids();
            sifirlama.Visibility = Visibility.Visible;
            //  sifirlama_id = 1;
        }
        private void ayarsf(object sender, RoutedEventArgs e)
        {
            reset_grids();
            ayarlar.Visibility = Visibility.Visible;
        }
        #endregion

        #region jog hareketler
        //x
        private void jog_x_sol(object sender, RoutedEventArgs e)
        {
            ns.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.GVL_manual.e1_sol", true);
        }

        private void jog_x_sag(object sender, RoutedEventArgs e)
        {
            ns.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.GVL_manual.e1_sag", true);

        }

        //y
        private void jog_y_sol(object sender, RoutedEventArgs e)
        {
            ns.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.GVL_manual.e2_sol", true);
        }

        private void jog_y_sag(object sender, RoutedEventArgs e)
        {
            ns.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.GVL_manual.e2_sag", true);

        }

        //z
        private void jog_z_sol(object sender, RoutedEventArgs e)
        {
            ns.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.GVL_manual.e3_sol", true);
        }

        private void jog_z_sag(object sender, RoutedEventArgs e)
        {
            ns.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.GVL_manual.e3_sag", true);

        }

        //tz
        private void jog_tz_sol(object sender, RoutedEventArgs e)
        {
            ns.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.GVL_manual.e4_sol", true);
        }

        private void jog_tz_sag(object sender, RoutedEventArgs e)
        {
            ns.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.GVL_manual.e4_sag", true);

        }

        //tr
        private void jog_tr_sol(object sender, RoutedEventArgs e)
        {
            ns.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.GVL_manual.e5_sol", true);
        }

        private void jog_tr_sag(object sender, RoutedEventArgs e)
        {
            ns.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.GVL_manual.e5_sag", true);

        }
        private void jog_bx_sol(object sender, RoutedEventArgs e)
        {

        }

        private void jog_bx_sag(object sender, RoutedEventArgs e)
        {

        }

        private void jog_bz_up(object sender, RoutedEventArgs e)
        {

        }

        private void jog_bz_down(object sender, RoutedEventArgs e)
        {

        }

        private void jog_by_sol(object sender, RoutedEventArgs e)
        {

        }

        private void jog_by_sag(object sender, RoutedEventArgs e)
        {

        }

        private void jog_cy_sol(object sender, RoutedEventArgs e)
        {

        }

        private void jog_cy_sag(object sender, RoutedEventArgs e)
        {

        }
        #endregion

        private void TextBox_MouseLeave(object sender, MouseEventArgs e)
        {

            Properties.Settings.Default.Xeksen_nominator = Convert.ToDouble(cabbar.Text);
            Properties.Settings.Default.Save();
            cabbar1.Content = Properties.Settings.Default.Xeksen_nominator.ToString();
            cabbar.Text = Properties.Settings.Default.Xeksen_nominator.ToString();
        }

        #region ayarlar
        private void xlostfocus(object sender, KeyboardFocusChangedEventArgs e)
        {

            set_axis_data setdata = new set_axis_data();

            Properties.Settings.Default.x_enc = Convert.ToDouble(tb_x_enc.Text);
            tb_x_enc.Text = Properties.Settings.Default.x_enc.ToString();

            Properties.Settings.Default.x_kalkis = Convert.ToDouble(tb_x_kalkis.Text);
            tb_x_kalkis.Text = Properties.Settings.Default.x_kalkis.ToString();

            Properties.Settings.Default.x_durus = Convert.ToDouble(tb_x_durus.Text);
            tb_x_durus.Text = Properties.Settings.Default.x_durus.ToString();

            Properties.Settings.Default.x_go_home = Convert.ToDouble(tb_x_gohome.Text);
            tb_x_gohome.Text = Properties.Settings.Default.x_go_home.ToString();

            Properties.Settings.Default.x_back_home = Convert.ToDouble(tb_x_backhome.Text);
            tb_x_backhome.Text = Properties.Settings.Default.x_back_home.ToString();

            Properties.Settings.Default.x_workspeed = Convert.ToDouble(tb_x_workspd.Text);
            tb_x_workspd.Text = Properties.Settings.Default.x_workspeed.ToString();

            Properties.Settings.Default.x_man_speed = Convert.ToDouble(tb_x_manspd.Text);
            tb_x_manspd.Text = Properties.Settings.Default.x_man_speed.ToString();

            Properties.Settings.Default.x_axis_limit = Convert.ToDouble(tb_x_axislimit.Text);
            tb_x_axislimit.Text = Properties.Settings.Default.x_axis_limit.ToString();

            Properties.Settings.Default.x_ofsett = Convert.ToDouble(tb_x_ofset.Text);
            tb_x_ofset.Text = Properties.Settings.Default.x_ofsett.ToString();
            Properties.Settings.Default.Save();
            GC.Collect();
            setdata.eksen1();
        }
        private void ylostfocus(object sender, KeyboardFocusChangedEventArgs e)
        {

            set_axis_data setdata = new set_axis_data();

            Properties.Settings.Default.y_enc = Convert.ToDouble(tb_y_enc.Text);
            tb_y_enc.Text = Properties.Settings.Default.y_enc.ToString();

            Properties.Settings.Default.y_kalkis = Convert.ToDouble(tb_y_kalkis.Text);
            tb_y_kalkis.Text = Properties.Settings.Default.y_kalkis.ToString();

            Properties.Settings.Default.y_durus = Convert.ToDouble(tb_y_durus.Text);
            tb_y_durus.Text = Properties.Settings.Default.y_durus.ToString();

            Properties.Settings.Default.y_go_home = Convert.ToDouble(tb_y_gohome.Text);
            tb_y_gohome.Text = Properties.Settings.Default.y_go_home.ToString();

            Properties.Settings.Default.y_back_home = Convert.ToDouble(tb_y_backhome.Text);
            tb_y_backhome.Text = Properties.Settings.Default.y_back_home.ToString();

            Properties.Settings.Default.y_workspeed = Convert.ToDouble(tb_y_workspd.Text);
            tb_y_workspd.Text = Properties.Settings.Default.y_workspeed.ToString();

            Properties.Settings.Default.y_man_speed = Convert.ToDouble(tb_y_manspd.Text);
            tb_y_manspd.Text = Properties.Settings.Default.y_man_speed.ToString();

            Properties.Settings.Default.y_axis_limit = Convert.ToDouble(tb_y_axislimit.Text);
            tb_y_axislimit.Text = Properties.Settings.Default.y_axis_limit.ToString();

            Properties.Settings.Default.y_ofsett = Convert.ToDouble(tb_y_ofset.Text);
            tb_y_ofset.Text = Properties.Settings.Default.y_ofsett.ToString();
            Properties.Settings.Default.Save();
            GC.Collect();
            setdata.eksen2();
        }
        private void zlostfocus(object sender, KeyboardFocusChangedEventArgs e)
        {

            set_axis_data setdata = new set_axis_data();

            Properties.Settings.Default.z_enc = Convert.ToDouble(tb_z_enc.Text);
            tb_z_enc.Text = Properties.Settings.Default.z_enc.ToString();

            Properties.Settings.Default.z_kalkis = Convert.ToDouble(tb_z_kalkis.Text);
            tb_z_kalkis.Text = Properties.Settings.Default.z_kalkis.ToString();

            Properties.Settings.Default.z_durus = Convert.ToDouble(tb_z_durus.Text);
            tb_z_durus.Text = Properties.Settings.Default.z_durus.ToString();

            Properties.Settings.Default.z_go_home = Convert.ToDouble(tb_z_gohome.Text);
            tb_z_gohome.Text = Properties.Settings.Default.z_go_home.ToString();

            Properties.Settings.Default.z_back_home = Convert.ToDouble(tb_z_backhome.Text);
            tb_z_backhome.Text = Properties.Settings.Default.z_back_home.ToString();

            Properties.Settings.Default.z_workspeed = Convert.ToDouble(tb_z_workspd.Text);
            tb_z_workspd.Text = Properties.Settings.Default.z_workspeed.ToString();

            Properties.Settings.Default.z_man_speed = Convert.ToDouble(tb_z_manspd.Text);
            tb_z_manspd.Text = Properties.Settings.Default.z_man_speed.ToString();

            Properties.Settings.Default.z_axis_limit = Convert.ToDouble(tb_z_axislimit.Text);
            tb_z_axislimit.Text = Properties.Settings.Default.z_axis_limit.ToString();

            Properties.Settings.Default.z_ofsett = Convert.ToDouble(tb_z_ofset.Text);
            tb_z_ofset.Text = Properties.Settings.Default.z_ofsett.ToString();
            Properties.Settings.Default.Save();
            GC.Collect();
            setdata.eksen3();
        }
        private void e4lostfocus(object sender, KeyboardFocusChangedEventArgs e)
        {

            set_axis_data setdata = new set_axis_data();

            Properties.Settings.Default.e4_enc = Convert.ToDouble(tb_e4_enc.Text);
            tb_e4_enc.Text = Properties.Settings.Default.e4_enc.ToString();

            Properties.Settings.Default.e4_kalkis = Convert.ToDouble(tb_e4_kalkis.Text);
            tb_e4_kalkis.Text = Properties.Settings.Default.e4_kalkis.ToString();

            Properties.Settings.Default.e4_durus = Convert.ToDouble(tb_e4_durus.Text);
            tb_e4_durus.Text = Properties.Settings.Default.e4_durus.ToString();

            Properties.Settings.Default.e4_go_home = Convert.ToDouble(tb_e4_gohome.Text);
            tb_e4_gohome.Text = Properties.Settings.Default.e4_go_home.ToString();

            Properties.Settings.Default.e4_back_home = Convert.ToDouble(tb_e4_backhome.Text);
            tb_e4_backhome.Text = Properties.Settings.Default.e4_back_home.ToString();

            Properties.Settings.Default.e4_workspeed = Convert.ToDouble(tb_e4_workspd.Text);
            tb_e4_workspd.Text = Properties.Settings.Default.e4_workspeed.ToString();

            Properties.Settings.Default.e4_man_speed = Convert.ToDouble(tb_e4_manspd.Text);
            tb_e4_manspd.Text = Properties.Settings.Default.e4_man_speed.ToString();

            Properties.Settings.Default.e4_axis_limit = Convert.ToDouble(tb_e4_axislimit.Text);
            tb_e4_axislimit.Text = Properties.Settings.Default.e4_axis_limit.ToString();

            Properties.Settings.Default.e4_ofsett = Convert.ToDouble(tb_e4_ofset.Text);
            tb_e4_ofset.Text = Properties.Settings.Default.e4_ofsett.ToString();
            Properties.Settings.Default.Save();
            GC.Collect();
            setdata.eksen4();
        }

        private void e5lostfocus(object sender, KeyboardFocusChangedEventArgs e)
        {

            set_axis_data setdata = new set_axis_data();

            Properties.Settings.Default.e5_enc = Convert.ToDouble(tb_e5_enc.Text);
            tb_e5_enc.Text = Properties.Settings.Default.e5_enc.ToString();

            Properties.Settings.Default.e5_kalkis = Convert.ToDouble(tb_e5_kalkis.Text);
            tb_e5_kalkis.Text = Properties.Settings.Default.e5_kalkis.ToString();

            Properties.Settings.Default.e5_durus = Convert.ToDouble(tb_e5_durus.Text);
            tb_e5_durus.Text = Properties.Settings.Default.e5_durus.ToString();

            Properties.Settings.Default.e5_go_home = Convert.ToDouble(tb_e5_gohome.Text);
            tb_e5_gohome.Text = Properties.Settings.Default.e5_go_home.ToString();

            Properties.Settings.Default.e5_back_home = Convert.ToDouble(tb_e5_backhome.Text);
            tb_e5_backhome.Text = Properties.Settings.Default.e5_back_home.ToString();

            Properties.Settings.Default.e5_workspeed = Convert.ToDouble(tb_e5_workspd.Text);
            tb_e5_workspd.Text = Properties.Settings.Default.e5_workspeed.ToString();

            Properties.Settings.Default.e5_man_speed = Convert.ToDouble(tb_e5_manspd.Text);
            tb_e5_manspd.Text = Properties.Settings.Default.e5_man_speed.ToString();

            Properties.Settings.Default.e5_axis_limit = Convert.ToDouble(tb_e5_axislimit.Text);
            tb_e5_axislimit.Text = Properties.Settings.Default.e5_axis_limit.ToString();

            Properties.Settings.Default.e5_ofsett = Convert.ToDouble(tb_e5_ofset.Text);
            tb_e5_ofset.Text = Properties.Settings.Default.e5_ofsett.ToString();
            Properties.Settings.Default.Save();
            GC.Collect();
            setdata.eksen5();
        }

        private void e6lostfocus(object sender, KeyboardFocusChangedEventArgs e)
        {

            set_axis_data setdata = new set_axis_data();

            Properties.Settings.Default.e6_enc = Convert.ToDouble(tb_e6_enc.Text);
            tb_e6_enc.Text = Properties.Settings.Default.e6_enc.ToString();

            Properties.Settings.Default.e6_kalkis = Convert.ToDouble(tb_e6_kalkis.Text);
            tb_e6_kalkis.Text = Properties.Settings.Default.e6_kalkis.ToString();

            Properties.Settings.Default.e6_durus = Convert.ToDouble(tb_e6_durus.Text);
            tb_e6_durus.Text = Properties.Settings.Default.e6_durus.ToString();

            Properties.Settings.Default.e6_go_home = Convert.ToDouble(tb_e6_gohome.Text);
            tb_e6_gohome.Text = Properties.Settings.Default.e6_go_home.ToString();

            Properties.Settings.Default.e6_back_home = Convert.ToDouble(tb_e6_backhome.Text);
            tb_e6_backhome.Text = Properties.Settings.Default.e6_back_home.ToString();

            Properties.Settings.Default.e6_workspeed = Convert.ToDouble(tb_e6_workspd.Text);
            tb_e6_workspd.Text = Properties.Settings.Default.e6_workspeed.ToString();

            Properties.Settings.Default.e6_man_speed = Convert.ToDouble(tb_e6_manspd.Text);
            tb_e6_manspd.Text = Properties.Settings.Default.e6_man_speed.ToString();

            Properties.Settings.Default.e6_axis_limit = Convert.ToDouble(tb_e6_axislimit.Text);
            tb_e6_axislimit.Text = Properties.Settings.Default.e6_axis_limit.ToString();

            Properties.Settings.Default.e6_ofsett = Convert.ToDouble(tb_e6_ofset.Text);
            tb_e6_ofset.Text = Properties.Settings.Default.e6_ofsett.ToString();
            Properties.Settings.Default.Save();
            GC.Collect();
            setdata.eksen6();
        }
        private void e7lostfocus(object sender, KeyboardFocusChangedEventArgs e)
        {

            set_axis_data setdata = new set_axis_data();

            Properties.Settings.Default.e7_enc = Convert.ToDouble(tb_e7_enc.Text);
            tb_e7_enc.Text = Properties.Settings.Default.e7_enc.ToString();

            Properties.Settings.Default.e7_kalkis = Convert.ToDouble(tb_e7_kalkis.Text);
            tb_e7_kalkis.Text = Properties.Settings.Default.e7_kalkis.ToString();

            Properties.Settings.Default.e7_durus = Convert.ToDouble(tb_e7_durus.Text);
            tb_e7_durus.Text = Properties.Settings.Default.e7_durus.ToString();

            Properties.Settings.Default.e7_go_home = Convert.ToDouble(tb_e7_gohome.Text);
            tb_e7_gohome.Text = Properties.Settings.Default.e7_go_home.ToString();

            Properties.Settings.Default.e7_back_home = Convert.ToDouble(tb_e7_backhome.Text);
            tb_e7_backhome.Text = Properties.Settings.Default.e7_back_home.ToString();

            Properties.Settings.Default.e7_workspeed = Convert.ToDouble(tb_e7_workspd.Text);
            tb_e7_workspd.Text = Properties.Settings.Default.e7_workspeed.ToString();

            Properties.Settings.Default.e7_man_speed = Convert.ToDouble(tb_e7_manspd.Text);
            tb_e7_manspd.Text = Properties.Settings.Default.e7_man_speed.ToString();

            Properties.Settings.Default.e7_axis_limit = Convert.ToDouble(tb_e7_axislimit.Text);
            tb_e7_axislimit.Text = Properties.Settings.Default.e7_axis_limit.ToString();

            Properties.Settings.Default.e7_ofsett = Convert.ToDouble(tb_e7_ofset.Text);
            tb_e7_ofset.Text = Properties.Settings.Default.e7_ofsett.ToString();
            Properties.Settings.Default.Save();
            GC.Collect();
            setdata.eksen7();
        }
        private void e8lostfocus(object sender, KeyboardFocusChangedEventArgs e)
        {

            set_axis_data setdata = new set_axis_data();

            Properties.Settings.Default.e8_enc = Convert.ToDouble(tb_e8_enc.Text);
            tb_e8_enc.Text = Properties.Settings.Default.e8_enc.ToString();

            Properties.Settings.Default.e8_kalkis = Convert.ToDouble(tb_e8_kalkis.Text);
            tb_e8_kalkis.Text = Properties.Settings.Default.e8_kalkis.ToString();

            Properties.Settings.Default.e8_durus = Convert.ToDouble(tb_e8_durus.Text);
            tb_e8_durus.Text = Properties.Settings.Default.e8_durus.ToString();

            Properties.Settings.Default.e8_go_home = Convert.ToDouble(tb_e8_gohome.Text);
            tb_e8_gohome.Text = Properties.Settings.Default.e8_go_home.ToString();

            Properties.Settings.Default.e8_back_home = Convert.ToDouble(tb_e8_backhome.Text);
            tb_e8_backhome.Text = Properties.Settings.Default.e8_back_home.ToString();

            Properties.Settings.Default.e8_workspeed = Convert.ToDouble(tb_e8_workspd.Text);
            tb_e8_workspd.Text = Properties.Settings.Default.e8_workspeed.ToString();

            Properties.Settings.Default.e8_man_speed = Convert.ToDouble(tb_e8_manspd.Text);
            tb_e8_manspd.Text = Properties.Settings.Default.e8_man_speed.ToString();

            Properties.Settings.Default.e8_axis_limit = Convert.ToDouble(tb_e8_axislimit.Text);
            tb_e8_axislimit.Text = Properties.Settings.Default.e8_axis_limit.ToString();

            Properties.Settings.Default.e8_ofsett = Convert.ToDouble(tb_e8_ofset.Text);
            tb_e8_ofset.Text = Properties.Settings.Default.e8_ofsett.ToString();
            Properties.Settings.Default.Save();
            GC.Collect();
            setdata.eksen8();
        }
        private void e9lostfocus(object sender, KeyboardFocusChangedEventArgs e)
        {

            set_axis_data setdata = new set_axis_data();

            Properties.Settings.Default.e9_enc = Convert.ToDouble(tb_e9_enc.Text);
            tb_e9_enc.Text = Properties.Settings.Default.e9_enc.ToString();

            Properties.Settings.Default.e9_kalkis = Convert.ToDouble(tb_e9_kalkis.Text);
            tb_e9_kalkis.Text = Properties.Settings.Default.e9_kalkis.ToString();

            Properties.Settings.Default.e9_durus = Convert.ToDouble(tb_e9_durus.Text);
            tb_e9_durus.Text = Properties.Settings.Default.e9_durus.ToString();

            Properties.Settings.Default.e9_go_home = Convert.ToDouble(tb_e9_gohome.Text);
            tb_e9_gohome.Text = Properties.Settings.Default.e9_go_home.ToString();

            Properties.Settings.Default.e9_back_home = Convert.ToDouble(tb_e9_backhome.Text);
            tb_e9_backhome.Text = Properties.Settings.Default.e9_back_home.ToString();

            Properties.Settings.Default.e9_workspeed = Convert.ToDouble(tb_e9_workspd.Text);
            tb_e9_workspd.Text = Properties.Settings.Default.e9_workspeed.ToString();

            Properties.Settings.Default.e9_man_speed = Convert.ToDouble(tb_e9_manspd.Text);
            tb_e9_manspd.Text = Properties.Settings.Default.e9_man_speed.ToString();

            Properties.Settings.Default.e9_axis_limit = Convert.ToDouble(tb_e9_axislimit.Text);
            tb_e9_axislimit.Text = Properties.Settings.Default.e9_axis_limit.ToString();

            Properties.Settings.Default.e9_ofsett = Convert.ToDouble(tb_e9_ofset.Text);
            tb_e9_ofset.Text = Properties.Settings.Default.e9_ofsett.ToString();
            Properties.Settings.Default.Save();
            GC.Collect();
            setdata.eksen9();
        }

        #endregion

        #region Sıfırlama-Gridleri

        int sifirlama_id = 1;
        public void sifirlama_tool1(object sender, RoutedEventArgs e)
        {
            lb_tool_selection.Content = "Takım 1";
            sifirlama_id = 1;
        }
        public void sifirlama_tool2(object sender, RoutedEventArgs e)
        {
            lb_tool_selection.Content = "Takım 2";
            sifirlama_id = 2;

        }
        public void sifirlama_tool3(object sender, RoutedEventArgs e)
        {
            lb_tool_selection.Content = "Takım 3";
            sifirlama_id = 3;

        }
        public void sifirlama_tool4(object sender, RoutedEventArgs e)
        {
            lb_tool_selection.Content = "Takım 4";
            sifirlama_id = 4;

        }
        public void sifirlama_tool5(object sender, RoutedEventArgs e)
        {
            lb_tool_selection.Content = "Takım 5";
            sifirlama_id = 5;

        }
        public void sifirlama_tool6(object sender, RoutedEventArgs e)
        {
            lb_tool_selection.Content = "Takım 6";
            sifirlama_id = 6;

        }
        public void sifirlama_tool7(object sender, RoutedEventArgs e)
        {
            lb_tool_selection.Content = "Takım 7";
            sifirlama_id = 7;

        }
        public void sifirlama_tool8(object sender, RoutedEventArgs e)
        {
            lb_tool_selection.Content = "Takım 8";
            sifirlama_id = 8;

        }
        public void sifirlama_tool9(object sender, RoutedEventArgs e)
        {
            lb_tool_selection.Content = "Takım 9";
            sifirlama_id = 9;

        }
        public void sifirlama_tool10(object sender, RoutedEventArgs e)
        {
            lb_tool_selection.Content = "Takım 10";
            sifirlama_id = 10;

        }
        public void sifirlama_kaydet(object sender, RoutedEventArgs e)
        {
            //ax e sifir x, sifir y, sifir z + eksen id si gidecek

            //id , x, y,z
            Properties.Settings.Default.sifir_x = Convert.ToDouble(tb_tool1_x.Text);
            tb_tool1_x.Text = Properties.Settings.Default.sifir_x.ToString();
            Properties.Settings.Default.sifir_y = Convert.ToDouble(tb_tool1_y.Text);
            tb_tool1_y.Text = Properties.Settings.Default.sifir_y.ToString();

            Properties.Settings.Default.sifir_z = Convert.ToDouble(tb_tool1_z.Text);
            tb_tool1_z.Text = Properties.Settings.Default.sifir_z.ToString();

            Properties.Settings.Default.sifir_id = Convert.ToDouble(sifirlama_id);
            Properties.Settings.Default.Save();
            GC.Collect();


        }
        public void sifirlama_pistonac(object sender, RoutedEventArgs e)
        {
            //axe pistonac biti + id yollicak


        }
        public void sifirlama_motorac(object sender, RoutedEventArgs e)
        {
            //ax e motorac biti + id yollicak


        }


        #endregion

        #region ReceteSf
        public bool flsts;
        public Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
        private void open_file(object sender, MouseButtonEventArgs e)
        {
            dlg.DefaultExt = ".plstmk";
            dlg.Filter = "Plstmk (*.plstmk)|*.plstmk|Txt (*.txt)|*.txt";
            Nullable<bool> result = dlg.ShowDialog();
            Properties.Settings.Default.file_path = dlg.FileName;
            Properties.Settings.Default.save_file_name = dlg.SafeFileName;
            Properties.Settings.Default.Save();
            String flpth = Properties.Settings.Default.file_path;
            flsts = Convert.ToBoolean(result);

            if (result == true)
            {
                filepathname.Content = Properties.Settings.Default.save_file_name;
                //CsvStreamReader ???
                //islem sayısı 
                string[] prf = new string[] { "Profile" };
                int prfcounter = (File.ReadAllText(flpth).Split(prf, StringSplitOptions.None).Length) - 1;//x tane profil islemi var diyoruz

                //txtedit.Items.Add(a-1);
                profilecounter.Content = prfcounter.ToString();
                string a = File.ReadAllText(flpth);
                var boy_pattern = new Regex(@"Profile;[0-9]+;?[0-9]+;([A-Za-z]+( [A-Za-z]+)+)\\.;[A-Za-z]+;[0-9]+;");
                var olcu_pattern = new Regex(@"[0-9]+");
                var eslesme = boy_pattern.Matches(a);
                var nummatch = olcu_pattern.Match(a);
                var ae = nummatch.NextMatch();//profil no
                var azr = nummatch.NextMatch();//stok no
                var efe = azr.NextMatch();//olcu 
                txtedit.Items.Add(efe);




                // var say = float.Parse(nummatch.Value);


                /*  string[] prf = new string[] {"Profile"};
                  string[] a = File.ReadAllText(flpth).Split(prf, StringSplitOptions.None);
                  for(int i = 0; i < a.Length; i++)
                  {
                      txtedit.Items.Add(a[i]);

                  }
                */
                /* string[] a = File.ReadAllText(flpth).Split(';');

                 for (int i = 0; i < a.Length; i++)
                 {

                     switch (a[i].ToString())
                     {
                         case "Profile":
                             txtedit.Items.Add(a[i + 5]);
                             continue;
                     }

                 }*/
                MessageBox.Show("AZRSSS");

            }
        }
        #endregion

        private void splittext(object sender, MouseButtonEventArgs e)
        {
            //string names[] = dlg.Spl
        }


    }
}
