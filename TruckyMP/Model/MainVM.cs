using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TruckyMP.API;
using TruckyMP.Sup;

namespace TruckyMP.Model
{
    public class MainVM : BaseVM
    {      

        string server;
        public string Server
        {
            get { return server; }
            set { server = value; NotifyPropertyChanged("Server"); }
        }

        DateTime time;

        public DateTime Time
        {
            get { return time; }
            set { time = value; OnPropertyChanged(); } 
        }

        string game_ver;

        public string Game_ver
        {
            get { return game_ver; }
            set { game_ver = value; OnPropertyChanged(); }
        }

        string players;
        public string Players
        {
            get { return players; }
            set { players = value; OnPropertyChanged(); }
        }

        private ObservableCollection<TopPlayers> topPlayers = new ObservableCollection<TopPlayers>();
        public ObservableCollection<TopPlayers> TopPlayers
        {
            get { return topPlayers; }
            set { SetProperty(ref topPlayers, value); }
        }

        private RelayCommand _updateTime;

        public RelayCommand UpdateTime
        {
            get
            {
                return _updateTime ?? (_updateTime = new RelayCommand(UpdateTimeCommand));
            }
        }

        public void UpdateTimeCommand(object o)
        {
            TruckyAPI truckyApi = new TruckyAPI(server);
            var info = truckyApi.GetTime();
            Time = info.response.calculated_game_time;
            info = truckyApi.GetVersion();
            Game_ver = info.response.supported_game_version;
            info = truckyApi.GetPlayers();        
            Players = info.response.servers[0].players.ToString();
        }

        private RelayCommand _topPlayersInfo;

        public RelayCommand TopPlayersInfo
        {
            get
            {
                return _topPlayersInfo ?? (_topPlayersInfo = new RelayCommand(TopPlayersInfoCommand));
            }
        }

        public void TopPlayersInfoCommand(object o)
        {
            TruckyAPI truckyApi = new TruckyAPI(server);
            var top = truckyApi.GetTop();
            TopPlayers.Clear();
            if (top != null)
            { 
                for (int i=0; i<10; i++)
                {                   
                    TopPlayers.Insert(i, new TopPlayers()
                    {
                        Name = top.response[i].name,
                        Players = top.response[i].players,
                        Country = top.response[i].country,
                        Color = top.response[i].color,
                        Severity = top.response[i].severity,
                        TrafficJams = top.response[i].trafficJams,
                        PlayersInvolvedInTrafficJams = top.response[i].playersInvolvedInTrafficJams
                    });
                }
                                
            }
        }

        private string playerID;
        public string PlayerID { get { return playerID; } set { playerID = value; OnPropertyChanged(); } }

    }
}
