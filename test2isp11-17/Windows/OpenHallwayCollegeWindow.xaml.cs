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
    /// Логика взаимодействия для GemeStartWindow7.xaml
    /// </summary>
    public partial class GemeStartWindow7 : Window
    {
        public GemeStartWindow7()
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
        char[] text = "    Ульяна шла на пары. Девушка весело перебирала ногами, даже не смотря куда идет. Найдя нужный кабинет, она зашла туда. Резко остановившись, девушка на секунду подумала, что зашла вовсе не туда. Но нет, это была её группа. Только преподаватель другой. Девушка начала осматривать его. Темно-синие волосы, как море. Острые скулы. Легкая щетина украшала парня.".ToCharArray();
        char[] text1 = "    — Девушка, вы кабинетом ошиблись?".ToCharArray();
        char[] text2 = "    Молодой преподаватель помахал перед её лицом ладонью. Ульяна тут же опомнилась, поняв, что она пялится на парня.".ToCharArray();
        char[] text3 = "    — Да нет. А вы собственно кто? Не первый раз уже задают такой вопрос.".ToCharArray();
        char[] text4 = "    — Садись, расскажу.".ToCharArray();
        char[] text5 = "    Девушка тут же кивнула. Все начали садиться на свои места. День на события вышел не особо красочным, так как был первый день. Так у девочек прошёл день в институте.".ToCharArray();
        char[] text6 = "    Ульяна шла на пары. Девушка весело перебирала ногами, даже не смотря куда идет. Найдя нужный кабинет, она зашла туда. Резко остановившись, девушка на секунду подумала, что зашла вовсе не туда. Но нет, это была её группа. Только преподаватель другой. Девушка начала осматривать его. Темно-синие волосы, как море. Острые скулы. Легкая щетина украшала парня.".ToCharArray();
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
            player.Open(new Uri("..\\..\\Music\\AlleyCat.WAV", UriKind.RelativeOrAbsolute));
            player.MediaEnded += new EventHandler(Media_Ended);
            player.Play();
            player.Volume = 0.1;
        }
        private void SoundPlay()
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
                CenterLeftImageBody.Opacity = 1;
                CenterLeftImageClothes.Opacity = 1;
                CenterLeftImageFace.Opacity = 1;
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
                HistoryText.Text = " ";
                text = text2;
                timer.Start();
            }

            if (click == 3)
            {
                CenterLeftImageFace.Opacity = 0;
                CenterLeftImageFace2.Opacity = 1;
                HistoryText.Text = " ";  
                text = text3;
                timer.Start();
            }

            if (click == 4)
            {

                HistoryText.Text = " ";
                text = text4;
                timer.Start();
            }

            if (click == 5)
            {
                CenterLeftImageFace.Opacity = 1;
                CenterLeftImageFace2.Opacity = 0;
                HistoryText.Text = " ";
                text = text5;
                timer.Start();
            }


            if (click == 6)
            {
                player.Stop();
                EveningOfTheFirstDayWindow openwindow = new EveningOfTheFirstDayWindow();
                openwindow.Show();
                this.Close();
            }

        }
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            click--;
            if (click == 0)
            {
                CenterLeftImageBody.Opacity = 0;
                CenterLeftImageClothes.Opacity = 0;
                CenterLeftImageFace.Opacity = 0;
                HistoryText.Text = " ";
                text = text6;
                timer.Start();
            }

            if (click == 1)
            {
                CenterRightImageBody.Opacity = 0;
                CenterRightImageClothes.Opacity = 0;
                CenterRightImageFace.Opacity = 0;
                HistoryText.Text = " ";
                SoundPlay();
                text = text1;
                timer.Start();
            }

            if (click == 2)
            {
                CenterLeftImageFace.Opacity = 1;
                CenterLeftImageFace2.Opacity = 0;
                HistoryText.Text = " ";
                text = text2;
                timer.Start();
            }

            if (click == 3)
            {

                HistoryText.Text = " ";
                text = text3;
                timer.Start();
            }

            if (click == 4)
            {
                CenterLeftImageFace.Opacity = 0;
                CenterLeftImageFace2.Opacity = 1;
                HistoryText.Text = " ";
                text = text4;
                timer.Start();
            }


            if (click == -1)
            {
                player.Stop();
                Apartment opemwindow = new Apartment();
                opemwindow.Show();
                this.Close();
            }
        }
    }
}

