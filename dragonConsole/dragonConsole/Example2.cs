using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dragonConsole
{
    class Example2
    {
        public static int id = 5;
        static string[] name = { "길", "닐", "딜", "릴", "밀", "빌" };
        public static void Print()
        {
            int i = 0;

            foreach (var a in name)
            {
                Console.WriteLine(name[i]);
                i++;
            }
        }
    }
}
