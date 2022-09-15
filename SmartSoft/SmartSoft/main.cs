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
    public partial class main : Form
    {

     


        public main()
        {
            InitializeComponent();

        }
        
      
        private void main_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public static Primary Primary = new Primary();

      

        private void button1_Click(object sender, EventArgs e)
        {
            DataBank.Server = textBox3.Text;
            SqlConnection con = new SqlConnection(@"Data Source='" + textBox3.Text + "'; Initial Catalog=SmartSoft; Integrated Security=SSPI;");
            con.Open();
            string sql = "select count(*) from [Пользователи] where Логин = '" + textBox1.Text + "' and Пароль = '" + textBox2.Text + "'";
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataReader rad = com.ExecuteReader();
            DataTable table = new DataTable();
            table.Load(rad);
            dataGridView1.DataSource = table;
            if (dataGridView1.Rows[0].Cells[0].Value.ToString() == "1")
            {
              this.Hide();
             Primary.Show();
              
            }
           else
            {
              MessageBox.Show("Не праивильный логин или пароль! Повторите попытку");
            }
        }
       
        private void button2_Click(object sender, EventArgs e)
        {
         
        }
        
    }
}
