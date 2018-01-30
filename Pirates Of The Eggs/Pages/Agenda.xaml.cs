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
    /// Interaction logic for Agenda.xaml
    /// </summary>
    public partial class Agenda : Page
    {
        public Agenda()
        {
            InitializeComponent();
        }

        public void Datum()
        {
            var x = Calendar.SelectedDate;


            string strConnection = ConfigurationManager.ConnectionStrings["POTEConnectionString"].ConnectionString;
            string Opslaan = string.Empty;
            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                Opslaan = $@"Insert into Reserveringen Values({LastName}, {x})";
                
                SqlCommand cmd = new SqlCommand(Opslaan, sqlConnection);
                SqlDataReader sqlDataReader = cmd.ExecuteReader();
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.MainFrame.Navigate(new Main());
        }
    }
}
