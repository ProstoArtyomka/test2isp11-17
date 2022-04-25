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

            //Вывод песен
            MusicPlayer();

            //Вывод текста
            Text();

            //Активация Таймера
            timer.Start();

        }
        //Название таймера
        DispatcherTimer timer = new DispatcherTimer();
        private void Text()
        {
            //Время вывода одного символа
            timer.Interval = new TimeSpan(0, 0, 0, 0, 40);
            timer.Tick += Timer_Tick;
        }

        int i = 0;
        //Заготовки текста
        char[] text = "    Время подходило к семи утра. Всем девушкам пора уже вставать, идти на учёбу. Но они похоже даже не думают об этом. Слишком уж вчерашняя вечеринка на них повлияла. Девочки до такой степени вчера отжигали до четырёх часов утра, так сказать, прощались с летом, что сейчас даже проснуться не могут. Но настырный будильник совершенно не жалел девчонок.".ToCharArray();
        char[] text1 = "    Первой это надоело Тасе. Она начала будить других девочек. Алиса быстро забегает в ванную комнату, захлопывая дверь перед Ульяниным носом.".ToCharArray();
        char[] text2 = "    Дура! - вскрикивает рыжая девушка вслед подруге.".ToCharArray();
        char[] text3 = "    После слов послышалось журчание воды. Ульяна не стала стоять возле двери, девушка пошла на кухню. Кухня была совмещена вместе с залом. С левой стороны была комната девочек.".ToCharArray();
        char[] text4 = "    На кухне уже стояла Лена. Блондинка зевала, делая всем кофе. Всё же сегодня ее очередь этим заниматься. Ульяна плюхнулась на стул, так же сонно зевая. Вскоре появилась Тася, так же садясь рядом. Три девушки пили кофе, совсем забыв о времени.".ToCharArray();
        char[] text5 = "    Через какое-то время девушки уже были готовы к выходу. Алиса училась на дизайнера. Лена училась на зубного врача. Тася пошла на ветеринара. Ульяна на журналиста. Алиса из любой тряпки могла сделать классную вещь. Лена же любила мучить людей. Тася обожала животных, да и многое про них знала. А Ульяна могла вытащить любую информацию.".ToCharArray();
        char[] text6 = "    Время подходило к семи утра. Всем девушкам пора уже вставать, идти на учёбу. Но они похоже даже не думают об этом. Слишком уж вчерашняя вечеринка на них повлияла. Девочки до такой степени вчера отжигали до четырёх часов утра, так сказать, прощались с летом, что сейчас даже проснуться не могут. Но настырный будильник совершенно не жалел девчонок.".ToCharArray();
        
        //Метод построчного вывода текста
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
        //Название медиаплеера
        private MediaPlayer player;
        private MediaPlayer sound;

        //Музыкальный метод плеера
        private void MusicPlayer()
        {
            player = new MediaPlayer();
            player.Open(new Uri("..\\..\\Music\\HideAndSeek.WAV", UriKind.RelativeOrAbsolute));
            player.MediaEnded += new EventHandler(Media_Ended);
            player.Play();
            player.Volume = 0.1;
        }
        //Звуковой метод плеера 1
        private void SoundPlay()
        {
            sound = new MediaPlayer();
            sound.Open(new Uri("..\\..\\BackSound\\AlarmСlock.WAV", UriKind.RelativeOrAbsolute));
            sound.Play();
            sound.Volume = 0.3;
        }
        //Звуковой метод плеера 2
        private void SoundPlay2()
        {
            sound = new MediaPlayer();
            sound.Open(new Uri("..\\..\\BackSound\\Door.WAV", UriKind.RelativeOrAbsolute));
            sound.Play();
            sound.Volume = 0.3;
        }
        //Метод зацикливания песни
        private void Media_Ended(object sender, EventArgs e)
        {
            player.Position = TimeSpan.Zero;
            player.Play();
            player.Volume = 0.1;
        }
        int click = 0;
        //Кнопка перехода вперед
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
                MainBackground.Opacity = 0;
                HistoryText.Text = " ";
                text = text3;
                timer.Start();
            }

            if (click == 4)
            {
                CenterRightImageFace.Opacity = 0;
                CenterRightImageFace2.Opacity = 1;
                LeftImageBody.Opacity = 1;
                LeftImageClothes.Opacity = 1;
                LeftImageFace.Opacity = 1;
                CenterLeftImageBody.Opacity = 1;
                CenterLeftImageClothes.Opacity = 1;
                CenterLeftImageFace.Opacity = 1;
                HistoryText.Text = " ";
                text = text4;
                timer.Start();
            }

            if (click == 5)
            {
                CenterLeftImageClothes2.Opacity = 1;
                CenterLeftImageClothes.Opacity = 0;
                CenterLeftImageBody.Opacity = 0;
                LeftImageClothes.Opacity = 0;
                LeftImageClothes2.Opacity = 1;
                RightImageBody.Opacity = 1;
                RightImageClothes.Opacity = 1;
                RightImageFace.Opacity = 1;
                CenterRightImageBody.Opacity = 0;
                CenterRightImageBody2.Opacity = 1;
                CenterRightImageClothes.Opacity = 0;
                CenterRightImageClothes2.Opacity = 1;
                CenterRightImageFace2.Opacity = 0;
                CenterRightImageFace3.Opacity = 1;
                HistoryText.Text = " ";
                text = text5;
                timer.Start();
            }


            if (click == 6)
            {
                player.Stop();
                GemeStartWindow7 openwindow = new GemeStartWindow7();
                openwindow.Show();
                this.Close();
            }

        }

        //Кнопка перехода Назад
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            click--;
            if (click == 0)
            {
                HistoryText.Text = " ";
                text = text6;
                timer.Start();
            }

            if (click == 1)
            {
                CenterRightImageBody.Opacity = 0;
                CenterRightImageClothes.Opacity = 0;
                CenterRightImageFace.Opacity = 0;
                SoundPlay();
                HistoryText.Text = " ";
                text = text1;
                timer.Start();
            }

            if (click == 2)
            {
                MainBackground.Opacity = 1;
                HistoryText.Text = " ";
                SoundPlay2();
                text = text2;
                timer.Start();
            }

            if (click == 3)
            {
                CenterRightImageFace.Opacity = 1;
                CenterRightImageFace2.Opacity = 0;
                LeftImageBody.Opacity = 0;
                LeftImageClothes.Opacity = 0;
                LeftImageFace.Opacity = 0;
                CenterLeftImageBody.Opacity = 0;
                CenterLeftImageClothes.Opacity = 0;
                CenterLeftImageFace.Opacity = 0;
                HistoryText.Text = " ";
                text = text3;
                timer.Start();
            }

            if (click == 4)
            {
                CenterLeftImageClothes2.Opacity = 0;
                CenterLeftImageClothes.Opacity = 1;
                CenterLeftImageBody.Opacity = 1;
                LeftImageClothes.Opacity = 1;
                LeftImageClothes2.Opacity = 0;
                RightImageBody.Opacity = 0;
                RightImageClothes.Opacity = 0;
                RightImageFace.Opacity = 0;
                CenterRightImageBody.Opacity = 1;
                CenterRightImageBody2.Opacity = 0;
                CenterRightImageClothes.Opacity = 1;
                CenterRightImageClothes2.Opacity = 0;
                CenterRightImageFace2.Opacity = 1;
                CenterRightImageFace3.Opacity = 0;
                HistoryText.Text = " ";
                text = text4;
                timer.Start();
            }


            if (click == -1)
            {
                player.Stop();
                GemeStartWindow5 opemwindow = new GemeStartWindow5();
                opemwindow.Show();
                this.Close();
            }
        }
    }
}
