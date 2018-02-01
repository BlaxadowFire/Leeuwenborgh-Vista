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
using System.Globalization;
using System.Threading;

namespace In_Uitgaven
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        _In_UitGavenDataSet datasource = new _In_UitGavenDataSet();
        private string Connection = ConfigurationManager.ConnectionStrings["In-UitGavenConnectionString"].ConnectionString;

        public string strConnection = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
            SetCulture();
            PasswordBox.Focus();

        }

        private void SetCulture()
        {
            CultureInfo ci = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
            Thread.CurrentThread.CurrentCulture = ci;
        }

        private void Insert_Click(object sender, RoutedEventArgs e)
        {
            if ((string)ConnectLbl.Content == "Not Connected")
            {
                MessageBox.Show("Please Enter Password");
                return;
            }

            try
            {
                string cmdString = string.Empty;
                using (SqlConnection sqlConnection = new SqlConnection(strConnection))
                {
                    sqlConnection.Open();
                    cmdString = (string) ((Button)sender).Content == "In" ? $"INSERT INTO InOutCome VALUES('{DatumDp.SelectedDate}',€{AmountTxt.Text},'{SourceTxt.Text}')" : $"INSERT INTO InOutCome VALUES('{DatumDp.SelectedDate}',€-{AmountTxt.Text},'{SourceTxt.Text}')";
                    SqlCommand cmdCommand = new SqlCommand(cmdString, sqlConnection);
                    SqlDataReader sqlDataReader = cmdCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {

                    }
                    sqlDataReader.Close();
                }
            }
            catch (SqlException sqle)
            {
                if (sqle.Message.StartsWith("Login failed"))
                {
                    MessageBox.Show("Password Incorrect, please try again");
                }
                else
                {
                    MessageBox.Show("An unexpected error occurred!");
                    MessageBox.Show(sqle.Message);
                }
            }

        }

        private void ConnectButton(object sender, RoutedEventArgs e)
        {
            strConnection = Connection + $";Password= {PasswordBox.Password}";
            ConnectLbl.Content = TestConnection() ? "Connected" : "Not Connected";
        }

        private bool TestConnection()
        {
            if (strConnection == string.Empty)
            {
                MessageBox.Show("Please Enter Password");
                ConnectLbl.Content = "Not Connected";
                return false;
            }

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(strConnection))
                {
                    sqlConnection.Open();
                    sqlConnection.Close();
                }
            }
            catch (SqlException sqle)
            {
                if (sqle.Message.StartsWith("Login failed"))
                {
                    MessageBox.Show("Password Incorrect, please try again");
                }
                else
                {
                    MessageBox.Show("An unexpected error occurred!");
                    MessageBox.Show(sqle.Message);
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Crittical error occurred!");
                MessageBox.Show(e.Message);
            }
            MessageBox.Show("Connection Succesfull!");
            AmountTxt.Focus();
            ConnectBtn.IsDefault = false;
            CurAmBtn.IsDefault = true;
            return true;
        }

        private void CurAmBtn_Click(object sender, RoutedEventArgs e)
        {
            if ((string)ConnectLbl.Content == "Not Connected")
            {
                MessageBox.Show("Please Enter Password");
                return;
            }

            try
            {
                string cmdString = string.Empty;
                using (SqlConnection sqlConnection = new SqlConnection(strConnection))
                {
                    sqlConnection.Open();
                    cmdString = "select SUM(Amount) as Amount from InOutcome";
                    SqlCommand cmdCommand = new SqlCommand(cmdString, sqlConnection);
                    SqlDataReader sqlDataReader = cmdCommand.ExecuteReader();
                    while (sqlDataReader.Read())
                    {
                        Current_Amount.Content = "€" + sqlDataReader["Amount"];
                        Current_Amount.Content = Current_Amount.Content.ToString().Remove(Current_Amount.Content.ToString().Length - 2);
                    }
                    sqlDataReader.Close();
                }
            }
            catch (SqlException sqle)
            {
                MessageBox.Show("An unexpected error occurred!");
                MessageBox.Show(sqle.Message);
            }
            catch (Exception exc)
            {
                MessageBox.Show("A criticall error occurred!");
                MessageBox.Show(exc.Message);
            }

        }
    }
}
