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
            Task.Run(() => List1(List2));
        }

        public void List4()
        {
            listBox1.Items.Add("4번째 콜백이 시작된다.");
            label4.Text = "성";
            listBox1.Items.Add("===============.");
        }

        public void List3()
        {
            listBox1.Items.Add("3번째 콜백이 시작된다.");
            label3.Text = "용";
            listBox1.Items.Add("===============.");
            Thread.Sleep(1000);

            Task.Run(() => List4());

        }

        public void List2()
        {
            listBox1.Items.Add("2번째 콜백이 시작된다.");
            label2.Text = "길";
            listBox1.Items.Add("===============.");
            Thread.Sleep(1000);

            Task.Run(() => List3());
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
