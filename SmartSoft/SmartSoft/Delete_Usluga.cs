using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SmartSoft
{
    public partial class Delete_Usluga : Form
    {
        public Delete_Usluga()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        Usluga usl = new Usluga();
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            usl.Show();

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

                dataGridView1.Visible = true;
                rad.Close();
                con.Close();

            }
            else
            {
                MessageBox.Show("Заполните поле");

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=" + DataBank.Server + "; Initial Catalog=SmartSoft; Integrated Security=SSPI;");

                con.Open();
                string sql = "DELETE FROM Услуги WHERE Наименование_услуги ='"+textBox1.Text+"'";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataReader rad = com.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(rad);
                MessageBox.Show("Услуга '"+textBox1.Text+"' успешно удалена! ");
                dataGridView1.DataSource = "";

            
                textBox1.Text = "";
            }
            catch
            {
                MessageBox.Show("Ошибка в удалении!");
            }
        }
    }
 }

