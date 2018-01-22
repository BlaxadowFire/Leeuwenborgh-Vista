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
            string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
            string CmdString = string.Empty;

            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                CmdString = @"
                select Gerechten.GerechtNaam, Gerechten.GerechtPrijs from Gerechten,GerechtCategorie where Gerechten.GerechtSoort = 1 order by Gerechten.GerechtID; ";
                SqlCommand cmd = new SqlCommand(CmdString, sqlConnection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = datasource.Tables["Gerechten, GerechtCategorie"];
                sda.Fill(dt);
                MyDataGrid.ItemsSource = dt.DefaultView;
            }
        }
    }
}
