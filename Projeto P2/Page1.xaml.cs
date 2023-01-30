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
using Microsoft.Win32;

namespace Projeto_P2
{
    public partial class Page1 : Page
    {

        public Page1()
        {
            InitializeComponent();
            mplayer.Open(new Uri(@"../../CF.mp3", UriKind.Relative));

            mplayer.Play();
        }

        MediaPlayer mplayer = new MediaPlayer();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            

            mplayer.Open(new Uri(@"../../1.mp3", UriKind.Relative));

            mplayer.Play();

            this.NavigationService.Navigate(new Page2());
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}

	
