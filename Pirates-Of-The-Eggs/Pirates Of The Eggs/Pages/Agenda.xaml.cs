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
using System.Threading;
using System.Globalization;

namespace Pirates_Of_The_Eggs
{
    /// <summary>
    /// Interaction logic for Agenda.xaml
    /// </summary>
    public partial class Agenda : Page
    {
        Pirates_of_the_eggsDataSet datasource = new Pirates_of_the_eggsDataSet();
        public string Date;
        public int Hour;
        public string Minute;
        public string StrDateTime;
        public int AmountOfPeople;
        public string LastName;


        public Agenda()
        {
            InitializeComponent();
            SetCulture();
        }

        private void SetCulture()
        {
            CultureInfo ci = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
            Thread.CurrentThread.CurrentCulture = ci;
        }
    

        public void Datum()
        {
            string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
            string cmdstring = string.Empty;
            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                sqlConnection.Open();
                cmdstring = $@"Insert into Reserveringen Values('{LastName}','{StrDateTime}', {AmountOfPeople})";
                
                SqlCommand cmd = new SqlCommand(cmdstring, sqlConnection);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
                while (sqlDataReader.Read())
                {
                };
                sqlConnection.Close();
            }
            
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new Main());
        }

        private void MakeReservation(object sender, RoutedEventArgs e)
        {
            try
            {
                Date = Calendar.SelectedDate.ToString().Substring(0, 10);
                Hour = Convert.ToInt16(HourCB.SelectionBoxItem.ToString());
                Minute = MinuteCB.SelectionBoxItem.ToString();
                if (Minute == "")
                {
                    throw new Exception("Error, Minute not set.");
                }
                StrDateTime = Date + " " + Hour + ":" + Minute + ":00";
                tb1.Text = StrDateTime;
                AmountOfPeople = Convert.ToInt16(AantalPersonen.SelectionBoxItem.ToString());
                LastName = LastNameTB.Text;
                Datum();
            }
            catch(SqlException sqle)
            {
                MessageBox.Show(sqle.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Vul a.u.b alle gegevens in.");
                return;
            }
        }

        private void GetReservation(object sender, RoutedEventArgs e)
        {
            try
            {
                string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
                string CmdString = string.Empty;
                using (SqlConnection sqlConnection = new SqlConnection(strConnection))
                {
                    datasource.Clear();
                    CmdString = $@"SELECT * FROM Reserveringen WHERE CONVERT(VARCHAR(25), ReservedDateTime, 126) LIKE '{DateTime.Now.ToShortDateString()}%'";
                    SqlCommand cmd = new SqlCommand(CmdString, sqlConnection);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);

                    DataTable dt = datasource.Tables["Orders"];

                    sda.Fill(dt);
                    ReservationDT.ItemsSource = dt.DefaultView;
                    
                    ReservationDT.Columns[0].Visibility = Visibility.Hidden;
                    ReservationDT.Columns[1].Visibility = Visibility.Hidden;
                }
            }
            catch (Exception) { }
        }
    }
}
