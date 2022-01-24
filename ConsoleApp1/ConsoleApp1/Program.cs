using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace ConsoleApp1
{
    class Program
    {
        static readonly HttpClient httpClient = new HttpClient();

        static void Main(string[] args)
        {
            Task.Run(async () => { await Dragon(); });
            Console.Read();
        }
        
        public static async Task Dragon()
        {
            await Task.Run(async () => {
                HttpClient HttpClient = new HttpClient();
                var res = await HttpClient.GetAsync("https://jsonplaceholder.typicode.com/todos");
                string data = await res.Content.ReadAsStringAsync();
                Console.WriteLine(data);
            });
        }
    }
}


