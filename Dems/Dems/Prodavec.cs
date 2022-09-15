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
using System.IO;

namespace Dems
{
    public partial class Prodavec : Form
    {
        public Prodavec()
        {
            InitializeComponent();
        }

        private void Prodavec_Load(object sender, EventArgs e)
        {
            Timer time = new Timer();
            time.Interval = 10000;
            time.Enabled = true;
            time.Start();
          //  label3.Text = time.ToString();
            SqlConnection cons = new SqlConnection(@"Data Source=DESKTOP-58N2ABP\SQLEXPRESS; Initial Catalog = Park; Integrated Security=SSPI;");
            cons.Open();
            SqlCommand coms = new SqlCommand("Select ФИО, Должность, Фото from Сотрудники where Код_Сотрудника = '"+UserClass.ID+"'", cons);
            DataTable tables = new DataTable();
            SqlDataReader rads = coms.ExecuteReader();
            tables.Load(rads);
            dataGridView1.DataSource = tables;
            cons.Close();
            label1.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            label2.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            byte[] bytes = (byte[])dataGridView1.Rows[0].Cells[2].Value;
            MemoryStream ms = new MemoryStream(bytes);
            pictureBox1.Image = Image.FromStream(ms);


            SqlConnection conss = new SqlConnection(@"Data Source=DESKTOP-58N2ABP\SQLEXPRESS; Initial Catalog = Park; Integrated Security=SSPI;");
            conss.Open();
            SqlCommand comss = new SqlCommand("Select * from Заказы order by id desc ", conss);
            DataTable tabless = new DataTable();
            SqlDataReader radss = comss.ExecuteReader();
            tabless.Load(radss);
            dataGridView2.DataSource = tabless;
            conss.Close();
        
            textBox1.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cons = new SqlConnection(@"Data Source=DESKTOP-58N2ABP\SQLEXPRESS; Initial Catalog = Park; Integrated Security=SSPI;");
            cons.Open();
            SqlCommand coms = new SqlCommand("Select Код_клиента from Клиенты where SN_Паспорта = '"+textBox2.Text+"'  ", cons);
            DataTable tables = new DataTable();
            SqlDataReader rads = coms.ExecuteReader();
            tables.Load(rads);
            dataGridView3.DataSource = tables;
            cons.Close();
            try
            {
                SqlConnection conss = new SqlConnection(@"Data Source=DESKTOP-58N2ABP\SQLEXPRESS; Initial Catalog = Park; Integrated Security=SSPI;");
                conss.Open();
                SqlCommand comss = new SqlCommand("insert into заказы values('" + textBox1.Text + "', '"+DateTime.Now+ "', '" + dataGridView3.Rows[0].Cells[0].Value.ToString() + "', '" + comboBox2.Text + "', NULL,'" + textBox3.Text + "', 101)", conss);
               
                SqlDataReader radss = comss.ExecuteReader();
               
                conss.Close();
                MessageBox.Show("Успех");
            }
            catch
            {
                MessageBox.Show("Ошибка добавления, проверьте правильность введенных данных");
            }
        }
    }
}
