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

            MessageBox.Show("Your name is pig lating is: " + pigLatinFirstName + " " + pigLatinLastName);
        }
    }
}
