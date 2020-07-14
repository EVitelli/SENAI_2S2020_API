using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace App2.Services
{
    public static class Utils
    {
        private static HttpClient client;

        public static HttpClient getClient
        {
            get
            {
                if(client == null)
                {
                    client = new HttpClient();
                    client.BaseAddress = new Uri("http://172.18.116.193:5000/api/");
                }

                return client;
            }
        }


    }
}
