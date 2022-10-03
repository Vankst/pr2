using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Логика взаимодействия для Window_zd2.xaml
    /// </summary>
    public partial class Window_zd2 : Window
    {
        public Window_zd2()
        {
            InitializeComponent();
        }

        private void btn_result_Click(object sender, RoutedEventArgs e)
        {
            tb_rez.Clear();
            string[] mas = tb_string.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            try
            {
                for (int i = mas.Length - 1; i >= 0; i--)
                {
                    string str = mas[i];
                    char[] ch = str.ToArray();
                    for (int j = 0; j < ch.Length; j++)
                    {
                        if (ch[j] >= Convert.ToChar(1040) && ch[j] <= Convert.ToChar(1103))
                        {
                            tb_rez.Text += ch[j];
                            if (j == ch.Length - 1)
                                tb_rez.Text += ' ';
                        }
                    }


                }

            }
            catch
            {
                tb_rez.Text = "Слишком много слов";
            }
        }

        private void btn_return_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Hide();
        }
    }
}
