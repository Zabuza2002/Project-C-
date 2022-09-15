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
    public partial class insert_company : Form
    {
        public insert_company()
        {
            InitializeComponent();
        }
        DateTime localDate = DateTime.Now;

        public static main main = new main();

        
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void insert_company_Load(object sender, EventArgs e)
        {
            SqlConnection cons = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");

            cons.Open();
            string sqls = "select [Наименование_статуса] from [Статусы]";
            SqlCommand coms = new SqlCommand(sqls, cons);
            SqlDataReader rads = coms.ExecuteReader();

            DataTable tables = new DataTable();
            tables.Load(rads);
            dataGridView1.DataSource = tables;
            for (int i = 0; i < Convert.ToInt32(dataGridView1.RowCount); i++)
            {
                comboBox1.Items.Add(Convert.ToString(dataGridView1.Rows[i].Cells[0].Value));
            }
            cons.Close();
        }
        public static Sdelka sdelka = new Sdelka();
        public static company company = new company();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            company.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");
            con.Open();
            string sql = "SELECT distinct Статусы.Номер_статуса FROM  Статусы  where Статусы.Наименование_статуса = '" + comboBox1.Text + "' ";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader rad = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rad);
            dataGridView2.DataSource = table;
            rad.Close();
            con.Close();


            try
            {

                SqlConnection cons = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");
                cons.Open();
                string sqls = "insert into компании values('" + textBox1.Text+ "', '" + localDate.ToString() + "', '" + dataGridView2.Rows[0].Cells[0].Value + "', '" + textBox2.Text + "', '" + maskedTextBox1.Text + "', '" + textBox3.Text + "', '" + maskedTextBox2.Text + "', '" + maskedTextBox3.Text + "');";
                SqlCommand coms = new SqlCommand(sqls, cons);
                SqlDataReader rads = coms.ExecuteReader();
                DataTable tables = new DataTable();
                tables.Load(rads);
                MessageBox.Show("Компания '"+textBox1.Text+"' успешно зарегистрирована!");
                rads.Close();
                cons.Close();
                textBox1.Text = "";
                comboBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                maskedTextBox2.Text = "";
                maskedTextBox3.Text = "";
                maskedTextBox1.Text = "";

            }
            catch
            {
                MessageBox.Show("Ошибка регистрации, повторите попытку!");
            }

        }
    }
}
