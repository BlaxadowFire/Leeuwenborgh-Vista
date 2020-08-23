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

namespace DBTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ConsoleDataSet DataSource = new ConsoleDataSet();
        public string strConnection = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        public string CmdString = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        public void LoadData()
        {
            using (SqlConnection sqlConnection = new SqlConnection(strConnection))
            {
                CmdString = "SELECT * FROM Games";
                SqlCommand cmd = new SqlCommand(CmdString, sqlConnection);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = DataSource.Tables["Games"];
                sda.Fill(dt);
                Data.ItemsSource = dt.DefaultView;
            };
        }
    }
}
