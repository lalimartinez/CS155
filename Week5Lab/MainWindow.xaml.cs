/// Chapter No. 4		Lab No. 1
/// File Name: SpeedLimitGUI.cs
/// @author: Zitlali Martinez
/// Date:  September 26, 2021
///
/// Problem Statement: Ask user to enter the speed limit and the limit thet are going at.
/// Display if they will get a penalty and change the background color accordingly.
/// 
/// 
/// Overall Plan:
/// 1) Prompt user for speed limit
/// 2) Prompt user for their speed
/// 3) Prompt user to click the button
/// 4) Display message stating if they will get a penalty
/// 5) If they are going at the speed limit, change background color to green
/// 6) Else if they are going more than 5 miles above the speed limit, change background color to red
/// 7) Else, change background color to yellow
///
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

namespace Week5Lab
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Read in the speed limit and limit
            int speedLimit = Int32.Parse(speedLimitTextBox.Text);
            int speed = Int32.Parse(speedTextBox.Text);

            //If speed equal to speed limit, change color to green
            //If speed more than 5 miles above speed limit, change color to red
            //If speed within 5 miles more than limit, change color to yellow
            if (speed == speedLimit)
            {
                TempCanvas.Background = Brushes.Green;
                messageLabel.Content = "No penalty. Your are going at the legal speed.";
            }
            else if(speed > (speedLimit + 5))
            {
                TempCanvas.Background = Brushes.Red;
                messageLabel.Content = "You are speeding and there is a penalty.";
            }
            else
            {
                TempCanvas.Background = Brushes.Yellow;
                messageLabel.Content = "You are speeding but there is no penalty.";
            }
        }
    }
}
