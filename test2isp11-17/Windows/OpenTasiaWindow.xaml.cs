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
using System.Windows.Threading;
using test2isp11_17.Windows;

namespace test2isp11_17
{
    /// <summary>
    /// Логика взаимодействия для GemeStartWindow5.xaml
    /// </summary>
    public partial class GemeStartWindow5 : Window
    {
        public GemeStartWindow5()
        {
            InitializeComponent();

            MusicPlayer();

            Text();

            timer.Start();

        }
        DispatcherTimer timer = new DispatcherTimer();
        private void Text()
        {
            timer.Interval = new TimeSpan(0, 0, 0, 0, 40);
            timer.Tick += Timer_Tick;
        }


        int i = 0;
        char[] text = "    Четвёртая девушка, самая скромная из всех - Ясенева Тася. Девушка очень добрая, по отношению к другим, доверчивая. Всегда придет на помощь. Но её внешность соответствует Снежной Королеве. Волосы достигали щиколоток, пряди окрашены в бирюзовой-волнистый цвет. Бледное личико покрыто румянцем. Ее глаза, отображают любовь к миру, одновременно замораживают.".ToCharArray();
        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                HistoryText.Text += text[i];
            }
            catch (IndexOutOfRangeException)
            {
                HistoryText.Text = "    Четвёртая девушка, самая скромная из всех - Ясенева Тася. Девушка очень добрая, по отношению к другим, доверчивая. Всегда придет на помощь. Но её внешность соответствует Снежной Королеве. Волосы достигали щиколоток, пряди окрашены в бирюзовой-волнистый цвет. Бледное личико покрыто румянцем. Ее глаза, отображают любовь к миру, одновременно замораживают.";
                i = -1;
                timer.Stop();
            }
            i++;
        }

        private MediaPlayer player;
        private void MusicPlayer()
        {
            player = new MediaPlayer();
            player.Open(new Uri("..\\..\\Music\\Tasia.WAV", UriKind.RelativeOrAbsolute));
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
            OpenArtyomWindow openwindow = new OpenArtyomWindow();
            openwindow.Show();
            this.Close();
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            GemeStartWindow2 openwindow = new GemeStartWindow2();
            openwindow.Show();
            this.Close();
        }
    }
}
