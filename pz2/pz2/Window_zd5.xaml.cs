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
    /// Логика взаимодействия для Window_zd5.xaml
    /// </summary>
    public partial class Window_zd5 : Window
    {
        public Window_zd5()
        {
            InitializeComponent();
        }

        private void btn_return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Hide();
        }

        private void btn_result_Click(object sender, RoutedEventArgs e)
        {
            int n, m;
            Random rnd = new Random();
            try
            {

                m = int.Parse(tb_m.Text);
                n = int.Parse(tb_n.Text);
                if (m < 0 || n < 0)
                {
                    MessageBox.Show("Числа должны быть положительными");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введите число");
                return;
            }
            int[,] mas = new int[m, n];
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = rnd.Next(-10, 10);
                }
            }
        }
    }
}
