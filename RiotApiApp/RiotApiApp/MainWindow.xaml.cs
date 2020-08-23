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
using RiotSharp;
using RiotSharp.Misc;

namespace RiotApiApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static long lngSumID;
        public static Region region;
        public static RiotApi api = RiotApi.GetDevelopmentInstance("RGAPI-5f74277e-2c41-4705-9b0a-a494b2bd6660");

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                region = CheckRegion();
            }
            catch (Exception)
            {
                MessageBox.Show("please select a region");
            }
                try
            { 
                var summoner = api.GetSummonerByName(region, SummonerNameTxtBox.Text);
                lngSumID = summoner.Id;
                MessageBox.Show(summoner.Id.ToString());
                Spectator.CurrentGameInfo();
            }
            catch (Exception)
            {
                MessageBox.Show("Summoner does not exist in that region, please try again");
            }
        }
        private Region CheckRegion()
        {
            ComboBoxItem cbi = ((ComboBoxItem)RegionCBox.SelectedValue);
            switch (cbi.Content.ToString())
            {
                case "br":
                    {
                        return Region.br;
                    }
                case "eune":
                    {
                        return Region.eune;
                    }
                case "euw":
                    {
                        return Region.euw;
                    }
                case "global":
                    {
                        return Region.global;
                    }
                case "jp":
                    {
                        return Region.jp;
                    }
                case "kr":
                    {
                        return Region.kr;
                    }
                case "lan":
                    {
                        return Region.lan;
                    }
                case "las":
                    {
                        return Region.las;
                    }
                case "na":
                    {
                        return Region.na;
                    }
                case "oce":
                    {
                        return Region.oce;
                    }
                case "ru":
                    {
                        return Region.ru;
                    }
                case "tr":
                    {
                        return Region.tr;
                    }
                default:
                    {
                        return Region.global;
                    }
            }
        }
    }
}
