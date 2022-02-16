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
    /// Логика взаимодействия для MainGameWindow.xaml
    /// </summary>
    public partial class MainGameWindow : Window
    {
        public MainGameWindow()
        {
            InitializeComponent();
        }

        private void GameStart_Click(object sender, RoutedEventArgs e)
        {
           GemeStartWindow1 openwindow = new GemeStartWindow1();
            openwindow.Show();
            this.Close();
        }

        private void GameSsve_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Игра сохранена");
        }

        private void GameExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show( "Вы точно хотите выйти? " ,  "Выход ", MessageBoxButton.YesNo);
            this.Close();
        }

        private void GameGallery_Click(object sender, RoutedEventArgs e)
        {
           WindowGallery openwindow = new WindowGallery();
            openwindow.Show();
            this.Close();
        }

        private void Authors_Click(object sender, RoutedEventArgs e)
        {
            AuthorWindow openwindow = new AuthorWindow();
            openwindow.Show();
            this.Close();
        }
    }
}
