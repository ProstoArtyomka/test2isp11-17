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
    /// Логика взаимодействия для EveningOfTheFirstDayWindow2.xaml
    /// </summary>
    public partial class EveningOfTheFirstDayWindow2 : Window
    {
        public EveningOfTheFirstDayWindow2()
        {
            InitializeComponent();

            MusicPlayer();

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
            RightImageBody.Opacity = 0;
            RightImageClothes.Opacity = 0;
            RightImageFace.Opacity = 0;
            RightImageBody2.Opacity = 1;
            RightImageClothes2.Opacity = 1;
            RightImageFace2.Opacity = 1;

        }
        DispatcherTimer timer = new DispatcherTimer();
        private void Text()
        {
            timer.Interval = new TimeSpan(0, 0, 0, 0, 40);
            timer.Tick += Timer_Tick;
        }

        int i = 0;
        char[] text = "    — Итак, девочки. Так как у вас восемь мест, а живете вы вчетвером, мы решили подселить к вам парней.".ToCharArray();
        char[] text1 = "    От такого заявления девочки пришли в полный аут.".ToCharArray();
        char[] text2 = "    —Но, Лариса. У всех девочки. Почему к нам этих свиней?".ToCharArray();
        char[] text3 = "    — Всё! Не хочу ничего слышать. Лариса ушла.".ToCharArray();
        char[] text4 = "    — Парни, ну вы даёте. Как я рада вас видеть. Алиса душит двух парней своими объятиями. Но они совсем не против.".ToCharArray();
        char[] text5 = "    —Извини, мы же не знали, что нас подселят сюда.".ToCharArray();
        char[] text6 = "    — Фил, Саш, а мы что-то не знаем? Арт и Влад с усмешкой смотрят на эту картину.".ToCharArray();
        char[] text7 = "    — Дураки? Она сестра наша, отвечает Саша, осматривая уже других девушек.".ToCharArray();
        char[] text8 = "    — А какого чёрта вы тут вообще делаете? - Спрашивает Ульяна. — Ой, а вы же новый преподаватель. Почему вы живёте со студентами? Ульяна продолжает прожигать взглядом нового преподавателя.".ToCharArray();
        char[] text9 = "    — Вот так я вам и сказал, скрещивая руки на груди сказал Влад.".ToCharArray();
        char[] text10 = "    — Какого чёрта вы тут устроили? Лена разводит руками, показывая на бардак, который устроили парни.".ToCharArray();
        char[] text11 = "    — А мы все уберём. Сразу сказал Арт, улыбаясь девушке.".ToCharArray();
        char[] text12 = "    — Не уберёте, я вам по башке метлой дам.".ToCharArray();
        char[] text13 = "    — Девочки, нам же в магазин надо промурчала Тася. Девочки быстро взяли пару сумок, кредитку, и убежали в магазин.".ToCharArray();
        char[] text14 = "    Парни между собой переглянулись. Медленно начиная уборку. Сначала они молчали, убирались. Но вскоре им это надоело. ".ToCharArray();
        char[] text15 = "    — Слушайте, не знал, что у вас есть сестра. -задумчиво сказал Влад. — И я не знал. Добавил Арт".ToCharArray();
        char[] text16 = "    — Об этом мало кто знает. Родители развелись, когда мы были мелкими. — Понятно, сказали парни.".ToCharArray();
        char[] text17 = "    Так и закончился первый день и тяжелое знакомство между ребятами.".ToCharArray();
        char[] text18 = "    — Итак, девочки. Так как у вас восемь мест, а живете вы вчетвером, мы решили подселить к вам парней.".ToCharArray();
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
            player.Open(new Uri("..\\..\\Music\\LadyLuck.WAV", UriKind.RelativeOrAbsolute));
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
        private void SoundPlay2()
        {
            sound = new MediaPlayer();
            sound.Open(new Uri("..\\..\\BackSound\\Sweep.WAV", UriKind.RelativeOrAbsolute));
            sound.Play();
            sound.Volume = 0.1;
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
                SoundPlay();
                RightImageBody2.Opacity = 0;
                RightImageClothes2.Opacity = 0;
                RightImageFace2.Opacity = 0;
                LeftImageBody.Opacity = 0;
                LeftImageClothes.Opacity = 0;
                LeftImageFace.Opacity = 0;
                CenterLeftImageBody.Opacity = 0;
                CenterLeftImageClothes.Opacity = 0;
                CenterLeftImageFace.Opacity = 0;
                CenterLeftImageBody2.Opacity = 1;
                CenterLeftImageClothes2.Opacity = 1;
                CenterLeftImageFace2.Opacity = 1;
                CenterRightImageBody.Opacity = 0;
                CenterRightImageClothes.Opacity = 0;
                CenterRightImageFace.Opacity = 0;
                CenterRightImageBody2.Opacity = 1;
                CenterRightImageClothes2.Opacity = 1;
                CenterRightImageFace2.Opacity = 1;
                RightImageClothes3.Opacity = 1;
                RightImageFace3.Opacity = 1;
                HistoryText.Text = " ";
                text = text4;
                timer.Start();
            }

            if (click == 5)
            {
                HistoryText.Text = " ";
                text = text5;
                timer.Start();
            }

            if (click == 6)
            {
                CenterLeftImageBody2.Opacity = 0;
                CenterLeftImageClothes2.Opacity = 0;
                CenterLeftImageFace2.Opacity = 0;
                CenterRightImageBody2.Opacity = 1;
                CenterRightImageClothes2.Opacity = 1;
                CenterRightImageFace2.Opacity = 1;
                RightImageClothes3.Opacity = 1;
                RightImageFace3.Opacity = 1;
                CenterLeftImageBody3.Opacity = 1;
                CenterLeftImageClothes3.Opacity = 1;
                CenterLeftImageFace3.Opacity = 1;
                LeftImageBody2.Opacity = 1;
                LeftImageClothes2.Opacity = 1;
                LeftImageFace2.Opacity = 1;
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
                LeftImageBody2.Opacity = 0;
                LeftImageClothes2.Opacity = 0;
                LeftImageFace2.Opacity = 0;
                CenterRightImageBody2.Opacity = 0;
                CenterRightImageClothes2.Opacity = 0;
                CenterRightImageFace2.Opacity = 0;
                RightImageBody3.Opacity = 0;
                RightImageClothes3.Opacity = 0;
                RightImageFace3.Opacity = 0;
                CenterRightImageBody3.Opacity = 1;
                CenterRightImageClothes3.Opacity = 1;
                CenterRightImageFace3.Opacity = 1;
                CenterLeftImageFace4.Opacity = 1;
                CenterLeftImageFace3.Opacity = 0;
                HistoryText.Text = " ";
                text = text8;
                timer.Start();
            }

            if (click == 9)
            {
                HistoryText.Text = " ";
                text = text9;
                timer.Start();
            }

            if (click == 10)
            {
                LeftImageBody2.Opacity = 1;
                LeftImageClothes2.Opacity = 1;
                LeftImageFace2.Opacity = 1;
                CenterRightImageBody3.Opacity = 0;
                CenterRightImageClothes3.Opacity = 0;
                CenterRightImageFace3.Opacity = 0;
                CenterLeftImageBody3.Opacity = 0;
                CenterLeftImageClothes3.Opacity = 0;
                CenterLeftImageFace4.Opacity = 0;
                CenterRightImageBody4.Opacity = 1;
                CenterRightImageClothes4.Opacity = 1;
                CenterRightImageFace4.Opacity = 1;
                HistoryText.Text = " ";
                text = text10;
                timer.Start();
            }

            if (click == 11)
            {
                HistoryText.Text = " ";
                text = text11;
                timer.Start();
            }

            if (click == 12)
            {
                HistoryText.Text = " ";
                text = text12;
                timer.Start();
            }

            if (click == 13)
            {
                LeftImageBody2.Opacity = 0;
                LeftImageClothes2.Opacity = 0;
                LeftImageFace2.Opacity = 0;
                CenterRightImageBody4.Opacity = 0;
                CenterRightImageClothes4.Opacity = 0;
                CenterRightImageFace4.Opacity = 0;
                CenterLeftImageBody.Opacity = 1;
                CenterLeftImageClothes.Opacity = 1;
                CenterLeftImageFace5.Opacity = 1;
                HistoryText.Text = " ";
                text = text13;
                timer.Start();
            }

            if (click == 14)
            {
                CenterLeftImageBody.Opacity = 0;
                CenterLeftImageClothes.Opacity = 0;
                CenterLeftImageFace5.Opacity = 0;
                LeftImageBody2.Opacity = 1;
                LeftImageClothes2.Opacity = 1;
                LeftImageFace3.Opacity = 1;
                CenterLeftImageBody3.Opacity = 1;
                CenterLeftImageClothes3.Opacity = 1;
                CenterLeftImageFace4.Opacity = 1;
                CenterRightImageBody2.Opacity = 1;
                CenterRightImageClothes2.Opacity = 1;
                CenterRightImageFace5.Opacity = 1;
                RightImageBody3.Opacity = 1;
                RightImageClothes3.Opacity = 1;
                RightImageFace4.Opacity = 1;
                SoundPlay();
                SoundPlay2();
                HistoryText.Text = " ";
                text = text14;
                timer.Start();
            }

            if (click == 15)
            {
                sound.Stop();
                HistoryText.Text = " ";
                text = text15;
                timer.Start();
            }

            if (click == 16)
            {
                HistoryText.Text = " ";
                text = text16;
                timer.Start();
            }

            if (click == 17)
            {
                LeftImageBody2.Opacity = 0;
                LeftImageClothes2.Opacity = 0;
                LeftImageFace3.Opacity = 0;
                CenterLeftImageBody3.Opacity = 0;
                CenterLeftImageClothes3.Opacity = 0;
                CenterLeftImageFace4.Opacity = 0;
                CenterRightImageBody2.Opacity = 0;
                CenterRightImageClothes2.Opacity = 0;
                CenterRightImageFace5.Opacity = 0;
                RightImageBody3.Opacity = 0;
                RightImageClothes3.Opacity = 0;
                RightImageFace4.Opacity = 0;
                MainBackground.Opacity = 0;
                HistoryText.Text = " ";
                text = text17;
                timer.Start();
            }

            if (click == 18)
            {
                player.Stop();
                FinalWindow openwindow = new FinalWindow();
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
                text = text18;
                timer.Start();
            }

            if (click == 1)
            {
                HistoryText.Text = " ";
                text = text1;
                timer.Start();
            }

            if (click == 2)
            {
                HistoryText.Text = " ";
                text = text2;
                timer.Start();
            }

            if (click == 3)
            {
                RightImageBody2.Opacity = 1;
                RightImageClothes2.Opacity = 1;
                RightImageFace2.Opacity = 1;
                LeftImageBody.Opacity = 1;
                LeftImageClothes.Opacity = 1;
                LeftImageFace.Opacity = 1;
                CenterLeftImageBody.Opacity = 1;
                CenterLeftImageClothes.Opacity = 1;
                CenterLeftImageFace.Opacity = 1;
                CenterLeftImageBody2.Opacity = 0;
                CenterLeftImageClothes2.Opacity = 0;
                CenterLeftImageFace2.Opacity = 0;
                CenterRightImageBody.Opacity = 1;
                CenterRightImageClothes.Opacity = 1;
                CenterRightImageFace.Opacity = 1;
                CenterRightImageBody2.Opacity = 0;
                CenterRightImageClothes2.Opacity = 0;
                CenterRightImageFace2.Opacity = 0;
                RightImageClothes3.Opacity = 0;
                RightImageFace3.Opacity = 0;
                HistoryText.Text = " ";
                text = text3;
                SoundPlay();
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
                CenterLeftImageBody2.Opacity = 1;
                CenterLeftImageClothes2.Opacity = 1;
                CenterLeftImageFace2.Opacity = 1;
                CenterRightImageBody2.Opacity = 1;
                CenterRightImageClothes2.Opacity = 1;
                CenterRightImageFace2.Opacity = 1;
                RightImageClothes3.Opacity = 1;
                RightImageFace3.Opacity = 1;
                CenterLeftImageBody3.Opacity = 0;
                CenterLeftImageClothes3.Opacity = 0;
                CenterLeftImageFace3.Opacity = 0;
                LeftImageBody2.Opacity = 0;
                LeftImageClothes2.Opacity = 0;
                LeftImageFace2.Opacity = 0;
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

            if (click == 7)
            {
                LeftImageBody2.Opacity = 1;
                LeftImageClothes2.Opacity = 1;
                LeftImageFace2.Opacity = 1;
                CenterRightImageBody2.Opacity = 1;
                CenterRightImageClothes2.Opacity = 1;
                CenterRightImageFace2.Opacity = 1;
                RightImageBody3.Opacity = 1;
                RightImageClothes3.Opacity = 1;
                RightImageFace3.Opacity = 1;
                CenterRightImageBody3.Opacity = 0;
                CenterRightImageClothes3.Opacity = 0;
                CenterRightImageFace3.Opacity = 0;
                CenterLeftImageFace4.Opacity = 0;
                CenterLeftImageFace3.Opacity = 1;
                HistoryText.Text = " ";
                text = text7;
                timer.Start();
            }

            if (click == 8)
            {
                HistoryText.Text = " ";
                text = text8;
                timer.Start();
            }

            if (click == 9)
            {
                LeftImageBody2.Opacity = 0;
                LeftImageClothes2.Opacity = 0;
                LeftImageFace2.Opacity = 0;
                CenterRightImageBody3.Opacity = 1;
                CenterRightImageClothes3.Opacity = 1;
                CenterRightImageFace3.Opacity = 1;
                CenterLeftImageBody3.Opacity = 1;
                CenterLeftImageClothes3.Opacity = 1;
                CenterLeftImageFace4.Opacity = 1;
                CenterRightImageBody4.Opacity = 0;
                CenterRightImageClothes4.Opacity = 0;
                CenterRightImageFace4.Opacity = 0;
                HistoryText.Text = " ";
                text = text9;
                timer.Start();
            }

            if (click == 10)
            {
                HistoryText.Text = " ";
                text = text10;
                timer.Start();
            }

            if (click == 11)
            {
                HistoryText.Text = " ";
                text = text11;
                timer.Start();
            }

            if (click == 12)
            {
                LeftImageBody2.Opacity = 1;
                LeftImageClothes2.Opacity = 1;
                LeftImageFace2.Opacity = 1;
                CenterRightImageBody4.Opacity = 1;
                CenterRightImageClothes4.Opacity = 1;
                CenterRightImageFace4.Opacity = 1;
                CenterLeftImageBody.Opacity = 0;
                CenterLeftImageClothes.Opacity = 0;
                CenterLeftImageFace5.Opacity = 0;
                HistoryText.Text = " ";
                text = text12;
                timer.Start();
            }

            if (click == 13)
            {
                CenterLeftImageBody.Opacity = 1;
                CenterLeftImageClothes.Opacity = 1;
                CenterLeftImageFace5.Opacity = 1;
                LeftImageBody2.Opacity = 0;
                LeftImageClothes2.Opacity = 0;
                LeftImageFace3.Opacity = 0;
                CenterLeftImageBody3.Opacity = 0;
                CenterLeftImageClothes3.Opacity = 0;
                CenterLeftImageFace4.Opacity = 0;
                CenterRightImageBody2.Opacity = 0;
                CenterRightImageClothes2.Opacity = 0;
                CenterRightImageFace5.Opacity = 0;
                RightImageBody3.Opacity = 0;
                RightImageClothes3.Opacity = 0;
                RightImageFace4.Opacity = 0;
                HistoryText.Text = " ";
                sound.Stop();
                text = text13;
                timer.Start();
            }

            if (click == 14)
            {
                SoundPlay();
                SoundPlay2();
                HistoryText.Text = " ";
                text = text14;
                timer.Start();
            }

            if (click == 15)
            {
                sound.Stop();
                HistoryText.Text = " ";
                text = text15;
                timer.Start();
            }

            if (click == 16)
            {
                LeftImageBody2.Opacity = 1;
                LeftImageClothes2.Opacity = 1;
                LeftImageFace3.Opacity = 1;
                CenterLeftImageBody3.Opacity = 1;
                CenterLeftImageClothes3.Opacity = 1;
                CenterLeftImageFace4.Opacity = 1;
                CenterRightImageBody2.Opacity = 1;
                CenterRightImageClothes2.Opacity = 1;
                CenterRightImageFace5.Opacity = 1;
                RightImageBody3.Opacity = 1;
                RightImageClothes3.Opacity = 1;
                RightImageFace4.Opacity = 1;
                MainBackground.Opacity = 1;
                HistoryText.Text = " ";
                text = text16;
                timer.Start();
            }

            if (click == -1)
            {
                player.Stop();
                OpenArtyomWindow opemwindow = new OpenArtyomWindow();
                opemwindow.Show();
                this.Close();
            }
        }
    }
}