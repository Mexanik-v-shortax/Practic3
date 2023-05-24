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

namespace Zadanie4Practic3
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
            double? y = null;
            double x = Convert.ToDouble(TbNumberA.Text);
            if (x < 0) { y = x * x - 3 - Math.Pow(3.14 - x, 1 / 3.0); TextBlockAnswer.Text = $"y={y:f2}"; }
            else if (0 <= x && x < 1) { y = x * x - 3 - Math.Pow(3.14 - x, 1 / 3.0); TextBlockAnswer.Text = $"y={y:f2}"; }
            else if (x >= 1) { y = x * x - 3 - Math.Pow(3.14 - x, 1 / 3.0); TextBlockAnswer.Text = $"y={y:f2}"; }
            else { TextBlockAnswer.Text = "За пределом значения"; }
        }
    }
}
