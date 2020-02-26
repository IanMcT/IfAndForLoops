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

namespace ifExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r = new Random();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, RoutedEventArgs e)
        {
            int die1 = r.Next(6) + 1;
            int die2 = r.Next(6) + 1;
            int numberToGuess = 7;
            lblOutput.Content = "";
            int countWins = 0;
            int checkAt = 1000000;

            for (int i = 0; i < 100000000; i++)
            {
                if (checkAt == i)
                {
                    lblOutput.Content = "At " + i.ToString() +
                        " you rolled a " + numberToGuess.ToString() +
                        " " + countWins.ToString() + " times.";
                    checkAt += 1000000;
                }
                die1 = r.Next(6) + 1;
                die2 = r.Next(6) + 1;
               /* lblOutput.Content += " Test " + i.ToString() + 
                    " Die 1: " + die1.ToString() + Environment.NewLine
                    + "Die 2: " + die2.ToString() + Environment.NewLine
                    + "Number to guess: " + numberToGuess.ToString();
                    */
                if (numberToGuess == (die1 + die2))
                {
                    /*lblOutput.Content += Environment.NewLine + "You guessed it!!!";
                    lblOutput.Content += " Doesn't it feel great to win";*/
                    countWins++;
                }
                else if (numberToGuess > (die1 + die2))
                {
/*                    lblOutput.Content += Environment.NewLine + "Your guess was too high.";
                    lblOutput.Content += " Too bad you lost";*/
                }
                else
                {
/*                    lblOutput.Content += Environment.NewLine + "Too low.  Sorry. ";
                    lblOutput.Content += " Sad to lose.";*/
                }//end if statement
            }//end for loop
            lblOutput.Content = "You won " + countWins.ToString() +
                   Environment.NewLine + lblOutput.Content;

        }
    }
}
