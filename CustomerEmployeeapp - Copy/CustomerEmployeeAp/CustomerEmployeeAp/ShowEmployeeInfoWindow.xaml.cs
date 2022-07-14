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
    /// Interaction logic for ShowEmployeeInfoWindow.xaml
    /// </summary>
    public partial class ShowEmployeeInfoWindow : Window
    {
        public ShowEmployeeInfoWindow()
        {
            InitializeComponent();
        }

       

        private void ShowButtonClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
