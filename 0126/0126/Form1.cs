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
using System.Timers;

namespace _0126
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int aliveHome = 0;
        int TotalMoney = 10000000;
        object obj = new object();

        private void button1_Click(object sender, EventArgs e)
        {
            string houseName = "헨젤과 그레텔";
            int housePrice = 100000;
            Task.Run(() => Show(houseName, housePrice, obj));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string houseName = "제빵왕 김탁구";
            int housePrice = 300000;
            Task.Run(() => Show(houseName, housePrice, obj));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string houseName = "인도 왕자";
            int housePrice = 500000;
            Task.Run(() => Show(houseName, housePrice, obj));
        }

        public void Show(string houseName, int housePrice, object obj)
        {
            lock (obj)
            {
                listBox1.Items.Add("====================================");
                listBox1.Items.Add(houseName + "집에 오신걸 환영합니다.");
                pictureBox4.Visible = false;

                for (int i = 1; i < 4; i++)
                {
                    Thread.Sleep(1000);
                    listBox1.Items.Add(string.Format("{0}일이 지났습니다.", i));
                    aliveHome++;
                }

                listBox1.Items.Add("집에서 쫒겨났습니다.");
                listBox1.Items.Add("====================================");
                pictureBox4.Visible = true;
                label2.Text = string.Format("총 거주일 : {0} 일", aliveHome);
                label1.Text = string.Format("재 산 : {0} 원", TotalMoney = TotalMoney - housePrice);
            }
        }
    }
}
