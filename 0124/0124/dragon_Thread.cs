using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace _0124
{
    class dragon_Thread
    {
        public void Run()
        {
            for(int i=0; i<50; i++)
            {

                if (i != 0 &&i % 5 == 0)
                {
                    Thread.Sleep(3000);
                    Console.WriteLine("나는 5의 배수이다.");
                    Console.WriteLine(i);

                } else
                {
                    Console.WriteLine(i);
                }
            }
                Console.WriteLine("Thread 종료");
        }
    }
}
