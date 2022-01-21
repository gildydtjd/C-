using System;
using System.Net.Http;
using static dragonConsole.Example2;
using System.Net;
namespace dragonConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Example.Print();
            int b = Example.id;
            Console.WriteLine(b);

            Console.WriteLine("-------------------------");

            Example2.Print();
            int c = Example2.id;
            Console.WriteLine(c);
            Request();
        }

        public static void Request(object sender, EventArgs e) : base(sender)
        {
            using (WebClient wc = new WebClient())
            {
                var json = new WebClient().DownloadString("https://jsonplaceholder.typicode.com/todos/1");
                Console.WriteLine(json.ToString());
            }
        }
    }

    class Example
    {
        public static int id = 0;
        public static void Print()
        {
            Console.WriteLine("hihi");
        }
    }
}
