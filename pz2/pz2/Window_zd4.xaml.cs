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
            int n = 0;
            int number = 0;
            Random rnd = new Random();
            try
            {
                n = int.Parse(tb_n.Text);
                number = int.Parse(tb_number.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Неверный ввод");
            }
            if (number >= 20 || number <= -20)
                MessageBox.Show("Число от -19 до 19");
            int[] mas = new int[n];
            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(-20, 20);
            }
            int temp;
            for(int i = 0; i < mas.Length - 1; i++)
            {
                for(int j = i + 1; j < mas.Length; j++)
                {
                    if(mas[i]> mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            int[] array = new int[mas.Length + 1];
            int k = 0, ch = 0;
            bool check = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (k >= mas.Length)
                {
                    if (ch == 0)
                    {
                        array[i] = number;
                    }
                    break;
                }
                if (mas[k] > number && mas[k-1] <= number && check == false)
                {
                    array[i] = number;
                    k--;
                    check = true;
                    ch++;
                }
                else
                {
                    array[i] = mas[k];
                    check = false;
                }
                k++;
                lbl_array.Content += $" {array[i]}";
            }
            for(int i = 0; i < mas.Length; i++)
            {
                lbl_mas.Content += $" {mas[i]}";
            }
        }
    }
}
