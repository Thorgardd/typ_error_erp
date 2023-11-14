using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ProjetForma
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        
        /// <summary>
        /// Entering Canal Button Effect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCanal_OnMouseEnter(object sender, MouseEventArgs e)
        {
            ButtonCanal.Background = Brushes.Chocolate;
            ButtonCanal.Foreground = Brushes.WhiteSmoke;
            ButtonCanal.Opacity = 1;
        }
        
        
        /// <summary>
        /// Leaving Canal Button Effect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonCanal_OnMouseLeave(object sender, MouseEventArgs e)
        {
            ButtonCanal.Background = Brushes.Transparent;
        }
        
        
        /// <summary>
        /// Entering Moderate Button Effect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonModerate_OnMouseEnter(object sender, MouseEventArgs e)
        {
            ButtonModerate.Background = Brushes.Chocolate;
            ButtonModerate.Foreground = Brushes.WhiteSmoke;
            ButtonModerate.Opacity = 1;
        }

        
        /// <summary>
        /// Leaving Moderate Button Effect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonModerate_OnMouseLeave(object sender, MouseEventArgs e)
        {
            ButtonModerate.Background = Brushes.Transparent;
        }
        
        
        /// <summary>
        /// Entering User Button Effect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUser_OnMouseEnter(object sender, MouseEventArgs e)
        {
            ButtonUser.Background = Brushes.Chocolate;
            ButtonUser.Foreground = Brushes.WhiteSmoke;
            ButtonUser.Opacity = 1;
        }
        
        
        /// <summary>
        /// Leaving User Button Effect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonUser_OnMouseLeave(object sender, MouseEventArgs e)
        {
            ButtonUser.Background = Brushes.Transparent;
        }
        
        
        /// <summary>
        /// Leaving Quit Button Effect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Quit_MouseEnter(object sender, RoutedEventArgs e)
        {
            Quit.Background = Brushes.DarkRed;
            Quit.Foreground = Brushes.White;
            Quit.Opacity = 1;
        }
        
        
        /// <summary>
        /// Leaving Quit Button Effect
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Quit_MouseLeave(object sender, RoutedEventArgs e)
        {
            Quit.Background = Brushes.Transparent;
        }

        
        /// <summary>
        /// Click methods for Quitting button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}