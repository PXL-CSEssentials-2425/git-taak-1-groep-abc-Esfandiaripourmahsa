using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GitTaak
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Red;
        }

        private void Image_MouseLeave(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void Image_MouseEnter_1(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Yellow;
        }

        private void Image_MouseLeave_1(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;

        }

        private void Image_MouseEnter_2(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Green;
        }

        private void Image_MouseLeave_2(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void Image_MouseEnter_3(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.Blue;
        }

        private void Image_MouseLeave_3(object sender, MouseEventArgs e)
        {
            mainWindow.Background = Brushes.LightGray;
        }

        private void rood_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorCode.Text = " #FF0000"; // Rood
            informatieCode.Text = "Rood is de kleur van warmte";

        }

        private void geel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorCode.Text = " #FFFF00"; // Geel
            informatieCode.Text = "Geel is de kleur van levenslust";
        }

        private void groen_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorCode.Text = " #008000"; // Groen
            informatieCode.Text = "Groen is de kleur van genezing";

        }

        private void blauw_MouseDown(object sender, MouseButtonEventArgs e)
        {
            colorCode.Text = " #0000FF"; // Blauw
            informatieCode.Text = "Blauw is de kleur van intelligentie";
        }

       
    }
}