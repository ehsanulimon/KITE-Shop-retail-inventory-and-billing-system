using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
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
using System.Configuration;

namespace kite
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>

    public partial class Login : Window

    {
        public static String passprove;
        public static String userEmailprove;

        public static String RepeatPassword;
        public static String Name_user;
        public static String ActivatedKey;
        public static int  Lengthpwin = 8;


    
        public Login()
        {
            InitializeComponent();
        }

        private void exitbtnClick(object sender, RoutedEventArgs e)
        {
            CentralWindow open = new CentralWindow();
            open.Show();
            this.Close();
        }
        //-------------------Visibility mode change--------------
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

        //########################  login #######################
        private void loginbtn_loginClick(object sender, RoutedEventArgs e)
        {
            userEmailprove = txtb_Email_login.Text;
            passprove = txtb_Password_login.Password;

            try
            {
                
                string mycon = "server=localhost;user id=root;database=kite_bd";

                string sql = "SELECT * FROM `user` WHERE `EMAIL` = @userEmail AND `PASSWORD` = @userPass";
                MySqlConnection connection = new MySqlConnection(mycon);
                MySqlCommand cmdSel = new MySqlCommand(sql, connection);
                cmdSel.Parameters.Add("@userEmail", MySqlDbType.VarChar).Value = userEmailprove;
                cmdSel.Parameters.Add("@userPass", MySqlDbType.VarChar).Value = passprove;

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmdSel);

                da.SelectCommand = cmdSel;
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    
                    CentralWindow open = new CentralWindow();
                    open.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("There is no information about this user");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error : " + ex.Message);
            }

        }

        private void Clearbtn_loginClick(object sender, RoutedEventArgs e)
        {

            txtb_Email_login.Text = " ";
            txtb_Password_login.Password = "";
        }


        //#########################   Registration ##########################

        private void Submitbtn_regClick(object sender, RoutedEventArgs e)
        {
          
            Name_user = txtb_Name_user.Text;     //Go to database
            userEmailprove = txtb_Email_user.Text;    //Go to database
            ActivatedKey = txtb_ActivatedKey.Text;    //Go to database*


            String temppass1 = txtb_Password_user.Password;
            int pwLength1 = temppass1.Length;
            String temppass2 = txtb_RepeatPassword_user.Password;
            int pwLength2 = temppass2.Length;

            if (Lengthpwin <= pwLength1 || Lengthpwin <= pwLength2)
            {
                if (txtb_Password_user.Password == txtb_RepeatPassword_user.Password)
                {
                    passprove = txtb_Password_user.Password;    //Go to database
                    RepeatPassword = txtb_RepeatPassword_user.Password;  
                    txtBlock_Reg.Text = "Your password was entered correctly";

                    //-------------------------------------------------------
                    string mycon = "server=localhost;user id=root;database=kite_bd";

                    string query = "INSERT INTO `user`(`NAME`, `EMAIL`,PASSWORD) VALUES ('" + Name_user + "','" + userEmailprove + "','" + passprove + "')";

                    MySqlConnection con = new MySqlConnection(mycon);
                    MySqlCommand com = new MySqlCommand(query, con);
                    MySqlDataReader reader;


                    con.Open();
                    reader = com.ExecuteReader();
                    //--------------------------------

                    txtb_Name_user.Text = "";
                    txtb_Email_user.Text = "";
                    txtb_Password_user.Password = "";
                    txtb_RepeatPassword_user.Password = "";

                    Registration_gridX.Visibility = Visibility.Collapsed;
                    login_gridX.Visibility = Visibility.Visible;
                }
                else
                {
                    txtBlock_Reg.Text = "Your password was not entered correctly";
                    txtb_Password_user.Password = "";
                    txtb_RepeatPassword_user.Password = "";
                }

            }
            else
            {
                txtBlock_Reg.Text = "Password length is short \nYour password must be at least " + Lengthpwin + "  characters long.\n" + "\tYou can try again :(";
                txtb_Password_user.Password = "";
                txtb_RepeatPassword_user.Password = "";
                temppass1 = " ";
                temppass2 = " ";
            }

        }

        private void Clearbtn_regClick(object sender, RoutedEventArgs e)
        {
            txtb_Name_user.Text = " ";
            txtb_Email_user.Text = " ";
            txtb_Password_user.Password = "";
            txtb_RepeatPassword_user.Password = "";
            

        }


      

    }
}
