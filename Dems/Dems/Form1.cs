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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        Admin admin = new Admin();
        Prodavec prodavec = new Prodavec();
        Starshoi_smeny starshoi_Smeny = new Starshoi_smeny();
        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-58N2ABP\SQLEXPRESS; Initial Catalog = Park; Integrated Security=SSPI;");
            con.Open();
            SqlCommand com = new SqlCommand("Select count(*) from Сотрудники where Логин = '" + textBox1.Text + "' and Пароль  = '" + textBox2.Text + "'", con);
            DataTable table = new DataTable();
            SqlDataReader rad = com.ExecuteReader();
            table.Load(rad);
            dataGridView1.DataSource = table;
            con.Close();
            if (dataGridView1.Rows[0].Cells[0].Value.ToString() == "1")
            {
                SqlConnection cons = new SqlConnection(@"Data Source=DESKTOP-58N2ABP\SQLEXPRESS; Initial Catalog = Park; Integrated Security=SSPI;");
                cons.Open();
                SqlCommand coms = new SqlCommand("Select Код_сотрудника, Должность from Сотрудники where Логин = '" + textBox1.Text + "' and Пароль  = '" + textBox2.Text + "'", cons);
                DataTable tables = new DataTable();
                SqlDataReader rads = coms.ExecuteReader();
                tables.Load(rads);
                dataGridView2.DataSource = tables;
                cons.Close();
                UserClass.ID =  dataGridView2.Rows[0].Cells[0].Value.ToString();
                if (dataGridView2.Rows[0].Cells[1].Value.ToString() == "Продавец")
                {
                    this.Hide();
                   prodavec.Show();
                }else if (dataGridView2.Rows[0].Cells[1].Value.ToString() == "Администратор")
                {
                    this.Hide();
                    admin.Show();
                }
                else if (dataGridView2.Rows[0].Cells[1].Value.ToString() == "Старший смены")
                {
                    this.Hide();
                    starshoi_Smeny.Show();
                }

            }
            else
            {
                MessageBox.Show("Ошибка при вводе логина или пароля");
            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = true;
            }
            else
            {
                textBox2.UseSystemPasswordChar = false;
            }
        }
    }
}
