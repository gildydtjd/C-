using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0124
{
    public partial class Form1 : Form
    {
        int TotalPrice = 0;
        public delegate int delFuncDow_Edge(int i);
        public delegate int delFuncTopping(string strOrder, int Ea);

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            delFuncDow_Edge delDow = new delFuncDow_Edge(fDow);
            delFuncDow_Edge delEdge = new delFuncDow_Edge(fEdge);
            delFuncTopping delTopping = null;

            int iDowOrder = 0;
            int iEdgeOrder = 0;

            //도우 선택
            if (checkBox1.Checked)
            {
                iDowOrder = 1;
            }
            else if (checkBox2.Checked)
            {
                iDowOrder = 2;
            }

            //delDow(iDowOrder);
            
            //엣지 선택
            if (checkBox4.Checked)
            {
                iEdgeOrder = 1;
            }
            else if (checkBox3.Checked)
            {
                iEdgeOrder = 2;
            }

            //delEdge(iEdgeOrder);
            fCallBackDelegate(iDowOrder, delDow);
            fCallBackDelegate(iEdgeOrder, delEdge);

            if (checkBox6.Checked) delTopping += fTopping1;
            if (checkBox5.Checked) delTopping += fTopping2;
            if (checkBox7.Checked) delTopping += fTopping3;

            delTopping("토핑", (int)numericUpDown1.Value);

            fboxOrder("-----------------------");
            fboxOrder(string.Format("전체 주문 가격은 {0}원 입니다", TotalPrice));
        }
        //도우
        private int fDow(int iDowOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;
            if (iDowOrder == 1)
            {
                iPrice = 10000;
                strOrder = string.Format("도우는 오리지널을 선택 하셨습니다. ({0}원)", iPrice.ToString());
            }
              else if(iDowOrder == 2)
            {
                iPrice = 11000;
                strOrder = string.Format("도우는 씬을 선택 하셨습니다. ({0}원)", iPrice.ToString());
            } 
              else
            {
                strOrder = "도우를 선택하지 않았습니다.";
            }
             
            listBox1.Items.Add(strOrder);

            return TotalPrice = TotalPrice + iPrice;
        }

        //엣지
        private int fEdge(int iEdgeOrder)
        {
            string strOrder = string.Empty;
            int iPrice = 0;

            if (iEdgeOrder == 1)
            {
                iPrice = 1000;
                strOrder = string.Format("엣지는 리치골드을 선택 하셨습니다. ({0}원)", iPrice.ToString());
            }
            else if (iEdgeOrder == 2)
            {
                iPrice = 2000;
                strOrder = string.Format("엣지는 치즈크러스트을 선택 하셨습니다. ({0}원)", iPrice.ToString());
            }
            else
            {
                strOrder = "엣지를 선택하지 않았습니다.";
            }

            listBox1.Items.Add(strOrder);

            return TotalPrice = TotalPrice + iPrice;
        }

        public int fCallBackDelegate(int i, delFuncDow_Edge delFunc)
        {
            return delFunc(i);
        }

        private int fTopping1(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 500;

            strOrder = string.Format("소세지 {0} {1} 개를 선택 하였습니다. : ({2}원 (1ea 500원)", Order, iEa, iPrice);

            fboxOrder(strOrder);

            return TotalPrice = TotalPrice + iPrice;
        }

        private int fTopping2(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 200;

            strOrder = string.Format("감자 {0} {1} 개를 선택 하였습니다. : ({2}원 (1ea 200원)", Order, iEa, iPrice);

            fboxOrder(strOrder);

            return TotalPrice = TotalPrice + iPrice;
        }

        private int fTopping3(string Order, int iEa)
        {
            string strOrder = string.Empty;
            int iPrice = iEa * 300;

            strOrder = string.Format("치즈 {0} {1} 개를 선택 하였습니다. : ({2}원 (1ea 300원)", Order, iEa, iPrice);

            fboxOrder(strOrder);

            return TotalPrice = TotalPrice + iPrice;
        }

        private void fboxOrder(string strOrder)
        {
            listBox1.Items.Add(strOrder);
        }
    }
}
