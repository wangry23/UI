using MahApps.Metro.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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

namespace UIDemo.DataGrid
{

    public class DataNode : INotifyPropertyChanged
    {
        private string _First;
        public string First
        {
            get
            {
                return _First;
            }
            set
            {
                if(_First != value)
                {
                    _First = value;
                    Notify("First");
                }
            }
        }
        public string Second { get; set; }
        public string Thrid { get; set; }
        public string Forth { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Notify(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }

    /// <summary>
    /// DataGridDemo.xaml 的交互逻辑
    /// </summary>
    public partial class DataGridDemo : MetroWindow
    {
        public ObservableCollection<DataNode> DataGridSources
        {
            get; set;
        }

        public DataGridDemo()
        {
            InitializeComponent();

            DataGridSources = new ObservableCollection<DataNode>();
            DataGridSources.Add(new DataNode() { First = "1", Second = "2", Thrid = "3", Forth = "4" });
            DataGridSources.Add(new DataNode() { First = "1", Second = "2", Thrid = "3", Forth = "4" });
            DataGridSources.Add(new DataNode() { First = "1", Second = "2", Thrid = "3", Forth = "4" });
            DataGridSources.Add(new DataNode() { First = "1", Second = "2", Thrid = "3", Forth = "4" });
            DataGridSources.Add(new DataNode() { First = "1", Second = "2", Thrid = "3", Forth = "4" });

        }
    }
}
