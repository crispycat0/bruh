using System.Media;
using System.Windows;

namespace Bruh {
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();

            new SoundPlayer("/Bruh;component/bruh.mp3").Play();  
        }
    }
}
