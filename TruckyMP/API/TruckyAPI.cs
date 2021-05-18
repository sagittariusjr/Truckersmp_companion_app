using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using TruckyMP.Model;

namespace TruckyMP.API
{
    public class TruckyAPI : Api
    {
        public TruckyAPI(string server) : base(server)
        {
        }

        public TimeDTO GetTime()
        {
            var response = GET(GetURItime());
            string content = response.Content.ReadAsStringAsync().Result;                 

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<TimeDTO>(content);
            }
            else
            {
                return null;
            }
        }

        public TimeDTO GetVersion()
        {
            var response = GET(GetURIversion());
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<TimeDTO>(content);
            }
            else
            {
                return null;
            }
        }

        public TimeDTO GetPlayers()
        {
            var response = GET(GetURIplayers());
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<TimeDTO>(content);
            }
            else
            {
                return null;
            }
        }

        public TopDTO GetTop()
        {
            var response = GET(GetURItop());
            string content = response.Content.ReadAsStringAsync().Result;

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                return JsonConvert.DeserializeObject<TopDTO>(content);
            }
            else
            {
                return null;
            }
        }
    }
}
