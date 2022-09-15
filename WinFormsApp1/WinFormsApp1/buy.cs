using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class buy : Form
    {
        public buy()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {

                case "Евро(EUR)":

                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-58N2ABP\SQLEXPRESS; Initial Catalog=money; Integrated Security=SSPI;");

                    con.Open();
                    string sql = "select [Курс_покупки] from Валюты where [Название_валюты]='Евро(EUR)'";
                    SqlCommand com = new SqlCommand(sql, con);

                    SqlDataReader rad = com.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(rad);
                    dataGridView1.DataSource = table;
                    label6.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
                    rad.Close();
                    con.Close();
                    break;
            }
        }

        private void buy_Load(object sender, EventArgs e)
        {

        }
    }
}
