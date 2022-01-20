using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0119
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        public void StringHooks(string f, string data, string about = default, string about2 = default, char about3 = default, int about4 = default, int about5 = default)
        {
            if (f != null && data !=null) {
                switch (f)
                {
                    case "Contain" : DContain.Text = data.Contains(about).ToString(); break;
                    case "Equals" : DEquals.Text = data.Equals(about).ToString(); break;
                    case "Length" : DLength.Text = data.Length.ToString(); break;
                    case "Replace" : DReplace.Text = data.Replace(about, about2).ToString(); break;
                    case "Split" : { string[] strSplit = data.Split(about3);  DSplit.Text = strSplit[0].ToString(); } break;
                    case "Substring" : DSubstring.Text = data.Substring(about4, about5).ToString(); break;
                    case "ToUpper" : DToUpper.Text = data.ToUpper().ToString(); break;
                    case "ToLower" : DToLower.Text = data.ToLower().ToString(); break;
                    case "Trim" : DTrim.Text = data.Trim().ToString(); break;
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strText = label1.Text;

            DContain.Text = strText.Contains("Test").ToString();
            DEquals.Text = strText.Equals("Test").ToString();
            DLength.Text = strText.Length.ToString();
            DReplace.Text = strText.Replace("Test", "draon").ToString();

            string[] strSplit = strText.Split('_');
            DSplit.Text = strSplit[0].ToString();

            DSubstring.Text = strText.Substring(3, 5).ToString();

            DToLower.Text = strText.ToLower().ToString();
            DToUpper.Text = strText.ToUpper().ToString();

            DTrim.Text = strText.Trim().ToString();
        }
    }
}
