using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using DevExpress.Xpf.Core;

namespace WpfApp8
{
    /// <summary>
    /// App.xaml etkileşim mantığı
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //ThemeManager.ApplicationThemeName = Theme.Win10LightName;
            base.OnStartup(e);
        }
    }
}
