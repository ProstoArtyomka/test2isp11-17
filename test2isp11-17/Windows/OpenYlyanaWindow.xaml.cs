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

namespace test2isp11_17
{
    /// <summary>
    /// Логика взаимодействия для GemeStartWindow4.xaml
    /// </summary>
    public partial class GemeStartWindow4 : Window
    {
        public GemeStartWindow4()
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
        char[] text = "    Вторая красавица являлась самой яркой из них - Рыжова Ульяна. Девушка с детства была непоседой, душа компании. Всегда весёлая, добрая. Иногда слишком даже надоедливая. Её оптимизм не давал никому грустить, она словно лучик солнца. Рыжие волосы придавали ей более детский вид. Маленький аккуратный носик, тонкие губки.".ToCharArray();
        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                HistoryText.Text += text[i];
            }
            catch (IndexOutOfRangeException)
            {
                HistoryText.Text = "    Вторая красавица являлась самой яркой из них - Рыжова Ульяна. Девушка с детства была непоседой, душа компании. Всегда весёлая, добрая. Иногда слишком даже надоедливая. Её оптимизм не давал никому грустить, она словно лучик солнца. Рыжие волосы придавали ей более детский вид. Маленький аккуратный носик, тонкие губки.";
                i = -1;
                timer.Stop();
            }
            i++;
        }

        private MediaPlayer player;
        private void MusicPlayer()
        {
            player = new MediaPlayer();
            player.Open(new Uri("..\\..\\Music\\Ylyana.WAV", UriKind.RelativeOrAbsolute));
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
            GemeStartWindow3 openwindow1 = new GemeStartWindow3();
            openwindow1.Show();
            this.Close();
        }
    }
}
