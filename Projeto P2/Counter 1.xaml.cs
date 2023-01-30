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
    /// Interaction logic for Counter_1.xaml
    /// </summary>
    public partial class Counter_1 : Page
    {
        
        MediaPlayer mplayer = new MediaPlayer();

        public Counter_1()
        {
            InitializeComponent();
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                mplayer.Open(new Uri(@"../../2.mp3", UriKind.Relative));

                mplayer.Play();

                this.NavigationService.Navigate(new Page3());
            
        }
    }
}
