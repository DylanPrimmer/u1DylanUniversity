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

namespace U1_McMaster_CompSci
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            btnONE.Visibility = Visibility.Collapsed;
            btnTHREE.Visibility = Visibility.Collapsed;
            TextBlock2.Visibility = Visibility.Collapsed;
            btnFOUR.Visibility = Visibility.Collapsed;
            TextBlock3.Visibility = Visibility.Collapsed;
        }

        private void btnTWO_Click(object sender, RoutedEventArgs e)
        {
            btnTHREE.Visibility = Visibility.Visible;
            btnTWO.Visibility = Visibility.Collapsed;
            TextBlock1.Visibility = Visibility.Collapsed;
            TextBlock2.Visibility = Visibility.Visible;
            btnFOUR.Visibility = Visibility.Collapsed;
            TextBlock3.Visibility = Visibility.Collapsed;
        }

        private void btnTHREE_Click(object sender, RoutedEventArgs e)
        {
            btnTHREE.Visibility = Visibility.Collapsed;
            TextBlock2.Visibility = Visibility.Collapsed;
            btnFOUR.Visibility = Visibility.Visible;
            TextBlock3.Visibility = Visibility.Visible;
            
        }

        private void btnFOUR_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
