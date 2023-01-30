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
    /// Interaction logic for Page4.xaml
    /// </summary>
    public partial class Page4 : Page
    {

        MediaPlayer mplayer = new MediaPlayer();
        

        public Page4()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mplayer.Open(new Uri(@"../../naomas.mp3", UriKind.Relative));

            mplayer.Play();

            this.NavigationService.Navigate(new Congrats());

            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mplayer.Open(new Uri(@"../../socrates.mp3", UriKind.Relative));

            mplayer.Play();

            this.NavigationService.Navigate(new Congrats());

            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            mplayer.Open(new Uri(@"../../nao.mp3", UriKind.Relative));

            mplayer.Play();

            this.NavigationService.Navigate(new Congrats());

            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            
                mplayer.Open(new Uri(@"../../count0.mp3", UriKind.Relative));

                mplayer.Play();

                this.NavigationService.Navigate(new Congrats());
                
        }
    }
}
