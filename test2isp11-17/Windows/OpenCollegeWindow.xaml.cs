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
using test2isp11_17.Windows;

namespace test2isp11_17
{
    /// <summary>
    /// Логика взаимодействия для GemeStartWindow3.xaml
    /// </summary>
    public partial class GemeStartWindow6 : Window
    {
        public GemeStartWindow6()
        {
            InitializeComponent();
        }

        private void GoNext_Click(object sender, RoutedEventArgs e)
        {
            GemeStartWindow7 openwindow = new GemeStartWindow7();
            openwindow.Show();
            this.Close();
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            OpenSashaAndPhilWindow openwindow = new OpenSashaAndPhilWindow();
            openwindow.Show();
            this.Close();
        }
    }
}
