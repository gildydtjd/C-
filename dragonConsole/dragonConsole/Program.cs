using System;
using System.Net.Http;
using static dragonConsole.Example2;
using System.Net;
using System.Threading.Tasks;
namespace dragonConsole
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
            await Task.Run(async () =>
            {
                HttpClient HttpClient = new HttpClient();
                var res = await HttpClient.GetAsync("https://jsonplaceholder.typicode.com/todos");
                string data = await res.Content.ReadAsStringAsync();
                Console.WriteLine(data);
            });
        }
    }
}
