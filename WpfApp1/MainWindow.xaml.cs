/// Chapter No. 3		Exercise No. 1
/// File Name: MortgagePaymentsGUI.cs
/// @author: Zitlali Martinez
/// Date:  September 19, 2021
///
/// Problem Statement: Ask user to enter their monthly mortgage payment and outstanding balance. 
/// Display how much of the payment goes towards the interest and the principal.
/// 
/// Overall Plan:
/// 1) Prompt user for monthly mortgage payment
/// 2) Prompt user for outstanding balance on mortgage
/// 3) Prompt user to click the button 
/// 4) Calculate how much of the payment goes toward the interest
/// 5) Calculate how much of the payment goes toward the principal
/// 6) Display the payment breakdown in a seperate message box
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

namespace WpfApp1
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
            //Constant for interest rate
            const double INTEREST_RATE = .0639;

            //Read in amounts from text boxes
            double monthlyPayment = double.Parse(monthlyPaymentTextBox.Text);
            double outstandingBalance = double.Parse(outstandingBalanceTextBox.Text);
            double interestPayment;
            double principalPayment;

            //Calculate how much goes to interest
            interestPayment = ((outstandingBalance * INTEREST_RATE) / 12);
            //Calculaye how much goes to the principal
            principalPayment = monthlyPayment - interestPayment;

            //Display payment breakdown in a message box
            MessageBox.Show("Interest Payment: $" + string.Format("{0:0.##}", interestPayment) + "\nPrincipal Payment: $" + string.Format("{0:0.##}", principalPayment));
        }

            
    }
      
    
}
