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
    /// Логика взаимодействия для OpenArtyomWindow.xaml
    /// </summary>
    public partial class OpenArtyomWindow : Window
    {
        public OpenArtyomWindow()
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
        char[] text = "    Артём, данный персонаж считается самым странным и подозрительным человеком в данной истории. По характеру он был молчаливым, закрытым от разговоров с другими людьми, имел самые странные взгляды на жизнь и любил бесить своей тупостью других людей, с которыми он общался.".ToCharArray();
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
        private void MusicPlayer()
        {
            player = new MediaPlayer();
            player.Open(new Uri("..\\..\\Music\\Artyom.WAV", UriKind.RelativeOrAbsolute));
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
            EveningOfTheFirstDayWindow2 openwindow = new EveningOfTheFirstDayWindow2();
            openwindow.Show();
            this.Close();
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            OpenSashaAndPhilWindow openwindow = new OpenSashaAndPhilWindow();
            openwindow.Show();
            this.Close();
        }
    }
}
