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

namespace Dop2Practic3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {

            int x = int.Parse(TbNumberA.Text);

            if (x >= 1 && x <= 999)
            {
                if (x < 10)
                {
                    TextBlockAnswer.Text = "однозначное число";
                }
                else if (x < 100)
                {
                    if (x % 2 == 0)
                    {
                        TextBlockAnswer.Text = "четное двузначное число";
                    }
                    else
                    {
                        TextBlockAnswer.Text = "нечетное двузначное число";
                    }
                }
                else // number >= 100
                {
                    if (x % 2 == 0)
                    {
                        TextBlockAnswer.Text = "четное трехзначное число";
                    }
                    else
                    {
                        TextBlockAnswer.Text = "нечетное трехзначное число";
                    }
                }
            }
            else
            {
                TextBlockAnswer.Text = "Число должно быть в диапазоне от 1 до 999.";
            }
        }
    }
}
