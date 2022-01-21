using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0121
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int SAmerica = 0;
        int SCafe = 0;
        int SMoca = 0;

        int EAmerica = 0;
        int ECafe = 0;
        int EMoca = 0;

        int CAmerica = 0;
        int CCafe = 0;
        int CMoca = 0;

        int TotalMoney = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            CheckBox[] c = { checkBox1, checkBox2, checkBox10, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9 };
            foreach(var data in c)
            {
                if (data.Checked)
                {
                    string a = data.Name.ToString();
                    switch (a)
                    {
                        case "checkBox1": SAmerica = 1; listBox1.Items.Add("스타벅스 아메리카노 1잔 : 5000원"); TotalMoney= TotalMoney+5000; label10.Text = "사용금액 " +TotalMoney.ToString()+"원"; checkBox1.Checked = false; break;
                        case "checkBox4": SCafe = 1; listBox1.Items.Add("스타벅스 카페라떼 1잔 : 5000원"); TotalMoney = TotalMoney + 5500; label10.Text = "사용금액 " + TotalMoney.ToString() + "원"; checkBox4.Checked = false; break;
                        case "checkBox5": SMoca = 1; listBox1.Items.Add("스타벅스 카페모카 1잔 : 6000원"); TotalMoney = TotalMoney + 6000; label10.Text = "사용금액 " + TotalMoney.ToString() + "원"; checkBox5.Checked = false; break;
                        case "checkBox7": EAmerica = 1; listBox1.Items.Add("이디아 아메리카노 1잔 : 5000원"); TotalMoney = TotalMoney + 5000; label10.Text = "사용금액 " + TotalMoney.ToString() + "원"; checkBox7.Checked = false; break;
                        case "checkBox6": ECafe = 1; listBox1.Items.Add("이디아 카페라떼 1잔 : 5500원"); TotalMoney = TotalMoney + 5500; label10.Text = "사용금액 " + TotalMoney.ToString() + "원"; checkBox6.Checked = false; break;
                        case "checkBox2": EMoca = 1; listBox1.Items.Add("이디아 카페모카 1잔 : 6000원"); TotalMoney = TotalMoney + 6000; label10.Text = "사용금액 " + TotalMoney.ToString() + "원"; checkBox2.Checked = false; break;
                        case "checkBox10": CAmerica = 1; listBox1.Items.Add("커피빈 아메리카노 1잔 : 5000원"); TotalMoney = TotalMoney + 5000; label10.Text = "사용금액 " + TotalMoney.ToString() + "원"; checkBox10.Checked = false; break;
                        case "checkBox9": CCafe = 1; listBox1.Items.Add("커피빈 카페라떼 1잔 : 5500원"); TotalMoney = TotalMoney + 5500; label10.Text = "사용금액 " + TotalMoney.ToString() + "원"; checkBox9.Checked = false; break;
                        case "checkBox8": CMoca = 1; listBox1.Items.Add("커피빈 카페모카 1잔 : 5000원"); TotalMoney = TotalMoney + 6000; label10.Text = "사용금액 " + TotalMoney.ToString() + "원"; checkBox8.Checked = false; break;
                    }
                }
            }
        }
    }
}
