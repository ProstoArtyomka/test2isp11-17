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

namespace test2isp11_17.Windows
{
    /// <summary>
    /// Логика взаимодействия для EveningOfTheFirstDayWindow.xaml
    /// </summary>
    public partial class EveningOfTheFirstDayWindow : Window
    {
        public EveningOfTheFirstDayWindow()
        {
            InitializeComponent();

            MusicPlayer();

            SoundPlay();

            Text();

            timer.Start();

            LeftImageBody.Opacity = 1;
            LeftImageClothes.Opacity = 1;
            LeftImageFace.Opacity = 1;
            CenterLeftImageBody.Opacity = 1;
            CenterLeftImageClothes.Opacity = 1;
            CenterLeftImageFace.Opacity = 1;
            CenterRightImageBody.Opacity = 1;
            CenterRightImageClothes.Opacity = 1;
            CenterRightImageFace.Opacity = 1;
            RightImageBody.Opacity = 1;
            RightImageClothes.Opacity = 1;
            RightImageFace.Opacity = 1;

        }
        DispatcherTimer timer = new DispatcherTimer();
        private void Text()
        {
            timer.Interval = new TimeSpan(0, 0, 0, 0, 40);
            timer.Tick += Timer_Tick;
        }

        int i = 0;
        char[] text = "    Ульяна первая зашла в комнату, а за ней все остальные. Тут же девочки замерли в шоке. По всему залу валялись вещи, они были мужскими. На столе лежали пустые коробки.".ToCharArray();
        char[] text1 = "    — Может нас грабят?  Ульяне показалось это самым логичным решением.".ToCharArray();
        char[] text2 = "    Но девушки даже обдумать это не успели, как дверь сзади них открылись. Зашла комендантша Лариса. А вслед за ней ещё два парня, которые занесли четыре матраса.".ToCharArray();
        char[] text3 = "    В этот момент из спальни вышли четыре парня.".ToCharArray();
        char[] text4 = "    Один из них был уже знаком, он являлся Владом.".ToCharArray();
        char[] text5 = "    Следом вышли еще два парня, оба блондины, почти одинаковые черты лица. Так же оба голубоглазые. ".ToCharArray();
        char[] text6 = "    Самый последний вышел темноволосый с ярко-синими карими глазами, с очаровательной улыбкой.".ToCharArray();
        char[] text7 = "    Четыре парня словно с обложки модного журнала. Обе стороны замерли, смотря друг на друга.".ToCharArray();
        char[] text8 = "    Ульяна первая зашла в комнату, а за ней все остальные. Тут же девочки замерли в шоке. По всему залу валялись вещи, они были мужскими. На столе лежали пустые коробки.".ToCharArray();
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
            player.Open(new Uri("..\\..\\Music\\Sleep.WAV", UriKind.RelativeOrAbsolute));
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
                HistoryText.Text = " ";
                text = text1;
                timer.Start();
            }

            if (click == 2)
            {
                HistoryText.Text = " ";
                SoundPlay();
                text = text2;
                timer.Start();
            }

            if (click == 3)
            {
                RightImageFace2.Opacity = 1;
                RightImageFace.Opacity = 0;
                HistoryText.Text = " ";
                text = text3;
                timer.Start();
            }

            if (click == 4)
            {
                LeftImageBody.Opacity = 0;
                LeftImageClothes.Opacity = 0;
                LeftImageFace.Opacity = 0;
                CenterLeftImageBody.Opacity = 0;
                CenterLeftImageClothes.Opacity = 0;
                CenterLeftImageFace.Opacity = 0;
                CenterRightImageBody.Opacity = 0;
                CenterRightImageClothes.Opacity = 0;
                CenterRightImageFace.Opacity = 0;
                RightImageBody.Opacity = 0;
                RightImageClothes.Opacity = 0;
                RightImageFace2.Opacity = 0;

                LeftImageBody2.Opacity = 1;
                LeftImageClothes2.Opacity = 1;
                LeftImageFace2.Opacity = 1;

                HistoryText.Text = " ";
                text = text4;
                timer.Start();
            }

            if (click == 5)
            {
                CenterLeftImageBody2.Opacity = 1;
                CenterLeftImageClothes2.Opacity = 1;
                CenterLeftImageFace2.Opacity = 1;
                CenterRightImageClothes2.Opacity = 1;
                CenterRightImageFace2.Opacity = 1;
                HistoryText.Text = " ";
                text = text5;
                timer.Start();
            }

            if (click == 6)
            {
                RightImageBody2.Opacity = 1;
                RightImageClothes2.Opacity = 1;
                RightImageFace3.Opacity = 1;
                HistoryText.Text = " ";
                text = text6;
                timer.Start();
            }

            if (click == 7)
            {
                HistoryText.Text = " ";
                text = text7;
                timer.Start();
            }

            if (click == 8)
            {
                player.Stop();
                OpenVladWindow openwindow = new OpenVladWindow();
                openwindow.Show();
                this.Close();
            }

        }
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            click--;
            if (click == 0)
            {
                HistoryText.Text = " ";
                text = text8;
                timer.Start();
            }

            if (click == 1)
            {
                HistoryText.Text = " ";
                SoundPlay();
                text = text1;
                timer.Start();
            }

            if (click == 2)
            {
                RightImageFace2.Opacity = 1;
                RightImageFace.Opacity = 0;
                HistoryText.Text = " ";
                text = text2;
                timer.Start();
            }

            if (click == 3)
            {
                LeftImageBody.Opacity = 0;
                LeftImageClothes.Opacity = 0;
                LeftImageFace.Opacity = 0;
                CenterLeftImageBody.Opacity = 0;
                CenterLeftImageClothes.Opacity = 0;
                CenterLeftImageFace.Opacity = 0;
                CenterRightImageBody.Opacity = 0;
                CenterRightImageClothes.Opacity = 0;
                CenterRightImageFace.Opacity = 0;
                RightImageBody.Opacity = 0;
                RightImageClothes.Opacity = 0;
                RightImageFace2.Opacity = 0;

                LeftImageBody2.Opacity = 1;
                LeftImageClothes2.Opacity = 1;
                LeftImageFace2.Opacity = 1;

                HistoryText.Text = " ";
                text = text3;
                timer.Start();
            }

            if (click == 4)
            {
                CenterLeftImageBody2.Opacity = 1;
                CenterLeftImageClothes2.Opacity = 1;
                CenterLeftImageFace2.Opacity = 1;
                CenterRightImageClothes2.Opacity = 1;
                CenterRightImageFace2.Opacity = 1;
                HistoryText.Text = " ";
                text = text4;
                timer.Start();
            }

            if (click == 5)
            {
                RightImageBody2.Opacity = 1;
                RightImageClothes2.Opacity = 1;
                RightImageFace3.Opacity = 1;
                HistoryText.Text = " ";
                text = text5;
                timer.Start();
            }

            if (click == 6)
            {
                HistoryText.Text = " ";
                text = text6;
                timer.Start();
            }

            if (click == -1)
            {
                player.Stop();
                GemeStartWindow7 opemwindow = new GemeStartWindow7();
                opemwindow.Show();
                this.Close();
            }

        }
    }
}

