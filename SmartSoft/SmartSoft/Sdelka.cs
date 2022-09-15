using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SmartSoft
{
    public partial class Sdelka : Form
    {
        public Sdelka()
        {
            InitializeComponent();
           
        }
         main main = new main();

        private void Sdelka_Load(object sender, EventArgs e)
        {
           
           
            SqlConnection con = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");
            con.Open();
            string sql = "SELECT Номер_сделки as 'Номер сделки', сделка.Сумма_сделки as 'Сумма', сделка.Дата_сделки as 'Дата', Типы_сделки.Наименование_сделки as 'Вид сделки', компании.Наименование_компании as 'Компания', Услуги.Наименование_услуги as 'Заказ' FROM Сделка JOIN Типы_сделки ON Сделка.Номер_типа_сделки = Типы_сделки.Номер_типа_сделки LEFT JOIN компании ON Сделка.Номер_компании = Компании.Номер_компании LEFT JOIN Услуги ON Сделка.Номер_услуги = Услуги.Номер_услуги";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader rad = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rad);
            dataGridView1.DataSource = table;
            con.Close();
            
            
        }
        public static insert_sdelka instrsd = new insert_sdelka(); 
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            instrsd.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.Text)
            {

                case "Дата":
                    string server = DataBank.Server;
                    SqlConnection con = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");

                    con.Open();
                    string sql = "SELECT Номер_сделки as 'Номер сделки', сделка.Сумма_сделки as 'Сумма', сделка.Дата_сделки as 'Дата', Типы_сделки.Наименование_сделки as 'Вид сделки', компании.Наименование_компании as 'Компания', Услуги.Наименование_услуги as 'Заказ' FROM Сделка JOIN Типы_сделки ON Сделка.Номер_типа_сделки = Типы_сделки.Номер_типа_сделки LEFT JOIN компании ON Сделка.Номер_компании = Компании.Номер_компании LEFT JOIN Услуги ON Сделка.Номер_услуги = Услуги.Номер_услуги order by Дата_сделки";
                    SqlCommand com = new SqlCommand(sql, con);

                    SqlDataReader rad = com.ExecuteReader();
                    DataTable table = new DataTable();
                    table.Load(rad);

                    dataGridView1.DataSource = table;
                    rad.Close();
                    con.Close();
                    break;
                case "Вид сделки":
                    
                    SqlConnection cons = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");

                    cons.Open();
                    string sql_1 = "SELECT Номер_сделки as 'Номер сделки', сделка.Сумма_сделки as 'Сумма', сделка.Дата_сделки as 'Дата', Типы_сделки.Наименование_сделки as 'Вид сделки', компании.Наименование_компании as 'Компания', Услуги.Наименование_услуги as 'Заказ' FROM Сделка JOIN Типы_сделки ON Сделка.Номер_типа_сделки = Типы_сделки.Номер_типа_сделки LEFT JOIN компании ON Сделка.Номер_компании = Компании.Номер_компании LEFT JOIN Услуги ON Сделка.Номер_услуги = Услуги.Номер_услуги order by[Вид сделки]";
                    SqlCommand coms = new SqlCommand(sql_1, cons);

                    SqlDataReader rads = coms.ExecuteReader();
                    DataTable tables = new DataTable();
                    tables.Load(rads);

                    dataGridView1.DataSource = tables;
                    rads.Close();
                    break;
                case "Сумма":
                    
                    SqlConnection conss = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");

                    conss.Open();
                    string sql_2 = "SELECT Номер_сделки as 'Номер сделки', сделка.Сумма_сделки as 'Сумма', сделка.Дата_сделки as 'Дата', Типы_сделки.Наименование_сделки as 'Вид сделки', компании.Наименование_компании as 'Компания', Услуги.Наименование_услуги as 'Заказ' FROM Сделка JOIN Типы_сделки ON Сделка.Номер_типа_сделки = Типы_сделки.Номер_типа_сделки LEFT JOIN компании ON Сделка.Номер_компании = Компании.Номер_компании LEFT JOIN Услуги ON Сделка.Номер_услуги = Услуги.Номер_услуги order by Сумма";
                    SqlCommand comss = new SqlCommand(sql_2, conss);

                    SqlDataReader radss = comss.ExecuteReader();
                    DataTable tabless = new DataTable();
                    tabless.Load(radss);

                    dataGridView1.DataSource = tabless;
                    radss.Close();
                    break;
            }
        }
  
        private void button6_Click(object sender, EventArgs e)
        {
            string server = DataBank.Server;
            SqlConnection con = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");

            con.Open();
            string sql = "SELECT Номер_сделки as 'Номер сделки', сделка.Сумма_сделки as 'Сумма', сделка.Дата_сделки as 'Дата', Типы_сделки.Наименование_сделки as 'Вид сделки', компании.Наименование_компании as 'Компания', Услуги.Наименование_услуги as 'Заказ' FROM Сделка JOIN Типы_сделки ON Сделка.Номер_типа_сделки = Типы_сделки.Номер_типа_сделки LEFT JOIN компании ON Сделка.Номер_компании = Компании.Номер_компании LEFT JOIN Услуги ON Сделка.Номер_услуги = Услуги.Номер_услуги WHERE Наименование_компании LIKE '%" + textBox1.Text + "%'";
            SqlCommand com = new SqlCommand(sql, con);

            SqlDataReader rad = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rad);

            dataGridView1.DataSource = table;
            rad.Close();
            con.Close();
         
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string server = DataBank.Server;
            SqlConnection con = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");
            con.Open();
            string sql = "SELECT Номер_сделки as 'Номер сделки', сделка.Сумма_сделки as 'Сумма', сделка.Дата_сделки as 'Дата', Типы_сделки.Наименование_сделки as 'Вид сделки', компании.Наименование_компании as 'Компания', Услуги.Наименование_услуги as 'Заказ' FROM Сделка JOIN Типы_сделки ON Сделка.Номер_типа_сделки = Типы_сделки.Номер_типа_сделки LEFT JOIN компании ON Сделка.Номер_компании = Компании.Номер_компании LEFT JOIN Услуги ON Сделка.Номер_услуги = Услуги.Номер_услуги";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader rad = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rad);
            dataGridView1.DataSource = table;
            rad.Close();
            con.Close();
        }
        Primary primary = new Primary();
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            primary.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
   
        private void button5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            primary.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
