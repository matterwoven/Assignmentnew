using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Assignmentnew
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
        static bool ContainsLetters(string input)
        {
            // Use a regular expression to check for letters (A-Z or a-z)
            return Regex.IsMatch(input, "[A-Za-z]");
        }
        private void AvgRes_Result_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Subtract_btn_Click(object sender, RoutedEventArgs e)
        {
            string number1 = PosNeg_Number1.Text;
            string number2 = PosNeg_Number2.Text;
            // Parsing my numbers
            int num1 = int.Parse(number1);
            int num2 = int.Parse(number2);

            string sign = "-";
            string equalSign = "=";
            // Doing math with our new int
            int resultsub = num1 - num2;

            string equation2 = $"{resultsub}";

            // Displaying the equation string
            PosNeg_Result.Text = equation2;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PosNeg_Number2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PosNeg_Result_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MultDiv_Number2_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MultDiv_Result_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void Mult_btn(object sender, RoutedEventArgs e)
        {
            if (ContainsLetters(MultDiv_Number1.Text) || ContainsLetters(MultDiv_Number2.Text))
            {
                MessageBox.Show("Invalid");
            }
            else
            {
                //Multiply
                string number1 = MultDiv_Number1.Text;
                string number2 = MultDiv_Number2.Text;
                // Parsing my numbers
                int num1 = int.Parse(number1);
                int num2 = int.Parse(number2);

                string sign = "*";
                string equalSign = "=";
                // Doing math with our new int
                int resultmultdiv = num1 * num2;

                string equation = $"{resultmultdiv}";

                // Displaying the equation string
                MultDiv_Result.Text = equation;
            }
            static bool ContainsLetters(string input)
            {
                // Use a regular expression to check for letters (A-Z or a-z)
                return Regex.IsMatch(input, "[A-Za-z]");
            }
        }

        private void Div_btn(object sender, RoutedEventArgs e)
        {
            if (ContainsLetters(MultDiv_Number1.Text) || ContainsLetters(MultDiv_Number2.Text))
            {
                MessageBox.Show("Invalid");
            }
            else
            {
                //Divide
                string number1 = MultDiv_Number1.Text;
                string number2 = MultDiv_Number2.Text;
                // Parsing my numbers
                int num1 = int.Parse(number1);
                int num2 = int.Parse(number2);

                string sign = "/";
                string equalSign = "=";
                // Doing math with our new int
                decimal resultmultdiv = num1 / num2;

                string equation = $"{resultmultdiv}";

                // Displaying the equation string
                MultDiv_Result.Text = equation;


            }
        }
        private void Subtract_btn(object sender, RoutedEventArgs e)
        {
            if (ContainsLetters(PosNeg_Number1.Text) || ContainsLetters(PosNeg_Number2.Text))
            {
                MessageBox.Show("Invalid");
            }
            else
            {
                //Negative
                string number1 = PosNeg_Number1.Text;
                string number2 = PosNeg_Number2.Text;
                // Parsing my numbers
                int num1 = int.Parse(number1);
                int num2 = int.Parse(number2);

                string sign = "-";
                string equalSign = "=";
                // Doing math with our new int
                int resultaddsub = num1 - num2;

                string equation = $"{resultaddsub}";

                // Displaying the equation string
                PosNeg_Result.Text = equation;


            }

        }
        private void Add_btn(object sender, RoutedEventArgs e)
        {
            if (ContainsLetters(PosNeg_Number1.Text) || ContainsLetters(PosNeg_Number2.Text))
            {
                MessageBox.Show("Invalid");
            }
            else
            {
                //Positive
                string number1 = PosNeg_Number1.Text;
                string number2 = PosNeg_Number2.Text;
                // Parsing my numbers
                int num1 = int.Parse(number1);
                int num2 = int.Parse(number2);

                string sign = "+";
                string equalSign = "=";
                // Doing math with our new int
                int resultaddsub = num1 + num2;

                string equation = $"{resultaddsub}";

                // Displaying the equation string
                PosNeg_Result.Text = equation;
            }
            void AverageOfRes_btn(object sender, RoutedEventArgs e)
            {

            }

        }

        private void AverageOfRes_btn(object sender, RoutedEventArgs e)
        {

            if (ContainsLetters(PosNeg_Number1.Text) || ContainsLetters(PosNeg_Number2.Text))
            {
                MessageBox.Show("Invalid");
            }
            else
            {

                string num1 = PosNeg_Result.Text;
                string num2 = MultDiv_Result.Text;

                int numbers1 = int.Parse(num1);
                int numbers2 = int.Parse(num2);

                int beforeavg = numbers1 + numbers2;
                int resultavg = beforeavg / 2;

                string equation = $"({numbers1} + {numbers2})/2 = {resultavg}";
                AvgRes_Result.Text = equation;
            }
        }
    }
}

