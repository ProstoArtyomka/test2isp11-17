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
        private MediaPlayer player = new MediaPlayer();
        private void MusicPlayer()
        {
            player.Open(new Uri("/Music/Menu.mp3", UriKind.Relative));
            player.Play();
        }
        private void GameStart_Click(object sender, RoutedEventArgs e)
        {
            GemeStartWindow1 openwindow = new GemeStartWindow1();
            openwindow.Show();
            this.Close();
        }
        private void GameExit_Click(object sender, RoutedEventArgs e)
        {
            var resultClick = MessageBox.Show( "Вы точно хотите выйти? " ,  "Выход ", MessageBoxButton.YesNo);
            if (resultClick == MessageBoxResult.Yes)
            {
                this.Close();
            }     
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
        private void GameSave_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Игра сохранена");
        }
    }
}
