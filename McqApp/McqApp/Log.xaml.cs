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
    /// Interaction logic for Log.xaml
    /// </summary>
    public partial class Log : Window
    {
        public Log()
        {
            InitializeComponent();
        }

        private void btnstart_Click(object sender, RoutedEventArgs e)
        {
            Faq mfaq = new Faq();
            mfaq.Show();

            string Ofaq = "Hi {0}...";
            Ofaq = string.Format("Hi {0}",txtname.Text);
            mfaq.tbluser.Text = Ofaq;  
           
        }
    }
}
