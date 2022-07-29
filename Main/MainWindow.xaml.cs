using System;
using System.ComponentModel;
using System.Threading;
using System.Windows;
using System.Windows.Threading;

namespace Kite
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

        // start timerlabel
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromSeconds(.01);
            dt.Tick += dtTicker;
            dt.Start();
        }
        private int incriment = 0;
        public void dtTicker(object sender, EventArgs e)
        {
            incriment++;
           
            if(incriment <= 101)
            {
                timerlabel.Content = incriment.ToString();
            }
            else
            {
                timerlabel.Content = "100";
            }
        }


        // end timerlabel
    }
}
