using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Media;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Resources;
using System.IO;

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

            MusicPlayer();
        }

        private MediaPlayer player;
        private void MusicPlayer()
        {
            player = new MediaPlayer();
            player.Open(new Uri(@"C:\Users\ARTEM\Source\Repos\test2isp11-17\test2isp11-17\Music\Menu.wav"));
            player.Play();
            player.Volume = 0.2;
        }

        private void GameStart_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            GemeStartWindow1 openwindow = new GemeStartWindow1();
            openwindow.Show();
            this.Close();
        }
        private void GameExit_Click(object sender, RoutedEventArgs e)
        {
            var resultClick = MessageBox.Show( "Вы точно хотите выйти? " ,  "Выход ", MessageBoxButton.YesNo);
            if (resultClick == MessageBoxResult.Yes)
            {
                player.Stop();
                this.Close();
            }     
        }
        private void GameGallery_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            WindowGallery openwindow = new WindowGallery();
            openwindow.Show();
            this.Close();
        }
        private void Authors_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            AuthorWindow openwindow = new AuthorWindow();
            openwindow.Show();
            this.Close();
        }
        private void GameSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Игра сохранена");
        }
    }
}
