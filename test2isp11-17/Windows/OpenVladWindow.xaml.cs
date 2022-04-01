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

namespace test2isp11_17.Windows
{
    /// <summary>
    /// Логика взаимодействия для OpenVladWindow.xaml
    /// </summary>
    public partial class OpenVladWindow : Window
    {
        public OpenVladWindow()
        {
            InitializeComponent();
        }
        private void GoNext_Click(object sender, RoutedEventArgs e)
        {
            OpenSashaAndPhilWindow openwindow = new OpenSashaAndPhilWindow();
            openwindow.Show();
            this.Close();
        }
    }
}
