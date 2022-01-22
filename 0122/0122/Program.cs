using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _0122
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


            using (StreamWriter sw = new StreamWriter(@"c:\C-\0122/dragon.txt"))
            {
                sw.WriteLine("안녕");
                sw.WriteLine("난 드래곤이야");
                sw.WriteLine("너도 드래곤이니?");
            }
        }
    }
}
