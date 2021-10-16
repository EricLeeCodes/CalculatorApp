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

namespace CalculatorProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string firstGroup = "";
        string secondGroup = "";
        string userInput = "";
        char function;
        double results = 0.0;

        //Added bool to "restart" the equation after pressing Equals when pressing numbers. 
        bool pressedEquals = false;




        public MainWindow()
        {
            InitializeComponent();
        }




        private void zeroButton_Click(object sender, RoutedEventArgs e)
        {

            if (pressedEquals == true)
            {
                firstGroup = "";
                secondGroup = "";
                userInput = "";
                results = 0.0;
                displayBox.Text = "0";
            }

            displayBox.Text = "";
            userInput += "0";
            displayBox.Text = userInput;
            pressedEquals = false;

        }

        private void oneButton_Click(object sender, RoutedEventArgs e)
        {
            if (pressedEquals == true)
            {
                firstGroup = "";
                secondGroup = "";
                userInput = "";
                results = 0.0;
                displayBox.Text = "0";
            }

            displayBox.Text = "";
            userInput += "1";
            displayBox.Text = userInput;
            pressedEquals = false;


        }

        private void twoButton_Click(object sender, RoutedEventArgs e)
        {

            if (pressedEquals == true)
            {
                firstGroup = "";
                secondGroup = "";
                userInput = "";
                results = 0.0;
                displayBox.Text = "0";
            }

            displayBox.Text = "";
            userInput += "2";
            displayBox.Text = userInput;
            pressedEquals = false;

        }

        private void threeButton_Click(object sender, RoutedEventArgs e)
        {

            if (pressedEquals == true)
            {
                firstGroup = "";
                secondGroup = "";
                userInput = "";
                results = 0.0;
                displayBox.Text = "0";
            }

            displayBox.Text = "";
            userInput += "3";
            displayBox.Text = userInput;
            pressedEquals = false;

        }

        private void fourButton_Click(object sender, RoutedEventArgs e)
        {

            if (pressedEquals == true)
            {
                firstGroup = "";
                secondGroup = "";
                userInput = "";
                results = 0.0;
                displayBox.Text = "0";
            }

            displayBox.Text = "";
            userInput += "4";
            displayBox.Text = userInput;
            pressedEquals = false;

        }

        private void fiveButton_Click(object sender, RoutedEventArgs e)
        {

            if (pressedEquals == true)
            {
                firstGroup = "";
                secondGroup = "";
                userInput = "";
                results = 0.0;
                displayBox.Text = "0";
            }

            displayBox.Text = "";
            userInput += "5";
            displayBox.Text = userInput;
            pressedEquals = false;

        }

        private void sixButton_Click(object sender, RoutedEventArgs e)
        {

            if (pressedEquals == true)
            {
                firstGroup = "";
                secondGroup = "";
                userInput = "";
                results = 0.0;
                displayBox.Text = "0";
            }

            displayBox.Text = "";
            userInput += "6";
            displayBox.Text = userInput;
            pressedEquals = false;

        }
        private void sevenButton_Click(object sender, RoutedEventArgs e)
        {
            if (pressedEquals == true)
            {
                firstGroup = "";
                secondGroup = "";
                userInput = "";
                results = 0.0;
                displayBox.Text = "0";
            }

            displayBox.Text = "";
            userInput += "7";
            displayBox.Text = userInput;
            pressedEquals = false;

        }

        private void eightButton_Click(object sender, RoutedEventArgs e)
        {

            if (pressedEquals == true)
            {
                firstGroup = "";
                secondGroup = "";
                userInput = "";
                results = 0.0;
                displayBox.Text = "0";
            }

            displayBox.Text = "";
            userInput += "8";
            displayBox.Text = userInput;
            pressedEquals = false;

        }

        private void nineButton_Click(object sender, RoutedEventArgs e)
        {

            if (pressedEquals == true)
            {
                firstGroup = "";
                secondGroup = "";
                userInput = "";
                results = 0.0;
                displayBox.Text = "0";
            }

            displayBox.Text = "";
            userInput += "9";
            displayBox.Text = userInput;
            pressedEquals = false;

        }


        //Special Buttons



        private void deciButton_Click(object sender, RoutedEventArgs e)
        {

            displayBox.Text = "";
            userInput += ".";
            displayBox.Text = userInput;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            pressedEquals = false;
            function = '+';
            firstGroup = userInput;
            userInput = "";
            displayBox.Text = "+";


        }

        private void subtractButton_Click(object sender, RoutedEventArgs e)
        {
            pressedEquals = false;
            function = '-';
            firstGroup = userInput;
            userInput = "";
            displayBox.Text = "-";


        }

        private void multiButton_Click(object sender, RoutedEventArgs e)
        {
            pressedEquals = false;
            function = '*';
            firstGroup = userInput;
            userInput = "";
            displayBox.Text = "×";



        }

        private void divideButton_Click(object sender, RoutedEventArgs e)
        {
            pressedEquals = false;
            function = '/';
            firstGroup = userInput;
            userInput = "";
            displayBox.Text = "÷";



        }


        //Equals Button

        private void equalsButton_Click(object sender, RoutedEventArgs e)
        {
            if (true)
            {
                double firstGroupDouble, secondGroupDouble;

                secondGroup = displayBox.Text;
                firstGroupDouble = Convert.ToDouble(firstGroup);
                secondGroupDouble = Convert.ToDouble(secondGroup);



                //Addition
                if (function == '+')
                {
                    results = firstGroupDouble + secondGroupDouble;
                    userInput = results.ToString();
                    displayBox.Text = userInput;



                }
                //Subtraction
                else if (function == '-')
                {
                    results = firstGroupDouble - secondGroupDouble;
                    userInput = results.ToString();
                    displayBox.Text = userInput;



                }
                //Multiplication
                else if (function == '*')
                {
                    results = firstGroupDouble * secondGroupDouble;
                    userInput = results.ToString();
                    displayBox.Text = userInput;

                }
                //Division
                else if (function == '/')
                {
                    results = firstGroupDouble / secondGroupDouble;
                    userInput = results.ToString();
                    displayBox.Text = userInput;

                }

                pressedEquals = true;
            }

        }



        //Clear Button

        private void clearButton_Click(object sender, RoutedEventArgs e)
        {
            firstGroup = "";
            secondGroup = "";
            userInput = "";
            results = 0.0;
            displayBox.Text = "0";
        }




    }
}
