using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0120
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] ArrayTest = { 1, 2, 3, 4, 5, 6, 7 };

            dgDay.Rows.Clear();

            dgDay["colDay1", 0].Value = ArrayTest[0];
            dgDay["colDay2", 0].Value = ArrayTest[1];
            dgDay["colDay3", 0].Value = ArrayTest[2];
            dgDay["colDay4", 0].Value = ArrayTest[3];
            dgDay["colDay5", 0].Value = ArrayTest[4];
            dgDay["colDay6", 0].Value = ArrayTest[5];
            dgDay["colDay7", 0].Value = ArrayTest[6];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[,] ArrayTest = { { 1, 2, 3, 4, 5, 6, 7 },{ 8, 9, 10, 11, 12, 13, 14 }};
            dgDay.Rows.Clear();

            dgDay.Rows.Add();
            dgDay["colDay1", 0].Value = ArrayTest[0,0];
            dgDay["colDay2", 0].Value = ArrayTest[0,1];
            dgDay["colDay3", 0].Value = ArrayTest[0,2];
            dgDay["colDay4", 0].Value = ArrayTest[0,3];
            dgDay["colDay5", 0].Value = ArrayTest[0,4];
            dgDay["colDay6", 0].Value = ArrayTest[0,5];
            dgDay["colDay7", 0].Value = ArrayTest[0,6];

            dgDay["colDay1", 1].Value = ArrayTest[1,0];
            dgDay["colDay2", 1].Value = ArrayTest[1,1];
            dgDay["colDay3", 1].Value = ArrayTest[1,2];
            dgDay["colDay4", 1].Value = ArrayTest[1,3];
            dgDay["colDay5", 1].Value = ArrayTest[1,4];
            dgDay["colDay6", 1].Value = ArrayTest[1,5];
            dgDay["colDay7", 1].Value = ArrayTest[1,6];
           
        }
    }
}
