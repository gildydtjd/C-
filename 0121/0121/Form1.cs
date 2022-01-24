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

        public static int TotalMoney = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            CheckBox[] checkBoxList = { checkBox1, checkBox2, checkBox10, checkBox4, checkBox5, checkBox6, checkBox7, checkBox8, checkBox9 };
            foreach(var list in checkBoxList)
            {
                if (list.Checked)
                {
                    string ListName = list.Name.ToString();
                    int low = 5000;
                    int mid = 5500;
                    int high = 6000;
                    string star = "스타벅스 ";
                    string edia = "이디아 ";
                    string cbin = "커피빈 ";

                    string Ame = "아메리카노 ";
                    string Ra = "카페라떼 ";
                    string Mo = "카페모카 ";
                    var Total = TotalMoney.ToString();

                    switch (ListName)
                    {
                        case "checkBox1": int SAmerica = 1;
                            listBox1.Items.Add(star + Ame + " : " + low +"원");
                            TotalMoney = TotalMoney + low;
                            label10.Text = "사용금액 " +TotalMoney +"원";
                            checkBox1.Checked = false;
                            break;

                        case "checkBox4": int SCafe = 1;
                            listBox1.Items.Add(star + Ra + " : " + low + "원");
                            TotalMoney = TotalMoney + mid;
                            label10.Text = "사용금액 " + TotalMoney + "원";
                            checkBox4.Checked = false;
                            break;
                        case "checkBox5": int SMoca = 1;
                            listBox1.Items.Add(star + Mo + " : " + low + "원");
                            TotalMoney = TotalMoney + high;
                            label10.Text = "사용금액 " + TotalMoney + "원";
                            checkBox5.Checked = false;
                            break;
                        case "checkBox7": int EAmerica = 
                                1; listBox1.Items.Add(edia + Ame + " : " + low + "원");
                            TotalMoney = TotalMoney + low;
                            label10.Text = "사용금액 " + TotalMoney + "원";
                            checkBox7.Checked = false;
                            break;
                        case "checkBox6": int ECafe = 1;
                            listBox1.Items.Add(edia + Ra + " : " + low + "원");
                            TotalMoney = TotalMoney + mid;
                            label10.Text = "사용금액 " + TotalMoney + "원";
                            checkBox6.Checked = false;
                            break;
                        case "checkBox2": int EMoca = 1;
                            listBox1.Items.Add(edia + Mo + " : " + low + "원");
                            TotalMoney = TotalMoney + high;
                            label10.Text = "사용금액 " + TotalMoney + "원";
                            checkBox2.Checked = false;
                            break;
                        case "checkBox10": int CAmerica = 1;
                            listBox1.Items.Add(cbin + Ame + " : " + low + "원");
                            TotalMoney = TotalMoney + low;
                            label10.Text = "사용금액 " + TotalMoney + "원";
                            checkBox10.Checked = false;
                            break;
                        case "checkBox9": int CCafe = 1;
                            listBox1.Items.Add(cbin + Ra + " : " + low + "원");
                            TotalMoney = TotalMoney + mid;
                            label10.Text = "사용금액 " + TotalMoney+ "원";
                            checkBox9.Checked = false;
                            break;
                        case "checkBox8": int CMoca = 1;
                            listBox1.Items.Add(cbin + Mo + " : " + low + "원");
                            TotalMoney = TotalMoney + high;
                            label10.Text = "사용금액 " + TotalMoney + "원";
                            checkBox8.Checked = false;
                            break;
                    }
                }
            }
        }
    }
}
