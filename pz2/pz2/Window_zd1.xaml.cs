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
    /// Логика взаимодействия для Window_zd1.xaml
    /// </summary>
    public partial class Window_zd1 : Window
    {
        public Window_zd1()
        {
            InitializeComponent();
        }

        private void btn_result_Click(object sender, RoutedEventArgs e)
        {
            string number = tb_number.Text;
            try
            {
                uint numb = Convert.ToUInt32(number);
                if (numb > 100 || numb < 0)
                {
                    tb_rez.Text = "Число не входит в заданный диапозон";

                }

                else
                {

                    tb_rez.Text = $"{Math.Abs(Factorial(2 * numb))}";
                }
            }
            catch
            {
                tb_rez.Text = "Введено не число";
            }


        }
        uint Factorial(uint n)
        {
            if (n == 1) return 1;
            return Convert.ToUInt32(n * Factorial(n - 1));
        }

        private void btn_return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
    
}
