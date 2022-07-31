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
using System.Windows.Media.Animation;
using System.Windows.Threading;


namespace kite
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

        /// <temp>
        /// //// 
       
        private void nextbtnClick(object sender, RoutedEventArgs e)
        {
            Login op = new Login();
            op.Show();
            Close();
        }
        /// <end temp>
        /// //// 

        // Start / Stop Timer

        DispatcherTimer _timer = new DispatcherTimer();
        int counter = 0;

        private void timer_Tick(object sender, EventArgs e)
        {
            counter++;
            TimerLabel.Text = counter.ToString();

            if (counter == 100)
            {
               
                _timer.Stop();
                TimerLabel.Text = "0".ToString();
            
                Login op = new Login();
                op.Show();
                Close();
            }
          
        }

        private void StartTimer()
        {
            cpb_uc.Visibility = Visibility.Visible;

            if (counter > 0)
            {
                _timer.Tick -= timer_Tick;
                counter = 0;
            }

            _timer.Interval = TimeSpan.FromMilliseconds(188);
            _timer.Tick += timer_Tick;
            _timer.Start();
           
        }

        private void StopTimer()
        {
            if (counter > 0)
            {
                _timer.Tick -= timer_Tick;
                counter = 0;
            }

            _timer.Stop();
            cpb_uc.Visibility = Visibility.Collapsed;
            TimerLabel.Text = "0".ToString();
         
        }

     
          private void StartAnimation()
            {
                ((Storyboard)cpb_uc.Resources["ProgressBarAnimation"]).Begin();
            }

            private void StopAnimation()
            {
                ((Storyboard)cpb_uc.Resources["ProgressBarAnimation"]).Stop();
            }

        private void loaded(object sender, RoutedEventArgs e)

        {
        
            StartTimer();
            StartAnimation();
        }


    }
}
