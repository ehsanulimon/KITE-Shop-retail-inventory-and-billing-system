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

        public static String Var_Category_offer;
        public static String Var_Products_Name_offer;
        public static String Var_Model_No_offer;

        public static String Var_Offer_package_offer;
        public static int int_Quantity_offer;
        public static int int_Discount_offer;
        public static int int_Price_offer;
        

        public static string v;
        // int_Quantity  int_Price  Var_Category Var_Series_Number Var_Model_No Var_Products_Name

        public static string Var_Customer_Name;  //Var_Customer_Name  Var_Customer_Address Var_Customer_Mobile Var_Customer_Email 
        public static string Var_Customer_Address;
        public static string Var_Customer_Email;
        public static string Var_Customer_Mobile;
        //selected_ProductsName selected__ProductsCategory selected_ModelNo  Set_Quantity Set_Price
        public static string selected_ProductsName;
        public static string selected__ProductsCategory;
        public static string selected_ModelNo;

        public static string selected_Quantity; //selected_Price
        public static string selected_Price;
        public static string Set_Price;        //V_Discount_billing V_Warranty_billing V_VAT_billing
        public static string V_Discount_billing;
        public static string V_Warranty_billing;
        public static string V_VAT_billing;

        public static string Text_Receipt;
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

             string mycon = "server=localhost;port=3306; user id=root;database=kite_bd";



            try
            {
                int stock_out = 0;
               
                string Query = "DELETE FROM `product` WHERE `Quantity` = @Stockout ";
                MySqlConnection MyConn = new MySqlConnection(mycon);
                MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                cmd.Parameters.AddWithValue("@Stockout", stock_out);
               
                MySqlDataReader MyReader;
                MyConn.Open();
                MyReader = cmd.ExecuteReader();
              
                while (MyReader.Read())
                {
                }
                MyConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            // Table show Stock input data grid 
            
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
            Var_Products_Name = txtb_ProductsName_Stock.Text;
            Var_Series_Number = txtb_SeriesNumber_Stock.Text;
            if (txtb_ProductsName_Stock.Text != null || txtb_SeriesNumber_Stock.Text != null)
            {

                int_Price = Convert.ToInt32(txtb_Price_Stock.Text);
                // int_Quantity = Convert.ToInt32(txtb_Quantity_Stock.Text);
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
            Var_Products_Name = txtb_ProductsName_Stock.Text;
            Var_Series_Number = txtb_SeriesNumber_Stock.Text;
            if (txtb_ProductsName_Stock.Text != null || txtb_SeriesNumber_Stock.Text != null)
            {

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
        //################################ Offer Fair #########################################################################
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

            string sql1 = "SELECT * FROM `offer`";
            MySqlConnection connection1 = new MySqlConnection(mycon);
            MySqlCommand cmdSel1 = new MySqlCommand(sql1, connection1);
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmdSel1);
            da1.Fill(dt1);
            Offerfair_datagridX.ItemsSource = dt1.DefaultView;



            string sql = "SELECT  a.* FROM `product` a  INNER JOIN (SELECT `Category`, MAX(ID) max_ID FROM  `product`  GROUP BY `Category`) b ON a.`Category` = b.`Category` AND  a.ID = b.max_ID";

            MySqlConnection connection = new MySqlConnection(mycon);
            MySqlCommand cmdSel = new MySqlCommand(sql, connection);
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);
            da.Fill(dt);

            cmb_box_ProductsCategory_offer.ItemsSource = dt.DefaultView;

          

        }
        private void ComboBox_DropDownClosed_ProductsCategory_offer(object sender, EventArgs e)
        {



            string selected = cmb_box_ProductsCategory_offer.Text;

            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT `Products Name` FROM `product` WHERE `Category`= @c ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                cmdSel2.Parameters.AddWithValue("@c", selected);
                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                cmb_box_ProductsName_offer.ItemsSource = dt2.DefaultView;


                connection2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ComboBox_DropDownClosed_ProductsName_offer(object sender, EventArgs e)
        {



            string selected = cmb_box_ProductsName_offer.Text;

            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT `Model No` FROM `product` WHERE `Products Name`= @n ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                cmdSel2.Parameters.AddWithValue("@n", selected);
                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                combobox_ModelNo_offer.ItemsSource = dt2.DefaultView;


                connection2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ComboBox_DropDownClosed_ModelNo_offer(object sender, EventArgs e)
        {



            string selected = combobox_ModelNo_offer.Text;

            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT `Quantity` FROM `product` WHERE `Model No`= @M ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                cmdSel2.Parameters.AddWithValue("@M", selected);
                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                cmb_Quantity_offer.ItemsSource = dt2.DefaultView;
                cmb_price_offer.ItemsSource = dt2.DefaultView;

                connection2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static int Quantity_old;
        private void ComboBox_DropDownClosed_Quantity_offer(object sender, EventArgs e)
        {



            string selected = cmb_Quantity_offer.Text;
            Quantity_old = Convert.ToInt32(selected);
            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT `Price` FROM `product` WHERE `Quantity`= @M ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                cmdSel2.Parameters.AddWithValue("@M", selected);
                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                
                cmb_price_offer.ItemsSource = dt2.DefaultView;

                connection2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


           


        }

        private void ComboBox_DropDownClosed_Discount_offer(object sender, EventArgs e)
        {



            int_Discount_offer = Convert.ToInt32(cmb_Discount_offer.Text);
           


        }

        public static int price_old;
        private void ComboBox_DropDownClosed_price_offer(object sender, EventArgs e)
        {



            string selected = cmb_price_offer.Text;
            price_old = Convert.ToInt32(selected);

            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT  `Discount` FROM `others` ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);

                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                cmb_Discount_offer.ItemsSource = dt2.DefaultView;


                connection2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    
        private void ComboBox_DropDownClosed_comboofferlistbox(object sender, EventArgs e)
        {



            string selected = comboofferlistbox.Text;

           

        }

        private void offerfairnextbtClick(object sender, RoutedEventArgs e)
        {

          

            Var_Category_offer = cmb_box_ProductsCategory_offer.Text;
             Var_Products_Name_offer = cmb_box_ProductsName_offer.Text;
             Var_Model_No_offer = combobox_ModelNo_offer.Text;

            Var_Offer_package_offer = txtb_Offerpackage_offer.Text;


            // textbox into var
            int_Quantity_offer = Convert.ToInt32(txtb_Quantity_offer.Text);
            // current Quantity
            int Quantity_set= ( Quantity_old  - int_Quantity_offer);

            // current Price
            int_Price_offer = (price_old * int_Quantity_offer);
            int price_new = int_Price_offer;



            int temp = int_Discount_offer * price_new;
            temp = temp / 100;

            // total Discount
            int_Discount_offer = temp;

            // current Price with Discount
            int_Price_offer = (int_Price_offer - int_Discount_offer);

            string mycon = "server=localhost;user id=root;database=kite_bd";
            try
            {
                
            string query = "INSERT INTO `offer`(`Category`, `Products Name`, `Model No`, `Offer package`, `Discount`, `Price`, `Quantity`) VALUES ('" + Var_Category_offer + "','" + Var_Products_Name_offer + "','" + Var_Model_No_offer + "','" + Var_Offer_package_offer + "','" + int_Discount_offer + "','" + int_Price_offer + "','" + int_Quantity_offer + "')";

            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();
            reader = com.ExecuteReader();

            con.Close();
             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

       cmb_box_ProductsCategory_offer.Text ="";
            cmb_box_ProductsName_offer.Text="";
            combobox_ModelNo_offer.Text="";
            txtb_Offerpackage_offer.Clear();
            cmb_Quantity_offer.Text = "";
            txtb_Quantity_offer.Clear();
            cmb_Discount_offer.Text = "";
            cmb_price_offer.Text = "";

            try
            {

                string query = "UPDATE `product` SET `Quantity`= @reQ WHERE `Model No`= @Number";

                MySqlConnection con = new MySqlConnection(mycon);
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();
                cmd.Parameters.Add(new MySqlParameter("@reQ", Quantity_set));
                cmd.Parameters.Add(new MySqlParameter("@Number", Var_Model_No_offer));
                //close data reader
                cmd.ExecuteNonQuery();


                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            string sql1 = "SELECT * FROM `offer`";
            MySqlConnection connection1 = new MySqlConnection(mycon);
            MySqlCommand cmdSel1 = new MySqlCommand(sql1, connection1);
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter(cmdSel1);
            da1.Fill(dt1);
            Offerfair_datagridX.ItemsSource = dt1.DefaultView;


        }

        private void offerUpdateClick(object sender, RoutedEventArgs e)
        {
            Var_Offer_package_offer = txtb_Offerpackage_offer.Text;
           
            if (txtb_Offerpackage_offer.Text != null)
            {

                try
                {

                    string mycon = "server=localhost;port=3306; user id=root;database=kite_bd";
                    string Query = "DELETE FROM `offer` WHERE `Offer package` = @Offerpackage ";
                    MySqlConnection MyConn = new MySqlConnection(mycon);
                    MySqlCommand cmd = new MySqlCommand(Query, MyConn);
                    cmd.Parameters.AddWithValue("@Offerpackage", Var_Offer_package_offer);
                   
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
                MessageBox.Show("\tData Not Deleted !\n Pless enter Offer package Name");
            }
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

        //########################################  Category ######################################################################
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
            if (v == "all" || v == "All" || v == "*")
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

            txtb_Search_Category.Clear();
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

            try
            {

                string sql1 = "SELECT `Offer package` FROM `offer`";

                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);

                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                cmb_Offer_billing.ItemsSource = dt2.DefaultView;


                connection2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

     

          


        }
        private void ComboBox_DropDownClosed_ProductsCategory_billing(object sender, EventArgs e)
        {



            selected__ProductsCategory = cmb_box_ProductsCategory_billing.Text;
            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT `Products Name` FROM `product` WHERE `Category`= @P ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                cmdSel2.Parameters.AddWithValue("@P", selected__ProductsCategory);
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



            selected_ProductsName = cmb_ProductsName_billing.Text;


            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT `Model No` FROM `product` WHERE `Products Name`= @M ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                cmdSel2.Parameters.AddWithValue("@M", selected_ProductsName);
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



            selected_ModelNo = cmb_box_ModelNo_billing.Text;


            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT `Price` FROM `product` WHERE `Model No`= @t ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                cmdSel2.Parameters.AddWithValue("@t", selected_ModelNo);
                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                cmb_box_Price_billing.ItemsSource = dt2.DefaultView;


                connection2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public static int count1;
        public static string Quantity1;
        public static string Quantity2;
        public static int count2;
        public static int Q1;
        public static string price_count;
        public static int re_Quantity;
        public static int int_Discount;
        public static int total_Discount;
        public static string Discount;
        public static int int_vat;
        public static int total_vat;
        public static string VAT;
        public static int sell;
        private void ComboBox_DropDownClosed_Price_billing(object sender, EventArgs e)
        {



            selected_Price = cmb_box_Price_billing.Text;
            count1 = Convert.ToInt32(selected_Price);

            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT `Quantity` FROM `product` WHERE `Price`= @t ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                cmdSel2.Parameters.AddWithValue("@t", selected_Price);
                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                combobox_Quantity_billing.ItemsSource = dt2.DefaultView;

                connection2.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void ComboBox_DropDownClosed_Q_billing(object sender, EventArgs e)
        {


            Quantity2 = combobox_Quantity_billing.Text;


            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT  `Discount` FROM `others` ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);

                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                cmb_box_Discountpackage_billing.ItemsSource = dt2.DefaultView;


                connection2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void ComboBox_DropDownClosed_Warranty(object sender, EventArgs e)
        {


            V_Warranty_billing = cmb_box_Warranty_billing.Text;

            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT  `VAT` FROM `others`";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);

                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                cmb_box_VAT_billing.ItemsSource = dt2.DefaultView;


                connection2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void ComboBox_DropDownClosed_VAT(object sender, EventArgs e)
        {


            V_VAT_billing = cmb_box_VAT_billing.Text;




        }
        private void ComboBox_DropDownClosed_Discount(object sender, EventArgs e)
        {

            V_Discount_billing = cmb_box_Discountpackage_billing.Text;



            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string sql1 = "SELECT  `Warranty` FROM `others` ";
                MySqlConnection connection2 = new MySqlConnection(mycon);
                MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);

                DataTable dt2 = new DataTable();
                connection2.Open();
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                da2.Fill(dt2);

                cmb_box_Warranty_billing.ItemsSource = dt2.DefaultView;


                connection2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CustomertextboxAddClick(object sender, RoutedEventArgs e)
        {//Var_Customer_Name  Var_Customer_Address Var_Customer_Mobile Var_Customer_Email 

    
        }

        
        private void ComboBox_DropDownClosed_Offer_billing(object sender, EventArgs e)
        {
            string offer_V = cmb_Offer_billing.Text;



        }


        private void CustomertextboxcleanClick(object sender, RoutedEventArgs e)
        {
            txtb_CustomerEmail_billing.Clear();
            txtb_CustomerMobileNo_billing.Clear();
            txtb_CustomerAddress_billing.Clear();
            txtb_CustomerName_billing.Clear();
        }
     


        private void BillingADDClick(object sender, RoutedEventArgs e)
        {


            Var_Customer_Name = txtb_CustomerName_billing.Text;
            Var_Customer_Address = txtb_CustomerAddress_billing.Text;
            Var_Customer_Mobile = txtb_CustomerMobileNo_billing.Text;
            Var_Customer_Email = txtb_CustomerEmail_billing.Text;


            string mycon = "server=localhost;user id=root;database=kite_bd";

            try
            {

           string query = "INSERT INTO `customer`(`Customer Name`, `Customer Address`, `Customer Mobile`, `Customer Email`) VALUES ('" + Var_Customer_Name + "','" + Var_Customer_Address + "','" + Var_Customer_Mobile + "','" + Var_Customer_Email + "')";

            MySqlConnection con = new MySqlConnection(mycon);
            MySqlCommand com = new MySqlCommand(query, con);
            MySqlDataReader reader;

            con.Open();
            reader = com.ExecuteReader();

            con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            int Q1 = Convert.ToInt32(Quantity2);

            Quantity1 = txtb_box_Quantity_billing.Text;


            count2 = Convert.ToInt32(Quantity1);

            re_Quantity = (Q1 - count2);

            try
            {
  
                string query2 = "UPDATE `product` SET `Quantity`= @reQ WHERE `Model No`= @Number";

                MySqlConnection con2 = new MySqlConnection(mycon);
                MySqlCommand cmd = new MySqlCommand(query2, con2);
                con2.Open();
                cmd.Parameters.Add(new MySqlParameter("@reQ", Convert.ToInt16(re_Quantity)));
                cmd.Parameters.Add(new MySqlParameter("@Number", selected_ModelNo));
                //close data reader
                cmd.ExecuteNonQuery();


                con2.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            int_Discount = Convert.ToInt32(V_Discount_billing);
            int_vat = Convert.ToInt32(V_Discount_billing);

            count2 = count2 * count1;
            int count3 = count2;
            price_count = Convert.ToString(count3);
            int temp = int_Discount * count2;
            temp = temp / 100;
            total_Discount = temp;
            count2 = count2 - temp;
            sell += count2;
            Discount = Convert.ToString(count2);
            int count4 = count2;
            temp = int_vat * count4;
            temp = temp / 100;
            total_vat = temp;
            int temp1 = count2 + temp;

            VAT = Convert.ToString(temp1);

            try
            {
                string mycon1 = "server=localhost;user id=root;database=kite_bd";
                string query1 = "INSERT INTO `statistics`(`Total Amount`) VALUES ('" + sell + "')";
                MySqlConnection con1 = new MySqlConnection(mycon1);
                MySqlCommand cmd1 = new MySqlCommand(query1, con1);
                con1.Open();
                cmd1.ExecuteNonQuery();
                con1.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BillingCleanClick(object sender, RoutedEventArgs e)
        {
            Receipt_RichTextBox.Document.Blocks.Clear();

            txtb_CustomerEmail_billing.Clear();
            txtb_CustomerMobileNo_billing.Clear();
            txtb_CustomerAddress_billing.Clear();
            txtb_CustomerName_billing.Clear();

            txtb_box_Quantity_billing.Text = "";
            cmb_box_Price_billing.Text = "";
            cmb_box_ProductsCategory_billing.Text = "";
            cmb_box_ModelNo_billing.Text = "";
            cmb_ProductsName_billing.Text = "";
            combobox_Quantity_billing.Text = "";

        }

        private void BillingPrintClick(object sender, RoutedEventArgs e)
        {

            PrintDialog printDlg = new PrintDialog();
            FlowDocument doc = new FlowDocument(new Paragraph(new Run(Text_Receipt)));

            doc.Name = "FlowDoc";//selected_ProductsName  selected_ModelNo selected_Quantity
            IDocumentPaginatorSource idpSource = doc;
            printDlg.PrintDocument(idpSource.DocumentPaginator, "Hello WPF Printing.");

            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string query = "UPDATE `customer` SET `Customer Receipt`= @Receipt WHERE `Customer Name`= @name AND `Customer Mobile`= @Number1";

                MySqlConnection con = new MySqlConnection(mycon);
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open();

                cmd.Parameters.Add(new MySqlParameter("@name", Var_Customer_Name));
                cmd.Parameters.Add(new MySqlParameter("@Number1", Var_Customer_Mobile));
                cmd.Parameters.Add(new MySqlParameter("@Receipt", Text_Receipt));
                //close data reader
                cmd.ExecuteNonQuery();


                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          

        }
        private void BillingPrintpreviewbtClick(object sender, RoutedEventArgs e)
        {
         


            Text_Receipt = "*******************KITE-Receipt****************\n" +
                         "Customer Name : " + Var_Customer_Name + " " + "Address : " + Var_Customer_Address + "\n" +
                         "Mobile No : " + Var_Customer_Mobile + " " + "Email : " + Var_Customer_Email + "\n" +
                         "------------------------------------------------------------- \n" +
                         "Products Name : " + selected_ProductsName + "\n" +
                         "Model No : " + selected_ModelNo + "\n" +
                         "Quantity : " + Quantity1 + "\n" +
                         "Price :                                                    " + price_count + " TK" + "\n" +
                         "------------------------------------------------------------- \n" +
                         "Discount (-) :" + V_Discount_billing + "%\t" + total_Discount + "\t\t" + Discount + " TK" + "\n" +
                         "Warranty : " + V_Warranty_billing + "\n" +
                         "VAT(+) :" + V_VAT_billing + "%\t" + total_vat + "\t\t" + VAT + " TK" + "\n" +
                          "------------------------------------------------------------- \n" +
                         "Total :                                                    " + VAT + " TK" + "\n" +
                          "------------------------------------------------------------- \n" +
                          "\n\t\t Bill generated by\n\t\t\t\t KITE Software\n";

            //*****************Receipt print **********
            Receipt_RichTextBox.Document.Blocks.Clear();
            Receipt_RichTextBox.Document.Blocks.Add(new Paragraph(new Run(Text_Receipt)));

         
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
        public static string C_M;
        public static string C_N;
   /*     private void AccountInstallmentsClick(object sender, RoutedEventArgs e)
        {

        } */

        private void AccountBalancebtClick(object sender, RoutedEventArgs e)
        {
            C_N=txtb_CustomerName_Account.Text;
             C_M =txtb_CustomerMobileNo_Account.Text;
            try
            {
                string mycon = "server=localhost;user id=root;database=kite_bd";
                string query = "SELECT `Customer Receipt` FROM `customer` WHERE `Customer Name`= @name2 AND `Customer Mobile`= @Number2 ";
                MySqlConnection con = new MySqlConnection(mycon);
                MySqlCommand cmd = new MySqlCommand(query, con);
                con.Open(); 

                cmd.Parameters.Add(new MySqlParameter("@name2", C_N));
                cmd.Parameters.Add(new MySqlParameter("@Number2", C_M));

                //close data reader
                cmd.ExecuteNonQuery();

                DataTable dt2 = new DataTable();
                
                MySqlDataAdapter da2 = new MySqlDataAdapter(cmd);
                da2.Fill(dt2);
                //Account_RichTextBox
                Account_DataGrid.ItemsSource = dt2.DefaultView;

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }  //ComboBox_DropDownClosed_Statistik_Account
        private void ComboBox_DropDownClosed_Statistik_Account(object sender, EventArgs e)
        {
           string x = cmb_box_Statistik_Account.Text;
           
            string x1 = "total product";
            string x2 = "No. of Products";
            string x3 = "total stock price";
            string x4 = "total no. of sell";
            string x5= "total amount sell";

            if (x == x1)
            {
                try
                {
                    string mycon = "server=localhost;user id=root;database=kite_bd";
                    string sql1 = "SELECT COUNT(*) FROM `product`";
                    MySqlConnection connection2 = new MySqlConnection(mycon);
                    MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                  
                    DataTable dt2 = new DataTable();
                    connection2.Open();
                    MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                    da2.Fill(dt2);

                    StatistikDataGrid.ItemsSource = dt2.DefaultView;
    
                    connection2.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else if (x == x2)
            {
                try
                {
                    string mycon = "server=localhost;user id=root;database=kite_bd";
                    string sql1 = "SELECT SUM(`Quantity`) FROM `product`";
                    MySqlConnection connection2 = new MySqlConnection(mycon);
                    MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                  
                    DataTable dt2 = new DataTable();
                    connection2.Open();
                    MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                    da2.Fill(dt2);

                    StatistikDataGrid.ItemsSource = dt2.DefaultView;

                    connection2.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (x == x3)
            {
                try
                {
                    string mycon = "server=localhost;user id=root;database=kite_bd";
                    string sql1 = "SELECT SUM(`Price`) FROM `product`";
                    MySqlConnection connection2 = new MySqlConnection(mycon);
                    MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);
                
                    DataTable dt2 = new DataTable();
                    connection2.Open();
                    MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                    da2.Fill(dt2);

                    StatistikDataGrid.ItemsSource = dt2.DefaultView;

                    connection2.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (x == x4)
            {
                try
                {
                    string mycon = "server=localhost;user id=root;database=kite_bd";
                    string sql1 = "SELECT COUNT(*) FROM `customer`";
                    MySqlConnection connection2 = new MySqlConnection(mycon);
                    MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);

                    DataTable dt2 = new DataTable();
                    connection2.Open();
                    MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                    da2.Fill(dt2);

                    StatistikDataGrid.ItemsSource = dt2.DefaultView;

                    connection2.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (x == x5)
            {
                try
                {
                    string mycon = "server=localhost;user id=root;database=kite_bd";
                    string sql1 = "SELECT SUM(`Total Amount`) FROM `statistics`";
                    MySqlConnection connection2 = new MySqlConnection(mycon);
                    MySqlCommand cmdSel2 = new MySqlCommand(sql1, connection2);

                    DataTable dt2 = new DataTable();
                    connection2.Open();
                    MySqlDataAdapter da2 = new MySqlDataAdapter(cmdSel2);
                    da2.Fill(dt2);

                    StatistikDataGrid.ItemsSource = dt2.DefaultView;

                    connection2.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }



        private void AccountPrintpreviewClick(object sender, RoutedEventArgs e)
        {

        }

        private void AccountPrintClick(object sender, RoutedEventArgs e)
        {

        }
      
    
    }
}
