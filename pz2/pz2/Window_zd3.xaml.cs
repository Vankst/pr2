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
    /// Логика взаимодействия для Window_zd3.xaml
    /// </summary>
    public partial class Window_zd3 : Window
    {
        public Window_zd3()
        {
            InitializeComponent();
        }

        private void btn_result_Click(object sender, RoutedEventArgs e)
        {
            int razm = 2;
            Random rnd = new Random();
            int[] mas = new int[razm];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(0, 100);
            }
            ;
            int[] rez = new int[razm];
            int maxkolv = 0;
            int startindex = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                int kolv = 0;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (i < mas.Length)
                    {
                        if ((mas[i] % mas[j]) == 0)
                        {                     
                            kolv++;
                            //MessageBox.Show($"Число {mas[i]} делится нацело на {mas[j]}, количество {kolv}");
                            i++;
                            if (maxkolv < kolv)
                            {
                                startindex = i;
                                maxkolv = kolv;
                            }
                        }
                    }
                    else
                        i++;
                }

            }
            if (maxkolv == 0)
            {
                //нет таких чисел
                return;
            }
            else
            {
                int sv = 0;
                for (int i = startindex; i < mas.Length; i++)
                {
                    if (sv < maxkolv)
                    {
                        MessageBox.Show(mas[i].ToString());
                    }
                    else
                    {
                        break;
                    }
                    sv++;
                }
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
