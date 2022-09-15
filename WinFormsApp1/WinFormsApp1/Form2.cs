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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public static Form1 f1 = new Form1();
        private void Form2_Load(object sender, EventArgs e)
        {
            SqlConnection cons = new SqlConnection(@"Data Source=DESKTOP-58N2ABP\SQLEXPRESS; Initial Catalog=money; Integrated Security=SSPI;");

            cons.Open();
            string sqls = "select [Название_валюты], [Курс_покупки], [Курс_продажи]  from валюты";
            SqlCommand coms = new SqlCommand(sqls, cons);


            //  textBox1.Text = dataGridView1.Rows[0].Cells[1].Value.ToString(); 
            SqlDataReader rads = coms.ExecuteReader();
            DataTable tables = new DataTable();
            tables.Load(rads);

            dataGridView1.DataSource = tables;
            rads.Close();
            cons.Close();




        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {

                case "Названию валюты":

                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-58N2ABP\SQLEXPRESS; Initial Catalog=money; Integrated Security=SSPI;");

                    con.Open();
                    string sql = "select * from Валюты order by [Название_валюты]";
                    SqlCommand com = new SqlCommand(sql, con);

                    SqlDataReader rad = com.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(rad);

                    dataGridView1.DataSource = table;
                    rad.Close();
                    con.Close();
                    break;
                case "Курсу продажи":

                    SqlConnection cons = new SqlConnection(@"Data Source=DESKTOP-58N2ABP\SQLEXPRESS; Initial Catalog=money; Integrated Security=SSPI;");

                    cons.Open();
                    string sql_1 = "select * from Валюты order by [Курс_продажи]";
                    SqlCommand coms = new SqlCommand(sql_1, cons);

                    SqlDataReader rads = coms.ExecuteReader();
                    DataTable tables = new DataTable();
                    tables.Load(rads);

                    dataGridView1.DataSource = tables;
                    rads.Close();
                    break;
                case "Курсу покупки":

                    SqlConnection conss = new SqlConnection(@"Data Source=DESKTOP-58N2ABP\SQLEXPRESS; Initial Catalog=money; Integrated Security=SSPI;");

                    conss.Open();
                    string sql_2 = "select * from Валюты order by [Курс_покупки]";
                    SqlCommand comss = new SqlCommand(sql_2, conss);

                    SqlDataReader radss = comss.ExecuteReader();
                    DataTable tabless = new DataTable();
                    tabless.Load(radss);

                    dataGridView1.DataSource = tabless;
                    radss.Close();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            f1.Show();
        }
        buy buy = new buy();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            buy.Show();
        }
    }
}
