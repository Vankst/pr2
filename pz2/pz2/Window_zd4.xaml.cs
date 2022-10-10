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

namespace pz2
{
    /// <summary>
    /// Логика взаимодействия для Window_zd4.xaml
    /// </summary>
    public partial class Window_zd4 : Window
    {
        public Window_zd4()
        {
            InitializeComponent();
        }

        private void btn_return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void btn_result_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
