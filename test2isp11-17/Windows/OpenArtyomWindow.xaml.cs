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
using test2isp11_17.Windows;

namespace test2isp11_17.Windows
{
    /// <summary>
    /// Логика взаимодействия для OpenArtyomWindow.xaml
    /// </summary>
    public partial class OpenArtyomWindow : Window
    {
        public OpenArtyomWindow()
        {
            InitializeComponent();
        }

        private void GoNext_Click(object sender, RoutedEventArgs e)
        {
            OpenVladWindow openwindow = new OpenVladWindow();
            openwindow.Show();
            this.Close();
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            GemeStartWindow5 openwindow = new GemeStartWindow5();
            openwindow.Show();
            this.Close();
        }
    }
}
