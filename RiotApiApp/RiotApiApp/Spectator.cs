using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiotSharp;

namespace RiotApiApp
{
    class Spectator
    {
        public static long ChampID;
        public static void CurrentGameInfo()
        {
            var CurrentChampion = MainWindow.api.GetCurrentGame(MainWindow.region, MainWindow.lngSumID);
            foreach (RiotSharp.SpectatorEndpoint.Participant Summoner in CurrentChampion.Participants)
            {
                if (Summoner.SummonerId == MainWindow.lngSumID)
                {
                    ChampID = Summoner.ChampionId;
                }
            }
        }
    }
}
