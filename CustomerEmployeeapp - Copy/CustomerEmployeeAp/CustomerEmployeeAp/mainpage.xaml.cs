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

namespace CustomerEmployeeAp
{
    /// <summary>
    /// Interaction logic for mainpage.xaml
    /// </summary>
    public partial class mainpage : Window
    {
        public mainpage()
        {
            InitializeComponent();
        }
        private void NewCustomer(object sender, RoutedEventArgs e)
        {
            NewCustomerWindow en = new NewCustomerWindow();
            en.Show();
          
        }
        private void CheckBalance(object sender, RoutedEventArgs e)
        {
            CheckBalanceWindow en = new CheckBalanceWindow();
            en.Show();

        }
        private void UpdateInfo(object sender, RoutedEventArgs e)
        {
            UpdateInfoWindow en = new UpdateInfoWindow();
            en.Show();

        }
        private void DeleteAccount(object sender, RoutedEventArgs e)
        {
            DeleteAccountWindow en = new DeleteAccountWindow();
            en.Show();

        }
        private void NewEmployee(object sender, RoutedEventArgs e)
        {
            NewEmployeeWindow en = new NewEmployeeWindow();
            en.Show();

        }
        private void ShowEmployeeInfo(object sender, RoutedEventArgs e)
        {
            ShowEmployeeInfoWindow en = new ShowEmployeeInfoWindow();
            en.Show();

        }
        private void UpdateEmployeeInfo(object sender, RoutedEventArgs e)
        {
            UpdateEmployeeInfoWindow en = new UpdateEmployeeInfoWindow();
            en.Show();

        }


     
    }


}

