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
using System.Windows.Shapes;

namespace test2isp11_17
{
    /// <summary>
    /// Логика взаимодействия для GemeStartWindow3.xaml
    /// </summary>
    public partial class GemeStartWindow3 : Window
    {
        public GemeStartWindow3()
        {
            InitializeComponent();
        }

        private void GoNext_Click_1(object sender, RoutedEventArgs e)
        {
            GemeStartWindow4 openwindow = new GemeStartWindow4();
            openwindow.Show();
            this.Close();
        }
    }
}