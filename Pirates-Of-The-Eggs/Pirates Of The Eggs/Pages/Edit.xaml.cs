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
    /// Interaction logic for Edit.xaml
    /// </summary>
    public partial class Edit : Page
    {
        Pirates_of_the_eggsDataSet datasource = new Pirates_of_the_eggsDataSet();
        public Edit()
        {
            InitializeComponent();
        }
        private void UpdateDataGrid(object sender, RoutedEventArgs e)
        {
            datasource.Clear();
            string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
            string CmdString = string.Empty;

            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                CmdString = @"SELECT * FROM Gerechten INNER JOIN GerechtCategorie ON GerechtSoort = GerechtCategorie.GerechtID";

                SqlCommand cmd = new SqlCommand(CmdString, sqlConnection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);

                DataTable dt = datasource.Tables["Gerechten"];

                sda.Fill(dt);
                MyDataGrid.ItemsSource = dt.DefaultView;
                MyDataGrid.Columns[3].Visibility = Visibility.Hidden;
                MyDataGrid.Columns[4].Visibility = Visibility.Hidden;
            }
        }
        private int ConvertGerechtSoort()
        {
            switch (GerechtSoortCBox.SelectionBoxItem)
            {
                case "Voorgerecht":
                    {
                        return 1;
                    }
                case "Soep":
                    {
                        return 2;
                    }
                case "Hoofdgerecht":
                    {
                        return 3;
                    }
                case "Dessert":
                    {
                        return 4;
                    }
                case "Drank":
                    {
                        return 5;
                    }
                default:
                    {
                        return 0;
                    }
            }
        }

        private void BackButton_OnClick(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new Main());
        }
        private void EditButton(object sender, RoutedEventArgs e)
        {
            try
            {
                string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
                string cmdString = string.Empty;
                using (SqlConnection sqlConnection = new SqlConnection(strConnection))
                {
                    sqlConnection.Open();
                    cmdString = $@"UPDATE Gerechten SET GerechtNaam='{GerechtNaamTxtBx.Text}', GerechtPrijs=€{GerechtPrijsTxtBx.Text}, GerechtSoort={ConvertGerechtSoort()} WHERE GerechtID= {IDTxtBx.Text}";
                    SqlCommand cmd = new SqlCommand(cmdString, sqlConnection);
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                    };
                    sqlConnection.Close();
                }
                UpdateDataGrid(null, null);
            }
            catch (Exception ex)
            {
                if (ex.Message.StartsWith("Incorrect syntax"))
                {
                    MessageBox.Show("Please enter all fields");
                    return;
                }
                MessageBox.Show(ex.Message);
            }
        }
        private void AddButton(object sender, RoutedEventArgs e)
        {
            try
            {
                string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
                string cmdString = string.Empty;
                using (SqlConnection sqlConnection = new SqlConnection(strConnection))
                {
                    sqlConnection.Open();
                    cmdString = $@"INSERT INTO Gerechten VALUES ('{GerechtNaamTxtBx.Text}',€{GerechtPrijsTxtBx.Text},{ConvertGerechtSoort()})";
                    SqlCommand cmd = new SqlCommand(cmdString, sqlConnection);
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                    };
                    sqlConnection.Close();
                }
                UpdateDataGrid(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void DeleteButton(object sender, RoutedEventArgs e)
        {
            if (IDTxtBx.Text == "")
            {
                MessageBox.Show("Please enter valid ID");
                return;
            }
            try
            {


                string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
                string cmdString = string.Empty;
                using (SqlConnection sqlConnection = new SqlConnection(strConnection))
                {
                    sqlConnection.Open();
                    cmdString = $@"DELETE FROM Gerechten WHERE GerechtID={IDTxtBx.Text}";
                    SqlCommand cmd = new SqlCommand(cmdString, sqlConnection);
                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                    };
                    sqlConnection.Close();
                }
                UpdateDataGrid(null, null);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
