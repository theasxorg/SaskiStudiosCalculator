using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace SimpleCalculator
{
    public partial class MainPage : PhoneApplicationPage
    {
        int first;
        int second;
        //int added;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            result.Text += "1"; 
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            result.Text += "2"; 
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            result.Text += "3"; 
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            result.Text += "4"; 
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            result.Text += "5"; 
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            result.Text += "6"; 
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            result.Text += "7"; 
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            result.Text += "8"; 
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            result.Text += "9"; 
        }

        private void Button_Click_Reset(object sender, RoutedEventArgs e)
        {
            result.Text = "";
            first = 0;
            second = 0;
            comms.Text = "Start Over!"; 
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            result.Text += "0"; 
        }

        private void Button_Click_s(object sender, RoutedEventArgs e)
        {
            //TO DO Don't allow user to type more numbers right after = is pressed
            //string result_full = first + "+" + second + "=" + added;
            if (result.Text.Length < 1)
                comms.Text = "Type a number!";
            else {
                first = int.Parse(result.Text);
                second = second + first;
                comms.Text = "Type another number and press =";
                result.Text = ""; 
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            first = int.Parse(result.Text);
            second = second + first;
            result.Text = "Good job!";
            comms.Text = "Result: " + second.ToString();
            first = 0;
            second = 0;
        }
    }
}