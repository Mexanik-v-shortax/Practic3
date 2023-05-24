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

namespace Zadanie3Practic3
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

            int A = Convert.ToInt32(TbNumberA.Text);
            int B = Convert.ToInt32(TbNumberB.Text);
            int C = Convert.ToInt32(TbNumberC.Text);
            int D = Convert.ToInt32(TbNumberD.Text);
            if (A == B && B == C && C != D) { TextBlockAnswer.Text = "4 порядковый номер"; }
            else if (A == B && B == D && D != C) { TextBlockAnswer.Text = "3 порядковый номер"; }
            else if (A == C && C == D && D != B) { TextBlockAnswer.Text = "2 порядковый номер"; }
            else if (D == B && B == C && C != A) { TextBlockAnswer.Text = "1 порядковый номер"; }
            else { TextBlockAnswer.Text = $"условия не выполнены "; }
        }
    }
}
