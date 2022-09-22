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
        public static String passprove;
        public static String userEmailprove;

        public static String RepeatPassword;
        public static String Name_user;
        public static String ActivatedKey;

        public static String userEmaiSet = "abc@gmail.com";   //from the database
        public static String passSet = "12345678";        //from the database
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


        //########################  login #######################
        private void loginbtn_loginClick(object sender, RoutedEventArgs e)
        {
            userEmailprove = txtb_Email_login.Text;
            passprove = txtb_Password_login.Password;



            int pwLength = passprove.Length;


            if (Lengthpwin <= pwLength)
            {

                if (userEmailprove == userEmaiSet && passprove == passSet)
                {
                    //  this.Hide();
                    CentralWindow open = new CentralWindow();
                    //  MessageBox.Show("Successfully Login :) ");
                    open.Show();
                    this.Close();

                }
                else if (userEmailprove != userEmaiSet && passprove == passSet)
                {
                    txtBlock_login.Text = "!! Check in the Email Nmae , \n\t  :( try again.";
                }
                else if (userEmailprove == userEmaiSet && passprove != passSet)
                {
                    txtBlock_login.Text = "!! Wrong password. Try again..., \n\t  :( try again.";
                }
                else
                {
                    txtBlock_login.Text = "!! Check in the Email Nmae and password , \n\t  :( try again.";
                }

            }
            else
            {
                txtBlock_login.Text = "Password length is short   " + pwLength + "\nYour password must be at least " + Lengthpwin + "  characters long.\n" + "\tYou can try again :(";
            }


        }

        private void Clearbtn_loginClick(object sender, RoutedEventArgs e)
        {

            txtb_Email_login.Text = " ";
            txtb_Password_login.Password = "";
        }



        //#########################   Registration ##########################

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
          

            Name_user = txtb_Name_user.Text;     //Go to database
            userEmailprove = txtb_Email_user.Text;    //Go to database
            ActivatedKey = txtb_ActivatedKey.Text;    //Go to database


            String temppass = txtb_Password_user.Password;
            int pwLength = temppass.Length;

            if (Lengthpwin <= pwLength)
            {
                if (txtb_Password_user.Password == txtb_RepeatPassword_user.Password)
                {
                    passprove = txtb_Password_user.Password;    //Go to database
                    RepeatPassword = txtb_RepeatPassword_user.Password;   //Go to database
                    txtBlock_Reg.Text = "Your password was entered correctly";
                }
                else
                {
                    txtBlock_Reg.Text = "Your password was not entered correctly";
                }

            }
            else
            {
                txtBlock_Reg.Text = "Password length is short   " + pwLength + "\nYour password must be at least " + Lengthpwin + "  characters long.\n" + "\tYou can try again :(";

                temppass = "";
            }

         



        //    MessageBox.Show(" Name_user   " + txtb_Name_user.Text + "\n userEmailprove  " + txtb_Email_user.Text + "\n passprove  " + txtb_Password_user.Password + "\n RepeatPassword  " + txtb_RepeatPassword_user.Password);



        }

        private void Clearbtn_regClick(object sender, RoutedEventArgs e)
        {
            txtb_Name_user.Text = " ";
            txtb_Email_user.Text = " ";
            txtb_Password_user.Password = "";
            txtb_RepeatPassword_user.Password = "";
            

        }
        /*
         *  int t;
            string str ,pw;


            for ( t=3; t >= 1; t--)
            {
                Console.WriteLine("Username (admin.com) :");
                str = Console.ReadLine();
                Console.WriteLine("Password (minimum 5 character) :");
                pw= Console.ReadLine();
                int pwLength = pw.Length;

                // username 
                string s1 = ".com";
                bool bo = str.Contains(s1);

                if (bo == true && pwLength >=5)
                {
                    Console.WriteLine("Thank you, "+str+".");
                    break;
                }
                else
                {
                    Console.WriteLine("!! Check in the Username or password , " + (t-1)+ " try again");


                }

            }


            }
         */
      

    }
}
