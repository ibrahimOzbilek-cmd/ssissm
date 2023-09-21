using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls.WebParts;


namespace WpfApp8
{
    internal class node_tags

    {
        public void baslangic()
        {

        }

    }


    internal class sifirlama
    {
        public double s_x, s_y, s_z;
        public sifirlama()
        {

        }
    }
    internal class set_axis_data
    {
        MainWindow ms = new MainWindow();

        public set_axis_data()
        {


        }
        public void eksen1()
        {
            //e1_enc, e1_kalkis, e1_durus, e1_gohome, e1_backohme, e1_workspd, e1_manspd, e1_limit, e1_ofset
          //  ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.variable_change.set_en", true);
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e1_enc", Convert.ToDouble(Properties.Settings.Default.x_enc));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e1_kalkis", Convert.ToDouble(Properties.Settings.Default.x_kalkis));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e1_durus", Convert.ToDouble(Properties.Settings.Default.x_durus));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e1_gohome", Convert.ToDouble(Properties.Settings.Default.x_go_home));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e1_backhome", Convert.ToDouble(Properties.Settings.Default.x_back_home));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e1_workspd", Convert.ToDouble(Properties.Settings.Default.x_workspeed));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e1_manspd", Convert.ToDouble(Properties.Settings.Default.x_man_speed));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e1_limit", Convert.ToDouble(Properties.Settings.Default.x_axis_limit));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e1_ofset", Convert.ToDouble(Properties.Settings.Default.x_ofsett));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.set_en", false); 
        }

        public void eksen2() {
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e2_enc", Convert.ToDouble(Properties.Settings.Default.y_enc));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e2_kalkis", Convert.ToDouble(Properties.Settings.Default.y_kalkis));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e2_durus", Convert.ToDouble(Properties.Settings.Default.y_durus));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e2_gohome", Convert.ToDouble(Properties.Settings.Default.y_go_home));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e2_backhome", Convert.ToDouble(Properties.Settings.Default.y_back_home));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e2_workspd", Convert.ToDouble(Properties.Settings.Default.y_workspeed));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e2_manspd", Convert.ToDouble(Properties.Settings.Default.y_man_speed));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e2_limit", Convert.ToDouble(Properties.Settings.Default.y_axis_limit));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e2_ofset", Convert.ToDouble(Properties.Settings.Default.y_ofsett));
        }
        public void eksen3() {
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e3_enc", Convert.ToDouble(Properties.Settings.Default.z_enc));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e3_kalkis", Convert.ToDouble(Properties.Settings.Default.z_kalkis));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e3_durus", Convert.ToDouble(Properties.Settings.Default.z_durus));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e3_gohome", Convert.ToDouble(Properties.Settings.Default.z_go_home));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e3_backhome", Convert.ToDouble(Properties.Settings.Default.z_back_home));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e3_workspd", Convert.ToDouble(Properties.Settings.Default.z_workspeed));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e3_manspd", Convert.ToDouble(Properties.Settings.Default.z_man_speed));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e3_limit", Convert.ToDouble(Properties.Settings.Default.z_axis_limit));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e3_ofset", Convert.ToDouble(Properties.Settings.Default.z_ofsett));

        }
        public void eksen4() {
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e4_enc", Convert.ToDouble(Properties.Settings.Default.e4_enc));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e4_kalkis", Convert.ToDouble(Properties.Settings.Default.e4_kalkis));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e4_durus", Convert.ToDouble(Properties.Settings.Default.e4_durus));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e4_gohome", Convert.ToDouble(Properties.Settings.Default.e4_go_home));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e4_backhome", Convert.ToDouble(Properties.Settings.Default.e4_back_home));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e4_workspd", Convert.ToDouble(Properties.Settings.Default.e4_workspeed));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e4_manspd", Convert.ToDouble(Properties.Settings.Default.e4_man_speed));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e4_limit", Convert.ToDouble(Properties.Settings.Default.e4_axis_limit));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e4_ofset", Convert.ToDouble(Properties.Settings.Default.e4_ofsett));
        }
        public void eksen5() {
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e5_enc", Convert.ToDouble(Properties.Settings.Default.e5_enc));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e5_kalkis", Convert.ToDouble(Properties.Settings.Default.e5_kalkis));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e5_durus", Convert.ToDouble(Properties.Settings.Default.e5_durus));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e5_gohome", Convert.ToDouble(Properties.Settings.Default.e5_go_home));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e5_backhome", Convert.ToDouble(Properties.Settings.Default.e5_back_home));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e5_workspd", Convert.ToDouble(Properties.Settings.Default.e5_workspeed));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e5_manspd", Convert.ToDouble(Properties.Settings.Default.e5_man_speed));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e5_limit", Convert.ToDouble(Properties.Settings.Default.e5_axis_limit));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e5_ofset", Convert.ToDouble(Properties.Settings.Default.e5_ofsett));
        }
        public void eksen6() {
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e6_enc", Convert.ToDouble(Properties.Settings.Default.e6_enc));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e6_kalkis", Convert.ToDouble(Properties.Settings.Default.e6_kalkis));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e6_durus", Convert.ToDouble(Properties.Settings.Default.e6_durus));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e6_gohome", Convert.ToDouble(Properties.Settings.Default.e6_go_home));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e6_backhome", Convert.ToDouble(Properties.Settings.Default.e6_back_home));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e6_workspd", Convert.ToDouble(Properties.Settings.Default.e6_workspeed));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e6_manspd", Convert.ToDouble(Properties.Settings.Default.e6_man_speed));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e6_limit", Convert.ToDouble(Properties.Settings.Default.e6_axis_limit));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e6_ofset", Convert.ToDouble(Properties.Settings.Default.e6_ofsett));
        }
        public void eksen7() {
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e7_enc", Convert.ToDouble(Properties.Settings.Default.e7_enc));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e7_kalkis", Convert.ToDouble(Properties.Settings.Default.e7_kalkis));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e7_durus", Convert.ToDouble(Properties.Settings.Default.e7_durus));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e7_gohome", Convert.ToDouble(Properties.Settings.Default.e7_go_home));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e7_backhome", Convert.ToDouble(Properties.Settings.Default.e7_back_home));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e7_workspd", Convert.ToDouble(Properties.Settings.Default.e7_workspeed));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e7_manspd", Convert.ToDouble(Properties.Settings.Default.e7_man_speed));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e7_limit", Convert.ToDouble(Properties.Settings.Default.e7_axis_limit));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e7_ofset", Convert.ToDouble(Properties.Settings.Default.e7_ofsett));
        }
        public void eksen8() {
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e8_enc", Convert.ToDouble(Properties.Settings.Default.e8_enc));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e8_kalkis", Convert.ToDouble(Properties.Settings.Default.e8_kalkis));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e8_durus", Convert.ToDouble(Properties.Settings.Default.e8_durus));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e8_gohome", Convert.ToDouble(Properties.Settings.Default.e8_go_home));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e8_backhome", Convert.ToDouble(Properties.Settings.Default.e8_back_home));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e8_workspd", Convert.ToDouble(Properties.Settings.Default.e8_workspeed));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e8_manspd", Convert.ToDouble(Properties.Settings.Default.e8_man_speed));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e8_limit", Convert.ToDouble(Properties.Settings.Default.e8_axis_limit));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e8_ofset", Convert.ToDouble(Properties.Settings.Default.e8_ofsett));
        }
        public void eksen9() {
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e9_enc", Convert.ToDouble(Properties.Settings.Default.e9_enc));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e9_kalkis", Convert.ToDouble(Properties.Settings.Default.e9_kalkis));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e9_durus", Convert.ToDouble(Properties.Settings.Default.e9_durus));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e9_gohome", Convert.ToDouble(Properties.Settings.Default.e9_go_home));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e9_backhome", Convert.ToDouble(Properties.Settings.Default.e9_back_home));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e9_workspd", Convert.ToDouble(Properties.Settings.Default.e9_workspeed));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e9_manspd", Convert.ToDouble(Properties.Settings.Default.e9_man_speed));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e9_limit", Convert.ToDouble(Properties.Settings.Default.e9_axis_limit));
            ms.client.WriteNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.Eksen_Ayarlar.e9_ofset", Convert.ToDouble(Properties.Settings.Default.e9_ofsett));
        }
    }
    internal class get_axis_data
    {
        MainWindow ms = new MainWindow();
        public string efe;
        public object e1_enc, e1_kalkis, e1_durus, e1_gohome, e1_backohme, e1_workspd, e1_manspd, e1_limit, e1_ofset;
        public get_axis_data()
        {
            //string seklinde adresler belirlenecek eksen 1 eksen 2 için vs vs

            Eksen1();
        }

        public void Eksen1()
        {
            e1_enc = ms.client.ReadNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.variable_change.e1_enc");
            e1_kalkis = ms.client.ReadNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.variable_change.e1_kalkis");
            e1_durus = ms.client.ReadNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.variable_change.e1_durus");
            e1_gohome = ms.client.ReadNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.variable_change.e1_gohome");
            e1_backohme = ms.client.ReadNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.variable_change.e1_backohme");
            e1_workspd = ms.client.ReadNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.variable_change.e1_workspd");
            e1_manspd = ms.client.ReadNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.variable_change.e1_manspd");
            e1_limit = ms.client.ReadNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.variable_change.e1_limit");
            e1_ofset = ms.client.ReadNode("ns=4;|var|Delta/x86_64/RTE/SM/CNC/ TV+WV.Application.variable_change.e1_ofset");


        }
        public void eksen2() { }
        public void eksen3() { }
        public void eksen4() { }
        public void eksen5() { }
        public void eksen6() { }
        public void eksen7() { }
        public void eksen8() { }
        public void eksen9() { }
    }
}
