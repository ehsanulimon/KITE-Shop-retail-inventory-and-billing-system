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
    }
}
