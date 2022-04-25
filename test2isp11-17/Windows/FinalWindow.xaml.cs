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
    /// Логика взаимодействия для FinalWindow.xaml
    /// </summary>
    public partial class FinalWindow : Window
    {
        public FinalWindow()
        {
            InitializeComponent();

            MusicPlayer();
        }
        private MediaPlayer player;
        private void MusicPlayer()
        {
            player = new MediaPlayer();
            player.Open(new Uri("..\\..\\Music\\Final.WAV", UriKind.RelativeOrAbsolute));
            player.MediaEnded += new EventHandler(Media_Ended);
            player.Play();
            player.Volume = 0.5;
        }

        private void Media_Ended(object sender, EventArgs e)
        {
            player.Position = TimeSpan.Zero;
            player.Play();
            player.Volume = 0.1;
        }
        private void GoNext_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            MainGameWindow opemwindow = new MainGameWindow();
            opemwindow.Show();
            this.Close();
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            EveningOfTheFirstDayWindow2 opemwindow = new EveningOfTheFirstDayWindow2();
            opemwindow.Show();
            this.Close();
        }
    }
}
