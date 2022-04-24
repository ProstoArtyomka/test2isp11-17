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
    /// Логика взаимодействия для OpenSashaAndPhilWindow.xaml
    /// </summary>
    public partial class OpenSashaAndPhilWindow : Window
    {
        public OpenSashaAndPhilWindow()
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
        char[] text = "    Саша и Фил, два брата-акробата, оба блондины, почти одинаковые черты лица. Так же оба голубоглазые. У них есть старшая сестра Алиса, с которой они особо не в ладах. По характеру они оба были спокойны как удавы, имели внешность как у Playboy моделей мужского рода.".ToCharArray();
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
            player.Open(new Uri("..\\..\\Music\\SashaAndPhil.WAV", UriKind.RelativeOrAbsolute));
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
            OpenVladWindow openwindow = new OpenVladWindow();
            openwindow.Show();
            this.Close();
        }
    }
}
