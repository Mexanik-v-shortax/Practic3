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

namespace DOp1Practic333
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
        void BtnOK_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(TbNumberA.Text);
            if (x == 0)
            {
                TextBlockAnswer.Text = "нулевое число ";
            }
            else if (x > 0)
            {
                if (x % 2 == 0)
                {
                    TextBlockAnswer.Text = "положительное четное число "; 
                }
                else
                {
                    TextBlockAnswer.Text = "положительное нечетное число ";
                }
            }
            else 
            {
                if (x % 2 == 0)
                {
                    TextBlockAnswer.Text = "отрицательное четное число ";
                }
                else
                {
                    TextBlockAnswer.Text = "отрицательное нечетное число ";
                }
            }
        }

    }
}
