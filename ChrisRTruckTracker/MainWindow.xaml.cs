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

namespace ChrisRTruckTracker
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

       
        public void buttonPrint_Click(object sender, RoutedEventArgs e)
        {
            string driversName;
            string driversNumber;
            string driversPhone;

            driversName = driverNameTextbox.Text;
            labelNameDriver.Content = driversName;
            driversNumber = driverNumberTextbox.Text;
            labelNumberDriver.Content = driversNumber;
            driversPhone = driverPhoneTextbox.Text;
            labelPhoneDriver.Content = driversPhone;

            int endMiles;
            int startMiles;
            int totalMiles;
            double pay;

            totalMiles = 0;

            int.TryParse(endMilesTextbox.Text, out endMiles);
            int.TryParse(startMilesTextbox.Text, out startMiles);

            totalMiles = endMiles - startMiles;

            labelMilesTotal.Content = totalMiles.ToString();

            pay = totalMiles * 0.25;
            labelPayDue.Content = pay.ToString();
        }
    }
}
