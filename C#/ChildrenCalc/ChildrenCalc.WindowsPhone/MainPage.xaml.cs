using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Windows;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace ChildrenCalc
{
    public partial class MainPage : Page
    {
        //int first;
        //int second;
        int inputNum;
        //string firstNum;
        //string secondNum;
        int added;

        // random number generation
        Random rnd = new Random();

        public MainPage()
        {

            InitializeComponent();


            //if result.Text's lenght is more than 2, disable all the buttons from 0 to 9
            // disable all the buttons after result.Text has 2 chars inside
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            result.Text += "1";

            // enable clear and equals buttons if result isn't empty
            if (result.Text.Length > 0)
            {
                Clear_Button.IsEnabled = true;
                Equals_Button.IsEnabled = true;
            }
            Buttons_off();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            result.Text += "2";

            // enable clear and equals buttons if result isn't empty
            if (result.Text.Length > 0)
            {
                Clear_Button.IsEnabled = true;
                Equals_Button.IsEnabled = true;
            }
            Buttons_off();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            result.Text += "3";

            // enable clear and equals buttons if result isn't empty
            if (result.Text.Length > 0)
            {
                Clear_Button.IsEnabled = true;
                Equals_Button.IsEnabled = true;
            }
            Buttons_off();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            result.Text += "4";

            // enable clear and equals buttons if result isn't empty
            if (result.Text.Length > 0)
            {
                Clear_Button.IsEnabled = true;
                Equals_Button.IsEnabled = true;
            }
            Buttons_off();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            result.Text += "5";

            // enable clear and equals buttons if result isn't empty
            if (result.Text.Length > 0)
            {
                Clear_Button.IsEnabled = true;
                Equals_Button.IsEnabled = true;
            }
            Buttons_off();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            result.Text += "6";

            // enable clear and equals buttons if result isn't empty
            if (result.Text.Length > 0)
            {
                Clear_Button.IsEnabled = true;
                Equals_Button.IsEnabled = true;
            }
            Buttons_off();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            result.Text += "7";

            // enable clear and equals buttons if result isn't empty
            if (result.Text.Length > 0)
            {
                Clear_Button.IsEnabled = true;
                Equals_Button.IsEnabled = true;
            }
            Buttons_off();
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            result.Text += "8";

            // enable clear and equals buttons if result isn't empty
            if (result.Text.Length > 0)
            {
                Clear_Button.IsEnabled = true;
                Equals_Button.IsEnabled = true;
            }
            Buttons_off();
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            result.Text += "9";

            // enable clear and equals buttons if result isn't empty
            if (result.Text.Length > 0)
            {
                Clear_Button.IsEnabled = true;
                Equals_Button.IsEnabled = true;
            }
            Buttons_off();
        }

        private void Button_Click_Reset(object sender, RoutedEventArgs e)
        {
            // clear result, switch clear and equals buttons off
            // change equals fore to black, reff butons_on
            result.Text = "";
            equals.Text = "=";
            Clear_Button.IsEnabled = false;
            Equals_Button.IsEnabled = false;
            equals.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
            Buttons_on();
        }

        private void Button_Click_0(object sender, RoutedEventArgs e)
        {
            result.Text += "0";

            // enable clear and equals buttons if result isn't empty
            if (result.Text.Length > 0)
            {
                Clear_Button.IsEnabled = true;
                Equals_Button.IsEnabled = true;
            }
            Buttons_off();
        }

        private void Button_Click_hs(object sender, RoutedEventArgs e)
        {
            // reff numbers_add method to populate _hs boxes
            numbers_add();

            // #096bb2 Color blueColor = Color.FromArgb(255,9,107,178);
            // #b21512 Color redColor = Color.FromArgb(255, 178, 21, 18);

            // reff gen_hearts so the ifs are innitiated
            gen_hearts();
        }

        private void Button_Click_equals(object sender, RoutedEventArgs e)
        {
            // reff numbers_add method to populate _hs boxes
            numbers_add();
            // disable equals on press
            Equals_Button.IsEnabled = false;

            // put the first and second numbers, parsed to var added
            added = int.Parse(firstInt.Text) + int.Parse(secondInt.Text);
            // put the parsed input of the user into inputNum
            inputNum = int.Parse(result.Text);

            // if the input from the user matches with the correct add value of 1+2, give success
            if (inputNum == added)
            {
                // reff button
                But_turn_off();
                equals.Foreground = new SolidColorBrush(Windows.UI.Colors.Green);
                equals.Text = "=";
                // show next button
                Clear_Button.Visibility = Visibility.Collapsed;
                next_button.Visibility = Visibility.Visible;
            }
            // if input is wrong, give error
            else
            {
                equals.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
                equals.Text = "≠";
            }
            // if these are not visible it won't enter the ifs inside the method, thus not hiding the boxes, if already visible
            if (first_hs.Visibility != Visibility.Visible && second_hs.Visibility != Visibility.Visible)
            {
                //reff gen_hearts so the ifs are innitiated
                gen_hearts();
            }
        }
        private void next_button_click(object sender, RoutedEventArgs e)
        {
            // only hide the app's elements to their default state, no need for gen_hearts reference    
            if (first_hs.Visibility == Visibility.Visible && second_hs.Visibility == Visibility.Visible)
            {
                firstInt.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                secondInt.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                first_hs.Visibility = Visibility.Collapsed;
                second_hs.Visibility = Visibility.Collapsed;
                // call animation
                slide_to_bottom.Begin();
                fade_out.Begin();
                // change the font and color back to original
                main_hs_button.FontFamily = new FontFamily("Assets/saski.ttf#Saski");
                main_hs_button.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                main_hs_copy.Visibility = Visibility.Collapsed;
            }
            // enable buttons
            Buttons_on();
            // generate new numbers
            number1Load2();
            number2Load2();
            // make equals black
            equals.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
            equals.Text = "=";
            // clear result
            result.Text = "";
            // hide this and show clear button
            next_button.Visibility = Visibility.Collapsed;
            Clear_Button.Visibility = Visibility.Visible;
            // disable clear button
            Clear_Button.IsEnabled = false;
        }
        private void about_us(object sender, RoutedEventArgs e)
        {
            // open about us page
            this.Frame.Navigate(typeof(AboutUs), null);
        }
        private async void rate_us(object sender, RoutedEventArgs e)
        {
            // link to windows store review
            var uri = new Uri(string.Format("ms-windows-store:REVIEW?PFN=Package.Current.Id.FamilyName"));
            // linked towards the package name, generated via the string.Format
            await Windows.System.Launcher.LaunchUriAsync(uri);
        }
        public void Buttons_off()
        {
            // method if result is longer than two digits, disable buttons
            if (result.Text.Length > 1)
            {
                Button_1.IsEnabled = false;
                Button_2.IsEnabled = false;
                Button_3.IsEnabled = false;
                Button_4.IsEnabled = false;
                Button_5.IsEnabled = false;
                Button_6.IsEnabled = false;
                Button_7.IsEnabled = false;
                Button_8.IsEnabled = false;
                Button_9.IsEnabled = false;
                Button_0.IsEnabled = false;
            }
        }
        public void But_turn_off()
        {
            // turn off buttons
            Button_1.IsEnabled = false;
            Button_2.IsEnabled = false;
            Button_3.IsEnabled = false;
            Button_4.IsEnabled = false;
            Button_5.IsEnabled = false;
            Button_6.IsEnabled = false;
            Button_7.IsEnabled = false;
            Button_8.IsEnabled = false;
            Button_9.IsEnabled = false;
            Button_0.IsEnabled = false;
        }
        public void Buttons_on()
        {
            // method for enabling buttons
            Button_1.IsEnabled = true;
            Button_2.IsEnabled = true;
            Button_3.IsEnabled = true;
            Button_4.IsEnabled = true;
            Button_5.IsEnabled = true;
            Button_6.IsEnabled = true;
            Button_7.IsEnabled = true;
            Button_8.IsEnabled = true;
            Button_9.IsEnabled = true;
            Button_0.IsEnabled = true;
        }

        public void gen_hearts()
        {
            // show and hide the hearts areas, change colour of first&second int areas
            if (first_hs.Visibility != Visibility.Visible && second_hs.Visibility != Visibility.Visible)
            {
                firstInt.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 9, 107, 178));
                secondInt.Foreground = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 178, 21, 18));
                first_hs.Visibility = Visibility.Visible;
                second_hs.Visibility = Visibility.Visible;
                // call animation
                slide_to_top.Begin();
                fade_in.Begin();
                // change the font and color of main_hs
                main_hs_button.FontFamily = new FontFamily("Assets/icomoon.ttf#icomoon");
                main_hs_button.Foreground = new SolidColorBrush(Windows.UI.Colors.Gold);
                main_hs_copy.Visibility = Visibility.Visible;
            }
            else
            {
                firstInt.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                secondInt.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                first_hs.Visibility = Visibility.Collapsed;
                second_hs.Visibility = Visibility.Collapsed;
                // call animation
                slide_to_bottom.Begin();
                fade_out.Begin();
                // change the font and color back to original
                main_hs_button.FontFamily = new FontFamily("Assets/saski.ttf#Saski");
                main_hs_button.Foreground = new SolidColorBrush(Windows.UI.Colors.Black);
                main_hs_copy.Visibility = Visibility.Collapsed;
            }
        }
        private void numbers_add()
        {
            // loops for number matching and populating first and second_hs
            // if loops so the amount of chars match the number in firstInt
            if (firstInt.Text == "0")
            { first_hs.Text = ""; }

            if (firstInt.Text == "1")
            { first_hs.Text = "1"; }

            if (firstInt.Text == "2")
            { first_hs.Text = "12"; }

            if (firstInt.Text == "3")
            { first_hs.Text = "123"; }

            if (firstInt.Text == "4")
            { first_hs.Text = "1234"; }

            if (firstInt.Text == "5")
            { first_hs.Text = "12345"; }

            if (firstInt.Text == "6")
            { first_hs.Text = "123456"; }

            if (firstInt.Text == "7")
            { first_hs.Text = "12345\n 67"; }

            if (firstInt.Text == "8")
            { first_hs.Text = "12345\n 678"; }

            if (firstInt.Text == "9")
            { first_hs.Text = "12345\n 6789"; }


            // if loops so the amount of chars match the number in secondInt
            if (secondInt.Text == "0")
            { second_hs.Text = ""; }

            if (secondInt.Text == "1")
            { second_hs.Text = "1"; }

            if (secondInt.Text == "2")
            { second_hs.Text = "12"; }

            if (secondInt.Text == "3")
            { second_hs.Text = "123"; }

            if (secondInt.Text == "4")
            { second_hs.Text = "1234"; }

            if (secondInt.Text == "5")
            { second_hs.Text = "12345"; }

            if (secondInt.Text == "6")
            { second_hs.Text = "123456"; }

            if (secondInt.Text == "7")
            { second_hs.Text = "12345\n 67"; }

            if (secondInt.Text == "8")
            { second_hs.Text = "12345\n 678"; }

            if (secondInt.Text == "9")
            { second_hs.Text = "12345\n 6789"; }

        }
        private void number1Load2()
        {
            // generate random numbers from 0-9 range, convert them ToString 
            // and place them in firstInt on app load
            int random1 = rnd.Next(10);
            string one_nine = random1.ToString();
            firstInt.Text = one_nine;
        }
        private void number2Load2()
        {
            // generate random numbers from 0-9 range, convert them ToString 
            // and place them in secondInt on app load
            int random2 = rnd.Next(10);
            string two_nine = random2.ToString();
            secondInt.Text = two_nine;
        }
        private void number1Load(object sender, RoutedEventArgs e)
        {
            // generate random numbers from 0-9 range, convert them ToString 
            // and place them in firstInt on app load
            int random1 = rnd.Next(10);
            string one_nine = random1.ToString();
            firstInt.Text = one_nine;
        }

        private void number2Load(object sender, RoutedEventArgs e)
        {
            // generate random numbers from 0-9 range, convert them ToString 
            // and place them in secondInt on app load
            int random2 = rnd.Next(10);
            string two_nine = random2.ToString();
            secondInt.Text = two_nine;
        }
    }
}
