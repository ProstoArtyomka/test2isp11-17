using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace test2isp11_17
{
    /// <summary>
    /// Логика взаимодействия для GemeStartWindow2.xaml
    /// </summary>
    public partial class GemeStartWindow2 : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public GemeStartWindow2()
        {
            InitializeComponent();

            MusicPlayer();

            Text();

            timer.Start();

        }
        private void Text()
        {
            timer.Interval = new TimeSpan(0, 0, 0, 0, 40);
            timer.Tick += Timer_Tick;
        }


        int i = 0;
        char[] text = "    Третья из девушек — Тихонова Лена. Девушка со своими взглядами на жизнь. Сама по себе она спокойна. Но только не тогда, когда надо поставить кого-то на место. Девушка — блондинка. Пухлые цветом малины губы, тонкий носик.".ToCharArray();
        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                HistoryText.Text += text[i];
            }
            catch (IndexOutOfRangeException)
            {
                HistoryText.Text = "    Третья из девушек — Тихонова Лена. Девушка со своими взглядами на жизнь. Сама по себе она спокойна. Но только не тогда, когда надо поставить кого-то на место. Девушка — блондинка. Пухлые цветом малины губы, тонкий носик.";
                i = -1;
                timer.Stop();
            }
            i++;
        }
        private MediaPlayer player;
        private void MusicPlayer()
        {
            player = new MediaPlayer();
            player.Open(new Uri("..\\..\\Music\\Lena.WAV", UriKind.RelativeOrAbsolute));
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
            player.Pause();
            GemeStartWindow5 openwindow = new GemeStartWindow5();
            openwindow.Show();
            this.Close();
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            player.Pause();
            GemeStartWindow4 openwindow = new GemeStartWindow4();
            openwindow.Show();
            this.Close();
        }
    }
}
