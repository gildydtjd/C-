using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0121
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            int money =  Form1.TotalMoney;
            User User1 = new User();
            User1.Name = "gil yong sung";
            User1.TotalMoney = money;

            Console.Write(User1.Name, User1.TotalMoney);
        }

        
    }
}
