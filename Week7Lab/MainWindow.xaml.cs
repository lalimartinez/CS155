/// Chapter No. 6		Lab No. 1
/// File Name: Calculator.cs
/// @author: Zitlali Martinez
/// Date:  October 10, 2021
///
/// Problem Statement: Take two values from a user and have the user choose which operation to perform on those values.
/// 
/// 
/// Overall Plan:
/// 1) Prompt user for two values
/// 2) Prompt user to select which operation to perform on the values
/// 3) Prompt user to click the button
/// 4) Use a switch statement to switch between the operations
/// 5) For index 0, add the values
/// 6) For index 1, subtract the values
/// 7) For index 2, multiply the values
/// 8) For index 3, divide the values
/// 9) For index 4, mod the values
/// 10) As a default, let user know that an operation must be selected
/// 11) Handle the exception if the user tries to divide by zero
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

namespace Week7Lab
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

        private void calculationButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int Operation = listBox.SelectedIndex;
                decimal leftHand = Convert.ToDecimal(leftTextBox.Text);
                decimal rightHand = Convert.ToDecimal(rightTextBox.Text);
                decimal result = 0;

                switch(Operation)
                {
                    //Add values
                    case 0:
                        result = leftHand + rightHand;
                        resultTextBox.Text = result.ToString();
                        break;

                    //Subtract values
                    case 1:
                        result = leftHand - rightHand;
                        resultTextBox.Text = result.ToString();
                        break;

                    //Multiply values
                    case 2:
                        result = leftHand * rightHand;
                        resultTextBox.Text = result.ToString();
                        break;

                    //Divide values
                    case 3:
                        result = leftHand / rightHand;
                        resultTextBox.Text = result.ToString();
                        break;

                    //Mod values
                    case 4:
                        result = leftHand % rightHand;
                        resultTextBox.Text = result.ToString();
                        break;

                    //Let user know they much select an operation
                    default:
                        result = 0;
                        MessageBox.Show("No operation selected.");
                        break;
                }
            }
            //Handle exception if user tries dividing by zero
            catch(DivideByZeroException)
            {
                MessageBox.Show("Error: Cannot divide by zero.");
            }
        }
    }
}
