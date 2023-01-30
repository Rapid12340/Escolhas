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
    /// Interaction logic for Counter_2.xaml
    /// </summary>
    public partial class Counter_2 : Page
    {
        
        MediaPlayer mplayer = new MediaPlayer();

        public Counter_2()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            mplayer.Open(new Uri(@"../../3.mp3", UriKind.Relative));

            mplayer.Play();

            this.NavigationService.Navigate(new Page4());
        }
    }
}
