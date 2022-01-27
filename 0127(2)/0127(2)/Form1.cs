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

namespace _0127_2_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Run();
        }

        private async void Run()
        {
            var t1 = Task.Run(() => gugudan());
            int sum = await t1;
            label1.Text = sum.ToString();
        }

        public int gugudan()
        {
            int result = 0;
            for (int i = 0; i < 10; i++)
            {
                listBox1.Items.Add(i);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                Thread.Sleep(1000);
                result = i;
            }

            return result;
         }
    }
}
