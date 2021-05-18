using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TruckyMP.Model
{
    public class Response
    {
        public int game_time { get; set; }
        public DateTime calculated_game_time { get; set; }
        public string supported_game_version { get; set; }
        public int totalPlayers { get; set; }
        public string name { get; set; }
        public int players { get; set; }
        public string country { get; set; }
        public string color { get; set; }
        public string severity { get; set; }
        public int trafficJams { get; set; }
        public int playersInvolvedInTrafficJams { get; set; }
        public IList<Server> servers { get; set; }
    }

    public class Server
    {
        public int players { get; set; }
    }

    public class TimeDTO
    {
        public Response response { get; set; }
    }

    public class TopDTO
    {
        public IList<Response> response { get; set; }
    }
}
