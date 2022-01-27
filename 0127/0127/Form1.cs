using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _0127
{
    public partial class Form1 : Form
    {
        private DataTable data_table = null;

        public Form1()
        {
            InitializeComponent();

            try
            {
                lock (DBcon.DBConn)
                {
                    if (!DBcon.IsDBConnected)
                    {
                        MessageBox.Show("db연결 안됨");
                        return;
                    }
                    else
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter("select * from [dragon].[dbo].[user]", DBcon.DBConn);
                        data_table = new DataTable();

                        try
                        {
                            adapter.Fill(data_table);
                            dataGridView1.DataSource = data_table;

                            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }
                        catch
                        {
                            MessageBox.Show("데이터 없음");
                        }

                        DBcon.Close();
                    }
                }
            } catch
            {
                MessageBox.Show("gridbox 오류");
            }
        }
    }
}
