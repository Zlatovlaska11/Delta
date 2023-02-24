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
using System.Windows.Threading;

namespace _3_hodina_darek
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        int score;
        DispatcherTimer casovac = new DispatcherTimer();

        public MainWindow()
        {
            casovac.Tick += Casovac_Tick;
            casovac.Interval = new TimeSpan(0, 0, 0, 1);
            
            InitializeComponent();
        }

        private void Casovac_Tick(object sender, EventArgs e)
        {
            Random nahoda = new Random();
            darek.Margin = new Thickness(nahoda.Next(0, (int)plocha.ActualWidth - (int)darek.Width), nahoda.Next(0, (int)plocha.ActualHeight - (int)darek.Height), 0, 0);
            darek.Visibility = Visibility.Visible;
        }

        private void strom_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            darek.Visibility = Visibility.Visible;
            casovac.Start();
        }

        private void darek_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            score++;
            skore.Content = score;
            darek.Visibility = Visibility.Hidden;
        }
    }
}
