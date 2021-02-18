using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_WebBrowser
{
    /// <summary>
    /// Interaction logic for MyWebBroswerWindow.xaml
    /// </summary>
    public partial class MyWebBroswerWindow : Window
    {
        public string query { get; set; }

        public MyWebBroswerWindow()
        { 
            InitializeComponent();

            webGoogle.Navigate($"https://www.google.com/search?q={query}");
        }
        public void search(String q)
        {
            query = q;
            webGoogle.Navigate($"https://www.google.com/search?q={q}");
        }
        public void Search()
        {
            webGoogle.Navigate($"https://www.google.com/search?q={query}");

        }
    }
}
