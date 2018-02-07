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
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Pirates_Of_The_Eggs
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public static int TableChoice;
        
        public Main()
        {
            InitializeComponent();
            StartTableCheck();
            TableChoice = 0;
            
        }

        private void StartTableCheck()
        {
            try
            {
                CheckTableFree(null, null);
            }
            catch (SqlException e)
            {
                if (e.Message.StartsWith("A network-related"))
                {
                    MessageBox.Show("Server timeout, are you connected to the internet?");
                    MessageBox.Show("If you do have internet connection, the server may be offline!");
                }
                else
                {
                    MessageBox.Show("An unexpected error occurred.");
                    MessageBox.Show(e.ToString());
                }
            }
        }

        private void CheckTableFree(object sender, RoutedEventArgs e)
        {
        
            string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
            string cmdString;
            int DataReader;

            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                sqlConnection.Open();
                cmdString = @"select TafelID as TafelID from Tafels where TafelGebruik = 1";

                SqlCommand cmd = new SqlCommand(cmdString, sqlConnection);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    DataReader = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("TafelID"));
                    //foreach (object obj in TableButtons.Children)
                    //{
                    //((Button)obj).Background = Brushes.Red;
                    ((Button)TableButtons.Children[DataReader-1]).Background = Brushes.Red;
                    TableInfo.DynamicTable1(DataReader);
                    //}
                }
                sqlConnection.Close();
            }
        }

        private void Tafel_Click(object sender, RoutedEventArgs e)
        {
            CheckTableFree(sender, e);
            TableChoice = Convert.ToInt16(((Button)sender).Content);

            if (TableInfo.DynamicTableRead(TableChoice) == 1)
            {
                TableInfo.TableAlreadyTaken = true;
                MenuKaart.CheckBetaald();
            }
            else
            {
                TableInfo.TableAlreadyTaken = false;
            }
            string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
                string cmdString;

                using (SqlConnection sqlConnection = new SqlConnection(strConnection))
                {
                    sqlConnection.Open();
                    cmdString = $@"UPDATE Tafels SET TafelGebruik=1 WHERE TafelID= {TableChoice}";


                    SqlCommand cmd = new SqlCommand(cmdString, sqlConnection);
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    while (sqlDataReader.Read()){}
                    sqlConnection.Close();
                }
            MainWindow.MainFrame.Navigate(new MenuKaart());
        }

        private void Bar_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new MenuKaart());
        }

        private void ShowBonnen_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new Bonnen());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new Agenda()); 
        }

        private void Btn_ClickRefresh(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new Main());
        }

        private void TXTCheck_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
