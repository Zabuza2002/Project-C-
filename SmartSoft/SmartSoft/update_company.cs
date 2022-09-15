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
    public partial class update_company : Form
    {
        public update_company()
        {
            InitializeComponent();
        }
        public static company comp = new company();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            comp.Show();

        }
  

        
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");
            con.Open();
            string sqlt = "select count(*) from Компании where ИНН = '" + textBox1.Text + "'";
            string sql = "select * from Компании where ИНН = '" + textBox1.Text + "'";
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
                textBox2.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
                maskedTextBox2.Text = dataGridView1.Rows[0].Cells[7].Value.ToString();
                maskedTextBox3.Text = dataGridView1.Rows[0].Cells[8].Value.ToString();
                maskedTextBox1.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
                textBox3.Text = dataGridView1.Rows[0].Cells[6].Value.ToString();
           

                rad.Close();

            }
            else
            {
                MessageBox.Show("Заполните поле");

            }

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");

                con.Open();
                string sql = "update [Компании] set [Наименование_компании] = '" + textBox4.Text + "', [Сфера_деятельности] = '" + textBox2.Text + "', ИНН = '" + maskedTextBox2.Text + "', Рассчетный_счет = '" + maskedTextBox3.Text + "', телефон ='" + maskedTextBox1.Text + "', Email = '" + textBox3.Text + "' WHERE [ИНН] = '" + textBox1.Text + "'";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader rad = com.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(rad);
                MessageBox.Show("Данные успешно обновлены");


                textBox4.Text = "";
                textBox2.Text = "";
                maskedTextBox2.Text = "";
                maskedTextBox3.Text = "";
                maskedTextBox1.Text = "";
                textBox3.Text = "";
            }
            catch
            {
                MessageBox.Show("Данные не обновлены!");
            }
        }
    }
    
}
