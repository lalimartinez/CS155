/// Chapter No. 4		Exercise No. 1
/// File Name: BMICalculatorGUI.cs
/// @author: Zitlali Martinez
/// Date:  September 26, 2021
///
/// Problem Statement: Ask user to enter their height an weight. Calculate their BMI. 
/// Display a message saying if their BMI is below, within, or above the healthy range and change the background color accordingly.
/// 
/// Overall Plan:
/// 1) Prompt user for their weight in pounds 
/// 2) Prompt user for their height in inches
/// 3) Prompt user to click the button 
/// 4) Calculate the user's BMI
/// 5) Print message saying whether BMI is below, within, or above the healthy range
/// 6) If BMI is below healthy range, change background color to blue
/// 7) Else if, BMI is within healthy range, change background color to green
/// 8) Else, change background color to yellow
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

namespace HomeworkWeek5Part1
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
            //Read in weight and heigh from textboxes
            double weight = double.Parse(weightTextBox.Text);
            double height = double.Parse(heightTextBox.Text);
            double BMI;

            //Calculate BMI
            BMI = (weight * 720) / (height * height);

            //Set text in BMI textbox to the BMI
            BMItextBox.Text = BMI.ToString();

            //Use if/else if/else to change color 
            //Blue if below helthy range, green if healthy, yellow if above
            if(BMI < 15)
            {
                TempCanvas.Background = Brushes.LightBlue;
                resultsLabel.Content = "Your BMI is below the healthy range.";
            }
            else if(BMI >= 15 && BMI <= 26)
            {
                TempCanvas.Background = Brushes.Green;
                resultsLabel.Content = "Your BMI is within the healthy range.";
            }
            else
            {
                TempCanvas.Background = Brushes.Yellow;
                resultsLabel.Content = "Your BMI is above the healthy range.";
            }
        }
    }
}
