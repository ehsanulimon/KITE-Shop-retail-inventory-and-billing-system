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

namespace CustomerEmployeeAp
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

        private void loginClick(object sender, RoutedEventArgs e)
        {
            string username = userbox.Text;
            string password = passwordbox.Password;

            mainpage login = new mainpage();
            login.Show();
            Close();
            /*
            if (username == "abc" && password== "123")
            {
                MessageBox.Show("successfully login completed");
                mainpage login = new mainpage();
                login.Show();
                Close();
            }
            else if (username != "abc")
            {   
                loginpagetextblock.Text = "incorrect username  \n \t try again";
            }
            else if (password != "123")
            {
                loginpagetextblock.Text = "incorrect password  \n \t try again";
            }
            else if(username != "abc" && password != "123")
            {
                 loginpagetextblock.Text = "incorrect username and password  \n \t try again";
            }
           else if (passwordbox.Password.Length == 0)
            {

                passwordbox.Focus();
            }
            else if (userbox.Text.Length == 0)
            {
                loginpagetextblock.Text = "incorrect username or password!! \n \t try again";
                userbox.Focus();
            }*/

        }

        private void exitbuttonclick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += dtTicker;
            dt.Start();
        }
        private int incriment = 0;
        private void dtTicker(object sender, EventArgs e)
        {
            incriment++;
            timerlabel.Content = incriment.ToString();
        }

        private void XButton(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
