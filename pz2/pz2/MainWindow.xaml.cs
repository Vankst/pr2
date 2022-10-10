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

namespace pz2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_zd1_Click(object sender, RoutedEventArgs e)
        {
          Window_zd1 window_Zd1 = new Window_zd1();
            window_Zd1.Show();
            this.Hide();
        }

        private void btn_zd2_Click(object sender, RoutedEventArgs e)
        {
            Window_zd2 window_Zd2 = new Window_zd2();
            window_Zd2.Show();
            this.Hide();
        }

        private void btn_zd3_Click(object sender, RoutedEventArgs e)
        {
            Window_zd3 window_Zd3 = new Window_zd3();
            window_Zd3.Show();
            this.Hide();
        }

        private void btn_zd5_Click(object sender, RoutedEventArgs e)
        {
            Window_zd5 window_Zd5 = new Window_zd5();
            window_Zd5.Show();
            Hide();
        }
    }
}
