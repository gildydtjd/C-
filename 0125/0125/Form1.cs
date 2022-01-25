using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0125
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Num> sortNum = new List<Num>();

        int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            // Num type 객체 생성
            Num NumData = new Num();

            // txtBox.Text 값 저장
            string txt = textBox1.Text;

            // txtBox.Text string에서 int로 형변환
            int txtNum = Int32.Parse(txt);

            // Text값 Num 객체에 넣기
            NumData.Number = txtNum;

            sortNum.Add(NumData);

            listBox1.Items.Add(sortNum[i].Number);

            i++;

            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = from incre in sortNum orderby incre.Number select incre;
            listBox1.Items.Clear();

            foreach(var i in result)
            {
                listBox1.Items.Add(i.Number);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var result = from decre in sortNum orderby decre.Number descending select decre;
            listBox1.Items.Clear();

            foreach (var i in result)
            {
                listBox1.Items.Add(i.Number);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sortNum.Clear();
            listBox1.Items.Clear();
            i = 0;
        }
    }

    class Num
    {
        public int Number { set; get; }
    }
}
