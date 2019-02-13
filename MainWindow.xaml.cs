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

namespace Task_8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        decimal number1;

        decimal memory;

        string operation;

        bool isFirstDigitFromNumber2;

        public MainWindow()
        {
            InitializeComponent();

            operation = "";

            isFirstDigitFromNumber2 = false;
        }

        private void Input(string enter)
        {
            if (operation == "" && number1 != 0)

            {
                ShowField.Text = "";
                number1 = 0;
            }

                if (isFirstDigitFromNumber2 == true)
            {
                ShowField.Text = "";
                isFirstDigitFromNumber2 = false;
            }

            if (ShowField.Text == "0")
            {
                ShowField.Text = enter;
            }
            else
            {
                ShowField.Text += enter;

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Input( (string)((Button)e.OriginalSource).Content);            
        }

        private void Button_Multiply_Click(object sender, RoutedEventArgs e)
        {
            if (operation != "")
            {
                ShowField.Text = Calculate().ToString();
            }
            else
            {
                number1 = decimal.Parse(ShowField.Text);
            }
            operation = "×";
            isFirstDigitFromNumber2 = true;
        }

        private void Button_Plus_Click(object sender, RoutedEventArgs e)
        {
            if (operation != "")
            {
                ShowField.Text = Calculate().ToString();
            }
            else
            {
                number1 = decimal.Parse(ShowField.Text);
            }
            operation = "+";
            isFirstDigitFromNumber2 = true;
        }

        private void Button_Minus_Click(object sender, RoutedEventArgs e)
        {
            if (operation != "")
            {
                ShowField.Text = Calculate().ToString();
            }
            else
            {
                number1 = decimal.Parse(ShowField.Text);
            }
            operation = "-";
            isFirstDigitFromNumber2 = true;
        }

        private void Button_Divide_Click(object sender, RoutedEventArgs e)
        {
            if (operation != "")
            {
                ShowField.Text = Calculate().ToString();
            }
            else
            {
                number1 = decimal.Parse(ShowField.Text);
            }
            operation = "÷";
            isFirstDigitFromNumber2 = true;
        }

        private void Button_Percent_Click(object sender, RoutedEventArgs e)
        {
            number1 = decimal.Parse(ShowField.Text);
            operation = "%";
            isFirstDigitFromNumber2 = true;
        }

        private void Button_Exponent_Click(object sender, RoutedEventArgs e)
        {
            number1 = decimal.Parse(ShowField.Text);
            operation = "^";
            isFirstDigitFromNumber2 = true;
        }

        private void Button_Clear_Click(object sender, RoutedEventArgs e)
        {
            ShowField.Text = "0";
            number1 = 0;
            operation = "";
        }

        private void Button_Sign_Click(object sender, RoutedEventArgs e)
        {
            ShowField.Text = (decimal.Parse(ShowField.Text) * (-1)).ToString();
        }

        private void Button_Dot_Click(object sender, RoutedEventArgs e)
        {
            ShowField.Text = ShowField.Text + ",";
        }

        private decimal Calculate()
        {
            decimal number2 = decimal.Parse(ShowField.Text);
            decimal result = 0;

            switch (operation)

            {
                case "+":

                    result = (number1 + number2);
                    break;

                case "-":

                    result = (number1 - number2);
                    break;

                case "×":

                    result = (number1 * number2);
                    break;

                case "÷":

                    result = (number1 / number2);
                    break;

                case "^":

                    result = (decimal)Math.Pow((double)number1, (double)number2);
                    break;

                case "%":

                    result = ((number2 / 100) * number1);
                    break;
            }

            operation = "";
            number1 = result;

            return result;
        }

        private void Button_Equal_Click(object sender, RoutedEventArgs e)
        {
            ShowField.Text = Calculate().ToString();
        }

        private void Button_SavePlus_Click(object sender, RoutedEventArgs e)
        {
            memory = memory + decimal.Parse(ShowField.Text);
        }

        private void Button_SaveMinus_Click(object sender, RoutedEventArgs e)
        {
            memory = memory + (decimal.Parse(ShowField.Text) * -1);
        }

        private void Button_SavedShow_Click(object sender, RoutedEventArgs e)
        {
            ShowField.Text = memory.ToString();
        }

        private void Button_SavedClear_Click(object sender, RoutedEventArgs e)
        {
            memory = 0;
        }

        private void Button_Off_Click(object sender, RoutedEventArgs e)
        {
            ShowField.Text = "";
            memory = 0;
            number1 = 0;
            operation = "";
        }


    }
}