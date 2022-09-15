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

namespace dom
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();

        
        }
  
        Prodavec1 prodavec = new Prodavec1();
        Admin admin = new Admin();
        Starshoi starshoi = new Starshoi();
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-58N2ABP\SQLEXPRESS; Initial Catalog = Prokat; Integrated Security = SSPI;");
            con.Open();
   
            SqlCommand com = new SqlCommand("Select count(*) from Сотрудники where Логин ='"+textBox1.Text+"' and Пароль = '"+textBox2.Text+"'", con);
            DataTable table = new DataTable();
            SqlDataReader reader = com.ExecuteReader();
            table.Load(reader);
            dataGridView2.DataSource = table;
            con.Close();
            
            if (dataGridView2.Rows[0].Cells[0].Value.ToString() == "1")
            {
                SqlConnection cons = new SqlConnection(@"Data Source = DESKTOP-58N2ABP\SQLEXPRESS; Initial Catalog = Prokat; Integrated Security = SSPI;");

                cons.Open();
                SqlCommand coms = new SqlCommand("Select код_сотрудника, должность from Сотрудники where Логин ='" + textBox1.Text + "' and Пароль = '" + textBox2.Text + "' ", cons);
                DataTable tables = new DataTable();
                SqlDataReader rads = coms.ExecuteReader();
                tables.Load(rads);
                dataGridView1.DataSource = tables;
                cons.Close();
                name.ID = dataGridView1.Rows[0].Cells[0].Value.ToString();
                if(dataGridView1.Rows[0].Cells[1].Value.ToString() == "Продавец")
                {
                    this.Hide();
                    prodavec.Show();
                }else if((dataGridView1.Rows[0].Cells[1].Value.ToString() == "Администратор"))
                {
                    this.Hide();
                    admin.Show();
                }
                else if ((dataGridView1.Rows[0].Cells[1].Value.ToString() == "Старший смены"))
                {
                    this.Hide();
                    starshoi.Show();
                }
            }
            else
            {
                MessageBox.Show("Неверно");
            }
        }
    }
}
