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

        public bool TableFree = true;

        public MenuKaart()
        {
            InitializeComponent();
            SelectedGerechten.Text = SelectedGerechten.Text + "\r\n" + "Order No. ";
            SelectedGerechtenPrice.Text = Main.TableChoice + "\r\n";
            OrderIDCheck(null,null);
            Amount.Text = "\r\n";
        }

        private void ShowTerug_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new Main());
        }

        private void ShowOpsplitsen_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new Opsplitsen());
        }

        private void GerechtenFilter(object sender, RoutedEventArgs e)
        {
            datasource.Clear();
            string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
            string CmdString = string.Empty;

            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                CmdString = @"SELECT * FROM Gerechten INNER JOIN GerechtCategorie ON GerechtSoort = GerechtCategorie.GerechtID";
                if (((Button)sender).Content.ToString() != "Alle")
                {
                    CmdString = CmdString + $" where GerechtCategorie.SoortNaam = '{((Button)sender).Content.ToString()}'";
                    //CmdString = CmdString + " where GerechtCategorie.SoortNaam = '" + ((Button)sender).Content + "'";
                }

                SqlCommand cmd = new SqlCommand(CmdString, sqlConnection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                
                DataTable dt = datasource.Tables["Gerechten"];

                sda.Fill(dt);
                MyDataGrid.ItemsSource = dt.DefaultView;
                MyDataGrid.Columns[1].Visibility = Visibility.Hidden;
                MyDataGrid.Columns[4].Visibility = Visibility.Hidden;
                MyDataGrid.Columns[5].Visibility = Visibility.Hidden;
                MyDataGrid.Columns[6].Visibility = Visibility.Hidden;
            }
        }

        private void GerechtClick(object sender, RoutedEventArgs e)
        {
            string Order;
            string Price =string.Empty;
            int Amount;
            DataRowView drv = (DataRowView)MyDataGrid.SelectedItem;

            if (drv != null)
            {
                Order = drv[1].ToString();
                Price = drv[2].ToString();
                if (TxtBlockNumber.Text == string.Empty)
                {
                    TxtBlockNumber.Text = "1";
                }
                Amount = Convert.ToInt32(TxtBlockNumber.Text);
                this.Amount.Text = this.Amount.Text + "\r\n" + Amount;
                for (int i = 0; i < Amount; i++)
                {
                    LoadOrderNumber(sender, e, Convert.ToInt32(drv[0]));
                }

                SelectedGerechten.Text = SelectedGerechten.Text + "\r\n" + Order;
                SelectedGerechtenPrice.Text = SelectedGerechtenPrice.Text + "\r\n" + Price;
                Btn_ClickClear(sender, e);
            } 
        }

        private void Btn_ClickNumber(object sender, RoutedEventArgs e)
        {
            if (TxtBlockNumber.Text == "" || Convert.ToInt16(TxtBlockNumber.Text) <= 10)
            {
                TxtBlockNumber.Text = TxtBlockNumber.Text + ((Button)sender).Content;
            }
        }

        private void Btn_ClickBackspace(object sender, RoutedEventArgs e)
        {
            if (TxtBlockNumber.Text.Length > 0)
            {
                TxtBlockNumber.Text = TxtBlockNumber.Text.Remove(TxtBlockNumber.Text.Length - 1);
            }
        }

        private void Btn_ClickClear(object sender, RoutedEventArgs e)
        {
            TxtBlockNumber.Text = String.Empty;
        }

        private void Btn_SendAantal(object sender, RoutedEventArgs e)
        {
            string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
            string Opslaan = string.Empty;

            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                Opslaan = @"Insert into Orders Values GerechtID OrderID TafelID Betaald";


                SqlCommand cmd = new SqlCommand(Opslaan, sqlConnection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
            }
        }

        private void BetalenButton(object sender, RoutedEventArgs e)
        {
            string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
            string cmdString = string.Empty;

            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                sqlConnection.Open();
                cmdString = $@"UPDATE Tafels SET TafelGebruik=0 WHERE TafelID= {Main.TableChoice}";
                TableInfo.DynamicTable0(Main.TableChoice);

                SqlCommand cmd = new SqlCommand(cmdString, sqlConnection);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                };
                sqlConnection.Close();
            }
            Betaald(sender,e);
        }

        private void Betaald(object sender, RoutedEventArgs e)
        {
            string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
            string cmdString = string.Empty;

            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                sqlConnection.Open();
                cmdString = $@"UPDATE Orders SET Betaald=1 WHERE TafelID= {Main.TableChoice}and OrderID={TableInfo.CurrentOrderNo}";
                TableInfo.DynamicTable0(Main.TableChoice);

                SqlCommand cmd = new SqlCommand(cmdString, sqlConnection);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                };
                sqlConnection.Close();
            }
        }

        private void LoadOrderNumber(object sender, RoutedEventArgs e, int x)
        {
            
            string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
            string cmdString = string.Empty;
            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                sqlConnection.Open();
                cmdString = $"INSERT INTO [Orders] values ({/*GerechtID*/x}, {/*OrderID*/TableInfo.CurrentOrderNo}, {/*TafelID*/Main.TableChoice}, {/*Betaald*/0})";
                    //cmd1.Connection = sqlConnection;
                    //cmd1.Parameters.AddWithValue("@TafelID", SelectedGerechten.Text);
                    SqlCommand cmdCommand = new SqlCommand(cmdString, sqlConnection);
                    SqlDataReader sqlDataReader1 = cmdCommand.ExecuteReader();
                    while (sqlDataReader1.Read())
                    {

                    };
                    sqlDataReader1.Close();
               }
        }

        private void OrderIDCheck(object sender, RoutedEventArgs e)
        {
            string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
            string cmdString = string.Empty;
            int DataReader = 0;
            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                
                sqlConnection.Open();
                if (TableInfo.TableAlreadyTaken && !CheckBetaald())
                {
                    cmdString = $@"select MAX(OrderID) as MaxID from Orders where TafelID = {Main.TableChoice}";
                }
                else
                {
                    cmdString = $@"select MAX(OrderID) as MaxID from Orders";
                }

                SqlCommand cmd = new SqlCommand(cmdString, sqlConnection);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    try
                    {
                        DataReader = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("MaxID"));
                    }catch (Exception){ }
                }
                if (!TableInfo.TableAlreadyTaken || TableInfo.TableAlreadyTaken && CheckBetaald())
                {
                    DataReader++;
                }
                TableInfo.CurrentOrderNo = DataReader;

                SelectedGerechtenPrice.Text = SelectedGerechtenPrice.Text + DataReader.ToString();
                sqlConnection.Close();
            }
        }

        public static bool CheckBetaald()
        {
            string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
            string cmdString = string.Empty;
            
            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                sqlConnection.Open();
                cmdString = $"Select Betaald as Betaald from Orders where OrderID = {TableInfo.CurrentOrderNo} AND TafelID = {Main.TableChoice}";
                SqlCommand cmd = new SqlCommand(cmdString, sqlConnection);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    TableInfo.IsBetaald = sqlDataReader.GetInt32(sqlDataReader.GetOrdinal("Betaald"));
                }
                sqlConnection.Close();
                if (TableInfo.IsBetaald == 1)
                {
                    return true;
                }
                return false;
            }
                       
        }
        public void RemoveButton(object sender, RoutedEventArgs e)
        {

        }

        private void CheckOrder(object sender, RoutedEventArgs e)
        {
            try
            {
                string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
                string CmdString = string.Empty;

                using (SqlConnection sqlConnection = new SqlConnection(strConnection))
                {
                    datasource.Clear();
                    CmdString = $@"SELECT * FROM Orders INNER JOIN Gerechten ON Orders.GerechtID = Gerechten.GerechtID WHERE OrderID = {TableInfo.CurrentOrderNo} ORDER BY Orders.ID, Orders.GerechtID";
                    SqlCommand cmd = new SqlCommand(CmdString, sqlConnection);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    DataTable dt = datasource.Tables["Orders"];

                    sda.Fill(dt);
                    OrderDataGrid.ItemsSource = dt.DefaultView;
                    /*
                    OrderDataGrid.Columns[1].Visibility = Visibility.Hidden;
                    OrderDataGrid.Columns[2].Visibility = Visibility.Hidden;
                    OrderDataGrid.Columns[3].Visibility = Visibility.Hidden;
                    OrderDataGrid.Columns[4].Visibility = Visibility.Hidden;
                    OrderDataGrid.Columns[5].Visibility = Visibility.Hidden;
                    OrderDataGrid.Columns[6].Visibility = Visibility.Hidden;
                    OrderDataGrid.Columns[9].Visibility = Visibility.Hidden;*/
                }
                HideOrderGridData();
            }
           catch (Exception) { CheckOrder(sender, e); }
        }

        private void HideOrderGridData()
        {
            try
            {
                OrderDataGrid.Columns[1].Visibility = Visibility.Hidden;
                OrderDataGrid.Columns[2].Visibility = Visibility.Hidden;
                OrderDataGrid.Columns[3].Visibility = Visibility.Hidden;
                OrderDataGrid.Columns[4].Visibility = Visibility.Hidden;
                OrderDataGrid.Columns[5].Visibility = Visibility.Hidden;
                OrderDataGrid.Columns[6].Visibility = Visibility.Hidden;
                OrderDataGrid.Columns[9].Visibility = Visibility.Hidden;
            }
            catch (Exception) { }
        }
    }
}
