/// Chapter No. 3		Lab No. 1
/// File Name: PigLatinGUI.cs
/// @author: Zitlali Martinez
/// Date:  September 19, 2021
///
/// Problem Statement: Ask user for first and last name and translate it to pig latin.
/// Display the pig latin name in a message box.
/// 
/// 
/// Overall Plan:
/// 1) Prompt user for first name
/// 2) Prompt user for last name
/// 3) Prompt user to click button to generate pig latin name
/// 4) Translate first name to pig latin
/// 5) Translate last name to pig latin
/// 6) Display pig latin name is a seperate message box
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

namespace Week4Lab1
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
            String firstName = firstNameTextBox.Text;
            String lastName = lastNameTextBox.Text;
            String pigLatinFirstName;
            String pigLatinLastName;
            firstName = firstName.ToLower();
            lastName = lastName.ToLower();

            pigLatinFirstName = firstName.Substring(1, firstName.Length - 1) + firstName.Substring(0, 1) + "ay";
            pigLatinFirstName = pigLatinFirstName.Substring(0, 1).ToUpper() + pigLatinFirstName.Substring(1, pigLatinFirstName.Length - 1);

            pigLatinLastName = lastName.Substring(1, lastName.Length - 1) + lastName.Substring(0, 1) + "ay";
            pigLatinLastName = pigLatinLastName.Substring(0, 1).ToUpper() + pigLatinLastName.Substring(1, pigLatinLastName.Length - 1);

            MessageBox.Show("Your name in pig latin is: " + pigLatinFirstName + " " + pigLatinLastName);
        }
    }
}
