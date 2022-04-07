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
    /// Логика взаимодействия для GemeStartWindow2.xaml
    /// </summary>
    public partial class GemeStartWindow2 : Window
    {
        public GemeStartWindow2()
        {
            InitializeComponent();

            MusicPlayer();
        }

        private MediaPlayer player;
        private void MusicPlayer()
        {
            player = new MediaPlayer();
            player.Open(new Uri(@"C:\Users\ARTEM\Source\Repos\test2isp11-17\test2isp11-17\Music\Lena.wav"));
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
            GemeStartWindow3 openwindow = new GemeStartWindow3();
            openwindow.Show();
            this.Close();
        }
    }
}
