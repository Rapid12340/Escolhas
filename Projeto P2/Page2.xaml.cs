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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        MediaPlayer mplayer = new MediaPlayer();
        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mplayer.Open(new Uri(@"../../Azul.mp3", UriKind.Relative));

            mplayer.Play();

            this.NavigationService.Navigate(new Counter_1());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mplayer.Open(new Uri(@"../../Vermelho.mp3", UriKind.Relative));

            mplayer.Play();

            this.NavigationService.Navigate(new Eh_1());

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mplayer.Open(new Uri(@"../../Tangerina.mp3", UriKind.Relative));

            mplayer.Play();

            this.NavigationService.Navigate(new Perto_1());


        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            mplayer.Open(new Uri(@"../../Laranja.mp3", UriKind.Relative));

            mplayer.Play();

            this.NavigationService.Navigate(new Boa());


        }
    }
}
