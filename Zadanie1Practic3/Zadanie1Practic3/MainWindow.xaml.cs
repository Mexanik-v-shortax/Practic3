﻿using System;
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

namespace Zadanie1Practic3
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
            int s = x % 2;
            if (x == 0) { TextBlockAnswer.Text = "нулевое число "; }
            else if (x > 0 && s == 0) { TextBlockAnswer.Text = "положительное четное"; }
            else if (x > 0 && s != 0) { TextBlockAnswer.Text = "положительное нечетное"; }
            else if (x < 0 && s == 0) { TextBlockAnswer.Text = "отрицательное четное "; }
            else if (x < 0 && s != 0) { TextBlockAnswer.Text = "отрицательное нечетное "; }

        }
    }
}
