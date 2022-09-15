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
    public partial class Update_Usluga : Form
    {
        public Update_Usluga()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");

                con.Open();
                string sql = "update [Услуги] set [Наименование_услуги] = '" + textBox4.Text + "', [Стоимость_услуги] = '" + textBox2.Text + "' where [Наименование_услуги] = '" + textBox1.Text + "' ";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader rad = com.ExecuteReader();
                 
                DataTable table = new DataTable();
                table.Load(rad);
                MessageBox.Show("Данные успешно обновлены");


                textBox4.Text = "";
                textBox2.Text = "";
                textBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Данные не обновлены!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");
            con.Open();
            string sqlt = "select count(*) from Услуги where Наименование_услуги = '" + textBox1.Text + "'";
            string sql = "select * from Услуги where Наименование_услуги = '" + textBox1.Text + "'";
            SqlCommand com = new SqlCommand(sql, con);

            SqlDataAdapter da = new SqlDataAdapter(sqlt, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                //  textBox1.Text = dataGridView1.Rows[0].Cells[1].Value.ToString(); 
                SqlDataReader rad = com.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(rad);

                dataGridView1.DataSource = table;
                textBox4.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
                textBox2.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            
                rad.Close();
                con.Close();

            }
            else
            {
                MessageBox.Show("Заполните поле");

            }

        }
        public static Usluga usluga = new Usluga();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            usluga.Show();

        }
    }
}
