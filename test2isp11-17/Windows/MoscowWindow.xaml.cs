using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Threading;
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
    /// Логика взаимодействия для GemeStartWindow1.xaml
    /// </summary>
    public partial class GemeStartWindow1 : Window
    {
        public GemeStartWindow1()
        {
            InitializeComponent();

            MusicPlayer();
        }
        private MediaPlayer player;
        private void MusicPlayer()
        {
            player = new MediaPlayer();
            player.Open(new Uri(@"C:\Users\ARTEM\Source\Repos\test2isp11-17\test2isp11-17\Music\City.wav"));
            player.MediaEnded += new EventHandler(Media_Ended);
            player.Play();
            player.Volume = 0.2;
        }
        private void Media_Ended(object sender, EventArgs e)
        {
            player.Position = TimeSpan.Zero;
            player.Play();
            player.Volume = 0.2;
        }
        private void GoNext_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            GemeStartWindow2 openwindow = new GemeStartWindow2();
            openwindow.Show();
            this.Close();
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            MainGameWindow openwindow1 = new MainGameWindow();
            openwindow1.Show();
            this.Close();
        }

        private void GoText_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
