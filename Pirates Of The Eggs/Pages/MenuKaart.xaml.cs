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
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Pirates_Of_The_Eggs
{
    /// <summary>
    /// Interaction logic for MenuKaart.xaml
    /// </summary>
    public partial class MenuKaart : Page
    {
        Pirates_of_the_eggsDataSet datasource = new Pirates_of_the_eggsDataSet();

        public MenuKaart()
        {
            InitializeComponent();
        }

        private void ShowTerug_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new Main());
        }

        private void ShowOpsplitsen_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new Opsplitsen());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            datasource.Clear();
            string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
            string CmdString = string.Empty;

            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                CmdString = @"select * from Gerechten inner join GerechtCategorie ON GerechtSoort = GerechtCategorie.GerechtID";
                if (((Button)sender).Content.ToString() != "Alle")
                {
                    CmdString = CmdString + $" where GerechtCategorie.SoortNaam = '{((Button)sender).Content.ToString()}'";
                    //CmdString = CmdString + " where GerechtCategorie.SoortNaam = '" + ((Button)sender).Content + "'";
                }
                //MyDataGrid.AutoGenerateColumns = false;

                SqlCommand cmd = new SqlCommand(CmdString, sqlConnection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                
                DataTable dt = datasource.Tables["Gerechten"];

                
                sda.Fill(dt);
                MyDataGrid.ItemsSource = dt.DefaultView;
                MyDataGrid.Columns[0].Visibility = Visibility.Hidden;
                MyDataGrid.Columns[3].Visibility = Visibility.Hidden;
                MyDataGrid.Columns[4].Visibility = Visibility.Hidden;
                MyDataGrid.Columns[5].Visibility = Visibility.Hidden;
            }
        }
    }
}
