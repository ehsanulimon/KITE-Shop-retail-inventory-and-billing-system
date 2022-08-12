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
using System.Text;

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

        private void XbtbClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void maxbtnClick(object sender, RoutedEventArgs e)
        {

          
                if (this.WindowState == System.Windows.WindowState.Normal)
                {
                    this.WindowState = System.Windows.WindowState.Maximized;
                    
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

        private void sevetestclick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Click seve");
        }


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
            MessageBox.Show("NewCommandBinding_Executed");
        }
        //Label_MouseLeftButtonDown
        private void Label_MouseLeftButtonDown(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Label_MouseLeftButtonDown");
        }

        private void test(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("MouseButtonEventArgs");
           
        }

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
        { //txtb_CustomerName_billing txtb_CustomerAddress_billing  txtb_CustomerMobileNo_billing txtb_CustomerEmail_billing  
          //Customer Name  //Address  //Mobile   //Email

            /*Setting a string With:

SelectAll()
RichTextBox.Selection.Text = "AA"
And returning with:

SelectAll()
Return RichTextBox.Selection.Text
Returns "AA" with carriage-return*/
            //Receipt_RichTextBox.AppendText("Customer Name: "+ txtb_CustomerName_billing.Text + "\nAddress: " + txtb_CustomerAddress_billing.Text + "\nMobile " + txtb_CustomerMobileNo_billing.Text + "\nEmail: " + txtb_CustomerEmail_billing.Text);

            Receipt_RichTextBox.Document.Blocks.Clear();
            Receipt_RichTextBox.Document.Blocks.Add(new Paragraph(new Run(
                "Customer Name: " + txtb_CustomerName_billing.Text 
                + "\nAddress: " + txtb_CustomerAddress_billing.Text 
                + "\nMobile " + txtb_CustomerMobileNo_billing.Text
                + "\nEmail: " + txtb_CustomerEmail_billing.Text)));
        }
        
        private void BillingCleanClick(object sender, RoutedEventArgs e)
        {
            Receipt_RichTextBox.Document.Blocks.Clear();
        }

        private void BillingPrintClick(object sender, RoutedEventArgs e)
        {
            
        }
        private void BillingPrintpreviewbtClick(object sender, RoutedEventArgs e)
        {

        }

        private void CustomertextboxcleanClick(object sender, RoutedEventArgs e)
        {

        }

        private void productstextboxCleanClick(object sender, RoutedEventArgs e)
        {

        }

    

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
