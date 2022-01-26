using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Data myData = new Data();

            Thread my1 = new Thread(Myfun);
            Thread my2 = new Thread(Myfun);
            Thread my3 = new Thread(Myfun);

            my1.Start(myData);

            my2.Start(myData);

            my3.Start(myData);

            my1.Join();
            my2.Join();
            my3.Join();
        }

        private static void Myfun(object obj)
        {
            Data targetData = obj as Data;

            for (int i = 0; i < 10; i++){
                targetData.Increase();
                Console.WriteLine(targetData.num);
            }
        }
    }

    class Data
    {
        public int num = 0;
        private object obj = new object();

        public void Increase()
        {
            lock (obj)
            {
                this.num++;
                Thread.Sleep(5);
            }
        }
    }
}
