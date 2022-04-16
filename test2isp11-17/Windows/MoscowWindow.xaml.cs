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
using System.Windows.Threading;

namespace test2isp11_17
{
    /// <summary>
    /// Логика взаимодействия для GemeStartWindow1.xaml
    /// </summary>
    public partial class GemeStartWindow1 : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        public GemeStartWindow1()
        {
            InitializeComponent();

            MusicPlayer();

            Text();
            timer.Start();

        }
        private void Text()
        {
            timer.Interval = new TimeSpan(0, 0, 0, 0, 40);// Определяем время для построения 50 мс
            timer.Tick += Timer_Tick;
        }


        int i = 0;
        char[] text = "    Москва — самый перспективный город. Город мечты, так многие говорят. И это правда. Тут можно добиться успехов, стать ячейкой общества. Четыре лучшие подруги, не разлей вода, дружили с самого детства. Они вместе пошли в школу, так же ее закончили. Они поддерживали друг друга, когда были проблемы. Они узнавали друг от друга всё, что творилось в их жизни, самыми первыми. Их так же отправили учиться в один город, в одно общежитие, жить в одной комнате, только профессии разные. Начался новый учебный год. ".ToCharArray();
        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                HistoryText.Text += text[i];
            }
            catch (IndexOutOfRangeException)
            {
                HistoryText.Text = "    Москва — самый перспективный город. Город мечты, так многие говорят. И это правда. Тут можно добиться успехов, стать ячейкой общества. Четыре лучшие подруги, не разлей вода, дружили с самого детства. Они вместе пошли в школу, так же ее закончили. Они поддерживали друг друга, когда были проблемы. Они узнавали друг от друга всё, что творилось в их жизни, самыми первыми. Их так же отправили учиться в один город, в одно общежитие, жить в одной комнате, только профессии разные. Начался новый учебный год. ";
                i = -1;
                timer.Stop();
            }
            i++;
        }

        private MediaPlayer player;
        private void MusicPlayer()
        {
            player = new MediaPlayer();
            player.Open(new Uri("..\\..\\Music\\City.WAV", UriKind.RelativeOrAbsolute));
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
