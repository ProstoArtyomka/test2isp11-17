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
    /// Логика взаимодействия для GemeStartWindow4.xaml
    /// </summary>
    public partial class GemeStartWindow4 : Window
    {
        public GemeStartWindow4()
        {
            InitializeComponent();
        }

        private void GoNext_Click(object sender, RoutedEventArgs e)
        {
            GemeStartWindow5 openwindow = new GemeStartWindow5();
            openwindow.Show();
            this.Close();
        }
    }
}
