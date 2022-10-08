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

namespace kite
{
    /// <summary>
    /// Interaction logic for CentralWindow.xaml
    /// </summary>
    public partial class CentralWindow : Window
    {
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
            
        }
      
       private void StockinputADDClick(object sender, RoutedEventArgs e)
        {

        }

        private void StockinputUpdateClick(object sender, RoutedEventArgs e)
        {

        }

        private void StockinputDeleteClick(object sender, RoutedEventArgs e)
        {

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
        }

        private void NextbtcategoryClick(object sender, RoutedEventArgs e)
        {

       
            if(Category_Viewgrid2.Visibility == Visibility.Visible)
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
            txtb_Search_Category.Text = " ";
        }

        private void CategoryViewgrid2_BT1Click(object sender, RoutedEventArgs e)
        {

        }

        private void CategoryViewgrid2_BT2Click(object sender, RoutedEventArgs e)
        {

        }

        private void CategoryViewgrid2_BT3Click(object sender, RoutedEventArgs e)
        {

        }

        private void CategoryViewgrid2_BT4Click(object sender, RoutedEventArgs e)
        {

        }

        private void CategoryViewgrid1_BT1Click(object sender, RoutedEventArgs e)
        {

        }

        private void CategoryViewgrid1_BT2Click(object sender, RoutedEventArgs e)
        {

        }

        private void CategoryViewgrid1_BT3Click(object sender, RoutedEventArgs e)
        {

        }

        private void CategoryViewgrid1_BT4Click(object sender, RoutedEventArgs e)
        {

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
            txtb_ProductsName_billing.Text = " ";
            
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
