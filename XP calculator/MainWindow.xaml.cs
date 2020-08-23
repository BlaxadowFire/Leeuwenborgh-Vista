using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
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

namespace XP_calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] xpArray = System.IO.File.ReadAllLines(@"%appdata%\XPCalculator\Database.txt");
        public static double dblTxtBxXP = 0;
        public MainWindow()
        {
            InitializeComponent();
           /* 
            lblXP1.Content = xpResource.ResourceManager.GetString("xp1");
            lblXP2.Content = xpResource.ResourceManager.GetString("xp2");
            lblXP3.Content = xpResource.ResourceManager.GetString("xp3");
            lblXP4.Content = xpResource.ResourceManager.GetString("xp4");
            lblXP5.Content = xpResource.ResourceManager.GetString("xp5");
            lblXP6.Content = xpResource.ResourceManager.GetString("xp6");
            lblXP7.Content = xpResource.ResourceManager.GetString("xp7");
            lblXP8.Content = xpResource.ResourceManager.GetString("xp8");
            lblXP9.Content = xpResource.ResourceManager.GetString("xp9");
            lblXP10.Content = xpResource.ResourceManager.GetString("xp10");
            lblXP11.Content = xpResource.ResourceManager.GetString("xp11");
            lblXP12.Content = xpResource.ResourceManager.GetString("xp12");
            lblXP13.Content = xpResource.ResourceManager.GetString("xp13");
            lblXP14.Content = xpResource.ResourceManager.GetString("xp14");
          */
            /*
            lblXP1.Content = Application.Current.Resources["xp1"];
            lblXP2.Content = Application.Current.Resources["xp2"];
            lblXP3.Content = Application.Current.Resources["xp3"];
            lblXP4.Content = Application.Current.Resources["xp4"];
            lblXP5.Content = Application.Current.Resources["xp5"];
            lblXP6.Content = Application.Current.Resources["xp6"];
            lblXP7.Content = Application.Current.Resources["xp7"];
            lblXP8.Content = Application.Current.Resources["xp8"];
            lblXP9.Content = Application.Current.Resources["xp9"];
            lblXP10.Content = Application.Current.Resources["xp10"];
            lblXP11.Content = Application.Current.Resources["xp11"];
            lblXP12.Content = Application.Current.Resources["xp12"];
            lblXP13.Content = Application.Current.Resources["xp13"];
            lblXP14.Content = Application.Current.Resources["xp14"];
            */


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (cbxXP1.IsChecked == true)
            {
                double dblXP1 = Convert.ToDouble(lblXP1.Content);
                dblTxtBxXP = Convert.ToDouble(txtbxXP.Text);
                double dblNewXP1 = dblXP1 + dblTxtBxXP;
                string strNewXP1 = Convert.ToString(dblNewXP1);

                /*
                 *xpResource.xp1 moet worden bijgewerkt door strNewP1
                 */
                
               // Application.Current.Resources["xp1"] = strNewXP1;
               //lblXP1.Content = Application.Current.Resources["xp1"];
            }
            else if (cbxXP2.IsChecked == true)
            {

            }
            else if (cbxXP3.IsChecked == true)
            {

            }
            else if (cbxXP4.IsChecked == true)
            {

            }
            else if (cbxXP5.IsChecked == true)
            {

            }
            else if (cbxXP6.IsChecked == true)
            {

            }
            else if (cbxXP7.IsChecked == true)
            {

            }
            else if (cbxXP8.IsChecked == true)
            {

            }
            else if (cbxXP9.IsChecked == true)
            {

            }
            else if (cbxXP10.IsChecked == true)
            {

            }
            else if (cbxXP11.IsChecked == true)
            {

            }
            else if (cbxXP12.IsChecked == true)
            {

            }
            else if (cbxXP13.IsChecked == true)
            {

            }
            else if (cbxXP14.IsChecked == true)
            {

            }
        }
    }
}
