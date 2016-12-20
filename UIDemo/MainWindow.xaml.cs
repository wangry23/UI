using MahApps.Metro;
using MahApps.Metro.Controls;
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

namespace UIDemo
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();

#if false
            ThemeManager.AddAccent("HsGrayAccent", new Uri("Style/GrayAccent.xaml"));
            ThemeManager.AddAppTheme("HsDarkTheme", new Uri("Style/HsDarkTheme.xaml"));
            
            // load theme & accent from sqlite
            string accentName = "HsGrayAccent", themeName = "HsDarkTheme";
            var appTheme = MahApps.Metro.ThemeManager.GetAppTheme(themeName);
            var appAccent = MahApps.Metro.ThemeManager.GetAccent(accentName);
            ThemeManager.ChangeAppStyle(Application.Current, appAccent, appTheme);
#endif
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UIDemo.DataGrid.DataGridDemo dataGrid = new DataGrid.DataGridDemo();
            dataGrid.ShowDialog();
        }
    }
}
