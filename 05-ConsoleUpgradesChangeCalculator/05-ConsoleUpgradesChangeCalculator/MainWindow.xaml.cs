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

namespace _05_ConsoleUpgradesChangeCalculator
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


        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //Ask the user to enter the cost
                //Console.WriteLine("Enter cost: ");
                //Read and define cost information given
                //string cost = Console.ReadLine();
                string cost = totalBox.Text;
                //Convert submitted cost input into an decimal
                decimal totalCost = decimal.Parse(cost);


                //Ask the user to enter the money received
                //Console.WriteLine("Enter money received from customer: ");
                //Read and define money received information given
                //string money = Console.ReadLine();
                string money = amountBox.Text;
                //Convert submited money received input into an integer
                decimal receivedMoney = decimal.Parse(money);

                //Figure out the change by subtracting totalCost from receivedMoney
                decimal change = receivedMoney - totalCost;

                //Turn change into quarters, dimes, nickels, and pennies
                //When dealing with doubles in a decimal situation suffix each number with a letter m
                //Math.Floor rounds down and Math.Ceiling rounds up
                //Modulo -> % takes the division operation and looks at the remainder, e.g. 3.25, the module looks at 0.25
                decimal quartersFractional = change / 0.25m;
                decimal actualQuarters = Math.Floor(quartersFractional);

                decimal dimesFractional = (change % 0.25m) / 0.1m;
                decimal actualDimes = Math.Floor(dimesFractional);

                decimal nickelsFractional = ((change % 0.25m) % 0.1m) / 0.05m;
                decimal actualNickels = Math.Floor(nickelsFractional);

                decimal penniesFractional = (((change % 0.25m) % 0.1m) % 0.05m) / 0.01m;
                decimal actualPennies = Math.Floor(penniesFractional);

                //Give change and quarters, dimes, nickels, and pennies results back to the user

                //Console.WriteLine("Amount to return to customer: " + change);
                returnDisplay.Text = change.ToString();

                //Console.WriteLine("Change to be returned in the following denominations: ");

                //Console.WriteLine("Quarters: " + actualQuarters);
                quartersDisplay.Text = actualQuarters.ToString();

                //Console.WriteLine("Dimes: " + actualDimes);
                dimesDisplay.Text = actualDimes.ToString();

                //Console.WriteLine("Nickels: " + actualNickels);
                nickelsDisplay.Text = actualNickels.ToString();

                //Console.WriteLine("Pennies: " + actualPennies);
                penniesDisplay.Text = actualPennies.ToString();

                //Console.ReadLine();

                totalBox.Clear();
                amountBox.Clear();

            }


            catch (Exception ex)
            {

                MessageBox.Show("Oops! Please enter a valid number!");

            }
        }

        private void clearButton_Click_1(object sender, RoutedEventArgs e)
        {
            totalBox.Clear();
            amountBox.Clear();
            returnDisplay.Clear();
            quartersDisplay.Clear();
            dimesDisplay.Clear();
            nickelsDisplay.Clear();
            penniesDisplay.Clear();
        }

            }
    }

