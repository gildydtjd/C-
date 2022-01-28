using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace _0128
{

    public delegate void Ddelegate();

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (textBox1.Text)
            {
                case "1":
                    Task.Run(() => List1(List2));
                    break;

                case "2":
                    Task.Run(() => List1(List3));
                    break;

                case "3":
                    Task.Run(() => List1(List4));
                    break;
            }
        }

        public void List4()
        {
            listBox1.Items.Add("콜백이 시작된다.");
            label4.Text = "임용성";
            listBox1.Items.Add("===============.");
        }

        public void List3()
        {
            listBox1.Items.Add("콜백이 시작된다.");
            label3.Text = "김용성";
            listBox1.Items.Add("===============.");
            Thread.Sleep(1000);
        }

        public void List2()
        {
            listBox1.Items.Add("콜백이 시작된다.");
            label2.Text = "길용성";
            listBox1.Items.Add("===============.");
            Thread.Sleep(1000);
        }

        public void List1(Ddelegate dragon)
        {
            listBox1.Items.Add("콜백이 시작된다.");
            label1.Text = "나는";
            listBox1.Items.Add("===============.");

            Thread.Sleep(1000);

            Task.Run(() => dragon());
        }
    }
}
