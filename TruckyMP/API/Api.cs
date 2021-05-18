using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TruckyMP.API
{
    public class Api
    {
        private string Game = "ets2";
        private string Server; //= "sim1";
        
        public Api(string server)
        {
            Server = server;
        }

        protected HttpResponseMessage GET(string URL)
        {
            using (HttpClient client = new HttpClient())
            {
                var result = client.GetAsync(URL);
                result.Wait();

                return result.Result;
            }
        }

        protected string GetURItime()
        {
            return "https://api.truckyapp.com/v2/truckersmp/time";
        }

        protected string GetURIversion()
        {
            return "https://api.truckyapp.com/v2/truckersmp/version";
        }

        protected string GetURIplayers()
        {
            return "https://api.truckyapp.com/v2/truckersmp/servers";
        }

        protected string GetURItop()
        {           
            return "https://api.truckyapp.com/v2/traffic/top?server="+ Server + "&game=" + Game;
        }

        protected string GetURIinfo()
        {
            return "https://api.truckyapp.com/v2/traffic/top?server=" + Server + "&game=" + Game;
        }
    }
}
