using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0123
{
    public partial class Form1 : Form
    {
        List<string> Students = new List<string>();
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textData = textBox1.Text;
            if (textData == "")
            {
                MessageBox.Show("학생의 이름을 입력하세요!");
            } else
            {
                string Name = textData;
                textBox1.Text = "";
                Students.Add(Name);
                listView1.Items.Add(Students[i]);
                i++;
            }
        }
    }
}
