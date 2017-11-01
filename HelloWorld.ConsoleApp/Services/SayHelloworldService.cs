using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.ConsoleApp.Services
{
    public class SayHelloworldService
    {

        HttpClient client;
        string url = "http://localhost:50457/api/SayHelloWorldAPI";
        public SayHelloworldService()
        {
            client = new HttpClient();

        }


        public async Task<string> Get()
        {
            try
            {
                var response = client.GetAsync(new Uri(url)).Result;
                var json = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<string>(json);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}
