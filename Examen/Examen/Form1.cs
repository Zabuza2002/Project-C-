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

namespace Examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-58N2ABP\SQLEXPRESS; Initial Catalog=Deautifull_salon; Integrated Security=SSPI;");
            con.Open();
            string sql = "select count(*) from users where Логин = '" + textBox1.Text + "' and пароль = '" + textBox2.Text + "'";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader rad = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rad);
            dataGridView1.DataSource = table;
            if (dataGridView1.Rows[0].Cells[0].Value.ToString() == "1")
            {
                this.Hide();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Ошибка входа");
            }
        }
    }
}
