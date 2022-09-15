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
    public partial class company : Form
    {
        public company()
        {
            InitializeComponent();
        }
        public static main main = new main();

      
        private void company_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");
            con.Open();
            string sql = "select Наименование_компании as 'Компания', ИНН, Рассчетный_счет as 'Рассчетный счет', Сфера_деятельности as 'Деятельность', Телефон, Email, Наименование_статуса as 'Статус', Дата_создания as 'Дата создания' from Компании left join Статусы on Компании.Статус = Статусы.Номер_статуса";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader rad = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rad);
            dataGridView1.DataSource = table;
            con.Close();
        }
        Primary primary = new Primary();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            primary.Show();
        }
        public static insert_company inscomp = new insert_company();
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            inscomp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");

            con.Open();
            string sql = "select Наименование_компании as 'Компания', Сфера_деятельности as 'Деятельность', Телефон, Email, Наименование_статуса as 'Статус', Дата_создания as 'Дата создания' from Компании left join Статусы on Компании.Статус = Статусы.Номер_статуса WHERE Наименование_компании LIKE '%" + textBox1.Text + "%'";
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
            SqlConnection con = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");
            con.Open();
            string sql = "select Наименование_компании as 'Компания', Сфера_деятельности as 'Деятельность', Телефон, Email, Наименование_статуса as 'Статус', Дата_создания as 'Дата создания' from Компании left join Статусы on Компании.Статус = Статусы.Номер_статуса";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader rad = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rad);
            dataGridView1.DataSource = table;
            rad.Close();
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public static update_company ipc = new update_company();
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ipc.Show();
        }
    }
}
