using kite.Assets;
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

namespace kite
{
    /// <summary>
    /// Interaction logic for CentralWindow.xaml
    /// </summary>
    public partial class CentralWindow : Window
    {

      
        public static String Var_Products_Name;
        public static String Var_Model_No;

        public static String Var_Series_Number;
        public static String Var_Category;

        public static int int_Price;
        public static int int_Quantity;
        // int_Quantity  int_Price  Var_Category Var_Series_Number Var_Model_No Var_Products_Name

        public static string v;
      
        public CentralWindow()
        {
            InitializeComponent();
        }

        //############## Mix min close program action method ############
        private void XbtbClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void maxbtnClick(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
            this.WindowStyle = WindowStyle.None;

           if (this.WindowState == System.Windows.WindowState.Normal)
                {
                    //this.WindowState = System.Windows.WindowState.Maximized;
                   this.WindowState = WindowState.Maximized;
                   this.WindowStyle = WindowStyle.None;
            }
                else
                {
                    this.WindowState = System.Windows.WindowState.Normal;
                     
                }
            
            
          

        }
        private void minbtnClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        //########## file menu action method #########
        private void OpenCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("OpenCommandBinding_Executed");

        }
        private void SaveCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("SaveCommandBinding_Executed");
        }
        private void NewCommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
         // MessageBox.Show("NewCommandBinding_Executed");
            CentralWindow open = new CentralWindow();
            open.Show();
            this.Close();



        }
        //################## Window munu ##############
        private void StockInput_Grid_menu_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("StockInput_MLBD_Click");
            OfferFairgridX.Visibility = Visibility.Collapsed;
            CategorygridX.Visibility = Visibility.Collapsed;
            BillinggridX.Visibility = Visibility.Collapsed;
            AccountgridX.Visibility = Visibility.Collapsed;
            StartGrid.Visibility = Visibility.Collapsed;

            //Visible
            StockinputgridX.Visibility = Visibility.Visible;
        }
        private void OfferFair_Grid_menu_Click(object sender, RoutedEventArgs e)
        {
            StockinputgridX.Visibility = Visibility.Collapsed;
            CategorygridX.Visibility = Visibility.Collapsed;
            BillinggridX.Visibility = Visibility.Collapsed;
            AccountgridX.Visibility = Visibility.Collapsed;
            StartGrid.Visibility = Visibility.Collapsed;
            //Visible
            OfferFairgridX.Visibility = Visibility.Visible;
        }
        private void Category_Grid_menu_Click(object sender, RoutedEventArgs e)
        {
            StockinputgridX.Visibility = Visibility.Collapsed;
            OfferFairgridX.Visibility = Visibility.Collapsed;
            BillinggridX.Visibility = Visibility.Collapsed;
            AccountgridX.Visibility = Visibility.Collapsed;
            StartGrid.Visibility = Visibility.Collapsed;
            //Visible
            CategorygridX.Visibility = Visibility.Visible;
        }
        private void Billing_Grid_menu_Click(object sender, RoutedEventArgs e)
        {
            StockinputgridX.Visibility = Visibility.Collapsed;
            OfferFairgridX.Visibility = Visibility.Collapsed;
            CategorygridX.Visibility = Visibility.Collapsed;
            AccountgridX.Visibility = Visibility.Collapsed;
            StartGrid.Visibility = Visibility.Collapsed;
            //Visible
            BillinggridX.Visibility = Visibility.Visible;

        }
        private void Account_Grid_menu_Click(object sender, RoutedEventArgs e)
        {
            StockinputgridX.Visibility = Visibility.Collapsed;
            OfferFairgridX.Visibility = Visibility.Collapsed;
            CategorygridX.Visibility = Visibility.Collapsed;
            BillinggridX.Visibility = Visibility.Collapsed;
            StartGrid.Visibility = Visibility.Collapsed;
            //Visible
            AccountgridX.Visibility = Visibility.Visible;


        }

        //############################ end window menu ##############
        //############################setting menu #################  theme_setting_click
        private void userinfo_setting_click(object sender, RoutedEventArgs e)
        {
            exView open = new exView();
            open.Show();
            open.userData();

        }
        private void theme_setting1_click(object sender, RoutedEventArgs e)   ///StartGridX CustomertextboxClean productstextboxClean megaoffergrid <<red
        {
            
                this.gridm.Background = System.Windows.Media.Brushes.MediumVioletRed;
            this.megaoffergrid.Background = System.Windows.Media.Brushes.MediumVioletRed;
            this.StartGridX.Background = System.Windows.Media.Brushes.MediumVioletRed;

            // this.CustomertextboxClean.Background = System.Windows.Media.Brushes.Black;
            //   this.productstextboxClean.Background = System.Windows.Media.Brushes.Black;


            this.StockinputgridX.Background = System.Windows.Media.Brushes.MediumVioletRed;
            this.OfferFairgridX.Background = System.Windows.Media.Brushes.MediumVioletRed;
            this.CategorygridX.Background = System.Windows.Media.Brushes.MediumVioletRed;
            this.BillinggridX.Background = System.Windows.Media.Brushes.MediumVioletRed;
            this.AccountgridX.Background = System.Windows.Media.Brushes.MediumVioletRed;
        }
        private void theme_setting2_click(object sender, RoutedEventArgs e)   
        {

            this.gridm.Background = System.Windows.Media.Brushes.Tan; //tan Beige Ivory Searchlable
            this.megaoffergrid.Background = System.Windows.Media.Brushes.Tan;
            this.StartGridX.Background = System.Windows.Media.Brushes.Tan;

            this.StockinputgridX.Background = System.Windows.Media.Brushes.Tan;
            this.OfferFairgridX.Background = System.Windows.Media.Brushes.Tan;
            this.CategorygridX.Background = System.Windows.Media.Brushes.Tan;
            this.BillinggridX.Background = System.Windows.Media.Brushes.Tan;
            this.AccountgridX.Background = System.Windows.Media.Brushes.Tan;

            this.Searchlable.Foreground = System.Windows.Media.Brushes.Black;
        }
        private void theme_setting3_click(object sender, RoutedEventArgs e)   
        {

            this.gridm.Background = System.Windows.Media.Brushes.Black;
            this.megaoffergrid.Background = System.Windows.Media.Brushes.Black;
            this.StartGridX.Background = System.Windows.Media.Brushes.Black;

            this.StockinputgridX.Background = System.Windows.Media.Brushes.Black;
            this.OfferFairgridX.Background = System.Windows.Media.Brushes.Black;
            this.CategorygridX.Background = System.Windows.Media.Brushes.Black;
            this.BillinggridX.Background = System.Windows.Media.Brushes.Black;
            this.AccountgridX.Background = System.Windows.Media.Brushes.Black;

        }

        private void theme_setting4_click(object sender, RoutedEventArgs e)   ///StartGridX CustomertextboxClean productstextboxClean megaoffergrid <<red
        {

            this.gridm.Background = System.Windows.Media.Brushes.DimGray;
            this.megaoffergrid.Background = System.Windows.Media.Brushes.DimGray;
            this.StartGridX.Background = System.Windows.Media.Brushes.DimGray;

            this.StockinputgridX.Background = System.Windows.Media.Brushes.DimGray;
            this.OfferFairgridX.Background = System.Windows.Media.Brushes.DimGray;
            this.CategorygridX.Background = System.Windows.Media.Brushes.DimGray;
            this.BillinggridX.Background = System.Windows.Media.Brushes.DimGray;
            this.AccountgridX.Background = System.Windows.Media.Brushes.DimGray;

        }
        private void theme_setting5_click(object sender, RoutedEventArgs e)
        {

            this.gridm.Background = System.Windows.Media.Brushes.Beige; //tan Beige Ivory
            this.megaoffergrid.Background = System.Windows.Media.Brushes.DarkGray;
            this.StartGridX.Background = System.Windows.Media.Brushes.DarkGray;



            this.StockinputgridX.Background = System.Windows.Media.Brushes.DarkGray;
            this.OfferFairgridX.Background = System.Windows.Media.Brushes.DarkGray;
            this.CategorygridX.Background = System.Windows.Media.Brushes.DarkGray;
            this.BillinggridX.Background = System.Windows.Media.Brushes.DarkGray;
            this.AccountgridX.Background = System.Windows.Media.Brushes.DarkGray;
        }
        private void theme_setting6_click(object sender, RoutedEventArgs e)
        {

            this.gridm.Background = System.Windows.Media.Brushes.Ivory; 
            this.megaoffergrid.Background = System.Windows.Media.Brushes.DimGray;
            this.StartGridX.Background = System.Windows.Media.Brushes.DimGray;

            this.StockinputgridX.Background = System.Windows.Media.Brushes.DimGray;
            this.OfferFairgridX.Background = System.Windows.Media.Brushes.DimGray;
            this.CategorygridX.Background = System.Windows.Media.Brushes.DimGray;
            this.BillinggridX.Background = System.Windows.Media.Brushes.DimGray;
            this.AccountgridX.Background = System.Windows.Media.Brushes.DimGray;

        }


        //################## StockInput_MLBD ##############
        private void StockInput_MLBD(object sender, MouseButtonEventArgs e)
        {
           OfferFairgridX.Visibility = Visibility.Collapsed;
           CategorygridX.Visibility = Visibility.Collapsed;
          BillinggridX.Visibility = Visibility.Collapsed;
           AccountgridX.Visibility = Visibility.Collapsed;
            StartGrid.Visibility = Visibility.Collapsed;

            //Visible
            StockinputgridX.Visibility = Visibility.Visible;

            // Table show Stock input data grid 
            string mycon = "server=localhost;user id=root;database=kite_bd";
            string sql = "SELECT * FROM `product`";
            MySqlConnection connection = new MySqlConnection(mycon);
            MySqlCommand cmdSel = new MySqlCommand(sql, connection);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
            da.Fill(dt);
            Stockinput_datagridX.ItemsSource = dt.DefaultView;

            // clear Stock input textbox
            txtb_ProductsName_Stock.Clear();
            txtb_ModelNo_Stock.Clear();
            txtb_SeriesNumber_Stock.Clear();
            txtb_Category_Stock.Clear();
            txtb_Price_Stock.Clear();
            txtb_Quantity_Stock.Clear();

        }

        private void StockinputADDClick(object sender, RoutedEventArgs e)  // 08-10-2022  
        {   // txtb_ProductsName_Stock txtb_ModelNo_Stock txtb_SeriesNumber_Stock txtb_Category_Stock  txtb_Price_Stock txtb_Quantity_Stock Stockinput_datagridX
            // Products Name || Model No || Series Number || Category ||  Price  || Quantity 
            // int_Quantity  int_Price  Var_Category Var_Series_Number Var_Model_No Var_Products_Name
            Var_Products_Name = txtb_ProductsName_Stock.Text;
            Var_Model_No = txtb_ModelNo_Stock.Text;
            Var_Series_Number = txtb_SeriesNumber_Stock.Text;
            Var_Category = txtb_Category_Stock.Text;
            int_Price = Convert.ToInt32(txtb_Price_Stock.Text);
            int_Quantity = Convert.ToInt32(txtb_Quantity_Stock.Text);

            string mycon = "server=localhost;user id=root;database=kite_bd";
            string query = "INSERT INTO `product`(`Products Name`, `Model No`, `Series Number`, `Category`, `Price`, `Quantity`) VALUES ('" + Var_Products_Name + "','" + Var_Model_No + "','" + Var_Series_Number + "','" + Var_Category + "','" + int_Price + "','" + int_Quantity + "')";

            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();
            reader = com.ExecuteReader();

            con.Close();
         
            txtb_ProductsName_Stock.Clear();
            txtb_ModelNo_Stock.Clear();
            txtb_SeriesNumber_Stock.Clear();
            txtb_Category_Stock.Clear();
            txtb_Price_Stock.Clear();
            txtb_Quantity_Stock.Clear();

            string sql = "SELECT * FROM `product`";
            MySqlConnection connection = new MySqlConnection(mycon);
            MySqlCommand cmdSel = new MySqlCommand(sql, connection);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
            da.Fill(dt);
            Stockinput_datagridX.ItemsSource = dt.DefaultView;
        }

        private void StockinputUpdateClick(object sender, RoutedEventArgs e)
        {
          
            if(txtb_ProductsName_Stock.Text == null || txtb_SeriesNumber_Stock.Text == null)
            {
                Var_Products_Name = txtb_ProductsName_Stock.Text;
                Var_Series_Number = txtb_SeriesNumber_Stock.Text;
                //int_Price = Convert.ToInt32(txtb_Price_Stock.Text);
                int_Quantity = Convert.ToInt32(txtb_Quantity_Stock.Text);
                try
                {
                    string mycon = "server=localhost;user id=root;database=kite_bd";  //OR `Series Number` = @VarSeriesNumber

                    string query = "UPDATE `product` SET `Price`= @intPrice WHERE `Products Name` = @VarproductName OR `Series Number` = @VarSeriesNumber ";

                    MySqlConnection con = new MySqlConnection(mycon);
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@intPrice", Convert.ToInt32(int_Price));
                    cmd.Parameters.AddWithValue("@VarproductName", Var_Products_Name);
                    cmd.Parameters.AddWithValue("@VarSeriesNumber", Var_Series_Number);
                    //  cmd.Parameters.AddWithValue("@intQuantity", Convert.ToInt32(int_Quantity));
                    MySqlDataReader MyReader;
                    con.Open();
                    MyReader = cmd.ExecuteReader();
                    MessageBox.Show("Data Updated");
                    while (MyReader.Read())
                    {
                    }
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                txtb_ProductsName_Stock.Clear();
                txtb_SeriesNumber_Stock.Clear();
                txtb_Price_Stock.Clear();

            }
            else
            {
                MessageBox.Show("\tData Not Updated !\n Pless enter product name or series number.");
            }

        }

        private void StockinputDeleteClick(object sender, RoutedEventArgs e)
        {
            if (txtb_ProductsName_Stock.Text == null || txtb_SeriesNumber_Stock.Text == null)
            {
                Var_Products_Name = txtb_ProductsName_Stock.Text;
                Var_Series_Number = txtb_SeriesNumber_Stock.Text;
                try
                {

                    string mycon = "server=localhost;port=3306; user id=root;database=kite_bd";
                    string Query = "DELETE FROM `product` WHERE `Products Name` = @VarproductName OR `Series Number` = @VarSeriesNumber ";
                    MySqlConnection MyConn = new MySqlConnection(mycon);
                    MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                    cmd.Parameters.AddWithValue("@VarproductName", Var_Products_Name);
                    cmd.Parameters.AddWithValue("@VarSeriesNumber", Var_Series_Number);
                    MySqlDataReader MyReader;
                    MyConn.Open();
                    MyReader = cmd.ExecuteReader();
                    MessageBox.Show("Data Deleted");
                    while (MyReader.Read())
                    {
                    }
                    MyConn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                txtb_ProductsName_Stock.Clear();
                txtb_SeriesNumber_Stock.Clear();
            }
            else
            {
                MessageBox.Show("\tData Not Deleted !\n Pless enter product name or series number");
            }

        } 
          private void OfferFair_MLBD(object sender, MouseButtonEventArgs e)
           {
            StockinputgridX.Visibility = Visibility.Collapsed;
            CategorygridX.Visibility = Visibility.Collapsed;
            BillinggridX.Visibility = Visibility.Collapsed;
             AccountgridX.Visibility = Visibility.Collapsed;
            StartGrid.Visibility = Visibility.Collapsed;
            //Visible
            OfferFairgridX.Visibility = Visibility.Visible;


            // Products Name || Model No || Series Number || Category ||  Price  || Quantity 
            // int_Quantity  int_Price  Var_Category Var_Series_Number Var_Model_No Var_Products_Name
            // cmb_box_ProductsCategory_offer
           string mycon = "server=localhost;user id=root;database=kite_bd";
            string sql = "SELECT  a.* FROM `product` a  INNER JOIN (SELECT `Category`, MAX(ID) max_ID FROM  `product`  GROUP BY `Category`) b ON a.`Category` = b.`Category` AND  a.ID = b.max_ID";

            MySqlConnection connection = new MySqlConnection(mycon);
            MySqlCommand cmdSel = new MySqlCommand(sql, connection);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
            da.Fill(dt);
           
            cmb_box_ProductsCategory_offer.ItemsSource = dt.DefaultView;
           

        } 

        private void offerfairnextbtClick(object sender, RoutedEventArgs e)
        { 
        }

        private void offerUpdateClick(object sender, RoutedEventArgs e)
        {

        }

        private void offerDeleteClick(object sender, RoutedEventArgs e)
        {

        }
        
   

        private void megaOfferChecked(object sender, RoutedEventArgs e)
        {
            pricerangesgrid.Visibility = Visibility.Collapsed;
            combooffergrid.Visibility = Visibility.Collapsed;

            megaoffergrid.Visibility = Visibility.Visible;
        }

        private void ComboOffeChecked(object sender, RoutedEventArgs e)
        {
            pricerangesgrid.Visibility = Visibility.Collapsed;
            megaoffergrid.Visibility = Visibility.Collapsed;
            combooffergrid.Visibility = Visibility.Visible;
        }

        private void PriceRangesChecked(object sender, RoutedEventArgs e)
        {
            combooffergrid.Visibility = Visibility.Collapsed;
            megaoffergrid.Visibility = Visibility.Collapsed;
            pricerangesgrid.Visibility = Visibility.Visible;
        }


        private void Category_MLBD(object sender, MouseButtonEventArgs e)
        {
            StockinputgridX.Visibility = Visibility.Collapsed;
            OfferFairgridX.Visibility = Visibility.Collapsed;
            BillinggridX.Visibility = Visibility.Collapsed;
            AccountgridX.Visibility = Visibility.Collapsed;
            StartGrid.Visibility = Visibility.Collapsed;
            //Visible
            CategorygridX.Visibility = Visibility.Visible;
            //Category_datagridX
            //cmb_box_ProductsCategory_Category show  
            string mycon = "server=localhost;user id=root;database=kite_bd";
            string sql = "SELECT  a.* FROM `product` a  INNER JOIN (SELECT `Category`, MAX(ID) max_ID FROM  `product`  GROUP BY `Category`) b ON a.`Category` = b.`Category` AND  a.ID = b.max_ID";

            MySqlConnection connection = new MySqlConnection(mycon);
            MySqlCommand cmdSel = new MySqlCommand(sql, connection);
            DataTable dt = new DataTable();
            connection.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
            da.Fill(dt);
         
            cmb_box_ProductsCategory_Category.ItemsSource = dt.DefaultView;

            
            connection.Close();
  

        }
   
        private void ComboBox_DropDownClosed_Category(object sender, EventArgs e)
        {



            string selected = cmb_box_ProductsCategory_Category.Text;

            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT * FROM `product` WHERE `Category` = @C ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                cmdSel2.Parameters.AddWithValue("@C", selected);
                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                Category_datagridX.ItemsSource = dt2.DefaultView;

            
                connection2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
  

        private void NextbtcategoryClick(object sender, RoutedEventArgs e)
        {
            

            if (Category_Viewgrid2.Visibility == Visibility.Visible)
            {
                Category_Viewgrid2.Visibility = Visibility.Collapsed;
                Category_Viewgrid1.Visibility = Visibility.Visible;
            }
            else
            {
                Category_Viewgrid1.Visibility = Visibility.Collapsed;
                Category_Viewgrid2.Visibility = Visibility.Visible;
            }

        }

        private void PreviousbtcategoryClick(object sender, RoutedEventArgs e)
        {


            if (Category_Viewgrid1.Visibility == Visibility.Visible)
            {
                Category_Viewgrid1.Visibility = Visibility.Collapsed;
                Category_Viewgrid2.Visibility = Visibility.Visible;
            }
            else
            {
                Category_Viewgrid2.Visibility = Visibility.Collapsed;
                Category_Viewgrid1.Visibility = Visibility.Visible;
            }
        }

        private void Search_MLBD(object sender, MouseButtonEventArgs e)
        {
            v = txtb_Search_Category.Text;
           if(v=="all" || v=="All"|| v == "*")
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql = "SELECT * FROM `product`";
                MySqlConnection connection = new MySqlConnection(mycon);
                MySqlCommand cmdSel = new MySqlCommand(sql, connection);
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
                da.Fill(dt);
                Category_datagridX.ItemsSource = dt.DefaultView;
            }
            else
            {
                try
                {
                    string mycon = "server=localhost;user id=root;database=kite_bd";
                    string sql1 = "SELECT * FROM `product` WHERE `Products Name` =@C OR `Category` =@C  OR `Series Number` =@C OR `Price` =@C OR `Model No` =@C ";
                    MySqlConnection connection2 = new MySqlConnection(mycon);
                    MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                    cmdSel2.Parameters.AddWithValue("@C", v);
                    DataTable dt2 = new DataTable();
                    connection2.Open();
                    MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                    da2.Fill(dt2);

                    Category_datagridX.ItemsSource = dt2.DefaultView;



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        
            txtb_Search_Category.Text = " ";
        }

        private void CategoryViewgrid2_BT1Click(object sender, RoutedEventArgs e)
        { 
            string selected = V5.Text; 

            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT * FROM `product` WHERE `Category` = @C ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                cmdSel2.Parameters.AddWithValue("@C", selected);
                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                Category_datagridX.ItemsSource = dt2.DefaultView;


                connection2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
    }

        private void CategoryViewgrid2_BT2Click(object sender, RoutedEventArgs e)
        {
            string selected = V6.Text;

            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT * FROM `product` WHERE `Category` = @C ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                cmdSel2.Parameters.AddWithValue("@C", selected);
                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                Category_datagridX.ItemsSource = dt2.DefaultView;


                connection2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoryViewgrid2_BT3Click(object sender, RoutedEventArgs e)
        {
            string selected = V7.Text;

            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT * FROM `product` WHERE `Category` = @C ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                cmdSel2.Parameters.AddWithValue("@C", selected);
                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                Category_datagridX.ItemsSource = dt2.DefaultView;


                connection2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoryViewgrid2_BT4Click(object sender, RoutedEventArgs e)
        {
            string selected = V8.Text;

            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT * FROM `product` WHERE `Category` = @C ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                cmdSel2.Parameters.AddWithValue("@C", selected);
                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                Category_datagridX.ItemsSource = dt2.DefaultView;


                connection2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoryViewgrid1_BT1Click(object sender, RoutedEventArgs e)
        {
            string selected = v1.Text;
            
            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT * FROM `product` WHERE `Category` = @C ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                cmdSel2.Parameters.AddWithValue("@C", selected);
                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                Category_datagridX.ItemsSource = dt2.DefaultView;


                connection2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoryViewgrid1_BT2Click(object sender, RoutedEventArgs e)
        {
            string selected = V2.Text;

            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT * FROM `product` WHERE `Category` = @C ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                cmdSel2.Parameters.AddWithValue("@C", selected);
                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                Category_datagridX.ItemsSource = dt2.DefaultView;


                connection2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoryViewgrid1_BT3Click(object sender, RoutedEventArgs e)
        {
            string selected = V3.Text;

            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT * FROM `product` WHERE `Category` = @C ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                cmdSel2.Parameters.AddWithValue("@C", selected);
                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                Category_datagridX.ItemsSource = dt2.DefaultView;


                connection2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CategoryViewgrid1_BT4Click(object sender, RoutedEventArgs e)
        {
            string selected = V4.Text;

            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT * FROM `product` WHERE `Category` = @C ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                cmdSel2.Parameters.AddWithValue("@C", selected);
                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                Category_datagridX.ItemsSource = dt2.DefaultView;


                connection2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
 

        //######################################  Billing method # ########################################
        private void Billing_MLBD(object sender, MouseButtonEventArgs e)
        {
            StockinputgridX.Visibility = Visibility.Collapsed;
            OfferFairgridX.Visibility = Visibility.Collapsed;
            CategorygridX.Visibility = Visibility.Collapsed;
            AccountgridX.Visibility = Visibility.Collapsed;
            StartGrid.Visibility = Visibility.Collapsed;
            //Visible
            BillinggridX.Visibility = Visibility.Visible;


            string mycon = "server=localhost;user id=root;database=kite_bd";
            string sql_C = "SELECT  a.* FROM `product` a  INNER JOIN (SELECT `Category`, MAX(ID) max_ID FROM  `product`  GROUP BY `Category`) b ON a.`Category` = b.`Category` AND  a.ID = b.max_ID";

            MySqlConnection connection = new MySqlConnection(mycon);
            MySqlCommand cmd_C = new MySqlCommand(sql_C, connection);
            DataTable dt = new DataTable();
            connection.Open();
            MySqlDataAdapter da_C = new MySqlDataAdapter(cmd_C);
            da_C.Fill(dt);

            cmb_box_ProductsCategory_billing.ItemsSource = dt.DefaultView;
           

            connection.Close();

        }
        private void ComboBox_DropDownClosed_ProductsCategory_billing(object sender, EventArgs e)
        {



            string selected = cmb_box_ProductsCategory_billing.Text;
            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT `Products Name` FROM `product` WHERE `Category`= @P ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                cmdSel2.Parameters.AddWithValue("@P", selected);
                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                cmb_ProductsName_billing.ItemsSource = dt2.DefaultView;


                connection2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void ComboBox_DropDownClosed_ProductsName_billing(object sender, EventArgs e)
        {



            string selected = cmb_ProductsName_billing.Text;


            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT `Model No` FROM `product` WHERE `Products Name`= @M ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                cmdSel2.Parameters.AddWithValue("@M", selected);
                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                cmb_box_ModelNo_billing.ItemsSource = dt2.DefaultView;


                connection2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ComboBox_DropDownClosed_ModelNo_billing(object sender, EventArgs e)
        {



            string selected = cmb_box_ModelNo_billing.Text;


           

        }
        private void ComboBox_DropDownClosed_Quantity_billing(object sender, EventArgs e)
        {



            string selected = cmb_box_Quantity_billing.Text;
            

        }


        private void BillingADDClick(object sender, RoutedEventArgs e)
        {

            


        }
        
        private void BillingCleanClick(object sender, RoutedEventArgs e)
        {
            Receipt_RichTextBox.Document.Blocks.Clear();
        }

        private void BillingPrintClick(object sender, RoutedEventArgs e)
        {
            PrintDialog pd = new PrintDialog();

            if ((pd.ShowDialog() == true))

            {

                //use either one of the below     

                pd.PrintVisual(Receipt_RichTextBox as Visual, "Print Visual");

                pd.PrintDocument(documentPaginator: ((IDocumentPaginatorSource)Receipt_RichTextBox.Document).DocumentPaginator,

                    description: "Microsoft Print to PDF");

            }

        }
        private void BillingPrintpreviewbtClick(object sender, RoutedEventArgs e)
        {
            PrintDialog printDlg = new PrintDialog();
            FlowDocument doc = new FlowDocument(new Paragraph(new Run(" "+ txtb_CustomerEmail_billing.Text + "Some text goes here")));

            doc.Name = "FlowDoc";
            IDocumentPaginatorSource idpSource = doc;
            printDlg.PrintDocument(idpSource.DocumentPaginator, "Hello WPF Printing.");

        }

        private void CustomertextboxcleanClick(object sender, RoutedEventArgs e)
        {
            txtb_CustomerEmail_billing.Clear();
            txtb_CustomerMobileNo_billing.Clear();
            txtb_CustomerAddress_billing.Clear();
            txtb_CustomerName_billing.Clear();
        }
        private void CustomertextboxAddClick(object sender, RoutedEventArgs e)
        {
            //txtb_CustomerEmail_billing.Text;
           // txtb_CustomerMobileNo_billing.Text;
            //txtb_CustomerAddress_billing.Text;
            //txtb_CustomerName_billing.Text;
        }

        private void productstextboxCleanClick(object sender, RoutedEventArgs e)
        {
            cmb_box_Quantity_billing.Text = " ";
            txtb_Price_billing.Text = " ";
            cmb_box_ProductsCategory_billing.Text = " ";
            cmb_box_ModelNo_billing.Text = " ";
            cmb_ProductsName_billing.Text = " ";
            
        }

        //######################################################ACCount ###############

        private void Account_MLBD(object sender, MouseButtonEventArgs e)
        {
            StockinputgridX.Visibility = Visibility.Collapsed;
            OfferFairgridX.Visibility = Visibility.Collapsed;
            CategorygridX.Visibility = Visibility.Collapsed;
            BillinggridX.Visibility = Visibility.Collapsed;
            StartGrid.Visibility = Visibility.Collapsed;
            //Visible
            AccountgridX.Visibility = Visibility.Visible;


        }

        private void AccountInstallmentsClick(object sender, RoutedEventArgs e)
        {

        }

        private void AccountBalancebtClick(object sender, RoutedEventArgs e)
        {

        }

        private void AccountPrintpreviewClick(object sender, RoutedEventArgs e)
        {

        }

        private void AccountPrintClick(object sender, RoutedEventArgs e)
        {

        }

    
    }
}
