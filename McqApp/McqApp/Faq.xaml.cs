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
using System.Windows.Shapes;

namespace McqApp
{
    /// <summary>
    /// Interaction logic for Faq.xaml
    /// </summary>
    public partial class Faq : Window
    {
        int value = 300;
        
        public Faq()
        {
            InitializeComponent();
        }

        private void First_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox boxclick = (CheckBox)sender;
            int oldvalue1 = Convert.ToInt32(lblmk1.Content);

            if (boxclick.Tag.ToString() == "1")
            {
                oldvalue1 = oldvalue1 + 20;
            }
            else
            {
                oldvalue1 = oldvalue1 + 0;
            }
            lblmk1.Content = oldvalue1.ToString();
            boxclick.IsEnabled = false;
            
        }

        private void Second_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox boxclick = (CheckBox)sender;
            int oldvalue2 = Convert.ToInt32(lblmk2.Content);

            if (boxclick.Tag.ToString() == "1")
            {
                oldvalue2 = oldvalue2 + 20;
            }
            else
            {
                oldvalue2 = oldvalue2 + 0;
            }
            lblmk2.Content = oldvalue2.ToString();
            boxclick.IsEnabled = false;
        }

        private void Third_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox boxclick = (CheckBox)sender;
            int oldvalue3 = Convert.ToInt32(lblmk3.Content);

            if (boxclick.Tag.ToString() == "1")
            {
                oldvalue3 = oldvalue3 + 20;
            }
            else
            {
                oldvalue3 = oldvalue3 + 0;
            }
            lblmk3.Content = oldvalue3.ToString();
            boxclick.IsEnabled = false;
        }

        private void Fourth_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox boxclick = (CheckBox)sender;
            int oldvalue4 = Convert.ToInt32(lblmk4.Content);

            if (boxclick.Tag.ToString() == "1")
            {
                oldvalue4 = oldvalue4 + 20;
            }
            else
            {
                oldvalue4 = oldvalue4 + 0;
            }
            lblmk4.Content = oldvalue4.ToString();
            boxclick.IsEnabled = false;
        }

        private void Fifth_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox boxclick = (CheckBox)sender;
            int oldvalue5 = Convert.ToInt32(lblmk5.Content);

            if (boxclick.Tag.ToString() == "1")
            {
                oldvalue5 = oldvalue5 + 20;
            }
            else
            {
                oldvalue5 = oldvalue5 + 0;
            }
            lblmk5.Content = oldvalue5.ToString();
            
            boxclick.IsEnabled = false;
        }

        private void Sixth_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox boxclick = (CheckBox)sender;
            int oldvalue6 = Convert.ToInt32(lblmk6.Content);

            if (boxclick.Tag.ToString() == "1")
            {
                oldvalue6 = oldvalue6 + 20;
            }
            else
            {
                oldvalue6 = oldvalue6 + 0;
            }
            lblmk6.Content = oldvalue6.ToString();
            boxclick.IsEnabled = false;
        }

        private void Seventh_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox boxclick = (CheckBox)sender;
            int oldvalue7 = Convert.ToInt32(lblmk7.Content);

            if (boxclick.Tag.ToString() == "1")
            {
                oldvalue7 = oldvalue7 + 20;
            }
            else
            {
                oldvalue7 = oldvalue7 + 0;
            }
            lblmk7.Content = oldvalue7.ToString();
            boxclick.IsEnabled = false;
        }

        private void Eighth_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox boxclick = (CheckBox)sender;
            int oldvalue8 = Convert.ToInt32(lblmk8.Content);

            if (boxclick.Tag.ToString() == "1")
            {
                oldvalue8 = oldvalue8 + 20;
            }
            else
            {
                oldvalue8 = oldvalue8 + 0;
            }
            lblmk8.Content = oldvalue8.ToString();
            boxclick.IsEnabled = false;
        }

        private void Ninth_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox boxclick = (CheckBox)sender;
            int oldvalue9 = Convert.ToInt32(lblmk9.Content);

            if (boxclick.Tag.ToString() == "1")
            {
                oldvalue9 = oldvalue9 + 20;
            }
            else
            {
                oldvalue9 = oldvalue9 + 0;
            }
            lblmk9.Content = oldvalue9.ToString();
            boxclick.IsEnabled = false;
        }

        private void Tenth_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox boxclick = (CheckBox)sender;
            int oldvalue10 = Convert.ToInt32(lblmk10.Content);

            if (boxclick.Tag.ToString() == "1")
            {
                oldvalue10 = oldvalue10 + 20;
            }
            else
            {
                oldvalue10 = oldvalue10 + 0;
            }
            lblmk10.Content = oldvalue10.ToString();
            boxclick.IsEnabled = false;
        }

        private void Eleven_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox boxclick = (CheckBox)sender;
            int oldvalue11 = Convert.ToInt32(lblmk11.Content);

            if (boxclick.Tag.ToString() == "1")
            {
                oldvalue11 = oldvalue11 + 20;
            }
            else
            {
                oldvalue11 = oldvalue11 + 0;
            }
            lblmk11.Content = oldvalue11.ToString();
            boxclick.IsEnabled = false;
        }

        private void Twelve_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox boxclick = (CheckBox)sender;
            int oldvalue12 = Convert.ToInt32(lblmk12.Content);

            if (boxclick.Tag.ToString() == "1")
            {
                oldvalue12 = oldvalue12 + 20;
            }
            else
            {
                oldvalue12 = oldvalue12 + 0;
            }
            lblmk12.Content = oldvalue12.ToString();
            boxclick.IsEnabled = false;
        }

        private void Thirteen_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox boxclick = (CheckBox)sender;
            int oldvalue13 = Convert.ToInt32(lblmk13.Content);

            if (boxclick.Tag.ToString() == "1")
            {
                oldvalue13 = oldvalue13 + 20;
            }
            else
            {
                oldvalue13 = oldvalue13 + 0;
            }
            lblmk13.Content = oldvalue13.ToString();
            boxclick.IsEnabled = false;
        }

        private void Fourteen_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox boxclick = (CheckBox)sender;
            int oldvalue14 = Convert.ToInt32(lblmk14.Content);

            if (boxclick.Tag.ToString() == "1")
            {
                oldvalue14 = oldvalue14 + 20;
            }
            else
            {
                oldvalue14 = oldvalue14 + 0;
            }
            lblmk14.Content = oldvalue14.ToString();
            boxclick.IsEnabled = false;
        }

        private void Fifteen_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox boxclick = (CheckBox)sender;
            int oldvalue15 = Convert.ToInt32(lblmk15.Content);

            if (boxclick.Tag.ToString() == "1")
            {
                oldvalue15 = oldvalue15 + 20;
            }
            else
            {
                oldvalue15 = oldvalue15 + 0;
            }
            lblmk15.Content = oldvalue15.ToString();
            boxclick.IsEnabled = false;
        }

        private void btnresult_Click(object sender, RoutedEventArgs e)
        {
            int oldvalue1 = Convert.ToInt32(lblmk1.Content);
            int oldvalue2 = Convert.ToInt32(lblmk2.Content);
            int oldvalue3 = Convert.ToInt32(lblmk3.Content);
            int oldvalue4 = Convert.ToInt32(lblmk4.Content);
            int oldvalue5 = Convert.ToInt32(lblmk5.Content);
            int oldvalue6 = Convert.ToInt32(lblmk6.Content);
            int oldvalue7 = Convert.ToInt32(lblmk7.Content);
            int oldvalue8 = Convert.ToInt32(lblmk8.Content);
            int oldvalue9 = Convert.ToInt32(lblmk9.Content);
            int oldvalue10 = Convert.ToInt32(lblmk10.Content);
            int oldvalue11 = Convert.ToInt32(lblmk11.Content);
            int oldvalue12 = Convert.ToInt32(lblmk12.Content);
            int oldvalue13 = Convert.ToInt32(lblmk13.Content);
            int oldvalue14 = Convert.ToInt32(lblmk14.Content);
            int oldvalue15 = Convert.ToInt32(lblmk15.Content);

            int value = oldvalue1 + oldvalue2 + oldvalue3 + oldvalue4 + oldvalue5 + oldvalue6 + oldvalue7 + oldvalue8 + 
                                    oldvalue9 + oldvalue10 + oldvalue11 + oldvalue12 + oldvalue13 + oldvalue14 + oldvalue15;

            lblresult.Content = Convert.ToString(value);
            if(value < 120)
            {
                MessageBox.Show("Your score is "+ value +" /600 (FAIL) Improvememt Needed!" );
          
            }
            else
            {
                MessageBox.Show("Your score is" + value + " /600 (PASS) Keep Going On <3");
            }
        }
    }
}
