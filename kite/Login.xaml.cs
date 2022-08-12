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
using System.Windows.Shapes;

namespace kite
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void exitbtnClick(object sender, RoutedEventArgs e)
        {
           
         
            this.Close();
           
        }

        private void RegistrationbtnClick(object sender, RoutedEventArgs e)
        {
              login_gridX.Visibility = Visibility.Collapsed;
            Registration_gridX.Visibility = Visibility.Visible;
        }
        private void SigninbtnClick(object sender, RoutedEventArgs e)
        {
           
            Registration_gridX.Visibility = Visibility.Collapsed;
            login_gridX.Visibility = Visibility.Visible;
        }

        private void Submitbtn_regClick(object sender, RoutedEventArgs e)
        {
            CentralWindow open = new CentralWindow();
            open.Show();
            this.Close();
        }

        private void Clearbtn_regClick(object sender, RoutedEventArgs e)
        {

        }

        private void loginbtn_loginClick(object sender, RoutedEventArgs e)
        {
            CentralWindow open = new CentralWindow();
            open.Show();
            this.Close();
        }

        private void Clearbtn_loginClick(object sender, RoutedEventArgs e)
        {

        }

    }
}
