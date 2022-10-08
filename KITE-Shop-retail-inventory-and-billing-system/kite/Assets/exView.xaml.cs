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
using MySql.Data.MySqlClient;
using System.Data;
namespace kite.Assets
{
    /// <summary>
    /// Interaction logic for exView.xaml
    /// </summary>
    public partial class exView : Window
    {
        public exView()
        {
            InitializeComponent();

           
        }
        public void userData()
        {
            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";

                string sql = "SELECT * FROM `user`";
                MySqlConnection connection = new MySqlConnection(mycon);
                MySqlCommand cmdSel = new MySqlCommand(sql, connection);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                da.Fill(dt);
                // dG.DataContext = dt;
               // dG.ItemsSource = dt.DefaultView;
                viewDataGirid.ItemsSource = dt.DefaultView;

            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }
        }
    }
}
