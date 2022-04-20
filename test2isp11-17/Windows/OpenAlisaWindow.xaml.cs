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
    /// Логика взаимодействия для GemeStartWindow3.xaml
    /// </summary>
    public partial class GemeStartWindow3 : Window
    {
        public GemeStartWindow3()
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
        char[] text = "    Первая из четырех красавиц была Коршунова Алиса. Девушка сама по себе была со сложным характером. Её дар бесить всё и всех. Девушка активно этим пользовалась. Ей нравилось ругаться со всеми и выигрывать, показывая, что она лучшая. Что по внешности — девушка то она не была на вид стервой, само воплощение доброты. Прическа у нее были сделаны в виде двух пучков, они были покрашены в фиолетовый цвет. Тонкий носик, пухлые губки, нежная улыбка.".ToCharArray();
        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                HistoryText.Text += text[i];
            }
            catch (IndexOutOfRangeException)
            {
                HistoryText.Text = "    Первая из четырех красавиц была Коршунова Алиса. Девушка сама по себе была со сложным характером. Её дар бесить всё и всех. Девушка активно этим пользовалась. Ей нравилось ругаться со всеми и выигрывать, показывая, что она лучшая. Что по внешности — девушка то она не была на вид стервой, само воплощение доброты. Прическа у нее были сделаны в виде двух пучков, они были покрашены в фиолетовый цвет. Тонкий носик, пухлые губки, нежная улыбка.";
                i = -1;
                timer.Stop();
            }
            i++;
        }

        private MediaPlayer player;
        private void MusicPlayer()
        {
            player = new MediaPlayer();
            player.Open(new Uri("..\\..\\Music\\Alisa.WAV", UriKind.RelativeOrAbsolute));
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
            GemeStartWindow4 openwindow = new GemeStartWindow4();
            openwindow.Show();
            this.Close();
        }
        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            player.Stop();
            GemeStartWindow1 openwindow1 = new GemeStartWindow1();
            openwindow1.Show();
            this.Close();
        }
    }
}
