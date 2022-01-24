using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _0124
{
    delegate int FuncDelegate(int a, int b);

    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            Program p = new Program();
            p.Thread_go();
        }

        void Thread_go()
        {
            dragon_Thread d = new dragon_Thread();

            Thread t1 = new Thread(new ThreadStart(d.Run));
            t1.Start();

            //Console.WriteLine("Interrupt");
            //t1.Interrupt();

            Console.WriteLine("IsAlive");
            bool t1Bool = t1.IsAlive;
            Console.WriteLine("지금 Thread의 실행 상태는 : "+ t1Bool );

            Console.WriteLine("Suspend");
            t1.Suspend();
            Console.WriteLine("Suspend 잠자는중");
            Thread.Sleep(4000);

            Console.WriteLine("Resume");
            t1.Resume();
            Console.WriteLine("Resume 다시 시작");

            //Console.WriteLine("Join");
            //t1.Join();

            Console.WriteLine("6초 뒤에 Abort");
            Thread.Sleep(10000);
            t1.Abort();
            Console.WriteLine("종료");
        }
    }
}
