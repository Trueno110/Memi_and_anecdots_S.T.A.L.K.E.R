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

namespace Memi_and_anecdots_S.T.A.L.K.E.R
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AAAAA_Click(object sender, RoutedEventArgs e)
        {
            Registration fal = new Registration();
            fal.Show();
            this.Close();

        }

        private void Vh_Click(object sender, RoutedEventArgs e)
        {
            Lenta fal = new Lenta();
            fal.Show();
            this.Close();
        }
    }
}
