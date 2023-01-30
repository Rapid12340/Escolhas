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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projeto_P2
{
    /// <summary>
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        MediaPlayer mplayer = new MediaPlayer();

        public Page3()
        {
            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mplayer.Open(new Uri(@"../../13.mp3", UriKind.Relative));

            mplayer.Play();

            this.NavigationService.Navigate(new Boa_2());


        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {



            mplayer.Open(new Uri(@"../../Roxo2.mp3", UriKind.Relative));

            mplayer.Play();

            this.NavigationService.Navigate(new Counter_2());


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mplayer.Open(new Uri(@"../../14.mp3", UriKind.Relative));

            mplayer.Play();

            this.NavigationService.Navigate(new Perto_2());



        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            mplayer.Open(new Uri(@"../../4.mp3", UriKind.Relative));

            mplayer.Play();

            this.NavigationService.Navigate(new Eh_2());


        }
    }
}
