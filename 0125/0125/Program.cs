using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0125
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
            //Student d = new Student();
            //d.Dragon();
        }
    }
}

//class Student
//{
//    public string Name { get; set; }
//    public int Age { get; set; }

//    public void Dragon()
//    {
//        Student st1 = new Student
//        {
//            Name = "길용성",
//            Age = 30
//        };

//        Student st2 = new Student
//        {
//            Name = "닐용성",
//            Age = 25
//        };

//        Student st3 = new Student
//        {
//            Name = "딜용성",
//            Age = 20
//        };

//        Student st4 = new Student
//        {
//            Name = "릴용성",
//            Age = 15
//        };


//        List<Student> StudentList = new List<Student>();
//        StudentList.Add(st1);
//        StudentList.Add(st2);
//        StudentList.Add(st3);
//        StudentList.Add(st4);

//        var Twenty_Student = from s in StudentList

//                             where s.Age >= 20 && s.Age < 30

//                             orderby s.Age ascending

//                             select s;

//        foreach (var Stu in Twenty_Student)

//        {
//            Console.WriteLine("나이가 20대인 학생은 = {0} 입니다. 나이 : {1}살", Stu.Name, Stu.Age);
//        }
