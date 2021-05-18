using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TruckyMP.Sup;

namespace TruckyMP.Model
{
    public class TopPlayers : BaseVM
    {
        private string name; 
        public string Name 
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }
        
        private int players; 
        public int Players
        {
            get { return players; }
            set { SetProperty(ref players, value); }
        }

        private string country;
        public string Country
        {
            get { return country; }
            set { SetProperty(ref country, value); }
        }

        private string color;
        public string Color
        {
            get { return color; }
            set { SetProperty(ref color, value); }
        }

        private string severity;
        public string Severity
        {
            get { return severity; }
            set { SetProperty(ref severity, value); }
        }

        private int trafficJams;
        public int TrafficJams
        {
            get { return trafficJams; }
            set { SetProperty(ref trafficJams, value); }
        }

        private int playersInvolvedInTrafficJams;
        public int PlayersInvolvedInTrafficJams
        {
            get { return playersInvolvedInTrafficJams; }
            set { SetProperty(ref playersInvolvedInTrafficJams, value); }
        }

    }
}
