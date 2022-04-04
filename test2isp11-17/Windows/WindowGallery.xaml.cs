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
using System.Windows.Shapes;

namespace test2isp11_17
{
    /// <summary>
    /// Логика взаимодействия для WindowGallery.xaml
    /// </summary>
    public partial class WindowGallery : Window
    {
        public WindowGallery()
        {
            InitializeComponent();
        }

        private void BtnBackS_Click(object sender, RoutedEventArgs e)
        {
            MainGameWindow openwindow = new MainGameWindow();
            openwindow.Show();
            this.Close();
        }
    }
}
