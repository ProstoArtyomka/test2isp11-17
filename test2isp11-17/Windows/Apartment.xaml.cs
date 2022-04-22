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

namespace test2isp11_17.Windows
{
    /// <summary>
    /// Логика взаимодействия для Apartment.xaml
    /// </summary>
    public partial class Apartment : Window
    {
        public Apartment()
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
        char[] text = "    Время подходило к семи утра. Всем девушкам пора уже вставать, идти на учёбу. Но они похоже даже не думают об этом. Слишком уж вчерашняя вечеринка на них повлияла. Девочки до такой степени вчера отжигали до четырёх часов утра, так сказать, прощались с летом, что сейчас даже проснуться не могут. Но настырный будильник совершенно не жалел девчонок.".ToCharArray();
        char[] text1 = "    Первой это надоело Тасе. Она начала будить других девочек. Алиса быстро забегает в ванную комнату, захлопывая дверь перед Ульяниным носом.".ToCharArray();
        char[] text2 = "    Дура! - вскрикивает рыжая девушка вслед подруге.".ToCharArray();
        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                HistoryText.Text += text[i];
            }
            catch (IndexOutOfRangeException)
            {
                i = -1;
                timer.Stop();
            }
            i++;       
        }

        private MediaPlayer player;
        private MediaPlayer sound;
        private void MusicPlayer()
        {
            player = new MediaPlayer();
            player.Open(new Uri("..\\..\\Music\\HideAndSeek.WAV", UriKind.RelativeOrAbsolute));
            player.MediaEnded += new EventHandler(Media_Ended);
            player.Play();
            player.Volume = 0.1;
        }
        private void SoundPlay()
        {
            sound = new MediaPlayer();
            sound.Open(new Uri("..\\..\\BackSound\\AlarmСlock.WAV", UriKind.RelativeOrAbsolute));
            sound.Play();
            sound.Volume = 0.3;
        }
        private void SoundPlay2()
        {
            sound = new MediaPlayer();
            sound.Open(new Uri("..\\..\\BackSound\\Door.WAV", UriKind.RelativeOrAbsolute));
            sound.Play();
            sound.Volume = 0.3;
        }
        private void Media_Ended(object sender, EventArgs e)
        {
            player.Position = TimeSpan.Zero;
            player.Play();
            player.Volume = 0.1;
        }
        int click = 0;
        private void GoNext_Click(object sender, RoutedEventArgs e)
        {
            click++;
            if (click == 1)
            {
                SoundPlay();
                HistoryText.Text = " ";
                text = text1;
                timer.Start();
            }

            if (click == 2)
            {
                CenterRightImageBody.Opacity = 1;
                CenterRightImageClothes.Opacity = 1;
                CenterRightImageFace.Opacity = 1;
                SoundPlay2();
                HistoryText.Text = " ";
                text = text2;
                timer.Start();
            }

            if (click == 3)
            {
                player.Stop();
                GemeStartWindow3 openwindow = new GemeStartWindow3();
                openwindow.Show();
                this.Close();
            }

        }
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            GemeStartWindow5 opemwindow = new GemeStartWindow5();
            opemwindow.Show();
            this.Close();
        }
    }
}
