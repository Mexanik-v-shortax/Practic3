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

namespace Zadanie5Practic3
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
            int y = Convert.ToInt32(TbNumberB.Text);
            TextBlockAnswer.Text = "";
            if (y > -x && y < 23 && x < 0) { TextBlockAnswer.Text = "V oblasti"; }
            else if (y < -x && y > 23 && x > 0) { TextBlockAnswer.Text = "V ne oblasti"; }
            else { TextBlockAnswer.Text = "Na grani"; }




        }
    }
}
