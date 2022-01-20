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
        int[,] ArrayTest = { { 1, 2, 3, 4, 5, 6, 7 }, { 8, 9, 10, 11, 12, 13, 14 } };

        private void button1_Click(object sender, EventArgs e)
        {
            dgDay.Rows.Clear();

            dgDay["colDay1", 0].Value = ArrayTest[0,0];
            dgDay["colDay2", 0].Value = ArrayTest[0,1];
            dgDay["colDay3", 0].Value = ArrayTest[0,2];
            dgDay["colDay4", 0].Value = ArrayTest[0,3];
            dgDay["colDay5", 0].Value = ArrayTest[0,4];
            dgDay["colDay6", 0].Value = ArrayTest[0,5];
            dgDay["colDay7", 0].Value = ArrayTest[0,6];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgDay.Rows.Clear();

            dgDay.Rows.Add();
                for (int i = 0; i < 2; ++i)
                {
                    for (int j = 1; j <= 7; ++j)
                    {
                        dgDay[$"colDay{j}", i].Value = ArrayTest[i, j-1];
                    }
                }
            }
        }
    }
