using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using ProjetForma.Users;

namespace ProjetForma.Interfaces
{
    public partial class Login : Window
    {
        private string UserName = "admin";
        private string PassWord = "admin";
        
        
        public Login()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// Username field focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Username_OnGotFocus(object sender, RoutedEventArgs e)
        {
            Username.Text = String.Empty;
            Username.Foreground = Brushes.WhiteSmoke;
            Username.Opacity = 1;
        }

        
        /// <summary>
        /// Password field focus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Password_OnGotFocus(object sender, RoutedEventArgs e)
        {
            Password.Password = String.Empty;
            Password.Foreground = Brushes.WhiteSmoke;
            Password.Opacity = 1;
        }

        
        /// <summary>
        /// Login button action
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_OnClick(object sender, RoutedEventArgs e)
        {
            if (Username.Text == UserName && Password.Password == PassWord)
            {
                CreateMainWindow();
            }
            else
            {
                LogStatus.Foreground = Brushes.Red;
                LogStatus.Visibility = Visibility.Visible;
            }
        }

        
        /// <summary>
        /// Method used if the user press the enter key
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Password_OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (Username.Text == UserName && Password.Password == PassWord)
                {
                    CreateMainWindow();
                }
                else
                {
                    LogStatus.Foreground = Brushes.Red;
                    LogStatus.Visibility = Visibility.Visible;
                }
            }
        }

        
        /// <summary>
        /// Method used to create the main window
        /// </summary>
        private void CreateMainWindow()
        {
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }

        
        /// <summary>
        /// Entering Login Button with the mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_OnMouseEnter(object sender, MouseEventArgs e)
        {
            Button.Foreground = Brushes.WhiteSmoke;
            Button.Background = Brushes.DarkGreen;
            Button.Opacity = 1;
        }
        
        
        /// <summary>
        /// Leaving Login Button with the mouse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_OnMouseLeave(object sender, MouseEventArgs e)
        {
            Button.Background = Brushes.Transparent;
        }
    }
}
