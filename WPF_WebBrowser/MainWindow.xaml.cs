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

namespace WPF_WebBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            txtQuery.Clear();
        }

        private void btnGo_Click(object sender, RoutedEventArgs e)
        {
            string query = txtQuery.Text;

            //webGoogle.Navigate($"{query}");
            MyWebBroswerWindow google = new MyWebBroswerWindow();
            google.query = query;
            google.Show(); // open multiple windows
            //google.ShowDialog();  (open only 1 window at time)
            google.ShowDialog();
        }
    }
}
